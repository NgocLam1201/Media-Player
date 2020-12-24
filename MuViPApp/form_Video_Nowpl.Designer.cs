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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_Video_Nowpl));
            this.panel3 = new System.Windows.Forms.Panel();
            this.pn_Video = new System.Windows.Forms.Panel();
            this.MediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Play = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_Pause = new Bunifu.Framework.UI.BunifuImageButton();
            this.pb_Music_Player = new Bunifu.Framework.UI.BunifuProgressBar();
            this.btn_Before = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_Music_Nowpl_Replay = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_Music_Nowpl_Mute = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_Mix = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_Next = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.list_Video = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lb_NamePl = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.tmrVideo = new System.Windows.Forms.Timer(this.components);
            this.panel3.SuspendLayout();
            this.pn_Video.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MediaPlayer)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Play)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Pause)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Before)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Music_Nowpl_Replay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Music_Nowpl_Mute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Mix)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Next)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pn_Video);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 44);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 406);
            this.panel3.TabIndex = 29;
            // 
            // pn_Video
            // 
            this.pn_Video.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(42)))), ((int)(((byte)(56)))));
            this.pn_Video.Controls.Add(this.MediaPlayer);
            this.pn_Video.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_Video.Location = new System.Drawing.Point(0, 0);
            this.pn_Video.Name = "pn_Video";
            this.pn_Video.Size = new System.Drawing.Size(655, 365);
            this.pn_Video.TabIndex = 7;
            // 
            // MediaPlayer
            // 
            this.MediaPlayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MediaPlayer.Enabled = true;
            this.MediaPlayer.Location = new System.Drawing.Point(0, 0);
            this.MediaPlayer.Name = "MediaPlayer";
            this.MediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("MediaPlayer.OcxState")));
            this.MediaPlayer.Size = new System.Drawing.Size(655, 365);
            this.MediaPlayer.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.btn_Play);
            this.panel1.Controls.Add(this.btn_Pause);
            this.panel1.Controls.Add(this.pb_Music_Player);
            this.panel1.Controls.Add(this.btn_Before);
            this.panel1.Controls.Add(this.btn_Music_Nowpl_Replay);
            this.panel1.Controls.Add(this.btn_Music_Nowpl_Mute);
            this.panel1.Controls.Add(this.btn_Mix);
            this.panel1.Controls.Add(this.btn_Next);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 365);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(655, 41);
            this.panel1.TabIndex = 4;
            // 
            // btn_Play
            // 
            this.btn_Play.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Play.BackColor = System.Drawing.Color.Transparent;
            this.btn_Play.Image = ((System.Drawing.Image)(resources.GetObject("btn_Play.Image")));
            this.btn_Play.ImageActive = null;
            this.btn_Play.Location = new System.Drawing.Point(525, 15);
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
            this.btn_Pause.Location = new System.Drawing.Point(232, 13);
            this.btn_Pause.Name = "btn_Pause";
            this.btn_Pause.Size = new System.Drawing.Size(32, 20);
            this.btn_Pause.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Pause.TabIndex = 30;
            this.btn_Pause.TabStop = false;
            this.btn_Pause.Visible = false;
            this.btn_Pause.Zoom = 10;
            this.btn_Pause.Click += new System.EventHandler(this.btn_Pause_Click);
            // 
            // pb_Music_Player
            // 
            this.pb_Music_Player.BackColor = System.Drawing.Color.Silver;
            this.pb_Music_Player.BorderRadius = 5;
            this.pb_Music_Player.Dock = System.Windows.Forms.DockStyle.Top;
            this.pb_Music_Player.Location = new System.Drawing.Point(0, 0);
            this.pb_Music_Player.MaximumValue = 100;
            this.pb_Music_Player.Name = "pb_Music_Player";
            this.pb_Music_Player.ProgressColor = System.Drawing.Color.DarkViolet;
            this.pb_Music_Player.Size = new System.Drawing.Size(655, 5);
            this.pb_Music_Player.TabIndex = 32;
            this.pb_Music_Player.Value = 30;
            // 
            // btn_Before
            // 
            this.btn_Before.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Before.BackColor = System.Drawing.Color.Transparent;
            this.btn_Before.Image = ((System.Drawing.Image)(resources.GetObject("btn_Before.Image")));
            this.btn_Before.ImageActive = null;
            this.btn_Before.Location = new System.Drawing.Point(187, 13);
            this.btn_Before.Name = "btn_Before";
            this.btn_Before.Size = new System.Drawing.Size(56, 21);
            this.btn_Before.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Before.TabIndex = 29;
            this.btn_Before.TabStop = false;
            this.btn_Before.Zoom = 10;
            // 
            // btn_Music_Nowpl_Replay
            // 
            this.btn_Music_Nowpl_Replay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Music_Nowpl_Replay.BackColor = System.Drawing.Color.Transparent;
            this.btn_Music_Nowpl_Replay.Image = ((System.Drawing.Image)(resources.GetObject("btn_Music_Nowpl_Replay.Image")));
            this.btn_Music_Nowpl_Replay.ImageActive = null;
            this.btn_Music_Nowpl_Replay.Location = new System.Drawing.Point(354, 9);
            this.btn_Music_Nowpl_Replay.Name = "btn_Music_Nowpl_Replay";
            this.btn_Music_Nowpl_Replay.Size = new System.Drawing.Size(46, 25);
            this.btn_Music_Nowpl_Replay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Music_Nowpl_Replay.TabIndex = 31;
            this.btn_Music_Nowpl_Replay.TabStop = false;
            this.btn_Music_Nowpl_Replay.Zoom = 10;
            // 
            // btn_Music_Nowpl_Mute
            // 
            this.btn_Music_Nowpl_Mute.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Music_Nowpl_Mute.BackColor = System.Drawing.Color.Transparent;
            this.btn_Music_Nowpl_Mute.Image = ((System.Drawing.Image)(resources.GetObject("btn_Music_Nowpl_Mute.Image")));
            this.btn_Music_Nowpl_Mute.ImageActive = null;
            this.btn_Music_Nowpl_Mute.Location = new System.Drawing.Point(406, 9);
            this.btn_Music_Nowpl_Mute.Name = "btn_Music_Nowpl_Mute";
            this.btn_Music_Nowpl_Mute.Size = new System.Drawing.Size(28, 23);
            this.btn_Music_Nowpl_Mute.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Music_Nowpl_Mute.TabIndex = 25;
            this.btn_Music_Nowpl_Mute.TabStop = false;
            this.btn_Music_Nowpl_Mute.Zoom = 10;
            // 
            // btn_Mix
            // 
            this.btn_Mix.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Mix.BackColor = System.Drawing.Color.Transparent;
            this.btn_Mix.Image = ((System.Drawing.Image)(resources.GetObject("btn_Mix.Image")));
            this.btn_Mix.ImageActive = null;
            this.btn_Mix.Location = new System.Drawing.Point(317, 9);
            this.btn_Mix.Name = "btn_Mix";
            this.btn_Mix.Size = new System.Drawing.Size(31, 25);
            this.btn_Mix.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Mix.TabIndex = 27;
            this.btn_Mix.TabStop = false;
            this.btn_Mix.Zoom = 10;
            // 
            // btn_Next
            // 
            this.btn_Next.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Next.BackColor = System.Drawing.Color.Transparent;
            this.btn_Next.Image = ((System.Drawing.Image)(resources.GetObject("btn_Next.Image")));
            this.btn_Next.ImageActive = null;
            this.btn_Next.Location = new System.Drawing.Point(262, 11);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(49, 23);
            this.btn_Next.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Next.TabIndex = 28;
            this.btn_Next.TabStop = false;
            this.btn_Next.Zoom = 10;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(42)))), ((int)(((byte)(56)))));
            this.panel4.Controls.Add(this.list_Video);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(655, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(145, 406);
            this.panel4.TabIndex = 6;
            // 
            // list_Video
            // 
            this.list_Video.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(42)))), ((int)(((byte)(56)))));
            this.list_Video.Dock = System.Windows.Forms.DockStyle.Fill;
            this.list_Video.ForeColor = System.Drawing.SystemColors.Info;
            this.list_Video.FormattingEnabled = true;
            this.list_Video.Location = new System.Drawing.Point(0, 0);
            this.list_Video.MultiColumn = true;
            this.list_Video.Name = "list_Video";
            this.list_Video.Size = new System.Drawing.Size(145, 406);
            this.list_Video.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(42)))), ((int)(((byte)(56)))));
            this.panel2.Controls.Add(this.lb_NamePl);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 44);
            this.panel2.TabIndex = 28;
            // 
            // lb_NamePl
            // 
            this.lb_NamePl.AutoSize = true;
            this.lb_NamePl.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_NamePl.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lb_NamePl.Location = new System.Drawing.Point(131, 9);
            this.lb_NamePl.Name = "lb_NamePl";
            this.lb_NamePl.Size = new System.Drawing.Size(109, 18);
            this.lb_NamePl.TabIndex = 7;
            this.lb_NamePl.Text = "Video\'s Name";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(66, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(59, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
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
            this.panel3.ResumeLayout(false);
            this.pn_Video.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MediaPlayer)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_Play)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Pause)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Before)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Music_Nowpl_Replay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Music_Nowpl_Mute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Mix)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Next)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel pn_Video;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuImageButton btn_Play;
        private Bunifu.Framework.UI.BunifuImageButton btn_Pause;
        private Bunifu.Framework.UI.BunifuProgressBar pb_Music_Player;
        private Bunifu.Framework.UI.BunifuImageButton btn_Before;
        private Bunifu.Framework.UI.BunifuImageButton btn_Music_Nowpl_Replay;
        private Bunifu.Framework.UI.BunifuImageButton btn_Music_Nowpl_Mute;
        private Bunifu.Framework.UI.BunifuImageButton btn_Mix;
        private Bunifu.Framework.UI.BunifuImageButton btn_Next;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lb_NamePl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.ListBox list_Video;
        private System.Windows.Forms.Timer tmrVideo;
        private AxWMPLib.AxWindowsMediaPlayer MediaPlayer;
    }
}