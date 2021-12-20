using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using NAudio.Wave;
using NAudio.Wave.SampleProviders;
using NAudio.WaveFormRenderer;

namespace WindowsFormsApp2
{
    public partial class Meowzic : Form
    {
        private string filePath = string.Empty;
        List<string> playListDir = new List<string>();
        List<string> playListName = new List<string>();
        private WaveOutEvent outputDevice;
        private AudioFileReader audioFile;
        private int playIndex = 0;
        private bool pause;
        private bool renderWaveView;
        private Image appImage = global::WindowsFormsApp2.Properties.Resources.cat_music;
        private bool onRepeat;
        private bool isDark;

        // Delay between end of audio and start of another
        const int transTime = 0;

        public Meowzic()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            using (StreamReader lastPL = new StreamReader("last playlist.txt"))
            {
                string line = lastPL.ReadLine();
                while (line != null)
                {
                    var filePath = line;
                    playListDir.Add(filePath);
                    var fileName = Path.GetFileNameWithoutExtension(line);
                    playList.Items.Add(fileName);
                    line = lastPL.ReadLine();
                }
            }
            LoadConfig();
            CorrectConfig();
            playButton.Focus();
            pictureBox1.Show();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            using (StreamWriter lastPL = new StreamWriter(@"last playlist.txt", false))
            {
                foreach (string file in playListDir)
                {
                    lastPL.WriteLine(file);
                }
            }
            SaveConfig();
        }

        private void SaveConfig()
        {
            using (StreamWriter configFile = new StreamWriter("configFile.txt", false))
            {
                configFile.WriteLine(playIndex);
                configFile.WriteLine(renderWaveView);
            }
        }
        private void LoadConfig()
        {
            using (StreamReader configFile = new StreamReader("configFile.txt"))
            {
                playIndex = int.Parse(configFile.ReadLine());
                if (configFile.ReadLine() == "True")
                {
                    renderWaveView = true;
                }
                else
                {
                    renderWaveView = false;
                }
            }
        }
        private void CorrectConfig()
        {
            if (playIndex < 0)
            {
                playIndex = 0;
            }
        }

        private void Play()
        {
            if (!PlayListIsEmpty())
            {
                if (playButton.Text == "Play")
                {
                    if (outputDevice == null)
                    {
                        outputDevice = new WaveOutEvent();
                        outputDevice.PlaybackStopped += OnPlaybackStopped;
                    }
                    if (audioFile == null)
                    {

                        audioFile = new AudioFileReader(playListDir[playIndex]);
                        playList.SelectedIndex = playIndex;
                        outputDevice.Init(audioFile);

                        visualizeAudio();


                    }
                    if (pause == false) { }
                    else { pause = false; }
                    outputDevice.Play();
                    Thread.Sleep(transTime);

                    pictureBox1.Enabled = true;
                    playButton.Text = "Stop";

                    //position track

                    //Parallel.For(audioFile.Position, audioFile.Length, count => {
                    //    posBar.Value = (int)(count / (audioFile.Length / 200));

                    //});
                }
                else
                {
                    if (outputDevice != null)
                    {
                        outputDevice.Stop();
                        pause = true;
                        pictureBox1.Enabled = false;

                    }
                    playButton.Text = "Play";
                }

            }

            else { MessageBox.Show("Playlist is Empty"); }
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            Play();
        }

        private void OnPlaybackStopped(object sender, StoppedEventArgs args)
        {

            if (pause == false)
            {
                if (playIndex < playListDir.Count - 1)
                {
                    playIndex++;
                    audioFile.Dispose();
                    audioFile = null;
                    try
                    {
                        audioFile = new AudioFileReader(playListDir[playIndex]);
                    }
                    catch (IOException)
                    {
                        MessageBox.Show("Nothing to Play");
                    }
                    outputDevice.Init(audioFile);
                    visualizeAudio();
                    Thread.Sleep(transTime);

                    outputDevice.Play();
                    playList.SelectedIndex = playIndex;



                }


                else
                {

                    outputDevice.Dispose();
                    outputDevice = null;
                    audioFile.Dispose();
                    audioFile = null;
                    playButton.Text = "Play";
                    // end of playlist
                    playIndex = 0;
                    pictureBox1.Enabled = false;

                    if (onRepeat)
                    {
                        playIndex = 0;
                        Play();

                    }


                }
            }

        }



