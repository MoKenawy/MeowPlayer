namespace WindowsFormsApp2
{
    partial class Meowzic
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Meowzic));
            this.posBar = new System.Windows.Forms.TrackBar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.savePlaylistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importPlaylistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteSelectedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.normalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renderWaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.checkAllButton = new System.Windows.Forms.Button();
            this.onRepeatButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.volBar = new System.Windows.Forms.TrackBar();
            this.afterButton = new System.Windows.Forms.Button();
            this.advanceButton = new System.Windows.Forms.Button();
            this.playButton = new System.Windows.Forms.Button();
            this.rewindButton = new System.Windows.Forms.Button();
            this.beforeButton = new System.Windows.Forms.Button();
            this.playPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.playList = new System.Windows.Forms.CheckedListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.posBar)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.volBar)).BeginInit();
            this.playPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // posBar
            // 
            this.posBar.AutoSize = false;
            this.posBar.BackColor = System.Drawing.Color.White;
            this.posBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.posBar.Location = new System.Drawing.Point(0, 24);
            this.posBar.Margin = new System.Windows.Forms.Padding(50, 3, 3, 3);
            this.posBar.Maximum = 200;
            this.posBar.Name = "posBar";
            this.posBar.Size = new System.Drawing.Size(846, 24);
            this.posBar.TabIndex = 5;
            this.posBar.Scroll += new System.EventHandler(this.posBar_Scroll);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(952, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.savePlaylistToolStripMenuItem,
            this.importPlaylistToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // savePlaylistToolStripMenuItem
            // 
            this.savePlaylistToolStripMenuItem.Name = "savePlaylistToolStripMenuItem";
            this.savePlaylistToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.savePlaylistToolStripMenuItem.Text = "Save Playlist";
            this.savePlaylistToolStripMenuItem.Click += new System.EventHandler(this.savePlaylistToolStripMenuItem_Click);
            // 
            // importPlaylistToolStripMenuItem
            // 
            this.importPlaylistToolStripMenuItem.Name = "importPlaylistToolStripMenuItem";
            this.importPlaylistToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.importPlaylistToolStripMenuItem.Text = "Import Playlist";
            this.importPlaylistToolStripMenuItem.Click += new System.EventHandler(this.importPlaylistToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playListToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // playListToolStripMenuItem
            // 
            this.playListToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearToolStripMenuItem,
            this.deleteSelectedToolStripMenuItem});
            this.playListToolStripMenuItem.Name = "playListToolStripMenuItem";
            this.playListToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.playListToolStripMenuItem.Text = "PlayList";
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // deleteSelectedToolStripMenuItem
            // 
            this.deleteSelectedToolStripMenuItem.Name = "deleteSelectedToolStripMenuItem";
            this.deleteSelectedToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.deleteSelectedToolStripMenuItem.Text = "Delete selected";
            this.deleteSelectedToolStripMenuItem.Click += new System.EventHandler(this.deleteSelectedToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.normalToolStripMenuItem,
            this.renderWaveToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // normalToolStripMenuItem
            // 
            this.normalToolStripMenuItem.Name = "normalToolStripMenuItem";
            this.normalToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.normalToolStripMenuItem.Text = "Normal";
            this.normalToolStripMenuItem.Click += new System.EventHandler(this.normalToolStripMenuItem_Click);
            // 
            // renderWaveToolStripMenuItem
            // 
            this.renderWaveToolStripMenuItem.Name = "renderWaveToolStripMenuItem";
            this.renderWaveToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.renderWaveToolStripMenuItem.Text = "Render Wave";
            this.renderWaveToolStripMenuItem.Click += new System.EventHandler(this.renderWaveToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // AddButton
            // 
            this.AddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AddButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.AddButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.Location = new System.Drawing.Point(860, 448);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(33, 23);
            this.AddButton.TabIndex = 10;
            this.AddButton.Text = "+";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteButton.BackgroundImage = global::WindowsFormsApp2.Properties.Resources._296_2961763_trash_icon_png_rubbish_white_bin_transparent_png;
            this.deleteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.deleteButton.Location = new System.Drawing.Point(919, 448);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(33, 23);
            this.deleteButton.TabIndex = 8;
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // checkAllButton
            // 
            this.checkAllButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.checkAllButton.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.select_all_icon_9;
            this.checkAllButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.checkAllButton.Location = new System.Drawing.Point(889, 448);
            this.checkAllButton.Name = "checkAllButton";
            this.checkAllButton.Size = new System.Drawing.Size(33, 23);
            this.checkAllButton.TabIndex = 7;
            this.checkAllButton.UseVisualStyleBackColor = true;
            this.checkAllButton.Click += new System.EventHandler(this.checkAllButton_Click);
            // 
            // onRepeatButton
            // 
            this.onRepeatButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.onRepeatButton.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.download;
            this.onRepeatButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.onRepeatButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.onRepeatButton.Location = new System.Drawing.Point(850, 15);
            this.onRepeatButton.Margin = new System.Windows.Forms.Padding(0, 15, 3, 15);
            this.onRepeatButton.Name = "onRepeatButton";
            this.onRepeatButton.Size = new System.Drawing.Size(26, 39);
            this.onRepeatButton.TabIndex = 7;
            this.onRepeatButton.UseVisualStyleBackColor = true;
            this.onRepeatButton.Click += new System.EventHandler(this.onRepeatButton_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.Controls.Add(this.beforeButton);
            this.flowLayoutPanel2.Controls.Add(this.rewindButton);
            this.flowLayoutPanel2.Controls.Add(this.playButton);
            this.flowLayoutPanel2.Controls.Add(this.advanceButton);
            this.flowLayoutPanel2.Controls.Add(this.afterButton);
            this.flowLayoutPanel2.Controls.Add(this.volBar);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(250, 0);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(0, 0, 50, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(550, 69);
            this.flowLayoutPanel2.TabIndex = 6;
            this.flowLayoutPanel2.WrapContents = false;
            // 
            // volBar
            // 
            this.volBar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.volBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.volBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flowLayoutPanel2.SetFlowBreak(this.volBar, true);
            this.volBar.Location = new System.Drawing.Point(410, 12);
            this.volBar.Margin = new System.Windows.Forms.Padding(50, 3, 3, 3);
            this.volBar.Maximum = 100;
            this.volBar.Name = "volBar";
            this.volBar.Size = new System.Drawing.Size(137, 45);
            this.volBar.TabIndex = 6;
            this.volBar.TabStop = false;
            this.volBar.TickFrequency = 10;
            this.volBar.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.volBar.Value = 50;
            this.volBar.Scroll += new System.EventHandler(this.volBar_Scroll);
            // 
            // afterButton
            // 
            this.afterButton.Location = new System.Drawing.Point(296, 3);
            this.afterButton.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.afterButton.Name = "afterButton";
            this.afterButton.Size = new System.Drawing.Size(61, 63);
            this.afterButton.TabIndex = 2;
            this.afterButton.TabStop = false;
            this.afterButton.Text = ">>";
            this.afterButton.UseVisualStyleBackColor = true;
            this.afterButton.Click += new System.EventHandler(this.button5_Click);
            this.afterButton.MouseEnter += new System.EventHandler(this.Button_Enter);
            this.afterButton.MouseLeave += new System.EventHandler(this.Button_Leave);
            // 
            // advanceButton
            // 
            this.advanceButton.Location = new System.Drawing.Point(222, 3);
            this.advanceButton.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.advanceButton.Name = "advanceButton";
            this.advanceButton.Size = new System.Drawing.Size(61, 63);
            this.advanceButton.TabIndex = 1;
            this.advanceButton.TabStop = false;
            this.advanceButton.Text = ">";
            this.advanceButton.UseVisualStyleBackColor = true;
            this.advanceButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.advanceButton_MouseDown);
            this.advanceButton.MouseEnter += new System.EventHandler(this.Button_Enter);
            this.advanceButton.MouseLeave += new System.EventHandler(this.Button_Leave);
            // 
            // playButton
            // 
            this.playButton.Location = new System.Drawing.Point(148, 3);
            this.playButton.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(61, 63);
            this.playButton.TabIndex = 0;
            this.playButton.Text = "Play";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            this.playButton.MouseEnter += new System.EventHandler(this.Button_Enter);
            this.playButton.MouseLeave += new System.EventHandler(this.Button_Leave);
            // 
            // rewindButton
            // 
            this.rewindButton.Location = new System.Drawing.Point(74, 3);
            this.rewindButton.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.rewindButton.Name = "rewindButton";
            this.rewindButton.Size = new System.Drawing.Size(61, 63);
            this.rewindButton.TabIndex = 3;
            this.rewindButton.Text = "<";
            this.rewindButton.UseVisualStyleBackColor = true;
            this.rewindButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.rewindButton_MouseDown);
            this.rewindButton.MouseEnter += new System.EventHandler(this.Button_Enter);
            this.rewindButton.MouseLeave += new System.EventHandler(this.Button_Leave);
            // 
            // beforeButton
            // 
            this.beforeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.beforeButton.ForeColor = System.Drawing.Color.DarkBlue;
            this.beforeButton.Location = new System.Drawing.Point(0, 3);
            this.beforeButton.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.beforeButton.Name = "beforeButton";
            this.beforeButton.Size = new System.Drawing.Size(61, 63);
            this.beforeButton.TabIndex = 4;
            this.beforeButton.Text = "<<";
            this.beforeButton.UseCompatibleTextRendering = true;
            this.beforeButton.UseVisualStyleBackColor = true;
            this.beforeButton.Click += new System.EventHandler(this.button1_Click);
            this.beforeButton.MouseEnter += new System.EventHandler(this.Button_Enter);
            this.beforeButton.MouseLeave += new System.EventHandler(this.Button_Leave);
            // 
            // playPanel
            // 
            this.playPanel.AutoSize = true;
            this.playPanel.BackColor = System.Drawing.Color.White;
            this.playPanel.Controls.Add(this.flowLayoutPanel2);
            this.playPanel.Controls.Add(this.onRepeatButton);
            this.playPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.playPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playPanel.ForeColor = System.Drawing.Color.DarkBlue;
            this.playPanel.Location = new System.Drawing.Point(0, 493);
            this.playPanel.Margin = new System.Windows.Forms.Padding(0);
            this.playPanel.Name = "playPanel";
            this.playPanel.Padding = new System.Windows.Forms.Padding(250, 0, 500, 0);
            this.playPanel.Size = new System.Drawing.Size(952, 69);
            this.playPanel.TabIndex = 0;
            this.playPanel.WrapContents = false;
            // 
            // playList
            // 
            this.playList.BackColor = System.Drawing.Color.WhiteSmoke;
            this.playList.Dock = System.Windows.Forms.DockStyle.Right;
            this.playList.Font = new System.Drawing.Font("Perpetua", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playList.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.playList.FormattingEnabled = true;
            this.playList.HorizontalScrollbar = true;
            this.playList.Location = new System.Drawing.Point(849, 24);
            this.playList.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.playList.Name = "playList";
            this.playList.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.playList.Size = new System.Drawing.Size(103, 469);
            this.playList.TabIndex = 2;
            this.playList.UseCompatibleTextRendering = true;
            this.playList.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBox1_ItemCheck);
            this.playList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.checkedListBox1_KeyDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Image = global::WindowsFormsApp2.Properties.Resources.cat_music;
            this.pictureBox1.InitialImage = global::WindowsFormsApp2.Properties.Resources.felix_the;
            this.pictureBox1.Location = new System.Drawing.Point(0, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(849, 469);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Meowzic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(952, 562);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.checkAllButton);
            this.Controls.Add(this.playList);
            this.Controls.Add(this.playPanel);
            this.Controls.Add(this.posBar);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Meowzic";
            this.Text = "Meowzic";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.posBar)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.volBar)).EndInit();
            this.playPanel.ResumeLayout(false);
            this.playPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TrackBar posBar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem savePlaylistToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importPlaylistToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteSelectedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renderWaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem normalToolStripMenuItem;
        private System.Windows.Forms.Button checkAllButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button onRepeatButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button beforeButton;
        private System.Windows.Forms.Button rewindButton;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Button advanceButton;
        private System.Windows.Forms.Button afterButton;
        private System.Windows.Forms.TrackBar volBar;
        private System.Windows.Forms.FlowLayoutPanel playPanel;
        private System.Windows.Forms.CheckedListBox playList;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

