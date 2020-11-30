namespace MuViPApp
{
    partial class Form_Music_Nowpl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Music_Nowpl));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btn_Music_Nowpl_Play = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_NamePl = new System.Windows.Forms.Label();
            this.lb_Info_Music = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.max_Volume = new Bunifu.Framework.UI.BunifuImageButton();
            this.medium_Volume = new Bunifu.Framework.UI.BunifuImageButton();
            this.Volume_Slider = new Bunifu.Framework.UI.BunifuSlider();
            this.Mute = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_Music_Nowpl_Pause = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_Music_Nowpl_Before = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_Music_Nowpl_Replay = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_Music_Nowpl_Mix = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_Music_Nowpl_Next = new Bunifu.Framework.UI.BunifuImageButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.play = new Bunifu.Framework.UI.BunifuSlider();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lv_My_Music = new System.Windows.Forms.ListView();
            this.Name_Music = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Artist_Music = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Genre_Music = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Date_Added_Music = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Length_Music = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Link_Music = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Link_Picture = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView1 = new System.Windows.Forms.ListView();
            this.timer_play = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.btn_Music_Nowpl_Play)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.max_Volume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medium_Volume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Music_Nowpl_Pause)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Music_Nowpl_Before)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Music_Nowpl_Replay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Music_Nowpl_Mix)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Music_Nowpl_Next)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // btn_Music_Nowpl_Play
            // 
            this.btn_Music_Nowpl_Play.BackColor = System.Drawing.Color.Transparent;
            this.btn_Music_Nowpl_Play.Image = ((System.Drawing.Image)(resources.GetObject("btn_Music_Nowpl_Play.Image")));
            this.btn_Music_Nowpl_Play.ImageActive = null;
            this.btn_Music_Nowpl_Play.Location = new System.Drawing.Point(56, 95);
            this.btn_Music_Nowpl_Play.Name = "btn_Music_Nowpl_Play";
            this.btn_Music_Nowpl_Play.Size = new System.Drawing.Size(18, 17);
            this.btn_Music_Nowpl_Play.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Music_Nowpl_Play.TabIndex = 16;
            this.btn_Music_Nowpl_Play.TabStop = false;
            this.btn_Music_Nowpl_Play.Zoom = 10;
            this.btn_Music_Nowpl_Play.Click += new System.EventHandler(this.btn_Music_Nowpl_Play_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(322, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(8, 8);
            this.panel1.TabIndex = 22;
            // 
            // lb_NamePl
            // 
            this.lb_NamePl.AutoSize = true;
            this.lb_NamePl.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_NamePl.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lb_NamePl.Location = new System.Drawing.Point(84, 17);
            this.lb_NamePl.Name = "lb_NamePl";
            this.lb_NamePl.Size = new System.Drawing.Size(104, 18);
            this.lb_NamePl.TabIndex = 7;
            this.lb_NamePl.Text = "Song\'s Name";
            // 
            // lb_Info_Music
            // 
            this.lb_Info_Music.AutoSize = true;
            this.lb_Info_Music.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Info_Music.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_Info_Music.Location = new System.Drawing.Point(85, 45);
            this.lb_Info_Music.Name = "lb_Info_Music";
            this.lb_Info_Music.Size = new System.Drawing.Size(25, 13);
            this.lb_Info_Music.TabIndex = 8;
            this.lb_Info_Music.Text = "Info";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(42)))), ((int)(((byte)(56)))));
            this.panel2.Controls.Add(this.max_Volume);
            this.panel2.Controls.Add(this.medium_Volume);
            this.panel2.Controls.Add(this.Volume_Slider);
            this.panel2.Controls.Add(this.Mute);
            this.panel2.Controls.Add(this.lb_Info_Music);
            this.panel2.Controls.Add(this.btn_Music_Nowpl_Pause);
            this.panel2.Controls.Add(this.btn_Music_Nowpl_Before);
            this.panel2.Controls.Add(this.btn_Music_Nowpl_Replay);
            this.panel2.Controls.Add(this.lb_NamePl);
            this.panel2.Controls.Add(this.btn_Music_Nowpl_Mix);
            this.panel2.Controls.Add(this.btn_Music_Nowpl_Next);
            this.panel2.Controls.Add(this.btn_Music_Nowpl_Play);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.play);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(643, 120);
            this.panel2.TabIndex = 23;
            // 
            // max_Volume
            // 
            this.max_Volume.BackColor = System.Drawing.Color.Transparent;
            this.max_Volume.Image = ((System.Drawing.Image)(resources.GetObject("max_Volume.Image")));
            this.max_Volume.ImageActive = null;
            this.max_Volume.Location = new System.Drawing.Point(176, 92);
            this.max_Volume.Name = "max_Volume";
            this.max_Volume.Size = new System.Drawing.Size(25, 19);
            this.max_Volume.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.max_Volume.TabIndex = 25;
            this.max_Volume.TabStop = false;
            this.max_Volume.Zoom = 10;
            this.max_Volume.Click += new System.EventHandler(this.max_Volume_Click);
            // 
            // medium_Volume
            // 
            this.medium_Volume.BackColor = System.Drawing.Color.Transparent;
            this.medium_Volume.Image = ((System.Drawing.Image)(resources.GetObject("medium_Volume.Image")));
            this.medium_Volume.ImageActive = null;
            this.medium_Volume.Location = new System.Drawing.Point(175, 93);
            this.medium_Volume.Name = "medium_Volume";
            this.medium_Volume.Size = new System.Drawing.Size(25, 18);
            this.medium_Volume.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.medium_Volume.TabIndex = 24;
            this.medium_Volume.TabStop = false;
            this.medium_Volume.Zoom = 10;
            this.medium_Volume.Click += new System.EventHandler(this.max_Volume_Click);
            // 
            // Volume_Slider
            // 
            this.Volume_Slider.BackColor = System.Drawing.Color.Transparent;
            this.Volume_Slider.BackgroudColor = System.Drawing.Color.DarkGray;
            this.Volume_Slider.BorderRadius = 20;
            this.Volume_Slider.IndicatorColor = System.Drawing.Color.DarkOrchid;
            this.Volume_Slider.Location = new System.Drawing.Point(202, 88);
            this.Volume_Slider.MaximumValue = 100;
            this.Volume_Slider.Name = "Volume_Slider";
            this.Volume_Slider.Size = new System.Drawing.Size(92, 30);
            this.Volume_Slider.TabIndex = 26;
            this.Volume_Slider.Value = 0;
            this.Volume_Slider.ValueChanged += new System.EventHandler(this.Volume_Slider_ValueChanged);
            // 
            // Mute
            // 
            this.Mute.BackColor = System.Drawing.Color.Transparent;
            this.Mute.Image = ((System.Drawing.Image)(resources.GetObject("Mute.Image")));
            this.Mute.ImageActive = null;
            this.Mute.Location = new System.Drawing.Point(174, 94);
            this.Mute.Name = "Mute";
            this.Mute.Size = new System.Drawing.Size(31, 17);
            this.Mute.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Mute.TabIndex = 23;
            this.Mute.TabStop = false;
            this.Mute.Zoom = 10;
            this.Mute.Click += new System.EventHandler(this.Mute_Click);
            // 
            // btn_Music_Nowpl_Pause
            // 
            this.btn_Music_Nowpl_Pause.BackColor = System.Drawing.Color.Transparent;
            this.btn_Music_Nowpl_Pause.Image = ((System.Drawing.Image)(resources.GetObject("btn_Music_Nowpl_Pause.Image")));
            this.btn_Music_Nowpl_Pause.ImageActive = null;
            this.btn_Music_Nowpl_Pause.Location = new System.Drawing.Point(59, 95);
            this.btn_Music_Nowpl_Pause.Name = "btn_Music_Nowpl_Pause";
            this.btn_Music_Nowpl_Pause.Size = new System.Drawing.Size(14, 16);
            this.btn_Music_Nowpl_Pause.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Music_Nowpl_Pause.TabIndex = 20;
            this.btn_Music_Nowpl_Pause.TabStop = false;
            this.btn_Music_Nowpl_Pause.Visible = false;
            this.btn_Music_Nowpl_Pause.Zoom = 10;
            this.btn_Music_Nowpl_Pause.Click += new System.EventHandler(this.btn_Music_Nowpl_Pause_Click);
            // 
            // btn_Music_Nowpl_Before
            // 
            this.btn_Music_Nowpl_Before.BackColor = System.Drawing.Color.Transparent;
            this.btn_Music_Nowpl_Before.Image = ((System.Drawing.Image)(resources.GetObject("btn_Music_Nowpl_Before.Image")));
            this.btn_Music_Nowpl_Before.ImageActive = null;
            this.btn_Music_Nowpl_Before.Location = new System.Drawing.Point(21, 95);
            this.btn_Music_Nowpl_Before.Name = "btn_Music_Nowpl_Before";
            this.btn_Music_Nowpl_Before.Size = new System.Drawing.Size(35, 17);
            this.btn_Music_Nowpl_Before.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Music_Nowpl_Before.TabIndex = 19;
            this.btn_Music_Nowpl_Before.TabStop = false;
            this.btn_Music_Nowpl_Before.Zoom = 10;
            this.btn_Music_Nowpl_Before.Click += new System.EventHandler(this.btn_Music_Nowpl_Before_Click);
            // 
            // btn_Music_Nowpl_Replay
            // 
            this.btn_Music_Nowpl_Replay.BackColor = System.Drawing.Color.Transparent;
            this.btn_Music_Nowpl_Replay.Image = ((System.Drawing.Image)(resources.GetObject("btn_Music_Nowpl_Replay.Image")));
            this.btn_Music_Nowpl_Replay.ImageActive = null;
            this.btn_Music_Nowpl_Replay.Location = new System.Drawing.Point(144, 93);
            this.btn_Music_Nowpl_Replay.Name = "btn_Music_Nowpl_Replay";
            this.btn_Music_Nowpl_Replay.Size = new System.Drawing.Size(23, 18);
            this.btn_Music_Nowpl_Replay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Music_Nowpl_Replay.TabIndex = 21;
            this.btn_Music_Nowpl_Replay.TabStop = false;
            this.btn_Music_Nowpl_Replay.Zoom = 10;
            this.btn_Music_Nowpl_Replay.Click += new System.EventHandler(this.btn_Music_Nowpl_Replay_Click);
            // 
            // btn_Music_Nowpl_Mix
            // 
            this.btn_Music_Nowpl_Mix.BackColor = System.Drawing.Color.Transparent;
            this.btn_Music_Nowpl_Mix.Image = ((System.Drawing.Image)(resources.GetObject("btn_Music_Nowpl_Mix.Image")));
            this.btn_Music_Nowpl_Mix.ImageActive = null;
            this.btn_Music_Nowpl_Mix.Location = new System.Drawing.Point(115, 94);
            this.btn_Music_Nowpl_Mix.Name = "btn_Music_Nowpl_Mix";
            this.btn_Music_Nowpl_Mix.Size = new System.Drawing.Size(19, 18);
            this.btn_Music_Nowpl_Mix.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Music_Nowpl_Mix.TabIndex = 17;
            this.btn_Music_Nowpl_Mix.TabStop = false;
            this.btn_Music_Nowpl_Mix.Zoom = 10;
            this.btn_Music_Nowpl_Mix.Click += new System.EventHandler(this.btn_Music_Nowpl_Mix_Click);
            // 
            // btn_Music_Nowpl_Next
            // 
            this.btn_Music_Nowpl_Next.BackColor = System.Drawing.Color.Transparent;
            this.btn_Music_Nowpl_Next.Image = ((System.Drawing.Image)(resources.GetObject("btn_Music_Nowpl_Next.Image")));
            this.btn_Music_Nowpl_Next.ImageActive = null;
            this.btn_Music_Nowpl_Next.Location = new System.Drawing.Point(79, 95);
            this.btn_Music_Nowpl_Next.Name = "btn_Music_Nowpl_Next";
            this.btn_Music_Nowpl_Next.Size = new System.Drawing.Size(27, 16);
            this.btn_Music_Nowpl_Next.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Music_Nowpl_Next.TabIndex = 18;
            this.btn_Music_Nowpl_Next.TabStop = false;
            this.btn_Music_Nowpl_Next.Zoom = 10;
            this.btn_Music_Nowpl_Next.Click += new System.EventHandler(this.btn_Music_Nowpl_Next_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(20, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(59, 61);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // play
            // 
            this.play.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.play.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.play.BackColor = System.Drawing.Color.Transparent;
            this.play.BackgroudColor = System.Drawing.Color.DarkGray;
            this.play.BorderRadius = 10;
            this.play.IndicatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(42)))), ((int)(((byte)(254)))));
            this.play.Location = new System.Drawing.Point(3, 69);
            this.play.MaximumValue = 100;
            this.play.Name = "play";
            this.play.Size = new System.Drawing.Size(640, 30);
            this.play.TabIndex = 22;
            this.play.Value = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lv_My_Music);
            this.panel3.Controls.Add(this.listView1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 120);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(643, 291);
            this.panel3.TabIndex = 24;
            // 
            // lv_My_Music
            // 
            this.lv_My_Music.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(33)))), ((int)(((byte)(45)))));
            this.lv_My_Music.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lv_My_Music.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Name_Music,
            this.Artist_Music,
            this.Genre_Music,
            this.Date_Added_Music,
            this.Length_Music,
            this.Link_Music,
            this.Link_Picture});
            this.lv_My_Music.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lv_My_Music.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lv_My_Music.ForeColor = System.Drawing.SystemColors.Info;
            this.lv_My_Music.FullRowSelect = true;
            this.lv_My_Music.HideSelection = false;
            this.lv_My_Music.Location = new System.Drawing.Point(0, 0);
            this.lv_My_Music.Name = "lv_My_Music";
            this.lv_My_Music.ShowItemToolTips = true;
            this.lv_My_Music.Size = new System.Drawing.Size(643, 291);
            this.lv_My_Music.TabIndex = 1;
            this.lv_My_Music.UseCompatibleStateImageBehavior = false;
            this.lv_My_Music.View = System.Windows.Forms.View.Details;
            // 
            // Name_Music
            // 
            this.Name_Music.Text = "Name";
            this.Name_Music.Width = 200;
            // 
            // Artist_Music
            // 
            this.Artist_Music.Text = "Artist";
            this.Artist_Music.Width = 130;
            // 
            // Genre_Music
            // 
            this.Genre_Music.Text = "Genre";
            this.Genre_Music.Width = 120;
            // 
            // Date_Added_Music
            // 
            this.Date_Added_Music.Text = "Date Added";
            this.Date_Added_Music.Width = 100;
            // 
            // Length_Music
            // 
            this.Length_Music.Text = "Length";
            this.Length_Music.Width = 100;
            // 
            // Link_Music
            // 
            this.Link_Music.Text = "";
            this.Link_Music.Width = 0;
            // 
            // Link_Picture
            // 
            this.Link_Picture.Text = "";
            this.Link_Picture.Width = 0;
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(45)))));
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(643, 291);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // timer_play
            // 
            this.timer_play.Interval = 1000;
            this.timer_play.Tick += new System.EventHandler(this.timer_play_Tick);
            // 
            // Form_Music_Nowpl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(643, 411);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Music_Nowpl";
            this.Text = "Form_Music_Nowpl";
            ((System.ComponentModel.ISupportInitialize)(this.btn_Music_Nowpl_Play)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.max_Volume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medium_Volume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Music_Nowpl_Pause)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Music_Nowpl_Before)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Music_Nowpl_Replay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Music_Nowpl_Mix)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Music_Nowpl_Next)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuImageButton btn_Music_Nowpl_Play;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lb_Info_Music;
        private Bunifu.Framework.UI.BunifuImageButton btn_Music_Nowpl_Pause;
        private Bunifu.Framework.UI.BunifuImageButton btn_Music_Nowpl_Before;
        private Bunifu.Framework.UI.BunifuImageButton btn_Music_Nowpl_Replay;
        private System.Windows.Forms.Label lb_NamePl;
        private Bunifu.Framework.UI.BunifuImageButton btn_Music_Nowpl_Mix;
        private Bunifu.Framework.UI.BunifuImageButton btn_Music_Nowpl_Next;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListView listView1;
        public System.Windows.Forms.ListView lv_My_Music;
        private System.Windows.Forms.ColumnHeader Name_Music;
        private System.Windows.Forms.ColumnHeader Artist_Music;
        private System.Windows.Forms.ColumnHeader Genre_Music;
        private System.Windows.Forms.ColumnHeader Date_Added_Music;
        private System.Windows.Forms.ColumnHeader Length_Music;
        private System.Windows.Forms.ColumnHeader Link_Music;
        private System.Windows.Forms.ColumnHeader Link_Picture;
        private Bunifu.Framework.UI.BunifuSlider play;
        private System.Windows.Forms.Timer timer_play;
        private Bunifu.Framework.UI.BunifuImageButton max_Volume;
        private Bunifu.Framework.UI.BunifuImageButton medium_Volume;
        private Bunifu.Framework.UI.BunifuImageButton Mute;
        public Bunifu.Framework.UI.BunifuSlider Volume_Slider;
    }
}