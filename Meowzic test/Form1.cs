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
using Meowzic_test;
using FontAwesome.Sharp;
using System.Timers;

namespace WindowsFormsApp2
{

    public partial class Meowzic : Form
    {
        private string filePath = string.Empty;
        public static List<string> playListDir = new List<string>();
        private WaveOutEvent outputDevice;
        private AudioFileReader audioFile;
        private Image appImage = Meowzic_test.Properties.Resources.cat_music;
        private int playIndex = 0;
        private bool pause;
        private bool renderWaveView;
        private bool onRepeat;
        private bool isDark;
        System.Timers.Timer timer;
        System.Timers.Timer positionTimer;
        int hours, minutes, seconds , secondsElapsed;

        public List<string> PlayListDir
        {
            get { return playListDir; }

        }
        public List<string> recentPlaylists = new List<string>();


        // Delay between end of audio and start of another
        const int transTime = 0;
        const int bytesPerSecond = 354564;

        public Meowzic()
        {
            InitializeComponent();
            this.panelTopContent.BringToFront();
            this.positionIndicatorPanel.BringToFront();

        }

        private void MoveCheckedUp()
        {

            var indices = playList.CheckedIndices;

            // works only for one item , until fixed
            if (indices.Count == 1)
            {
                foreach (int index in indices)
                {
                    if (index > 0)
                    {
                        string tempDir = playListDir[index - 1];
                        playListDir[index - 1] = playListDir[index];
                        playListDir[index] = tempDir;

                        var tempName = playList.Items[index - 1];
                        playList.Items[index - 1] = playList.Items[index];
                        playList.Items[index] = tempName;

                        playList.SetItemChecked(index, false);
                        playList.SetItemChecked(index - 1, true);

                        if (index == playIndex)
                        {
                            playIndex--;
                        }
                        else if (index - 1 == playIndex) { playIndex++; }

                        playList.SelectedIndex = playIndex;

                    }

                }
            }



        }