        private void AddAudio()
        {
            //var fileName = string.Empty;
            //var fileContent = string.Empty;
            DialogResult dialogResult;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {

                //openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*|Mp3 files (*.mp3)|*.mp3";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;
                openFileDialog.Multiselect = true;
                dialogResult = openFileDialog.ShowDialog();
                if (dialogResult == DialogResult.OK)
                {
                    foreach (var file in openFileDialog.FileNames)
                    {
                        var filePath = file;
                        playListDir.Add(filePath);
                        var fileName = Path.GetFileNameWithoutExtension(file);
                        playList.Items.Add(fileName);
                    }
                }
                //playList.SetSelected(0, true);

            }
        }

        private void savePlaylist()
        {
            using (SaveFileDialog saveFile = new SaveFileDialog())
            {
                saveFile.Title = "Save Playlist";
                saveFile.DefaultExt = "txt";
                saveFile.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                saveFile.FilterIndex = 0;
                saveFile.RestoreDirectory = true;
                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    using (var savedPL = new StreamWriter(saveFile.FileName, true))
                    {
                        foreach (string file in playListDir)
                        {
                            savedPL.WriteLine(file);
                        }
                    }
                }
            }

        }
        private void openPlaylist()
        {
            using (OpenFileDialog openFile = new OpenFileDialog())
            {

                openFile.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*|Mp3 files (*.mp3)|*.mp3";
                openFile.FilterIndex = 0;
                openFile.RestoreDirectory = true;
                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    using (StreamReader openPL = new StreamReader(openFile.FileName))
                    {
                        string line = openPL.ReadLine();
                        while (line != null)
                        {
                            var filePath = line;
                            playListDir.Add(filePath);
                            var fileName = Path.GetFileNameWithoutExtension(line);
                            playList.Items.Add(fileName);
                            line = openPL.ReadLine();
                        }
                    }

                }
            }

        }

        private void clearPlaylist()
        {
            if (outputDevice != null)
            {
                for (int i = playListDir.Count - 1; i >= 0; i--)
                {
                    playListDir.RemoveAt(i);
                    playList.Items.RemoveAt(i);
                }
                outputDevice.Stop();

            }
            else
            {
                for (int i = playListDir.Count - 1; i >= 0; i--)
                {
                    playListDir.RemoveAt(i);
                    playList.Items.RemoveAt(i);
                }
            }


        }

        /// <summary>
        /// delete misbehaviour : Stops Playing if deleting a duplicate of the currently running audio in the list
        /// </summary>
        private void delete()
        {
            var checkeditems = playList.CheckedIndices;
            var count = 0;
            bool isDeleted = false;
            foreach (var item in checkeditems)
            {

                if (audioFile != null)
                {
                    if (audioFile.FileName == playListDir[(int)item - count] && ((int)item - count) == playIndex && !isDeleted)
                    {
                        playListDir.RemoveAt((int)item - count);
                        playList.Items.RemoveAt((int)item - count);
                        count++;
                        playIndex--;
                        isDeleted = true;
                        outputDevice.Stop();

                    }
                    else
                    {
                        playListDir.RemoveAt((int)item - count);
                        playList.Items.RemoveAt((int)item - count);
                        count++;
                    }

                }
                else
                {
                    playListDir.RemoveAt((int)item - count);
                    playList.Items.RemoveAt((int)item - count);
                    count++;
                }

            }
            if (PlayListIsEmpty())
            {
                playIndex = 0;
                outputDevice.Stop();
            }

        }

        private void visualizeAudio()
        {
            if (audioFile != null)
            {
                if (renderWaveView)
                {
                    var rmsPeakProv = new RmsPeakProvider(4000);
                    var myRendererSettings = new SoundCloudBlockWaveFormSettings(Color.FromArgb(0, 0, 0), Color.DodgerBlue, Color.White, Color.DarkBlue);

                    var renderer = new WaveFormRenderer();
                    var audioFilePath = playListDir[playIndex];
                    using (var wavestream = new AudioFileReader(audioFilePath))
                    {
                        var image = renderer.Render(wavestream, rmsPeakProv, myRendererSettings);
                        //this.BackgroundImage = image;
                        pictureBox1.Image = image;
                    }
                }
            }


        }


        private void CheckAllList()
        {
            bool CheckToggle = AllPlayListChecked();
            int numberOfItems = 0;
            foreach (var item in playList.Items)
            {
                numberOfItems++;

            }
            for (int i = 0; i < numberOfItems; i++)
            {
                playList.SetItemChecked(i, !CheckToggle);


            }
        }
        private bool AllPlayListChecked()
        {
            int numberOfItems = 0;
            foreach (var item in playList.Items)
            {
                numberOfItems++;

            }
            for (int i = 0; i < numberOfItems; i++)
            {
                if (!playList.GetItemChecked(i)) { return false; }


            }
            return true;

        }
        private bool PlayListIsEmpty()
        {
            if (playListDir.Count == 0)
            {
                return true;
            }
            else { return false; }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (audioFile != null)
            {
                audioFile.Position = 0;
            }
        }

        private void volBar_Scroll(object sender, EventArgs e)
        {
            if (outputDevice != null)
            {
                outputDevice.Volume = volBar.Value / 100f;

            }
            BackColor = Color.White;
        }

        private void posBar_Scroll(object sender, EventArgs e)
        {
            if (audioFile != null)
            {
                audioFile.Position = (audioFile.Length / 200) * posBar.Value;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (audioFile != null)
            {
                outputDevice.Stop();
            }
        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {

        }

        private void checkedListBox1_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Delete)
            {
                delete();
            }
            else if (e.KeyCode == Keys.Enter)
            {
                var selIndex = playList.SelectedIndex;
                if (outputDevice != null)
                {
                    playIndex = selIndex - 1;
                    outputDevice.Stop();
                }
                else
                {
                    playIndex = selIndex;
                    Play();
                }
            }

        }



        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddAudio();
        }

        private void savePlaylistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            savePlaylist();
        }

        private void importPlaylistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openPlaylist();
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearPlaylist();
            playIndex = 0;
        }

        private void deleteSelectedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            delete();
        }

        private void renderWaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            renderWaveView = true;
            visualizeAudio();
        }

        private void normalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            renderWaveView = false;
            pictureBox1.Image = appImage;
            if (audioFile != null && pause == false)
            {
                pictureBox1.Enabled = true;
            }
        }


        private void Button_Enter(object sender, System.EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null)
            {
                if (!isDark)
                {


                    btn.BackColor = Color.DodgerBlue;
                    btn.ForeColor = Color.White;
                    btn.FlatStyle = FlatStyle.Standard;



                }
                else
                {
                    btn.BackColor = Color.FromArgb(80, 80, 82);
                    btn.ForeColor = Color.Black;

                    btn.FlatStyle = FlatStyle.Standard;


                }

            }
        }
        private void Button_Leave(object sender, System.EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null)
            {
                if (!isDark)
                {

                    btn.BackColor = Color.White;
                    btn.ForeColor = Color.RoyalBlue;


                }
                else
                {

                    btn.BackColor = Color.Black;
                    btn.ForeColor = Color.FromArgb(80, 80, 82);
                }
            }


        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            delete();
        }

        private void checkAllButton_Click(object sender, EventArgs e)
        {
            CheckAllList();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sha Project : 10/12/2021");
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddAudio();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (renderWaveView)
            {
                var mouseClick = e as MouseEventArgs;
                int MouseXPosition = mouseClick.X;
                audioFile.Position = MouseXPosition * (audioFile.Length / pictureBox1.Width);

            }

            playButton.Focus();
        }

        private void onRepeatButton_Click(object sender, EventArgs e)
        {
            if (onRepeat == false)
            {
                onRepeat = true;
                this.onRepeatButton.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.OnRepeatIcon;

            }
            else
            {
                onRepeat = false;
                this.onRepeatButton.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.download;
            }
        }

        private void rewindButton_MouseDown(object sender, MouseEventArgs e)
        {
            if (audioFile != null)
            {
                audioFile.Position -= (long)Math.Pow(10, 6);

            }

        }

        private void advanceButton_MouseDown(object sender, MouseEventArgs e)
        {
            if (audioFile != null)
            {
                audioFile.Position += (long)Math.Pow(10, 6);

            }
        }
        private void ViewDarkMode()
        {
            isDark = true;
            flowLayoutPanel2.BackColor = Color.FromArgb(29, 28, 31);
            playPanel.BackColor = Color.FromArgb(29, 28, 31);
            playList.BackColor = Color.FromArgb(29, 28, 31);
            this.BackColor = Color.FromArgb(29, 28, 31);
            this.ForeColor = Color.White;
            menuStrip1.ForeColor = Color.White;
            menuStrip1.BackColor = Color.FromArgb(29, 28, 31);
            pictureBox1.BorderStyle = BorderStyle.None;
            playList.BorderStyle = BorderStyle.None;
            playButton.BackColor = Color.FromArgb(80, 80, 82);
            afterButton.BackColor = Color.FromArgb(80, 80, 82);
            beforeButton.BackColor = Color.FromArgb(80, 80, 82);
            advanceButton.BackColor = Color.FromArgb(80, 80, 82);
            rewindButton.BackColor = Color.FromArgb(80, 80, 82);
            flowLayoutPanel2.ForeColor = Color.Black;

            volBar.BackColor = Color.FromArgb(80, 80, 82);


        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
        }
    }

}
