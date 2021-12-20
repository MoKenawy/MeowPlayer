using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeowzicUI_V._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ShowSubMenu(Panel SubMenuPanel) {
            if (SubMenuPanel.Visible == false)
            {
                SubMenuPanel.Visible = true;
            }

        }
        private void HideSubMenu(Panel SubMenuPanel) {
            if (SubMenuPanel.Visible == true)
            {
                SubMenuPanel.Visible = false;
            }
        }


        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelBotContent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void AllSubMenus_Click(object sender, EventArgs e)
        {

        }

        private void panelSubMenu1_Click(object sender, EventArgs e)
        {

        }

        private void MediaButton_Click(object sender, EventArgs e)
        {
            ShowSubMenu(MediaSubMenu);
            HideSubMenu(MediaSubMenu);
            HideSubMenu(PlaylistSubMenu);
            HideSubMenu(panelSubMenu3);
        }

        private void PlaylistButton_Click(object sender, EventArgs e)
        {
            ShowSubMenu(PlaylistSubMenu);
            HideSubMenu(PlaylistSubMenu);
            HideSubMenu(MediaSubMenu);
            HideSubMenu(panelSubMenu3);
        }
    }
}
