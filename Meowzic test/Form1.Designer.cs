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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Meowzic));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.moveUpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.moveDownToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moveDownToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moveUpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.onRepeatButton = new FontAwesome.Sharp.IconPictureBox();
            this.playButton = new FontAwesome.Sharp.IconPictureBox();
            this.beforeButton = new FontAwesome.Sharp.IconPictureBox();
            this.rewindButton = new FontAwesome.Sharp.IconPictureBox();
            this.advanceButton = new FontAwesome.Sharp.IconPictureBox();
            this.volBar = new System.Windows.Forms.TrackBar();
            this.afterButton = new FontAwesome.Sharp.IconPictureBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panelTopContent = new System.Windows.Forms.Panel();
            this.positionIndicatorPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.positionTrackBar = new System.Windows.Forms.TrackBar();
            this.playList = new System.Windows.Forms.CheckedListBox();
            this.panelContent = new System.Windows.Forms.Panel();
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.AboutButton = new System.Windows.Forms.Button();
            this.SettingsSubMenu = new System.Windows.Forms.Panel();
            this.RenderWaveButton = new System.Windows.Forms.Button();
            this.normalViewButton = new System.Windows.Forms.Button();
            this.settingsButton = new System.Windows.Forms.Button();
            this.PlaylistSubMenu = new System.Windows.Forms.Panel();
            this.clearPlaylistButton = new System.Windows.Forms.Button();
            this.savePlaylistButton = new System.Windows.Forms.Button();
            this.openPlaylistButton = new System.Windows.Forms.Button();
            this.PlaylistButton = new System.Windows.Forms.Button();
            this.MediaSubMenu = new System.Windows.Forms.Panel();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.checkAllButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.MediaButton = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.logo = new System.Windows.Forms.PictureBox();
            this.ElapsedTimeShadow = new System.Windows.Forms.Panel();
            this.contextMenuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.onRepeatButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.beforeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rewindButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.advanceButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.volBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.afterButton)).BeginInit();
            this.panelTopContent.SuspendLayout();
            this.positionIndicatorPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.positionTrackBar)).BeginInit();
            this.panelContent.SuspendLayout();
            this.panelSideMenu.SuspendLayout();
            this.SettingsSubMenu.SuspendLayout();
            this.PlaylistSubMenu.SuspendLayout();
            this.MediaSubMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.removeToolStripMenuItem1,
            this.moveUpToolStripMenuItem1,
            this.moveDownToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(139, 92);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // removeToolStripMenuItem1
            // 
            this.removeToolStripMenuItem1.Name = "removeToolStripMenuItem1";
            this.removeToolStripMenuItem1.Size = new System.Drawing.Size(138, 22);
            this.removeToolStripMenuItem1.Text = "Remove";
            this.removeToolStripMenuItem1.Click += new System.EventHandler(this.removeToolStripMenuItem1_Click);
            // 
            // moveUpToolStripMenuItem1
            // 
            this.moveUpToolStripMenuItem1.Name = "moveUpToolStripMenuItem1";
            this.moveUpToolStripMenuItem1.Size = new System.Drawing.Size(138, 22);
            this.moveUpToolStripMenuItem1.Text = "Move Up";
            this.moveUpToolStripMenuItem1.Click += new System.EventHandler(this.moveUpToolStripMenuItem1_Click);
            // 
            // moveDownToolStripMenuItem1
            // 
            this.moveDownToolStripMenuItem1.Name = "moveDownToolStripMenuItem1";
            this.moveDownToolStripMenuItem1.Size = new System.Drawing.Size(138, 22);
            this.moveDownToolStripMenuItem1.Text = "Move Down";
            this.moveDownToolStripMenuItem1.Click += new System.EventHandler(this.moveDownToolStripMenuItem1_Click);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.removeToolStripMenuItem.Text = "Remove";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
            // 
            // moveDownToolStripMenuItem
            // 
            this.moveDownToolStripMenuItem.Name = "moveDownToolStripMenuItem";
            this.moveDownToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.moveDownToolStripMenuItem.Text = "Move Down";
            this.moveDownToolStripMenuItem.Click += new System.EventHandler(this.moveDownToolStripMenuItem_Click);
            // 
            // moveUpToolStripMenuItem
            // 
            this.moveUpToolStripMenuItem.Name = "moveUpToolStripMenuItem";
            this.moveUpToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.moveUpToolStripMenuItem.Text = "Move Up";
            this.moveUpToolStripMenuItem.Click += new System.EventHandler(this.moveUpToolStripMenuItem_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 9;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.onRepeatButton, 6, 2);
            this.tableLayoutPanel1.Controls.Add(this.playButton, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.beforeButton, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.rewindButton, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.advanceButton, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.volBar, 7, 2);
            this.tableLayoutPanel1.Controls.Add(this.afterButton, 5, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBox2, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 476);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.99977F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.00023F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(921, 69);
            this.tableLayoutPanel1.TabIndex = 15;
            // 
            // onRepeatButton
            // 
            this.onRepeatButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.onRepeatButton.BackColor = System.Drawing.Color.White;
            this.onRepeatButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.onRepeatButton.ForeColor = System.Drawing.Color.DodgerBlue;
            this.onRepeatButton.IconChar = FontAwesome.Sharp.IconChar.LongArrowAltRight;
            this.onRepeatButton.IconColor = System.Drawing.Color.DodgerBlue;
            this.onRepeatButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.onRepeatButton.IconSize = 40;
            this.onRepeatButton.Location = new System.Drawing.Point(491, 13);
            this.onRepeatButton.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.onRepeatButton.Name = "onRepeatButton";
            this.onRepeatButton.Size = new System.Drawing.Size(40, 40);
            this.onRepeatButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.onRepeatButton.TabIndex = 16;
            this.onRepeatButton.TabStop = false;
            this.onRepeatButton.UseGdi = true;
            this.onRepeatButton.UseIconCache = true;
            this.onRepeatButton.Click += new System.EventHandler(this.onRepeatButton_Click);
            this.onRepeatButton.MouseEnter += new System.EventHandler(this.IconPicture_Enter);
            this.onRepeatButton.MouseLeave += new System.EventHandler(this.IconPicture_Leave);
            // 
            // playButton
            // 
            this.playButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.playButton.BackColor = System.Drawing.Color.White;
            this.playButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.playButton.ForeColor = System.Drawing.Color.DodgerBlue;
            this.playButton.IconChar = FontAwesome.Sharp.IconChar.Play;
            this.playButton.IconColor = System.Drawing.Color.DodgerBlue;
            this.playButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.playButton.IconSize = 40;
            this.playButton.Location = new System.Drawing.Point(311, 13);
            this.playButton.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(40, 40);
            this.playButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.playButton.TabIndex = 15;
            this.playButton.TabStop = false;
            this.playButton.UseGdi = true;
            this.playButton.UseIconCache = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            this.playButton.MouseEnter += new System.EventHandler(this.IconPicture_Enter);
            this.playButton.MouseLeave += new System.EventHandler(this.IconPicture_Leave);
            // 
            // beforeButton
            // 
            this.beforeButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.beforeButton.BackColor = System.Drawing.Color.White;
            this.beforeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.beforeButton.ForeColor = System.Drawing.Color.DodgerBlue;
            this.beforeButton.IconChar = FontAwesome.Sharp.IconChar.AngleDoubleLeft;
            this.beforeButton.IconColor = System.Drawing.Color.DodgerBlue;
            this.beforeButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.beforeButton.IconSize = 40;
            this.beforeButton.Location = new System.Drawing.Point(191, 13);
            this.beforeButton.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.beforeButton.Name = "beforeButton";
            this.beforeButton.Size = new System.Drawing.Size(40, 40);
            this.beforeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.beforeButton.TabIndex = 14;
            this.beforeButton.TabStop = false;
            this.beforeButton.UseGdi = true;
            this.beforeButton.UseIconCache = true;
            this.beforeButton.Click += new System.EventHandler(this.beforeButton_Click);
            this.beforeButton.MouseEnter += new System.EventHandler(this.IconPicture_Enter);
            this.beforeButton.MouseLeave += new System.EventHandler(this.IconPicture_Leave);
            // 
            // rewindButton
            // 
            this.rewindButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rewindButton.BackColor = System.Drawing.Color.White;
            this.rewindButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.rewindButton.ForeColor = System.Drawing.Color.DodgerBlue;
            this.rewindButton.IconChar = FontAwesome.Sharp.IconChar.AngleLeft;
            this.rewindButton.IconColor = System.Drawing.Color.DodgerBlue;
            this.rewindButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.rewindButton.IconSize = 40;
            this.rewindButton.Location = new System.Drawing.Point(251, 13);
            this.rewindButton.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.rewindButton.Name = "rewindButton";
            this.rewindButton.Size = new System.Drawing.Size(40, 40);
            this.rewindButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.rewindButton.TabIndex = 13;
            this.rewindButton.TabStop = false;
            this.rewindButton.UseGdi = true;
            this.rewindButton.UseIconCache = true;
            this.rewindButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.rewindButton_MouseDown);
            this.rewindButton.MouseEnter += new System.EventHandler(this.IconPicture_Enter);
            this.rewindButton.MouseLeave += new System.EventHandler(this.IconPicture_Leave);
            // 
            // advanceButton
            // 
            this.advanceButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.advanceButton.BackColor = System.Drawing.Color.White;
            this.advanceButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.advanceButton.ForeColor = System.Drawing.Color.DodgerBlue;
            this.advanceButton.IconChar = FontAwesome.Sharp.IconChar.AngleRight;
            this.advanceButton.IconColor = System.Drawing.Color.DodgerBlue;
            this.advanceButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.advanceButton.IconSize = 40;
            this.advanceButton.Location = new System.Drawing.Point(371, 13);
            this.advanceButton.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.advanceButton.Name = "advanceButton";
            this.advanceButton.Size = new System.Drawing.Size(40, 40);
            this.advanceButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.advanceButton.TabIndex = 12;
            this.advanceButton.TabStop = false;
            this.advanceButton.UseGdi = true;
            this.advanceButton.UseIconCache = true;
            this.advanceButton.Click += new System.EventHandler(this.advanceButton_Click);
            this.advanceButton.MouseEnter += new System.EventHandler(this.IconPicture_Enter);
            this.advanceButton.MouseLeave += new System.EventHandler(this.IconPicture_Leave);
            // 
            // volBar
            // 
            this.volBar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.volBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.volBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.volBar.Location = new System.Drawing.Point(591, 11);
            this.volBar.Margin = new System.Windows.Forms.Padding(50, 3, 3, 3);
            this.volBar.Maximum = 100;
            this.volBar.Name = "volBar";
            this.volBar.Size = new System.Drawing.Size(146, 45);
            this.volBar.TabIndex = 10;
            this.volBar.TabStop = false;
            this.volBar.TickFrequency = 10;
            this.volBar.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.volBar.Value = 50;
            this.volBar.Scroll += new System.EventHandler(this.volBar_Scroll);
            // 
            // afterButton
            // 
            this.afterButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.afterButton.BackColor = System.Drawing.Color.White;
            this.afterButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.afterButton.ForeColor = System.Drawing.Color.DodgerBlue;
            this.afterButton.IconChar = FontAwesome.Sharp.IconChar.AngleDoubleRight;
            this.afterButton.IconColor = System.Drawing.Color.DodgerBlue;
            this.afterButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.afterButton.IconSize = 40;
            this.afterButton.Location = new System.Drawing.Point(431, 13);
            this.afterButton.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.afterButton.Name = "afterButton";
            this.afterButton.Size = new System.Drawing.Size(40, 40);
            this.afterButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.afterButton.TabIndex = 11;
            this.afterButton.TabStop = false;
            this.afterButton.UseGdi = true;
            this.afterButton.UseIconCache = true;
            this.afterButton.Click += new System.EventHandler(this.afterButton_Click);
            this.afterButton.MouseEnter += new System.EventHandler(this.IconPicture_Enter);
            this.afterButton.MouseLeave += new System.EventHandler(this.IconPicture_Leave);
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBox2.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.textBox2.HideSelection = false;
            this.textBox2.Location = new System.Drawing.Point(35, 22);
            this.textBox2.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(127, 23);
            this.textBox2.TabIndex = 15;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox2.Visible = false;
            // 
            // panelTopContent
            // 
            this.panelTopContent.BackColor = System.Drawing.Color.White;
            this.panelTopContent.Controls.Add(this.positionIndicatorPanel);
            this.panelTopContent.Controls.Add(this.pictureBox1);
            this.panelTopContent.Controls.Add(this.positionTrackBar);
            this.panelTopContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTopContent.Location = new System.Drawing.Point(136, 0);
            this.panelTopContent.Name = "panelTopContent";
            this.panelTopContent.Size = new System.Drawing.Size(702, 476);
            this.panelTopContent.TabIndex = 2;
            // 
            // positionIndicatorPanel
            // 
            this.positionIndicatorPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.positionIndicatorPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(19)))), ((int)(((byte)(128)))));
            this.positionIndicatorPanel.Controls.Add(this.ElapsedTimeShadow);
            this.positionIndicatorPanel.Location = new System.Drawing.Point(0, 0);
            this.positionIndicatorPanel.Margin = new System.Windows.Forms.Padding(0);
            this.positionIndicatorPanel.Name = "positionIndicatorPanel";
            this.positionIndicatorPanel.Size = new System.Drawing.Size(2, 461);
            this.positionIndicatorPanel.TabIndex = 18;
            this.positionIndicatorPanel.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Image = global::Meowzic_test.Properties.Resources.cat_music;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(702, 461);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.picturePositionChange_Click);
            // 
            // positionTrackBar
            // 
            this.positionTrackBar.AutoSize = false;
            this.positionTrackBar.BackColor = System.Drawing.Color.GhostWhite;
            this.positionTrackBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.positionTrackBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.positionTrackBar.Location = new System.Drawing.Point(0, 461);
            this.positionTrackBar.Margin = new System.Windows.Forms.Padding(50, 3, 3, 3);
            this.positionTrackBar.Maximum = 200;
            this.positionTrackBar.Name = "positionTrackBar";
            this.positionTrackBar.Size = new System.Drawing.Size(702, 15);
            this.positionTrackBar.TabIndex = 17;
            this.positionTrackBar.TabStop = false;
            this.positionTrackBar.TickFrequency = 2;
            this.positionTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.positionTrackBar.Scroll += new System.EventHandler(this.positionTrackBar_Scroll);
            // 
            // playList
            // 
            this.playList.BackColor = System.Drawing.Color.WhiteSmoke;
            this.playList.ContextMenuStrip = this.contextMenuStrip1;
            this.playList.Dock = System.Windows.Forms.DockStyle.Right;
            this.playList.Font = new System.Drawing.Font("Perpetua", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playList.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.playList.FormattingEnabled = true;
            this.playList.Location = new System.Drawing.Point(838, 0);
            this.playList.Name = "playList";
            this.playList.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.playList.Size = new System.Drawing.Size(83, 476);
            this.playList.TabIndex = 13;
            this.playList.UseCompatibleTextRendering = true;
            this.playList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.checkedListBox1_KeyDown);
            // 
            // panelContent
            // 
            this.panelContent.BackColor = System.Drawing.Color.White;
            this.panelContent.Controls.Add(this.panelTopContent);
            this.panelContent.Controls.Add(this.panelSideMenu);
            this.panelContent.Controls.Add(this.playList);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(0, 0);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(921, 476);
            this.panelContent.TabIndex = 3;
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.AutoScroll = true;
            this.panelSideMenu.BackColor = System.Drawing.Color.White;
            this.panelSideMenu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelSideMenu.Controls.Add(this.AboutButton);
            this.panelSideMenu.Controls.Add(this.SettingsSubMenu);
            this.panelSideMenu.Controls.Add(this.settingsButton);
            this.panelSideMenu.Controls.Add(this.PlaylistSubMenu);
            this.panelSideMenu.Controls.Add(this.PlaylistButton);
            this.panelSideMenu.Controls.Add(this.MediaSubMenu);
            this.panelSideMenu.Controls.Add(this.MediaButton);
            this.panelSideMenu.Controls.Add(this.panelLogo);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(136, 476);
            this.panelSideMenu.TabIndex = 16;
            // 
            // AboutButton
            // 
            this.AboutButton.BackColor = System.Drawing.Color.White;
            this.AboutButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.AboutButton.FlatAppearance.BorderSize = 0;
            this.AboutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AboutButton.Font = new System.Drawing.Font("Microsoft Tai Le", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AboutButton.ForeColor = System.Drawing.Color.DodgerBlue;
            this.AboutButton.Location = new System.Drawing.Point(0, 583);
            this.AboutButton.Margin = new System.Windows.Forms.Padding(0);
            this.AboutButton.Name = "AboutButton";
            this.AboutButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.AboutButton.Size = new System.Drawing.Size(115, 46);
            this.AboutButton.TabIndex = 7;
            this.AboutButton.Text = "About";
            this.AboutButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AboutButton.UseVisualStyleBackColor = false;
            this.AboutButton.Click += new System.EventHandler(this.AboutButton_Click);
            this.AboutButton.MouseEnter += new System.EventHandler(this.SidePanelButtons_MouseEnter);
            this.AboutButton.MouseLeave += new System.EventHandler(this.SidePanelButtons_MouseLeave);
            // 
            // SettingsSubMenu
            // 
            this.SettingsSubMenu.AutoSize = true;
            this.SettingsSubMenu.BackColor = System.Drawing.Color.AliceBlue;
            this.SettingsSubMenu.Controls.Add(this.RenderWaveButton);
            this.SettingsSubMenu.Controls.Add(this.normalViewButton);
            this.SettingsSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.SettingsSubMenu.Location = new System.Drawing.Point(0, 503);
            this.SettingsSubMenu.Name = "SettingsSubMenu";
            this.SettingsSubMenu.Size = new System.Drawing.Size(115, 80);
            this.SettingsSubMenu.TabIndex = 6;
            this.SettingsSubMenu.Visible = false;
            // 
            // RenderWaveButton
            // 
            this.RenderWaveButton.BackColor = System.Drawing.Color.GhostWhite;
            this.RenderWaveButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.RenderWaveButton.FlatAppearance.BorderSize = 0;
            this.RenderWaveButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.RenderWaveButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.RenderWaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RenderWaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RenderWaveButton.Location = new System.Drawing.Point(0, 40);
            this.RenderWaveButton.Name = "RenderWaveButton";
            this.RenderWaveButton.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.RenderWaveButton.Size = new System.Drawing.Size(115, 40);
            this.RenderWaveButton.TabIndex = 9;
            this.RenderWaveButton.Text = "Render Wave";
            this.RenderWaveButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RenderWaveButton.UseVisualStyleBackColor = false;
            this.RenderWaveButton.Click += new System.EventHandler(this.RenderWaveButton_Click);
            // 
            // normalViewButton
            // 
            this.normalViewButton.BackColor = System.Drawing.Color.GhostWhite;
            this.normalViewButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.normalViewButton.FlatAppearance.BorderSize = 0;
            this.normalViewButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.normalViewButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.normalViewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.normalViewButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.normalViewButton.Location = new System.Drawing.Point(0, 0);
            this.normalViewButton.Name = "normalViewButton";
            this.normalViewButton.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.normalViewButton.Size = new System.Drawing.Size(115, 40);
            this.normalViewButton.TabIndex = 8;
            this.normalViewButton.Text = "Normal View";
            this.normalViewButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.normalViewButton.UseVisualStyleBackColor = false;
            this.normalViewButton.Click += new System.EventHandler(this.normalViewButton_Click);
            // 
            // settingsButton
            // 
            this.settingsButton.BackColor = System.Drawing.Color.White;
            this.settingsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.settingsButton.FlatAppearance.BorderSize = 0;
            this.settingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsButton.Font = new System.Drawing.Font("Microsoft Tai Le", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsButton.ForeColor = System.Drawing.Color.DodgerBlue;
            this.settingsButton.Location = new System.Drawing.Point(0, 457);
            this.settingsButton.Margin = new System.Windows.Forms.Padding(0);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.settingsButton.Size = new System.Drawing.Size(115, 46);
            this.settingsButton.TabIndex = 5;
            this.settingsButton.Text = "Settings";
            this.settingsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.settingsButton.UseVisualStyleBackColor = false;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            this.settingsButton.MouseEnter += new System.EventHandler(this.SidePanelButtons_MouseEnter);
            this.settingsButton.MouseLeave += new System.EventHandler(this.SidePanelButtons_MouseLeave);
            // 
            // PlaylistSubMenu
            // 
            this.PlaylistSubMenu.AutoSize = true;
            this.PlaylistSubMenu.BackColor = System.Drawing.Color.AliceBlue;
            this.PlaylistSubMenu.Controls.Add(this.clearPlaylistButton);
            this.PlaylistSubMenu.Controls.Add(this.savePlaylistButton);
            this.PlaylistSubMenu.Controls.Add(this.openPlaylistButton);
            this.PlaylistSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.PlaylistSubMenu.Location = new System.Drawing.Point(0, 337);
            this.PlaylistSubMenu.Name = "PlaylistSubMenu";
            this.PlaylistSubMenu.Size = new System.Drawing.Size(115, 120);
            this.PlaylistSubMenu.TabIndex = 4;
            this.PlaylistSubMenu.Visible = false;
            // 
            // clearPlaylistButton
            // 
            this.clearPlaylistButton.BackColor = System.Drawing.Color.GhostWhite;
            this.clearPlaylistButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.clearPlaylistButton.FlatAppearance.BorderSize = 0;
            this.clearPlaylistButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.clearPlaylistButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.clearPlaylistButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearPlaylistButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearPlaylistButton.Location = new System.Drawing.Point(0, 80);
            this.clearPlaylistButton.Name = "clearPlaylistButton";
            this.clearPlaylistButton.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.clearPlaylistButton.Size = new System.Drawing.Size(115, 40);
            this.clearPlaylistButton.TabIndex = 7;
            this.clearPlaylistButton.Text = "Clear";
            this.clearPlaylistButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.clearPlaylistButton.UseVisualStyleBackColor = false;
            this.clearPlaylistButton.Click += new System.EventHandler(this.clearPlaylistButton_Click);
            // 
            // savePlaylistButton
            // 
            this.savePlaylistButton.BackColor = System.Drawing.Color.GhostWhite;
            this.savePlaylistButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.savePlaylistButton.FlatAppearance.BorderSize = 0;
            this.savePlaylistButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.savePlaylistButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.savePlaylistButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.savePlaylistButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savePlaylistButton.Location = new System.Drawing.Point(0, 40);
            this.savePlaylistButton.Name = "savePlaylistButton";
            this.savePlaylistButton.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.savePlaylistButton.Size = new System.Drawing.Size(115, 40);
            this.savePlaylistButton.TabIndex = 6;
            this.savePlaylistButton.Text = "Save Playlist";
            this.savePlaylistButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.savePlaylistButton.UseVisualStyleBackColor = false;
            this.savePlaylistButton.Click += new System.EventHandler(this.savePlaylistButton_Click);
            // 
            // openPlaylistButton
            // 
            this.openPlaylistButton.BackColor = System.Drawing.Color.GhostWhite;
            this.openPlaylistButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.openPlaylistButton.FlatAppearance.BorderSize = 0;
            this.openPlaylistButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.openPlaylistButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.openPlaylistButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openPlaylistButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openPlaylistButton.Location = new System.Drawing.Point(0, 0);
            this.openPlaylistButton.Name = "openPlaylistButton";
            this.openPlaylistButton.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.openPlaylistButton.Size = new System.Drawing.Size(115, 40);
            this.openPlaylistButton.TabIndex = 5;
            this.openPlaylistButton.Text = "Open Playlist";
            this.openPlaylistButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.openPlaylistButton.UseVisualStyleBackColor = false;
            this.openPlaylistButton.Click += new System.EventHandler(this.openPlaylistButton_Click);
            // 
            // PlaylistButton
            // 
            this.PlaylistButton.BackColor = System.Drawing.Color.White;
            this.PlaylistButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.PlaylistButton.FlatAppearance.BorderSize = 0;
            this.PlaylistButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlaylistButton.Font = new System.Drawing.Font("Microsoft Tai Le", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlaylistButton.ForeColor = System.Drawing.Color.DodgerBlue;
            this.PlaylistButton.Location = new System.Drawing.Point(0, 291);
            this.PlaylistButton.Margin = new System.Windows.Forms.Padding(0);
            this.PlaylistButton.Name = "PlaylistButton";
            this.PlaylistButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.PlaylistButton.Size = new System.Drawing.Size(115, 46);
            this.PlaylistButton.TabIndex = 3;
            this.PlaylistButton.Text = "Playlist";
            this.PlaylistButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PlaylistButton.UseVisualStyleBackColor = false;
            this.PlaylistButton.Click += new System.EventHandler(this.PlaylistButton_Click);
            this.PlaylistButton.MouseEnter += new System.EventHandler(this.SidePanelButtons_MouseEnter);
            this.PlaylistButton.MouseLeave += new System.EventHandler(this.SidePanelButtons_MouseLeave);
            // 
            // MediaSubMenu
            // 
            this.MediaSubMenu.AutoSize = true;
            this.MediaSubMenu.BackColor = System.Drawing.Color.AliceBlue;
            this.MediaSubMenu.Controls.Add(this.RemoveButton);
            this.MediaSubMenu.Controls.Add(this.checkAllButton);
            this.MediaSubMenu.Controls.Add(this.AddButton);
            this.MediaSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.MediaSubMenu.Location = new System.Drawing.Point(0, 171);
            this.MediaSubMenu.Name = "MediaSubMenu";
            this.MediaSubMenu.Size = new System.Drawing.Size(115, 120);
            this.MediaSubMenu.TabIndex = 2;
            this.MediaSubMenu.Visible = false;
            // 
            // RemoveButton
            // 
            this.RemoveButton.BackColor = System.Drawing.Color.GhostWhite;
            this.RemoveButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.RemoveButton.FlatAppearance.BorderSize = 0;
            this.RemoveButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.RemoveButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.RemoveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveButton.Location = new System.Drawing.Point(0, 80);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.RemoveButton.Size = new System.Drawing.Size(115, 40);
            this.RemoveButton.TabIndex = 3;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RemoveButton.UseVisualStyleBackColor = false;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // checkAllButton
            // 
            this.checkAllButton.BackColor = System.Drawing.Color.GhostWhite;
            this.checkAllButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.checkAllButton.FlatAppearance.BorderSize = 0;
            this.checkAllButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.checkAllButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.checkAllButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkAllButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkAllButton.Location = new System.Drawing.Point(0, 40);
            this.checkAllButton.Name = "checkAllButton";
            this.checkAllButton.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.checkAllButton.Size = new System.Drawing.Size(115, 40);
            this.checkAllButton.TabIndex = 2;
            this.checkAllButton.Text = "Check All";
            this.checkAllButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.checkAllButton.UseVisualStyleBackColor = false;
            this.checkAllButton.Click += new System.EventHandler(this.checkAllButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.GhostWhite;
            this.AddButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.AddButton.FlatAppearance.BorderSize = 0;
            this.AddButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.AddButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.Location = new System.Drawing.Point(0, 0);
            this.AddButton.Name = "AddButton";
            this.AddButton.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.AddButton.Size = new System.Drawing.Size(115, 40);
            this.AddButton.TabIndex = 1;
            this.AddButton.Text = "Add Music";
            this.AddButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // MediaButton
            // 
            this.MediaButton.BackColor = System.Drawing.Color.White;
            this.MediaButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.MediaButton.FlatAppearance.BorderSize = 0;
            this.MediaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MediaButton.Font = new System.Drawing.Font("Microsoft Tai Le", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MediaButton.ForeColor = System.Drawing.Color.DodgerBlue;
            this.MediaButton.Location = new System.Drawing.Point(0, 125);
            this.MediaButton.Margin = new System.Windows.Forms.Padding(0);
            this.MediaButton.Name = "MediaButton";
            this.MediaButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.MediaButton.Size = new System.Drawing.Size(115, 46);
            this.MediaButton.TabIndex = 0;
            this.MediaButton.Text = "Media";
            this.MediaButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MediaButton.UseVisualStyleBackColor = false;
            this.MediaButton.Click += new System.EventHandler(this.MediaButton_Click);
            this.MediaButton.MouseEnter += new System.EventHandler(this.SidePanelButtons_MouseEnter);
            this.MediaButton.MouseLeave += new System.EventHandler(this.SidePanelButtons_MouseLeave);
            // 
            // panelLogo
            // 
            this.panelLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelLogo.Controls.Add(this.logo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(115, 125);
            this.panelLogo.TabIndex = 1;
            // 
            // logo
            // 
            this.logo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.logo.BackColor = System.Drawing.Color.Transparent;
            this.logo.Image = global::Meowzic_test.Properties.Resources.M_logo_3;
            this.logo.Location = new System.Drawing.Point(17, 34);
            this.logo.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(75, 51);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            // 
            // ElapsedTimeShadow
            // 
            this.ElapsedTimeShadow.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ElapsedTimeShadow.BackColor = System.Drawing.Color.Transparent;
            this.ElapsedTimeShadow.Location = new System.Drawing.Point(0, 0);
            this.ElapsedTimeShadow.Margin = new System.Windows.Forms.Padding(0);
            this.ElapsedTimeShadow.Name = "ElapsedTimeShadow";
            this.ElapsedTimeShadow.Size = new System.Drawing.Size(0, 461);
            this.ElapsedTimeShadow.TabIndex = 19;
            this.ElapsedTimeShadow.Visible = false;
            this.ElapsedTimeShadow.Click += new System.EventHandler(this.picturePositionChange_Click);
            // 
            // Meowzic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 545);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.tableLayoutPanel1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "Meowzic";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Meowzic";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.onRepeatButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.beforeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rewindButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.advanceButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.volBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.afterButton)).EndInit();
            this.panelTopContent.ResumeLayout(false);
            this.positionIndicatorPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.positionTrackBar)).EndInit();
            this.panelContent.ResumeLayout(false);
            this.panelSideMenu.ResumeLayout(false);
            this.panelSideMenu.PerformLayout();
            this.SettingsSubMenu.ResumeLayout(false);
            this.PlaylistSubMenu.ResumeLayout(false);
            this.MediaSubMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moveDownToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moveUpToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TrackBar volBar;
        private System.Windows.Forms.Panel panelTopContent;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem moveUpToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem moveDownToolStripMenuItem1;
        private FontAwesome.Sharp.IconPictureBox afterButton;
        private FontAwesome.Sharp.IconPictureBox advanceButton;
        private FontAwesome.Sharp.IconPictureBox rewindButton;
        private FontAwesome.Sharp.IconPictureBox beforeButton;
        private FontAwesome.Sharp.IconPictureBox playButton;
        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Button AboutButton;
        private System.Windows.Forms.Panel SettingsSubMenu;
        private System.Windows.Forms.Button RenderWaveButton;
        private System.Windows.Forms.Button normalViewButton;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.Panel PlaylistSubMenu;
        private System.Windows.Forms.Button clearPlaylistButton;
        private System.Windows.Forms.Button savePlaylistButton;
        private System.Windows.Forms.Button openPlaylistButton;
        private System.Windows.Forms.Button PlaylistButton;
        private System.Windows.Forms.Panel MediaSubMenu;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Button checkAllButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button MediaButton;
        private FontAwesome.Sharp.IconPictureBox onRepeatButton;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckedListBox playList;
        private System.Windows.Forms.TrackBar positionTrackBar;
        private System.Windows.Forms.Panel positionIndicatorPanel;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Panel ElapsedTimeShadow;
    }
}