        private void MoveCheckedDown()
        {
            var indices = playList.CheckedIndices;
            int[] indicesArray = new int[indices.Count];
            int count = 0;
            for (int i = (indicesArray.Length - 1); i >= 0; i--)
            {
                indicesArray[count] = indices[i];
                count++;
            }
            // works only for one item , until fixed
            if (indices.Count == 1)
            {
                foreach (int index in indicesArray)
                {
                    if (index < playListDir.Count - 1)
                    {
                        string tempDir = playListDir[index + 1];
                        playListDir[index + 1] = playListDir[index];
                        playListDir[index] = tempDir;

                        var tempName = playList.Items[index + 1];
                        playList.Items[index + 1] = playList.Items[index];
                        playList.Items[index] = tempName;


                        playList.SetItemChecked(index, false);
                        playList.SetItemChecked(index + 1, true);
                        if (index == playIndex)
                        {
                            playIndex++;

                        }
                        else if (index + 1 == playIndex) { playIndex--; }

                        playList.SelectedIndex = playIndex;
                    }
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //timer = new System.Timers.Timer();
            //timer.Interval = 1000;
            //timer.Elapsed += OnTimeEvent;



            try
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
            catch (System.IO.FileNotFoundException)
            {
                using (StreamWriter lastPL = new StreamWriter(@"last playlist.txt", false))
                {

                }
            }

        }

        private void OnPositionTimeEvent(object sender, ElapsedEventArgs e)
        {
            if (audioFile != null)
                if (positionTimer != null)
                    try
                    {
                        Invoke(new Action(() =>
                        {
                            double posEquation1 = audioFile.Position * 200 / audioFile.Length;
                            positionTrackBar.Value = (int)Math.Round(posEquation1);

                            double posIndicator_X = audioFile.Position * pictureBox1.Width / audioFile.Length;


                            positionIndicatorPanel.Location = new Point((int)Math.Round(posIndicator_X), 0);
                        }));
                    }
                    catch (System.InvalidOperationException)
                    {

                    }

        }

        //private void OnTimeEvent(object sender, ElapsedEventArgs e)
        //{
        //    if (audioFile != null)
        //    {
        //        Invoke(new Action(() =>
        //        {
        //            seconds = (int)(audioFile.Position / bytesPerSecond) - secondsElapsed;


        //            if (seconds >= 60 && seconds >= 0)
        //            {
        //                minutes++;
        //            }
        //            if (minutes >= 60)
        //            {
        //                hours ++;
        //            }
        //            // > 317520 
        //            // < 529200
        //            // 354564
        //            double time = audioFile.Position / bytesPerSecond;
        //            textBox1.Text = audioFile.Position.ToString();
        //            textBox2.Text = $"{hours} : {minutes} : {seconds}";
        //            secondsElapsed = (minutes * 60) + (hours * 60 * 60);

        //        })); 
        //    }
        //}

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
            try
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
            catch (System.IO.FileNotFoundException)
            {
                using (StreamWriter configFile = new StreamWriter("configFile.txt", false))
                {
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
            positionTimer = new System.Timers.Timer();
            positionTimer.Interval = 500;
            positionTimer.Elapsed += OnPositionTimeEvent;

            //timer.Start();
            positionTimer.Start();
            if (!PlayListIsEmpty())
            {
                if (playButton.IconChar == FontAwesome.Sharp.IconChar.Play)
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

                        seconds = minutes = hours = 0;


                    }
                    if (pause == false) { }
                    else { pause = false; }
                    outputDevice.Play();
                    Thread.Sleep(transTime);

                    pictureBox1.Enabled = true;
                    playButton.IconChar = FontAwesome.Sharp.IconChar.Pause;

                    //position track

                    //Parallel.For(audioFile.Position, audioFile.Length, count =>
                    //{
                    //    //posBar = (int)(count / (audioFile.Length / 200));
                    //    var posBar = (double)(count / audioFile.Length) * 100;
                    //    Thread.Sleep(50000);



                    //});

                }
                else
                {
                    if (outputDevice != null)
                    {
                        outputDevice.Stop();
                        pause = true;
                        pictureBox1.Enabled = false;
                        //timer.Stop();
                        positionTimer.Stop();

                    }
                    playButton.IconChar = FontAwesome.Sharp.IconChar.Play;
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
                    seconds = minutes = hours = 0;
                    outputDevice.Play();
                    playList.SelectedIndex = playIndex;



                }


                else
                {

                    outputDevice.Dispose();
                    outputDevice = null;
                    audioFile.Dispose();
                    audioFile = null;
                    playButton.IconChar = FontAwesome.Sharp.IconChar.Play;
                    // end of playlist
                    playIndex = 0;
                    pictureBox1.Enabled = false;
                    if (timer != null)
                    {
                        timer.Stop();

                    }
                    //positionTimer.Stop();

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
        private void UpdateRecentPlaylist()
        {
            if (recentPlaylists.Count == 6)
            {
                recentPlaylists.RemoveAt(5);
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
                    recentPlaylists.Insert(0, openFile.FileName);
                    UpdateRecentPlaylist();
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
            //foreach (var item in recentPlaylists)
            //{
            //    MessageBox.Show(item.ToString());

            //}

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
                if (outputDevice != null)
                    outputDevice.Stop();
            }

        }

        private void visualizeAudio()
        {
            if (audioFile != null)
            {
                if (renderWaveView)
                {
                    var rmsPeakProv = new RmsPeakProvider(this.Width * 10);
                    var myRendererSettings = new SoundCloudBlockWaveFormSettings(Color.FromArgb(0, 0, 0), Color.DodgerBlue, Color.White, Color.DarkBlue);
                    myRendererSettings.Width = this.Width;
                    myRendererSettings.BottomHeight = this.Height / 2;
                    myRendererSettings.TopHeight = this.Height / 2;

                    var renderer = new WaveFormRenderer();
                    var audioFilePath = playListDir[playIndex];
                    using (var wavestream = new AudioFileReader(audioFilePath))
                    {
                        var image = renderer.Render(wavestream, rmsPeakProv, myRendererSettings);
                        //this.BackgroundImage = image;
                        pictureBox1.Image = image;
                    }
                    positionIndicatorPanel.Visible = true;
                    positionTrackBar.Visible = false;

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


        private void beforeButton_Click(object sender, EventArgs e)
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



        private void afterButton_Click(object sender, EventArgs e)
        {
            if (audioFile != null)
            {
                outputDevice.Stop();
                afterButton.IconColor = Color.White;
                afterButton.BackColor = Color.DodgerBlue;
            }

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
        private void IconPicture_Enter(object sender, System.EventArgs e)
        {
            var btn = sender as IconPictureBox;
            if (btn != null)
            {
                if (!isDark)
                {


                    btn.BackColor = Color.DodgerBlue;
                    btn.IconColor = Color.White;



                }
                else
                {
                    btn.BackColor = Color.FromArgb(80, 80, 82);
                    btn.IconColor = Color.Black;



                }

            }
        }
        private void IconPicture_Leave(object sender, System.EventArgs e)
        {
            var btn = sender as IconPictureBox;
            if (btn != null)
            {
                if (!isDark)
                {

                    btn.BackColor = Color.White;
                    btn.IconColor = Color.DodgerBlue;


                }
                else
                {

                    btn.BackColor = Color.Black;
                    btn.IconColor = Color.FromArgb(80, 80, 82);
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

        private void picturePositionChange_Click(object sender, EventArgs e)
        {
            if (renderWaveView)
            {
                var mouseClick = e as MouseEventArgs;
                int MouseXPosition = mouseClick.X;
                audioFile.Position = MouseXPosition * (audioFile.Length / pictureBox1.Width);
                playList.SelectedIndex = playIndex;
            }

            playButton.Focus();
        }

        private void rewindButton_MouseDown(object sender, MouseEventArgs e)
        {
            if (audioFile != null)
            {
                audioFile.Position -= bytesPerSecond * 5;


            }


        }

        private void advanceButton_Click(object sender, EventArgs e)
        {
            if (audioFile != null)
            {
                audioFile.Position += bytesPerSecond * 5;


            }
        }


        private void ViewDarkMode()
        {
            isDark = true;
            //Suspend flowLayoutPanel2.BackColor = Color.FromArgb(29, 28, 31);
            //tableLayoutPanel1.BackColor = Color.FromArgb(29, 28, 31);
            playList.BackColor = Color.FromArgb(29, 28, 31);
            this.BackColor = Color.FromArgb(29, 28, 31);
            this.ForeColor = Color.White;
            //Suspend menuStrip1.ForeColor = Color.White;
            //Suspend menuStrip1.BackColor = Color.FromArgb(29, 28, 31);
            pictureBox1.BorderStyle = BorderStyle.None;
            playList.BorderStyle = BorderStyle.None;
            playButton.BackColor = Color.FromArgb(80, 80, 82);
            afterButton.BackColor = Color.FromArgb(80, 80, 82);
            beforeButton.BackColor = Color.FromArgb(80, 80, 82);
            advanceButton.BackColor = Color.FromArgb(80, 80, 82);
            rewindButton.BackColor = Color.FromArgb(80, 80, 82);
            //Suspend flowLayoutPanel2.ForeColor = Color.Black;

            volBar.BackColor = Color.FromArgb(80, 80, 82);


        }



        private void openPlaylistButton_Click(object sender, EventArgs e)
        {
            openPlaylist();
        }

        private void savePlaylistButton_Click(object sender, EventArgs e)
        {
            savePlaylist();
        }

        private void clearPlaylistButton_Click(object sender, EventArgs e)
        {
            clearPlaylist();
        }

        private void normalViewButton_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = appImage;
            renderWaveView = false;
            positionIndicatorPanel.Visible = false;
            positionTrackBar.Visible = true;
        }

        private void RenderWaveButton_Click(object sender, EventArgs e)
        {
            renderWaveView = true;
            visualizeAudio();
        }

        private void ToggleSubMenu(Panel SubMenuPanel)
        {
            if (SubMenuPanel.Visible == false)
            {
                SubMenuPanel.Visible = true;
            }
            else { SubMenuPanel.Visible = false; }

        }
        private void HideSubMenu(Panel SubMenuPanel)
        {
            if (SubMenuPanel.Visible == true)
            {
                SubMenuPanel.Visible = false;
            }
        }

        private void MediaButton_Click(object sender, EventArgs e)
        {
            ToggleSubMenu(MediaSubMenu);
            HideSubMenu(PlaylistSubMenu);
            HideSubMenu(SettingsSubMenu);
        }

        private void PlaylistButton_Click(object sender, EventArgs e)
        {
            ToggleSubMenu(PlaylistSubMenu);
            HideSubMenu(MediaSubMenu);
            HideSubMenu(SettingsSubMenu);
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            ToggleSubMenu(SettingsSubMenu);
            HideSubMenu(MediaSubMenu);
            HideSubMenu(PlaylistSubMenu);
        }

        private void checkAllButton_Click_1(object sender, EventArgs e)
        {
            CheckAllList();
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            delete();
        }
        private void onRepeatButton_Click(object sender, EventArgs e)
        {
            if (onRepeat == false)
            {
                onRepeat = true;
                onRepeatButton.IconChar = onRepeatButton.IconChar = FontAwesome.Sharp.IconChar.ExchangeAlt;

            }
            else
            {
                onRepeat = false;
                onRepeatButton.IconChar = onRepeatButton.IconChar = FontAwesome.Sharp.IconChar.LongArrowAltRight;
            }
        }

        private void moveUpButton_Click(object sender, EventArgs e)
        {
            MoveCheckedUp();
        }

        private void moveDownButton_Click(object sender, EventArgs e)
        {
            MoveCheckedDown();
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            delete();
        }

        private void moveUpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MoveCheckedUp();
        }

        private void moveDownToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MoveCheckedDown();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddAudio();
        }

        private void removeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            delete();
        }

        private void moveUpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MoveCheckedUp();
        }

        private void moveDownToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MoveCheckedDown();
        }

        private void positionTrackBar_Scroll(object sender, EventArgs e)
        {
            if (audioFile != null)
            {
                audioFile.Position = (audioFile.Length / 200) * positionTrackBar.Value;
            }
        }

        private void AboutButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sha Project, 12/12/2021");
        }



        private void SidePanelButtons_MouseEnter(object sender, EventArgs e)
        {
            var btn = sender as Button;
            if (btn != null)
            {
                if (!isDark)
                {


                    btn.BackColor = Color.DodgerBlue;
                    btn.ForeColor = Color.White;



                }
                else
                {
                    btn.BackColor = Color.FromArgb(80, 80, 82);
                    btn.ForeColor = Color.Black;



                }

            }
        }

        private void SidePanelButtons_MouseLeave(object sender, EventArgs e)
        {
            var btn = sender as Button;
            if (btn != null)
            {
                if (!isDark)
                {


                    btn.BackColor = Color.White;
                    btn.ForeColor = Color.DodgerBlue;



                }
                else
                {
                    btn.BackColor = Color.FromArgb(80, 80, 82);
                    btn.ForeColor = Color.Black;



                }


            }
        }


    }
}
