using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2;

namespace Meowzic_test
{
    public partial class Playlists : Form
    {
        List<string> recentPlaylists;
        public static List<string> recentPlayListDir = new List<string>();
        public static List<string> recentPlayList = new List<string>();
        private List<string> recentPlaylistsNames = new List<string>();
        public Playlists(List<string> recentPlaylists)
        {
            InitializeComponent();
            this.recentPlaylists = recentPlaylists;
            //for (int i = 0; i < recentPlaylists.Count; i++)
            //{
            //    recentPlaylistsNames[i] = Path.GetFileNameWithoutExtension(recentPlaylists[i]);
            //    UpdatePlaylistsName();
            //}
        }
        private void UpdatePlaylistsName() {
            button2.Text = recentPlaylistsNames[0];
            button3.Text = recentPlaylistsNames[1];
            button4.Text = recentPlaylistsNames[2];
            button5.Text = recentPlaylistsNames[3];
            button6.Text = recentPlaylistsNames[4];
            button7.Text = recentPlaylistsNames[5];

        }

        private void OpenPlaylist(string PlaylistDir) {
            using (StreamReader openPL = new StreamReader(PlaylistDir))
            {
                string line = openPL.ReadLine();
                while (line != null)
                {
                    var filePath = line;
                    recentPlayListDir.Add(filePath);
                    var fileName = Path.GetFileNameWithoutExtension(line);
                    recentPlayList.Add(fileName);
                    line = openPL.ReadLine();
                }
            }

        }

        //private void UpdateCurrentPlaylist() {
        //    Meowzic.playListDir = recentPlayListDir;
        //    int count = 0;
        //    foreach (var item in Meowzic.playList.Items)
        //    {
        //        Meowzic.playList.Items[count] = recentPlayList[count];
        //        count++;
        //    }

        //}



        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        //private void button2_Click(object sender, EventArgs e)
        //{
        //    OpenPlaylist(recentPlaylists[0]);
        //    foreach (var item in recentPlayList)
        //    {
        //        MessageBox.Show(item.ToString());
        //    }
        //    Meowzic.playListDir = recentPlayListDir;
        //    for (int i = 0; i < recentPlayList.Count; i++)
        //    {
        //        Meowzic.playList.Items[i] = recentPlayList[i];
        //    }
        //}

        private void button3_Click(object sender, EventArgs e)
        {
            OpenPlaylist(recentPlaylists[1]);


        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenPlaylist(recentPlaylists[2]);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenPlaylist(recentPlaylists[3]);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            OpenPlaylist(recentPlaylists[4]);

        }

        private void button7_Click(object sender, EventArgs e)
        {
            OpenPlaylist(recentPlaylists[5]);

        }
    }
}
