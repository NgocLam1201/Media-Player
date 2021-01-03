namespace MuViPApp
{
    partial class form_Video_Nowpl
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
            System.Windows.Forms.ColumnHeader fpath;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_Video_Nowpl));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.lb_NameVid = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lb_Length = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Loop = new Bunifu.Framework.UI.BunifuImageButton();
            this.Is_Loop = new Bunifu.Framework.UI.BunifuImageButton();
            this.lb_Endtime = new System.Windows.Forms.TextBox();
            this.lb_currentTime = new System.Windows.Forms.TextBox();
            this.Video_Slider = new Bunifu.Framework.UI.BunifuSlider();
            this.max_Volume = new Bunifu.Framework.UI.BunifuImageButton();
            this.medium_Volume = new Bunifu.Framework.UI.BunifuImageButton();
            this.Volume_Slider = new Bunifu.Framework.UI.BunifuSlider();
            this.Mute = new Bunifu.Framework.UI.BunifuImageButton();
            this.Is_Mix = new Bunifu.Framework.UI.BunifuImageButton();
            this.Mix_Media = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_Play = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_Pause = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_pre = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_Next = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.listView_VideoPlaying = new System.Windows.Forms.ListView();
            this.vid_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.length = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.timer_Video = new System.Windows.Forms.Timer(this.components);
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            fpath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MediaPlayer)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Loop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Is_Loop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.max_Volume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medium_Volume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Is_Mix)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mix_Media)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Play)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Pause)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_pre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Next)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // fpath
            // 
            fpath.DisplayIndex = 1;
            fpath.Text = "";
            fpath.Width = 0;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // lb_NameVid
            // 
            this.lb_NameVid.AutoSize = true;
            this.lb_NameVid.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_NameVid.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lb_NameVid.Location = new System.Drawing.Point(131, 9);
            this.lb_NameVid.Name = "lb_NameVid";
            this.lb_NameVid.Size = new System.Drawing.Size(0, 18);
            this.lb_NameVid.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(42)))), ((int)(((byte)(56)))));
            this.panel2.Controls.Add(this.bunifuImageButton1);
            this.panel2.Controls.Add(this.lb_Length);
            this.panel2.Controls.Add(this.lb_NameVid);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 52);
            this.panel2.TabIndex = 30;
            // 
            // lb_Length
            // 
            this.lb_Length.AutoSize = true;
            this.lb_Length.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_Length.Location = new System.Drawing.Point(131, 27);
            this.lb_Length.Name = "lb_Length";
            this.lb_Length.Size = new System.Drawing.Size(0, 13);
            this.lb_Length.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 52);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 398);
            this.panel3.TabIndex = 31;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.MediaPlayer);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 398);
            this.panel1.TabIndex = 0;
            // 
            // MediaPlayer
            // 
            this.MediaPlayer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MediaPlayer.Enabled = true;
            this.MediaPlayer.Location = new System.Drawing.Point(0, 0);
            this.MediaPlayer.Name = "MediaPlayer";
            this.MediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("MediaPlayer.OcxState")));
            this.MediaPlayer.Size = new System.Drawing.Size(605, 334);
            this.MediaPlayer.TabIndex = 7;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Gray;
            this.panel4.Controls.Add(this.Loop);
            this.panel4.Controls.Add(this.Is_Loop);
            this.panel4.Controls.Add(this.lb_Endtime);
            this.panel4.Controls.Add(this.lb_currentTime);
            this.panel4.Controls.Add(this.Video_Slider);
            this.panel4.Controls.Add(this.max_Volume);
            this.panel4.Controls.Add(this.medium_Volume);
            this.panel4.Controls.Add(this.Volume_Slider);
            this.panel4.Controls.Add(this.Mute);
            this.panel4.Controls.Add(this.Is_Mix);
            this.panel4.Controls.Add(this.Mix_Media);
            this.panel4.Controls.Add(this.btn_Play);
            this.panel4.Controls.Add(this.btn_Pause);
            this.panel4.Controls.Add(this.btn_pre);
            this.panel4.Controls.Add(this.btn_Next);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 334);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(605, 64);
            this.panel4.TabIndex = 8;
            // 
            // Loop
            // 
            this.Loop.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Loop.BackColor = System.Drawing.Color.Transparent;
            this.Loop.Image = ((System.Drawing.Image)(resources.GetObject("Loop.Image")));
            this.Loop.ImageActive = null;
            this.Loop.Location = new System.Drawing.Point(313, 34);
            this.Loop.Name = "Loop";
            this.Loop.Size = new System.Drawing.Size(34, 26);
            this.Loop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Loop.TabIndex = 35;
            this.Loop.TabStop = false;
            this.Loop.Zoom = 10;
            this.Loop.Click += new System.EventHandler(this.Loop_Click);
            // 
            // Is_Loop
            // 
            this.Is_Loop.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Is_Loop.BackColor = System.Drawing.Color.Transparent;
            this.Is_Loop.Image = ((System.Drawing.Image)(resources.GetObject("Is_Loop.Image")));
            this.Is_Loop.ImageActive = null;
            this.Is_Loop.Location = new System.Drawing.Point(313, 33);
            this.Is_Loop.Name = "Is_Loop";
            this.Is_Loop.Size = new System.Drawing.Size(37, 25);
            this.Is_Loop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Is_Loop.TabIndex = 36;
            this.Is_Loop.TabStop = false;
            this.Is_Loop.Zoom = 10;
            this.Is_Loop.Click += new System.EventHandler(this.Is_Loop_Click);
            // 
            // lb_Endtime
            // 
            this.lb_Endtime.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lb_Endtime.BackColor = System.Drawing.Color.Gray;
            this.lb_Endtime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lb_Endtime.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lb_Endtime.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Endtime.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.lb_Endtime.Location = new System.Drawing.Point(556, 17);
            this.lb_Endtime.Name = "lb_Endtime";
            this.lb_Endtime.ReadOnly = true;
            this.lb_Endtime.Size = new System.Drawing.Size(49, 18);
            this.lb_Endtime.TabIndex = 43;
            this.lb_Endtime.Text = "00:00:00";
            // 
            // lb_currentTime
            // 
            this.lb_currentTime.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lb_currentTime.BackColor = System.Drawing.Color.Gray;
            this.lb_currentTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lb_currentTime.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lb_currentTime.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_currentTime.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.lb_currentTime.Location = new System.Drawing.Point(3, 17);
            this.lb_currentTime.Name = "lb_currentTime";
            this.lb_currentTime.ReadOnly = true;
            this.lb_currentTime.Size = new System.Drawing.Size(51, 18);
            this.lb_currentTime.TabIndex = 42;
            this.lb_currentTime.Text = "00:00:00";
            this.lb_currentTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Video_Slider
            // 
            this.Video_Slider.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Video_Slider.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Video_Slider.BackColor = System.Drawing.Color.Transparent;
            this.Video_Slider.BackgroudColor = System.Drawing.Color.DarkGray;
            this.Video_Slider.BorderRadius = 30;
            this.Video_Slider.IndicatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(42)))), ((int)(((byte)(254)))));
            this.Video_Slider.Location = new System.Drawing.Point(2, -7);
            this.Video_Slider.MaximumValue = 100;
            this.Video_Slider.Name = "Video_Slider";
            this.Video_Slider.Size = new System.Drawing.Size(602, 30);
            this.Video_Slider.TabIndex = 41;
            this.Video_Slider.Value = 0;
            this.Video_Slider.ValueChanged += new System.EventHandler(this.Video_Slider_ValueChanged);
            // 
            // max_Volume
            // 
            this.max_Volume.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.max_Volume.BackColor = System.Drawing.Color.Transparent;
            this.max_Volume.Image = ((System.Drawing.Image)(resources.GetObject("max_Volume.Image")));
            this.max_Volume.ImageActive = null;
            this.max_Volume.Location = new System.Drawing.Point(355, 29);
            this.max_Volume.Name = "max_Volume";
            this.max_Volume.Size = new System.Drawing.Size(28, 30);
            this.max_Volume.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.max_Volume.TabIndex = 39;
            this.max_Volume.TabStop = false;
            this.max_Volume.Zoom = 10;
            this.max_Volume.Click += new System.EventHandler(this.max_Volume_Click);
            // 
            // medium_Volume
            // 
            this.medium_Volume.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.medium_Volume.BackColor = System.Drawing.Color.Transparent;
            this.medium_Volume.Image = ((System.Drawing.Image)(resources.GetObject("medium_Volume.Image")));
            this.medium_Volume.ImageActive = null;
            this.medium_Volume.Location = new System.Drawing.Point(360, 28);
            this.medium_Volume.Name = "medium_Volume";
            this.medium_Volume.Size = new System.Drawing.Size(23, 32);
            this.medium_Volume.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.medium_Volume.TabIndex = 38;
            this.medium_Volume.TabStop = false;
            this.medium_Volume.Zoom = 10;
            this.medium_Volume.Click += new System.EventHandler(this.max_Volume_Click);
            // 
            // Volume_Slider
            // 
            this.Volume_Slider.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Volume_Slider.BackColor = System.Drawing.Color.Transparent;
            this.Volume_Slider.BackgroudColor = System.Drawing.Color.DarkGray;
            this.Volume_Slider.BorderRadius = 20;
            this.Volume_Slider.IndicatorColor = System.Drawing.Color.DarkOrchid;
            this.Volume_Slider.Location = new System.Drawing.Point(388, 33);
            this.Volume_Slider.MaximumValue = 100;
            this.Volume_Slider.Name = "Volume_Slider";
            this.Volume_Slider.Size = new System.Drawing.Size(93, 30);
            this.Volume_Slider.TabIndex = 40;
            this.Volume_Slider.Value = 0;
            this.Volume_Slider.ValueChanged += new System.EventHandler(this.Volume_Slider_ValueChanged);
            // 
            // Mute
            // 
            this.Mute.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Mute.BackColor = System.Drawing.Color.Transparent;
            this.Mute.Image = ((System.Drawing.Image)(resources.GetObject("Mute.Image")));
            this.Mute.ImageActive = null;
            this.Mute.Location = new System.Drawing.Point(360, 31);
            this.Mute.Name = "Mute";
            this.Mute.Size = new System.Drawing.Size(22, 27);
            this.Mute.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Mute.TabIndex = 37;
            this.Mute.TabStop = false;
            this.Mute.Zoom = 10;
            this.Mute.Click += new System.EventHandler(this.Mute_Click);
            // 
            // Is_Mix
            // 
            this.Is_Mix.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Is_Mix.BackColor = System.Drawing.Color.Transparent;
            this.Is_Mix.Image = ((System.Drawing.Image)(resources.GetObject("Is_Mix.Image")));
            this.Is_Mix.ImageActive = null;
            this.Is_Mix.Location = new System.Drawing.Point(278, 33);
            this.Is_Mix.Name = "Is_Mix";
            this.Is_Mix.Size = new System.Drawing.Size(29, 24);
            this.Is_Mix.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Is_Mix.TabIndex = 34;
            this.Is_Mix.TabStop = false;
            this.Is_Mix.Zoom = 10;
            this.Is_Mix.Click += new System.EventHandler(this.Is_Mix_Click);
            // 
            // Mix_Media
            // 
            this.Mix_Media.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Mix_Media.BackColor = System.Drawing.Color.Transparent;
            this.Mix_Media.Image = ((System.Drawing.Image)(resources.GetObject("Mix_Media.Image")));
            this.Mix_Media.ImageActive = null;
            this.Mix_Media.Location = new System.Drawing.Point(278, 34);
            this.Mix_Media.Name = "Mix_Media";
            this.Mix_Media.Size = new System.Drawing.Size(29, 24);
            this.Mix_Media.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Mix_Media.TabIndex = 33;
            this.Mix_Media.TabStop = false;
            this.Mix_Media.Zoom = 10;
            this.Mix_Media.Click += new System.EventHandler(this.Mix_Media_Click);
            // 
            // btn_Play
            // 
            this.btn_Play.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Play.BackColor = System.Drawing.Color.Transparent;
            this.btn_Play.Image = ((System.Drawing.Image)(resources.GetObject("btn_Play.Image")));
            this.btn_Play.ImageActive = null;
            this.btn_Play.Location = new System.Drawing.Point(211, 35);
            this.btn_Play.Name = "btn_Play";
            this.btn_Play.Size = new System.Drawing.Size(27, 23);
            this.btn_Play.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Play.TabIndex = 16;
            this.btn_Play.TabStop = false;
            this.btn_Play.Zoom = 10;
            this.btn_Play.Click += new System.EventHandler(this.btn_Play_Click);
            // 
            // btn_Pause
            // 
            this.btn_Pause.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Pause.BackColor = System.Drawing.Color.Transparent;
            this.btn_Pause.Image = ((System.Drawing.Image)(resources.GetObject("btn_Pause.Image")));
            this.btn_Pause.ImageActive = null;
            this.btn_Pause.Location = new System.Drawing.Point(209, 34);
            this.btn_Pause.Name = "btn_Pause";
            this.btn_Pause.Size = new System.Drawing.Size(33, 23);
            this.btn_Pause.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Pause.TabIndex = 30;
            this.btn_Pause.TabStop = false;
            this.btn_Pause.Visible = false;
            this.btn_Pause.Zoom = 10;
            this.btn_Pause.Click += new System.EventHandler(this.btn_Pause_Click);
            // 
            // btn_pre
            // 
            this.btn_pre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_pre.BackColor = System.Drawing.Color.Transparent;
            this.btn_pre.Image = ((System.Drawing.Image)(resources.GetObject("btn_pre.Image")));
            this.btn_pre.ImageActive = null;
            this.btn_pre.Location = new System.Drawing.Point(160, 34);
            this.btn_pre.Name = "btn_pre";
            this.btn_pre.Size = new System.Drawing.Size(53, 23);
            this.btn_pre.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_pre.TabIndex = 29;
            this.btn_pre.TabStop = false;
            this.btn_pre.Zoom = 10;
            this.btn_pre.Click += new System.EventHandler(this.btn_Before_Click);
            // 
            // btn_Next
            // 
            this.btn_Next.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Next.BackColor = System.Drawing.Color.Transparent;
            this.btn_Next.Image = ((System.Drawing.Image)(resources.GetObject("btn_Next.Image")));
            this.btn_Next.ImageActive = null;
            this.btn_Next.Location = new System.Drawing.Point(237, 34);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(49, 23);
            this.btn_Next.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Next.TabIndex = 28;
            this.btn_Next.TabStop = false;
            this.btn_Next.Zoom = 10;
            this.btn_Next.Click += new System.EventHandler(this.btn_Next_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(42)))), ((int)(((byte)(56)))));
            this.panel5.Controls.Add(this.listView_VideoPlaying);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(605, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(195, 398);
            this.panel5.TabIndex = 9;
            // 
            // listView_VideoPlaying
            // 
            this.listView_VideoPlaying.BackColor = System.Drawing.Color.Black;
            this.listView_VideoPlaying.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.vid_Name,
            this.length,
            fpath});
            this.listView_VideoPlaying.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView_VideoPlaying.ForeColor = System.Drawing.Color.White;
            this.listView_VideoPlaying.FullRowSelect = true;
            this.listView_VideoPlaying.HideSelection = false;
            this.listView_VideoPlaying.Location = new System.Drawing.Point(0, 0);
            this.listView_VideoPlaying.MultiSelect = false;
            this.listView_VideoPlaying.Name = "listView_VideoPlaying";
            this.listView_VideoPlaying.Size = new System.Drawing.Size(195, 398);
            this.listView_VideoPlaying.TabIndex = 0;
            this.listView_VideoPlaying.UseCompatibleStateImageBehavior = false;
            this.listView_VideoPlaying.View = System.Windows.Forms.View.Details;
            this.listView_VideoPlaying.SelectedIndexChanged += new System.EventHandler(this.listView_VideoPlaying_SelectedIndexChanged);
            // 
            // vid_Name
            // 
            this.vid_Name.Text = "Name";
            this.vid_Name.Width = 128;
            // 
            // length
            // 
            this.length.DisplayIndex = 2;
            this.length.Text = "Length";
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 5;
            this.bunifuElipse2.TargetControl = this;
            // 
            // timer_Video
            // 
            this.timer_Video.Tick += new System.EventHandler(this.timer_Video_Tick);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(73, 6);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(37, 34);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 12;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            // 
            // form_Video_Nowpl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "form_Video_Nowpl";
            this.Text = "form_Video_Nowpl";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MediaPlayer)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Loop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Is_Loop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.max_Volume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medium_Volume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Is_Mix)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mix_Media)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Play)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Pause)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_pre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Next)).EndInit();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private Bunifu.Framework.UI.BunifuImageButton btn_Play;
        private Bunifu.Framework.UI.BunifuImageButton btn_Pause;
        private Bunifu.Framework.UI.BunifuImageButton btn_pre;
        private Bunifu.Framework.UI.BunifuImageButton btn_Next;
        private System.Windows.Forms.Panel panel5;
        private AxWMPLib.AxWindowsMediaPlayer MediaPlayer;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lb_NameVid;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private System.Windows.Forms.ListView listView_VideoPlaying;
        private System.Windows.Forms.ColumnHeader vid_Name;
        private System.Windows.Forms.ColumnHeader length;
        private System.Windows.Forms.Label lb_Length;
        private Bunifu.Framework.UI.BunifuImageButton Is_Mix;
        private Bunifu.Framework.UI.BunifuImageButton Mix_Media;
        private Bunifu.Framework.UI.BunifuImageButton Is_Loop;
        private Bunifu.Framework.UI.BunifuImageButton Loop;
        public Bunifu.Framework.UI.BunifuImageButton max_Volume;
        public Bunifu.Framework.UI.BunifuImageButton medium_Volume;
        public Bunifu.Framework.UI.BunifuSlider Volume_Slider;
        public Bunifu.Framework.UI.BunifuImageButton Mute;
        public System.Windows.Forms.TextBox lb_Endtime;
        public System.Windows.Forms.TextBox lb_currentTime;
        public Bunifu.Framework.UI.BunifuSlider Video_Slider;
        private System.Windows.Forms.Timer timer_Video;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
    }
}