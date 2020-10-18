namespace MuViPApp
{
    partial class Form_Muvip
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Muvip));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Login = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Search = new Bunifu.Framework.UI.BunifuTextbox();
            this.panel_Player = new System.Windows.Forms.Panel();
            this.lb_Music_PanelPlayer_NameArtist = new System.Windows.Forms.Label();
            this.lb_Music_PanelPlayer_NameSong = new System.Windows.Forms.Label();
            this.btn_Music_PlayerPanel_Replay = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_Music_PlayerPanel_Pause = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_Music_PlayerPanel_Before = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_Music_PlayerPanel_Next = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_Music_PlayerPanel_Mix = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_Music_PlayerPanel_Play = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_Music_PlayerPanel_More = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_Music_PlayerPanel_Mute = new Bunifu.Framework.UI.BunifuImageButton();
            this.RestTime = new System.Windows.Forms.TextBox();
            this.BeginTime = new System.Windows.Forms.TextBox();
            this.play = new Bunifu.Framework.UI.BunifuSlider();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pn_Childform = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel_Music_Playlist = new System.Windows.Forms.Panel();
            this.Logo = new System.Windows.Forms.Panel();
            this.title = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_Video = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_Music = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_My_Music = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_Add = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_Liked = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_Playlist = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_NowPlaying = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_History = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Help = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Exit = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Menuside = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_AddPl = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_My_Video = new Bunifu.Framework.UI.BunifuFlatButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            this.panel_Player.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Music_PlayerPanel_Replay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Music_PlayerPanel_Pause)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Music_PlayerPanel_Before)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Music_PlayerPanel_Next)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Music_PlayerPanel_Mix)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Music_PlayerPanel_Play)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Music_PlayerPanel_More)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Music_PlayerPanel_Mute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.pn_Childform.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.Logo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.Menuside.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(45)))));
            this.panel1.Controls.Add(this.Login);
            this.panel1.Controls.Add(this.Search);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(189, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(643, 40);
            this.panel1.TabIndex = 7;
            // 
            // Login
            // 
            this.Login.ActiveBorderThickness = 1;
            this.Login.ActiveCornerRadius = 20;
            this.Login.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.Login.ActiveForecolor = System.Drawing.Color.White;
            this.Login.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.Login.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(45)))));
            this.Login.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Login.BackgroundImage")));
            this.Login.ButtonText = "LOGIN";
            this.Login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Login.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(45)))));
            this.Login.IdleBorderThickness = 1;
            this.Login.IdleCornerRadius = 20;
            this.Login.IdleFillColor = System.Drawing.Color.White;
            this.Login.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(45)))));
            this.Login.IdleLineColor = System.Drawing.Color.White;
            this.Login.Location = new System.Drawing.Point(514, 5);
            this.Login.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(88, 30);
            this.Login.TabIndex = 2;
            this.Login.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Search
            // 
            this.Search.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(45)))));
            this.Search.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Search.BackgroundImage")));
            this.Search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Search.ForeColor = System.Drawing.Color.White;
            this.Search.Icon = ((System.Drawing.Image)(resources.GetObject("Search.Icon")));
            this.Search.Location = new System.Drawing.Point(163, 9);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(247, 24);
            this.Search.TabIndex = 3;
            this.Search.text = "Search";
            // 
            // panel_Player
            // 
            this.panel_Player.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(36)))));
            this.panel_Player.Controls.Add(this.lb_Music_PanelPlayer_NameArtist);
            this.panel_Player.Controls.Add(this.lb_Music_PanelPlayer_NameSong);
            this.panel_Player.Controls.Add(this.btn_Music_PlayerPanel_Replay);
            this.panel_Player.Controls.Add(this.btn_Music_PlayerPanel_Pause);
            this.panel_Player.Controls.Add(this.btn_Music_PlayerPanel_Before);
            this.panel_Player.Controls.Add(this.btn_Music_PlayerPanel_Next);
            this.panel_Player.Controls.Add(this.btn_Music_PlayerPanel_Mix);
            this.panel_Player.Controls.Add(this.btn_Music_PlayerPanel_Play);
            this.panel_Player.Controls.Add(this.btn_Music_PlayerPanel_More);
            this.panel_Player.Controls.Add(this.btn_Music_PlayerPanel_Mute);
            this.panel_Player.Controls.Add(this.RestTime);
            this.panel_Player.Controls.Add(this.BeginTime);
            this.panel_Player.Controls.Add(this.play);
            this.panel_Player.Controls.Add(this.pictureBox3);
            this.panel_Player.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_Player.Location = new System.Drawing.Point(189, 411);
            this.panel_Player.Name = "panel_Player";
            this.panel_Player.Size = new System.Drawing.Size(643, 100);
            this.panel_Player.TabIndex = 10;
            // 
            // lb_Music_PanelPlayer_NameArtist
            // 
            this.lb_Music_PanelPlayer_NameArtist.AutoSize = true;
            this.lb_Music_PanelPlayer_NameArtist.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Music_PanelPlayer_NameArtist.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_Music_PanelPlayer_NameArtist.Location = new System.Drawing.Point(88, 42);
            this.lb_Music_PanelPlayer_NameArtist.Name = "lb_Music_PanelPlayer_NameArtist";
            this.lb_Music_PanelPlayer_NameArtist.Size = new System.Drawing.Size(36, 16);
            this.lb_Music_PanelPlayer_NameArtist.TabIndex = 15;
            this.lb_Music_PanelPlayer_NameArtist.Text = "Artist";
            // 
            // lb_Music_PanelPlayer_NameSong
            // 
            this.lb_Music_PanelPlayer_NameSong.AutoSize = true;
            this.lb_Music_PanelPlayer_NameSong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Music_PanelPlayer_NameSong.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_Music_PanelPlayer_NameSong.Location = new System.Drawing.Point(87, 16);
            this.lb_Music_PanelPlayer_NameSong.Name = "lb_Music_PanelPlayer_NameSong";
            this.lb_Music_PanelPlayer_NameSong.Size = new System.Drawing.Size(97, 19);
            this.lb_Music_PanelPlayer_NameSong.TabIndex = 14;
            this.lb_Music_PanelPlayer_NameSong.Text = "Song\'s Name";
            // 
            // btn_Music_PlayerPanel_Replay
            // 
            this.btn_Music_PlayerPanel_Replay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Music_PlayerPanel_Replay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(36)))));
            this.btn_Music_PlayerPanel_Replay.Image = ((System.Drawing.Image)(resources.GetObject("btn_Music_PlayerPanel_Replay.Image")));
            this.btn_Music_PlayerPanel_Replay.ImageActive = null;
            this.btn_Music_PlayerPanel_Replay.Location = new System.Drawing.Point(384, 23);
            this.btn_Music_PlayerPanel_Replay.Name = "btn_Music_PlayerPanel_Replay";
            this.btn_Music_PlayerPanel_Replay.Size = new System.Drawing.Size(26, 32);
            this.btn_Music_PlayerPanel_Replay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Music_PlayerPanel_Replay.TabIndex = 13;
            this.btn_Music_PlayerPanel_Replay.TabStop = false;
            this.btn_Music_PlayerPanel_Replay.Zoom = 10;
            // 
            // btn_Music_PlayerPanel_Pause
            // 
            this.btn_Music_PlayerPanel_Pause.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Music_PlayerPanel_Pause.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(36)))));
            this.btn_Music_PlayerPanel_Pause.Image = ((System.Drawing.Image)(resources.GetObject("btn_Music_PlayerPanel_Pause.Image")));
            this.btn_Music_PlayerPanel_Pause.ImageActive = null;
            this.btn_Music_PlayerPanel_Pause.Location = new System.Drawing.Point(280, 26);
            this.btn_Music_PlayerPanel_Pause.Name = "btn_Music_PlayerPanel_Pause";
            this.btn_Music_PlayerPanel_Pause.Size = new System.Drawing.Size(19, 27);
            this.btn_Music_PlayerPanel_Pause.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Music_PlayerPanel_Pause.TabIndex = 12;
            this.btn_Music_PlayerPanel_Pause.TabStop = false;
            this.btn_Music_PlayerPanel_Pause.Visible = false;
            this.btn_Music_PlayerPanel_Pause.Zoom = 10;
            this.btn_Music_PlayerPanel_Pause.Click += new System.EventHandler(this.btn_Music_Pause_Click);
            // 
            // btn_Music_PlayerPanel_Before
            // 
            this.btn_Music_PlayerPanel_Before.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Music_PlayerPanel_Before.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(36)))));
            this.btn_Music_PlayerPanel_Before.Image = ((System.Drawing.Image)(resources.GetObject("btn_Music_PlayerPanel_Before.Image")));
            this.btn_Music_PlayerPanel_Before.ImageActive = null;
            this.btn_Music_PlayerPanel_Before.Location = new System.Drawing.Point(234, 27);
            this.btn_Music_PlayerPanel_Before.Name = "btn_Music_PlayerPanel_Before";
            this.btn_Music_PlayerPanel_Before.Size = new System.Drawing.Size(27, 26);
            this.btn_Music_PlayerPanel_Before.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Music_PlayerPanel_Before.TabIndex = 11;
            this.btn_Music_PlayerPanel_Before.TabStop = false;
            this.btn_Music_PlayerPanel_Before.Zoom = 10;
            // 
            // btn_Music_PlayerPanel_Next
            // 
            this.btn_Music_PlayerPanel_Next.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Music_PlayerPanel_Next.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(36)))));
            this.btn_Music_PlayerPanel_Next.Image = ((System.Drawing.Image)(resources.GetObject("btn_Music_PlayerPanel_Next.Image")));
            this.btn_Music_PlayerPanel_Next.ImageActive = null;
            this.btn_Music_PlayerPanel_Next.Location = new System.Drawing.Point(312, 24);
            this.btn_Music_PlayerPanel_Next.Name = "btn_Music_PlayerPanel_Next";
            this.btn_Music_PlayerPanel_Next.Size = new System.Drawing.Size(23, 32);
            this.btn_Music_PlayerPanel_Next.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Music_PlayerPanel_Next.TabIndex = 10;
            this.btn_Music_PlayerPanel_Next.TabStop = false;
            this.btn_Music_PlayerPanel_Next.Zoom = 10;
            // 
            // btn_Music_PlayerPanel_Mix
            // 
            this.btn_Music_PlayerPanel_Mix.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Music_PlayerPanel_Mix.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(36)))));
            this.btn_Music_PlayerPanel_Mix.Image = ((System.Drawing.Image)(resources.GetObject("btn_Music_PlayerPanel_Mix.Image")));
            this.btn_Music_PlayerPanel_Mix.ImageActive = null;
            this.btn_Music_PlayerPanel_Mix.Location = new System.Drawing.Point(345, 24);
            this.btn_Music_PlayerPanel_Mix.Name = "btn_Music_PlayerPanel_Mix";
            this.btn_Music_PlayerPanel_Mix.Size = new System.Drawing.Size(25, 32);
            this.btn_Music_PlayerPanel_Mix.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Music_PlayerPanel_Mix.TabIndex = 9;
            this.btn_Music_PlayerPanel_Mix.TabStop = false;
            this.btn_Music_PlayerPanel_Mix.Zoom = 10;
            // 
            // btn_Music_PlayerPanel_Play
            // 
            this.btn_Music_PlayerPanel_Play.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Music_PlayerPanel_Play.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(36)))));
            this.btn_Music_PlayerPanel_Play.Image = ((System.Drawing.Image)(resources.GetObject("btn_Music_PlayerPanel_Play.Image")));
            this.btn_Music_PlayerPanel_Play.ImageActive = null;
            this.btn_Music_PlayerPanel_Play.Location = new System.Drawing.Point(273, 27);
            this.btn_Music_PlayerPanel_Play.Name = "btn_Music_PlayerPanel_Play";
            this.btn_Music_PlayerPanel_Play.Size = new System.Drawing.Size(28, 26);
            this.btn_Music_PlayerPanel_Play.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Music_PlayerPanel_Play.TabIndex = 8;
            this.btn_Music_PlayerPanel_Play.TabStop = false;
            this.btn_Music_PlayerPanel_Play.Zoom = 10;
            this.btn_Music_PlayerPanel_Play.Click += new System.EventHandler(this.btn_Music_Play_Click);
            // 
            // btn_Music_PlayerPanel_More
            // 
            this.btn_Music_PlayerPanel_More.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Music_PlayerPanel_More.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(36)))));
            this.btn_Music_PlayerPanel_More.Image = ((System.Drawing.Image)(resources.GetObject("btn_Music_PlayerPanel_More.Image")));
            this.btn_Music_PlayerPanel_More.ImageActive = null;
            this.btn_Music_PlayerPanel_More.Location = new System.Drawing.Point(465, 23);
            this.btn_Music_PlayerPanel_More.Name = "btn_Music_PlayerPanel_More";
            this.btn_Music_PlayerPanel_More.Size = new System.Drawing.Size(22, 32);
            this.btn_Music_PlayerPanel_More.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Music_PlayerPanel_More.TabIndex = 7;
            this.btn_Music_PlayerPanel_More.TabStop = false;
            this.btn_Music_PlayerPanel_More.Zoom = 10;
            // 
            // btn_Music_PlayerPanel_Mute
            // 
            this.btn_Music_PlayerPanel_Mute.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Music_PlayerPanel_Mute.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(36)))));
            this.btn_Music_PlayerPanel_Mute.Image = ((System.Drawing.Image)(resources.GetObject("btn_Music_PlayerPanel_Mute.Image")));
            this.btn_Music_PlayerPanel_Mute.ImageActive = null;
            this.btn_Music_PlayerPanel_Mute.Location = new System.Drawing.Point(425, 24);
            this.btn_Music_PlayerPanel_Mute.Name = "btn_Music_PlayerPanel_Mute";
            this.btn_Music_PlayerPanel_Mute.Size = new System.Drawing.Size(22, 32);
            this.btn_Music_PlayerPanel_Mute.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Music_PlayerPanel_Mute.TabIndex = 6;
            this.btn_Music_PlayerPanel_Mute.TabStop = false;
            this.btn_Music_PlayerPanel_Mute.Zoom = 10;
            // 
            // RestTime
            // 
            this.RestTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RestTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(36)))));
            this.RestTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RestTime.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RestTime.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.RestTime.Location = new System.Drawing.Point(589, 70);
            this.RestTime.Name = "RestTime";
            this.RestTime.Size = new System.Drawing.Size(29, 18);
            this.RestTime.TabIndex = 5;
            this.RestTime.Text = "4:15";
            // 
            // BeginTime
            // 
            this.BeginTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BeginTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(36)))));
            this.BeginTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BeginTime.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BeginTime.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.BeginTime.Location = new System.Drawing.Point(75, 70);
            this.BeginTime.Name = "BeginTime";
            this.BeginTime.Size = new System.Drawing.Size(29, 18);
            this.BeginTime.TabIndex = 4;
            this.BeginTime.Text = "1:42";
            // 
            // play
            // 
            this.play.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.play.BackColor = System.Drawing.Color.Transparent;
            this.play.BackgroudColor = System.Drawing.Color.DarkGray;
            this.play.BorderRadius = 50;
            this.play.IndicatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(42)))), ((int)(((byte)(254)))));
            this.play.Location = new System.Drawing.Point(110, 68);
            this.play.MaximumValue = 100;
            this.play.Name = "play";
            this.play.Size = new System.Drawing.Size(472, 30);
            this.play.TabIndex = 1;
            this.play.Value = 35;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(7, 8);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(65, 62);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // pn_Childform
            // 
            this.pn_Childform.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(45)))));
            this.pn_Childform.Controls.Add(this.pictureBox2);
            this.pn_Childform.Cursor = System.Windows.Forms.Cursors.SizeNESW;
            this.pn_Childform.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_Childform.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pn_Childform.Location = new System.Drawing.Point(189, 40);
            this.pn_Childform.Name = "pn_Childform";
            this.pn_Childform.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pn_Childform.Size = new System.Drawing.Size(643, 371);
            this.pn_Childform.TabIndex = 11;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(142, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(400, 400);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // panel_Music_Playlist
            // 
            this.panel_Music_Playlist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(36)))));
            this.panel_Music_Playlist.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Music_Playlist.Location = new System.Drawing.Point(0, 323);
            this.panel_Music_Playlist.Name = "panel_Music_Playlist";
            this.panel_Music_Playlist.Size = new System.Drawing.Size(172, 86);
            this.panel_Music_Playlist.TabIndex = 10;
            // 
            // Logo
            // 
            this.Logo.Controls.Add(this.title);
            this.Logo.Controls.Add(this.pictureBox1);
            this.Logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.Logo.Location = new System.Drawing.Point(0, 0);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(172, 84);
            this.Logo.TabIndex = 1;
            // 
            // title
            // 
            this.title.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.title.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.title.Enabled = false;
            this.title.Font = new System.Drawing.Font("Sifonn", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.title.HideSelection = false;
            this.title.Location = new System.Drawing.Point(78, 33);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(76, 28);
            this.title.TabIndex = 0;
            this.title.Text = "MuViP";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_Video);
            this.panel3.Controls.Add(this.btn_Music);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 84);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(172, 37);
            this.panel3.TabIndex = 6;
            // 
            // btn_Video
            // 
            this.btn_Video.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_Video.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(45)))));
            this.btn_Video.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Video.BorderRadius = 0;
            this.btn_Video.ButtonText = "Video";
            this.btn_Video.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Video.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Video.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Video.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Video.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_Video.Iconimage")));
            this.btn_Video.Iconimage_right = null;
            this.btn_Video.Iconimage_right_Selected = null;
            this.btn_Video.Iconimage_Selected = null;
            this.btn_Video.IconMarginLeft = 0;
            this.btn_Video.IconMarginRight = 0;
            this.btn_Video.IconRightVisible = true;
            this.btn_Video.IconRightZoom = 0D;
            this.btn_Video.IconVisible = true;
            this.btn_Video.IconZoom = 70D;
            this.btn_Video.IsTab = true;
            this.btn_Video.Location = new System.Drawing.Point(88, 0);
            this.btn_Video.Name = "btn_Video";
            this.btn_Video.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(45)))));
            this.btn_Video.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_Video.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Video.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.btn_Video.selected = false;
            this.btn_Video.Size = new System.Drawing.Size(84, 37);
            this.btn_Video.TabIndex = 9;
            this.btn_Video.Text = "Video";
            this.btn_Video.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Video.Textcolor = System.Drawing.Color.White;
            this.btn_Video.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Video.Click += new System.EventHandler(this.btn_Video_Click_1);
            // 
            // btn_Music
            // 
            this.btn_Music.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_Music.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(45)))));
            this.btn_Music.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Music.BorderRadius = 0;
            this.btn_Music.ButtonText = "Music";
            this.btn_Music.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Music.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Music.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_Music.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Music.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_Music.Iconimage")));
            this.btn_Music.Iconimage_right = null;
            this.btn_Music.Iconimage_right_Selected = null;
            this.btn_Music.Iconimage_Selected = null;
            this.btn_Music.IconMarginLeft = 0;
            this.btn_Music.IconMarginRight = 0;
            this.btn_Music.IconRightVisible = true;
            this.btn_Music.IconRightZoom = 0D;
            this.btn_Music.IconVisible = true;
            this.btn_Music.IconZoom = 70D;
            this.btn_Music.IsTab = true;
            this.btn_Music.Location = new System.Drawing.Point(0, 0);
            this.btn_Music.Name = "btn_Music";
            this.btn_Music.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(45)))));
            this.btn_Music.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_Music.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Music.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.btn_Music.selected = false;
            this.btn_Music.Size = new System.Drawing.Size(88, 37);
            this.btn_Music.TabIndex = 1;
            this.btn_Music.Text = "Music";
            this.btn_Music.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Music.Textcolor = System.Drawing.Color.White;
            this.btn_Music.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Music.Click += new System.EventHandler(this.btn_Music_Click);
            // 
            // btn_My_Music
            // 
            this.btn_My_Music.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_My_Music.BackColor = System.Drawing.Color.Black;
            this.btn_My_Music.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_My_Music.BorderRadius = 0;
            this.btn_My_Music.ButtonText = "My Music";
            this.btn_My_Music.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_My_Music.DisabledColor = System.Drawing.Color.Gray;
            this.btn_My_Music.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_My_Music.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_My_Music.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_My_Music.Iconimage")));
            this.btn_My_Music.Iconimage_right = null;
            this.btn_My_Music.Iconimage_right_Selected = null;
            this.btn_My_Music.Iconimage_Selected = null;
            this.btn_My_Music.IconMarginLeft = 30;
            this.btn_My_Music.IconMarginRight = 0;
            this.btn_My_Music.IconRightVisible = true;
            this.btn_My_Music.IconRightZoom = 0D;
            this.btn_My_Music.IconVisible = true;
            this.btn_My_Music.IconZoom = 70D;
            this.btn_My_Music.IsTab = true;
            this.btn_My_Music.Location = new System.Drawing.Point(0, 121);
            this.btn_My_Music.Name = "btn_My_Music";
            this.btn_My_Music.Normalcolor = System.Drawing.Color.Black;
            this.btn_My_Music.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_My_Music.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_My_Music.selected = false;
            this.btn_My_Music.Size = new System.Drawing.Size(172, 41);
            this.btn_My_Music.TabIndex = 10;
            this.btn_My_Music.Text = "My Music";
            this.btn_My_Music.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_My_Music.Textcolor = System.Drawing.Color.Transparent;
            this.btn_My_Music.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btn_Add
            // 
            this.btn_Add.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_Add.BackColor = System.Drawing.Color.Black;
            this.btn_Add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Add.BorderRadius = 0;
            this.btn_Add.ButtonText = "Add";
            this.btn_Add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Add.DisabledColor = System.Drawing.Color.Black;
            this.btn_Add.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Add.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_Add.Iconimage")));
            this.btn_Add.Iconimage_right = null;
            this.btn_Add.Iconimage_right_Selected = null;
            this.btn_Add.Iconimage_Selected = null;
            this.btn_Add.IconMarginLeft = 30;
            this.btn_Add.IconMarginRight = 0;
            this.btn_Add.IconRightVisible = true;
            this.btn_Add.IconRightZoom = 1D;
            this.btn_Add.IconVisible = true;
            this.btn_Add.IconZoom = 70D;
            this.btn_Add.IsTab = true;
            this.btn_Add.Location = new System.Drawing.Point(0, 202);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Normalcolor = System.Drawing.Color.Black;
            this.btn_Add.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_Add.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Add.selected = false;
            this.btn_Add.Size = new System.Drawing.Size(172, 40);
            this.btn_Add.TabIndex = 3;
            this.btn_Add.Text = "Add";
            this.btn_Add.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Add.Textcolor = System.Drawing.Color.White;
            this.btn_Add.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click_1);
            // 
            // btn_Liked
            // 
            this.btn_Liked.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_Liked.BackColor = System.Drawing.Color.Black;
            this.btn_Liked.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Liked.BorderRadius = 0;
            this.btn_Liked.ButtonText = "Liked";
            this.btn_Liked.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Liked.DisabledColor = System.Drawing.Color.Black;
            this.btn_Liked.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Liked.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Liked.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Liked.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Liked.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_Liked.Iconimage")));
            this.btn_Liked.Iconimage_right = null;
            this.btn_Liked.Iconimage_right_Selected = null;
            this.btn_Liked.Iconimage_Selected = null;
            this.btn_Liked.IconMarginLeft = 30;
            this.btn_Liked.IconMarginRight = 0;
            this.btn_Liked.IconRightVisible = true;
            this.btn_Liked.IconRightZoom = 0D;
            this.btn_Liked.IconVisible = true;
            this.btn_Liked.IconZoom = 70D;
            this.btn_Liked.IsTab = true;
            this.btn_Liked.Location = new System.Drawing.Point(0, 242);
            this.btn_Liked.Name = "btn_Liked";
            this.btn_Liked.Normalcolor = System.Drawing.Color.Black;
            this.btn_Liked.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_Liked.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Liked.selected = false;
            this.btn_Liked.Size = new System.Drawing.Size(172, 40);
            this.btn_Liked.TabIndex = 4;
            this.btn_Liked.Text = "Liked";
            this.btn_Liked.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Liked.Textcolor = System.Drawing.Color.White;
            this.btn_Liked.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btn_Playlist
            // 
            this.btn_Playlist.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_Playlist.BackColor = System.Drawing.SystemColors.WindowText;
            this.btn_Playlist.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Playlist.BorderRadius = 0;
            this.btn_Playlist.ButtonText = "Playlist";
            this.btn_Playlist.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Playlist.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Playlist.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_Playlist.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Playlist.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_Playlist.Iconimage")));
            this.btn_Playlist.Iconimage_right = null;
            this.btn_Playlist.Iconimage_right_Selected = null;
            this.btn_Playlist.Iconimage_Selected = null;
            this.btn_Playlist.IconMarginLeft = 30;
            this.btn_Playlist.IconMarginRight = 0;
            this.btn_Playlist.IconRightVisible = true;
            this.btn_Playlist.IconRightZoom = 0D;
            this.btn_Playlist.IconVisible = true;
            this.btn_Playlist.IconZoom = 70D;
            this.btn_Playlist.IsTab = true;
            this.btn_Playlist.Location = new System.Drawing.Point(0, 0);
            this.btn_Playlist.Name = "btn_Playlist";
            this.btn_Playlist.Normalcolor = System.Drawing.SystemColors.WindowText;
            this.btn_Playlist.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_Playlist.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Playlist.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btn_Playlist.selected = false;
            this.btn_Playlist.Size = new System.Drawing.Size(154, 41);
            this.btn_Playlist.TabIndex = 5;
            this.btn_Playlist.Text = "Playlist";
            this.btn_Playlist.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Playlist.Textcolor = System.Drawing.Color.White;
            this.btn_Playlist.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Playlist.Click += new System.EventHandler(this.btn_Playlist_Click_1);
            // 
            // btn_NowPlaying
            // 
            this.btn_NowPlaying.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_NowPlaying.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_NowPlaying.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_NowPlaying.BorderRadius = 0;
            this.btn_NowPlaying.ButtonText = "Now Playing";
            this.btn_NowPlaying.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_NowPlaying.DisabledColor = System.Drawing.Color.Gray;
            this.btn_NowPlaying.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_NowPlaying.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_NowPlaying.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_NowPlaying.Iconimage")));
            this.btn_NowPlaying.Iconimage_right = null;
            this.btn_NowPlaying.Iconimage_right_Selected = null;
            this.btn_NowPlaying.Iconimage_Selected = null;
            this.btn_NowPlaying.IconMarginLeft = 30;
            this.btn_NowPlaying.IconMarginRight = 0;
            this.btn_NowPlaying.IconRightVisible = true;
            this.btn_NowPlaying.IconRightZoom = 0D;
            this.btn_NowPlaying.IconVisible = true;
            this.btn_NowPlaying.IconZoom = 70D;
            this.btn_NowPlaying.IsTab = true;
            this.btn_NowPlaying.Location = new System.Drawing.Point(0, 409);
            this.btn_NowPlaying.Name = "btn_NowPlaying";
            this.btn_NowPlaying.Normalcolor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_NowPlaying.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_NowPlaying.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_NowPlaying.selected = false;
            this.btn_NowPlaying.Size = new System.Drawing.Size(172, 37);
            this.btn_NowPlaying.TabIndex = 4;
            this.btn_NowPlaying.Text = "Now Playing";
            this.btn_NowPlaying.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_NowPlaying.Textcolor = System.Drawing.Color.White;
            this.btn_NowPlaying.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NowPlaying.Click += new System.EventHandler(this.btn_NowPlaying_Click);
            // 
            // btn_History
            // 
            this.btn_History.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_History.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_History.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_History.BorderRadius = 0;
            this.btn_History.ButtonText = "History";
            this.btn_History.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_History.DisabledColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_History.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_History.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_History.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_History.Iconimage")));
            this.btn_History.Iconimage_right = null;
            this.btn_History.Iconimage_right_Selected = null;
            this.btn_History.Iconimage_Selected = null;
            this.btn_History.IconMarginLeft = 30;
            this.btn_History.IconMarginRight = 0;
            this.btn_History.IconRightVisible = true;
            this.btn_History.IconRightZoom = 0D;
            this.btn_History.IconVisible = true;
            this.btn_History.IconZoom = 70D;
            this.btn_History.IsTab = true;
            this.btn_History.Location = new System.Drawing.Point(0, 446);
            this.btn_History.Name = "btn_History";
            this.btn_History.Normalcolor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_History.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_History.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_History.selected = false;
            this.btn_History.Size = new System.Drawing.Size(172, 40);
            this.btn_History.TabIndex = 5;
            this.btn_History.Text = "History";
            this.btn_History.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_History.Textcolor = System.Drawing.Color.White;
            this.btn_History.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // Help
            // 
            this.Help.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.Help.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Help.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Help.BorderRadius = 0;
            this.Help.ButtonText = "Help";
            this.Help.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Help.DisabledColor = System.Drawing.Color.Gray;
            this.Help.Dock = System.Windows.Forms.DockStyle.Top;
            this.Help.Iconcolor = System.Drawing.Color.Transparent;
            this.Help.Iconimage = ((System.Drawing.Image)(resources.GetObject("Help.Iconimage")));
            this.Help.Iconimage_right = null;
            this.Help.Iconimage_right_Selected = null;
            this.Help.Iconimage_Selected = null;
            this.Help.IconMarginLeft = 30;
            this.Help.IconMarginRight = 0;
            this.Help.IconRightVisible = true;
            this.Help.IconRightZoom = 0D;
            this.Help.IconVisible = true;
            this.Help.IconZoom = 60D;
            this.Help.IsTab = true;
            this.Help.Location = new System.Drawing.Point(0, 486);
            this.Help.Name = "Help";
            this.Help.Normalcolor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Help.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.Help.OnHoverTextColor = System.Drawing.Color.White;
            this.Help.selected = false;
            this.Help.Size = new System.Drawing.Size(172, 43);
            this.Help.TabIndex = 9;
            this.Help.Text = "Help";
            this.Help.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Help.Textcolor = System.Drawing.Color.White;
            this.Help.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // Exit
            // 
            this.Exit.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.Exit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Exit.BorderRadius = 0;
            this.Exit.ButtonText = "Exit";
            this.Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit.DisabledColor = System.Drawing.Color.Gray;
            this.Exit.Dock = System.Windows.Forms.DockStyle.Top;
            this.Exit.Iconcolor = System.Drawing.Color.Transparent;
            this.Exit.Iconimage = ((System.Drawing.Image)(resources.GetObject("Exit.Iconimage")));
            this.Exit.Iconimage_right = null;
            this.Exit.Iconimage_right_Selected = null;
            this.Exit.Iconimage_Selected = null;
            this.Exit.IconMarginLeft = 33;
            this.Exit.IconMarginRight = 0;
            this.Exit.IconRightVisible = true;
            this.Exit.IconRightZoom = 0D;
            this.Exit.IconVisible = true;
            this.Exit.IconZoom = 60D;
            this.Exit.IsTab = true;
            this.Exit.Location = new System.Drawing.Point(0, 529);
            this.Exit.Name = "Exit";
            this.Exit.Normalcolor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Exit.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.Exit.OnHoverTextColor = System.Drawing.Color.White;
            this.Exit.selected = false;
            this.Exit.Size = new System.Drawing.Size(172, 37);
            this.Exit.TabIndex = 8;
            this.Exit.Text = "Exit";
            this.Exit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Exit.Textcolor = System.Drawing.Color.White;
            this.Exit.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.Click += new System.EventHandler(this.Exit_Click_1);
            // 
            // Menuside
            // 
            this.Menuside.AutoScroll = true;
            this.Menuside.AutoScrollMargin = new System.Drawing.Size(1, 1);
            this.Menuside.AutoScrollMinSize = new System.Drawing.Size(1, 1);
            this.Menuside.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Menuside.Controls.Add(this.Exit);
            this.Menuside.Controls.Add(this.Help);
            this.Menuside.Controls.Add(this.btn_History);
            this.Menuside.Controls.Add(this.btn_NowPlaying);
            this.Menuside.Controls.Add(this.panel_Music_Playlist);
            this.Menuside.Controls.Add(this.panel2);
            this.Menuside.Controls.Add(this.btn_Liked);
            this.Menuside.Controls.Add(this.btn_Add);
            this.Menuside.Controls.Add(this.btn_My_Video);
            this.Menuside.Controls.Add(this.btn_My_Music);
            this.Menuside.Controls.Add(this.panel3);
            this.Menuside.Controls.Add(this.Logo);
            this.Menuside.Dock = System.Windows.Forms.DockStyle.Left;
            this.Menuside.Location = new System.Drawing.Point(0, 0);
            this.Menuside.Name = "Menuside";
            this.Menuside.Size = new System.Drawing.Size(189, 511);
            this.Menuside.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_AddPl);
            this.panel2.Controls.Add(this.btn_Playlist);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 282);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(172, 41);
            this.panel2.TabIndex = 11;
            // 
            // btn_AddPl
            // 
            this.btn_AddPl.Activecolor = System.Drawing.Color.Transparent;
            this.btn_AddPl.BackColor = System.Drawing.Color.Transparent;
            this.btn_AddPl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_AddPl.BorderRadius = 0;
            this.btn_AddPl.ButtonText = "";
            this.btn_AddPl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_AddPl.DisabledColor = System.Drawing.Color.Gray;
            this.btn_AddPl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_AddPl.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_AddPl.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_AddPl.Iconimage")));
            this.btn_AddPl.Iconimage_right = null;
            this.btn_AddPl.Iconimage_right_Selected = null;
            this.btn_AddPl.Iconimage_Selected = null;
            this.btn_AddPl.IconMarginLeft = 0;
            this.btn_AddPl.IconMarginRight = 15;
            this.btn_AddPl.IconRightVisible = true;
            this.btn_AddPl.IconRightZoom = 0D;
            this.btn_AddPl.IconVisible = true;
            this.btn_AddPl.IconZoom = 70D;
            this.btn_AddPl.IsTab = false;
            this.btn_AddPl.Location = new System.Drawing.Point(154, 0);
            this.btn_AddPl.Name = "btn_AddPl";
            this.btn_AddPl.Normalcolor = System.Drawing.Color.Transparent;
            this.btn_AddPl.OnHovercolor = System.Drawing.Color.Silver;
            this.btn_AddPl.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_AddPl.selected = false;
            this.btn_AddPl.Size = new System.Drawing.Size(18, 41);
            this.btn_AddPl.TabIndex = 11;
            this.btn_AddPl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_AddPl.Textcolor = System.Drawing.Color.White;
            this.btn_AddPl.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddPl.Click += new System.EventHandler(this.btn_AddPl_Click);
            // 
            // btn_My_Video
            // 
            this.btn_My_Video.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_My_Video.BackColor = System.Drawing.Color.Transparent;
            this.btn_My_Video.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_My_Video.BorderRadius = 0;
            this.btn_My_Video.ButtonText = "My Video";
            this.btn_My_Video.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_My_Video.DisabledColor = System.Drawing.Color.Gray;
            this.btn_My_Video.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_My_Video.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_My_Video.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_My_Video.Iconimage")));
            this.btn_My_Video.Iconimage_right = null;
            this.btn_My_Video.Iconimage_right_Selected = null;
            this.btn_My_Video.Iconimage_Selected = null;
            this.btn_My_Video.IconMarginLeft = 30;
            this.btn_My_Video.IconMarginRight = 0;
            this.btn_My_Video.IconRightVisible = true;
            this.btn_My_Video.IconRightZoom = 0D;
            this.btn_My_Video.IconVisible = true;
            this.btn_My_Video.IconZoom = 70D;
            this.btn_My_Video.IsTab = false;
            this.btn_My_Video.Location = new System.Drawing.Point(0, 162);
            this.btn_My_Video.Name = "btn_My_Video";
            this.btn_My_Video.Normalcolor = System.Drawing.Color.Transparent;
            this.btn_My_Video.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_My_Video.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_My_Video.selected = false;
            this.btn_My_Video.Size = new System.Drawing.Size(172, 40);
            this.btn_My_Video.TabIndex = 12;
            this.btn_My_Video.Text = "My Video";
            this.btn_My_Video.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_My_Video.Textcolor = System.Drawing.Color.White;
            this.btn_My_Video.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_My_Video.Visible = false;
            // 
            // Form_Muvip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(832, 511);
            this.Controls.Add(this.pn_Childform);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_Player);
            this.Controls.Add(this.Menuside);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MinimumSize = new System.Drawing.Size(750, 500);
            this.Name = "Form_Muvip";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "MuViP App";
            this.TransparencyKey = System.Drawing.Color.Black;
            this.panel1.ResumeLayout(false);
            this.panel_Player.ResumeLayout(false);
            this.panel_Player.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Music_PlayerPanel_Replay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Music_PlayerPanel_Pause)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Music_PlayerPanel_Before)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Music_PlayerPanel_Next)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Music_PlayerPanel_Mix)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Music_PlayerPanel_Play)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Music_PlayerPanel_More)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Music_PlayerPanel_Mute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.pn_Childform.ResumeLayout(false);
            this.pn_Childform.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.Logo.ResumeLayout(false);
            this.Logo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.Menuside.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuThinButton2 Login;
        private Bunifu.Framework.UI.BunifuTextbox Search;
        private System.Windows.Forms.Panel panel_Player;
        private Bunifu.Framework.UI.BunifuImageButton btn_Music_PlayerPanel_Replay;
        private Bunifu.Framework.UI.BunifuImageButton btn_Music_PlayerPanel_Pause;
        private Bunifu.Framework.UI.BunifuImageButton btn_Music_PlayerPanel_Before;
        private Bunifu.Framework.UI.BunifuImageButton btn_Music_PlayerPanel_Next;
        private Bunifu.Framework.UI.BunifuImageButton btn_Music_PlayerPanel_Mix;
        private Bunifu.Framework.UI.BunifuImageButton btn_Music_PlayerPanel_Play;
        private Bunifu.Framework.UI.BunifuImageButton btn_Music_PlayerPanel_More;
        private Bunifu.Framework.UI.BunifuImageButton btn_Music_PlayerPanel_Mute;
        private System.Windows.Forms.TextBox RestTime;
        private System.Windows.Forms.TextBox BeginTime;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel pn_Childform;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel Logo;
        private System.Windows.Forms.TextBox title;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Video;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Music;
        private Bunifu.Framework.UI.BunifuFlatButton btn_My_Music;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Add;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Liked;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Playlist;
        private Bunifu.Framework.UI.BunifuFlatButton btn_NowPlaying;
        private Bunifu.Framework.UI.BunifuFlatButton btn_History;
        private Bunifu.Framework.UI.BunifuFlatButton Help;
        private Bunifu.Framework.UI.BunifuFlatButton Exit;
        private System.Windows.Forms.Panel Menuside;
        private System.Windows.Forms.Panel panel_Music_Playlist;
        private Bunifu.Framework.UI.BunifuSlider play;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuFlatButton btn_AddPl;
        private Bunifu.Framework.UI.BunifuFlatButton btn_My_Video;
        private System.Windows.Forms.Label lb_Music_PanelPlayer_NameArtist;
        private System.Windows.Forms.Label lb_Music_PanelPlayer_NameSong;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

