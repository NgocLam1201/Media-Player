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
            this.btn_Music_Nowpl_Pause = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_Music_Nowpl_Before = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_Music_Nowpl_Replay = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_Music_Nowpl_Mute = new Bunifu.Framework.UI.BunifuImageButton();
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
            this.RestTime = new System.Windows.Forms.TextBox();
            this.BeginTime = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Music_Nowpl_Play)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Music_Nowpl_Pause)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Music_Nowpl_Before)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Music_Nowpl_Replay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Music_Nowpl_Mute)).BeginInit();
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
            this.btn_Music_Nowpl_Play.Location = new System.Drawing.Point(215, 92);
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
            this.panel2.Controls.Add(this.RestTime);
            this.panel2.Controls.Add(this.BeginTime);
            this.panel2.Controls.Add(this.lb_Info_Music);
            this.panel2.Controls.Add(this.btn_Music_Nowpl_Pause);
            this.panel2.Controls.Add(this.btn_Music_Nowpl_Before);
            this.panel2.Controls.Add(this.btn_Music_Nowpl_Replay);
            this.panel2.Controls.Add(this.lb_NamePl);
            this.panel2.Controls.Add(this.btn_Music_Nowpl_Mute);
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
            // btn_Music_Nowpl_Pause
            // 
            this.btn_Music_Nowpl_Pause.BackColor = System.Drawing.Color.Transparent;
            this.btn_Music_Nowpl_Pause.Image = ((System.Drawing.Image)(resources.GetObject("btn_Music_Nowpl_Pause.Image")));
            this.btn_Music_Nowpl_Pause.ImageActive = null;
            this.btn_Music_Nowpl_Pause.Location = new System.Drawing.Point(222, 93);
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
            this.btn_Music_Nowpl_Before.Location = new System.Drawing.Point(181, 91);
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
            this.btn_Music_Nowpl_Replay.Location = new System.Drawing.Point(305, 91);
            this.btn_Music_Nowpl_Replay.Name = "btn_Music_Nowpl_Replay";
            this.btn_Music_Nowpl_Replay.Size = new System.Drawing.Size(23, 18);
            this.btn_Music_Nowpl_Replay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Music_Nowpl_Replay.TabIndex = 21;
            this.btn_Music_Nowpl_Replay.TabStop = false;
            this.btn_Music_Nowpl_Replay.Zoom = 10;
            this.btn_Music_Nowpl_Replay.Click += new System.EventHandler(this.btn_Music_Nowpl_Replay_Click);
            // 
            // btn_Music_Nowpl_Mute
            // 
            this.btn_Music_Nowpl_Mute.BackColor = System.Drawing.Color.Transparent;
            this.btn_Music_Nowpl_Mute.Image = ((System.Drawing.Image)(resources.GetObject("btn_Music_Nowpl_Mute.Image")));
            this.btn_Music_Nowpl_Mute.ImageActive = null;
            this.btn_Music_Nowpl_Mute.Location = new System.Drawing.Point(338, 93);
            this.btn_Music_Nowpl_Mute.Name = "btn_Music_Nowpl_Mute";
            this.btn_Music_Nowpl_Mute.Size = new System.Drawing.Size(17, 16);
            this.btn_Music_Nowpl_Mute.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Music_Nowpl_Mute.TabIndex = 14;
            this.btn_Music_Nowpl_Mute.TabStop = false;
            this.btn_Music_Nowpl_Mute.Zoom = 10;
            // 
            // btn_Music_Nowpl_Mix
            // 
            this.btn_Music_Nowpl_Mix.BackColor = System.Drawing.Color.Transparent;
            this.btn_Music_Nowpl_Mix.Image = ((System.Drawing.Image)(resources.GetObject("btn_Music_Nowpl_Mix.Image")));
            this.btn_Music_Nowpl_Mix.ImageActive = null;
            this.btn_Music_Nowpl_Mix.Location = new System.Drawing.Point(275, 92);
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
            this.btn_Music_Nowpl_Next.Location = new System.Drawing.Point(239, 92);
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
            this.play.BorderRadius = 15;
            this.play.IndicatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(42)))), ((int)(((byte)(254)))));
            this.play.Location = new System.Drawing.Point(11, 68);
            this.play.MaximumValue = 100;
            this.play.Name = "play";
            this.play.Size = new System.Drawing.Size(624, 30);
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
            // RestTime
            // 
            this.RestTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RestTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(42)))), ((int)(((byte)(56)))));
            this.RestTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RestTime.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RestTime.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.RestTime.Location = new System.Drawing.Point(582, 92);
            this.RestTime.Name = "RestTime";
            this.RestTime.Size = new System.Drawing.Size(49, 18);
            this.RestTime.TabIndex = 24;
            this.RestTime.Text = "00:00:00";
            // 
            // BeginTime
            // 
            this.BeginTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BeginTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(42)))), ((int)(((byte)(56)))));
            this.BeginTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BeginTime.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BeginTime.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.BeginTime.Location = new System.Drawing.Point(12, 93);
            this.BeginTime.Name = "BeginTime";
            this.BeginTime.Size = new System.Drawing.Size(51, 18);
            this.BeginTime.TabIndex = 23;
            this.BeginTime.Text = "00:00:00";
            this.BeginTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
            ((System.ComponentModel.ISupportInitialize)(this.btn_Music_Nowpl_Pause)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Music_Nowpl_Before)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Music_Nowpl_Replay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Music_Nowpl_Mute)).EndInit();
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
        private Bunifu.Framework.UI.BunifuImageButton btn_Music_Nowpl_Mute;
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
        public System.Windows.Forms.TextBox RestTime;
        public System.Windows.Forms.TextBox BeginTime;
    }
}