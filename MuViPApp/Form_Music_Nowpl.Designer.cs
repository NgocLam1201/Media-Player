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
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pb_Music_Player = new Bunifu.Framework.UI.BunifuProgressBar();
            this.btn_Music_Nowpl_Pause = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_Music_Nowpl_Before = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_Music_Nowpl_Replay = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_Music_Nowpl_More = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_Music_Nowpl_Mute = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_Music_Nowpl_Mix = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_Music_Nowpl_Next = new Bunifu.Framework.UI.BunifuImageButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Music_Nowpl_Play)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Music_Nowpl_Pause)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Music_Nowpl_Before)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Music_Nowpl_Replay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Music_Nowpl_More)).BeginInit();
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
            this.btn_Music_Nowpl_Play.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Music_Nowpl_Play.BackColor = System.Drawing.Color.Transparent;
            this.btn_Music_Nowpl_Play.Image = ((System.Drawing.Image)(resources.GetObject("btn_Music_Nowpl_Play.Image")));
            this.btn_Music_Nowpl_Play.ImageActive = null;
            this.btn_Music_Nowpl_Play.Location = new System.Drawing.Point(55, 87);
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
            this.lb_NamePl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_NamePl.AutoSize = true;
            this.lb_NamePl.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_NamePl.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lb_NamePl.Location = new System.Drawing.Point(191, 19);
            this.lb_NamePl.Name = "lb_NamePl";
            this.lb_NamePl.Size = new System.Drawing.Size(0, 25);
            this.lb_NamePl.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(77, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "0 song";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(42)))), ((int)(((byte)(56)))));
            this.panel2.Controls.Add(this.pb_Music_Player);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btn_Music_Nowpl_Pause);
            this.panel2.Controls.Add(this.btn_Music_Nowpl_Before);
            this.panel2.Controls.Add(this.btn_Music_Nowpl_Replay);
            this.panel2.Controls.Add(this.btn_Music_Nowpl_More);
            this.panel2.Controls.Add(this.lb_NamePl);
            this.panel2.Controls.Add(this.btn_Music_Nowpl_Mute);
            this.panel2.Controls.Add(this.btn_Music_Nowpl_Mix);
            this.panel2.Controls.Add(this.btn_Music_Nowpl_Next);
            this.panel2.Controls.Add(this.btn_Music_Nowpl_Play);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(643, 112);
            this.panel2.TabIndex = 23;
            // 
            // pb_Music_Player
            // 
            this.pb_Music_Player.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_Music_Player.BackColor = System.Drawing.Color.Silver;
            this.pb_Music_Player.BorderRadius = 5;
            this.pb_Music_Player.Location = new System.Drawing.Point(3, 73);
            this.pb_Music_Player.MaximumValue = 100;
            this.pb_Music_Player.Name = "pb_Music_Player";
            this.pb_Music_Player.ProgressColor = System.Drawing.Color.DarkViolet;
            this.pb_Music_Player.Size = new System.Drawing.Size(640, 5);
            this.pb_Music_Player.TabIndex = 24;
            this.pb_Music_Player.Value = 30;
            // 
            // btn_Music_Nowpl_Pause
            // 
            this.btn_Music_Nowpl_Pause.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Music_Nowpl_Pause.BackColor = System.Drawing.Color.Transparent;
            this.btn_Music_Nowpl_Pause.Image = ((System.Drawing.Image)(resources.GetObject("btn_Music_Nowpl_Pause.Image")));
            this.btn_Music_Nowpl_Pause.ImageActive = null;
            this.btn_Music_Nowpl_Pause.Location = new System.Drawing.Point(59, 88);
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
            this.btn_Music_Nowpl_Before.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Music_Nowpl_Before.BackColor = System.Drawing.Color.Transparent;
            this.btn_Music_Nowpl_Before.Image = ((System.Drawing.Image)(resources.GetObject("btn_Music_Nowpl_Before.Image")));
            this.btn_Music_Nowpl_Before.ImageActive = null;
            this.btn_Music_Nowpl_Before.Location = new System.Drawing.Point(21, 87);
            this.btn_Music_Nowpl_Before.Name = "btn_Music_Nowpl_Before";
            this.btn_Music_Nowpl_Before.Size = new System.Drawing.Size(35, 17);
            this.btn_Music_Nowpl_Before.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Music_Nowpl_Before.TabIndex = 19;
            this.btn_Music_Nowpl_Before.TabStop = false;
            this.btn_Music_Nowpl_Before.Zoom = 10;
            // 
            // btn_Music_Nowpl_Replay
            // 
            this.btn_Music_Nowpl_Replay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Music_Nowpl_Replay.BackColor = System.Drawing.Color.Transparent;
            this.btn_Music_Nowpl_Replay.Image = ((System.Drawing.Image)(resources.GetObject("btn_Music_Nowpl_Replay.Image")));
            this.btn_Music_Nowpl_Replay.ImageActive = null;
            this.btn_Music_Nowpl_Replay.Location = new System.Drawing.Point(145, 87);
            this.btn_Music_Nowpl_Replay.Name = "btn_Music_Nowpl_Replay";
            this.btn_Music_Nowpl_Replay.Size = new System.Drawing.Size(23, 18);
            this.btn_Music_Nowpl_Replay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Music_Nowpl_Replay.TabIndex = 21;
            this.btn_Music_Nowpl_Replay.TabStop = false;
            this.btn_Music_Nowpl_Replay.Zoom = 10;
            // 
            // btn_Music_Nowpl_More
            // 
            this.btn_Music_Nowpl_More.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Music_Nowpl_More.BackColor = System.Drawing.Color.Transparent;
            this.btn_Music_Nowpl_More.Image = ((System.Drawing.Image)(resources.GetObject("btn_Music_Nowpl_More.Image")));
            this.btn_Music_Nowpl_More.ImageActive = null;
            this.btn_Music_Nowpl_More.Location = new System.Drawing.Point(204, 86);
            this.btn_Music_Nowpl_More.Name = "btn_Music_Nowpl_More";
            this.btn_Music_Nowpl_More.Size = new System.Drawing.Size(18, 21);
            this.btn_Music_Nowpl_More.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Music_Nowpl_More.TabIndex = 15;
            this.btn_Music_Nowpl_More.TabStop = false;
            this.btn_Music_Nowpl_More.Zoom = 10;
            // 
            // btn_Music_Nowpl_Mute
            // 
            this.btn_Music_Nowpl_Mute.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Music_Nowpl_Mute.BackColor = System.Drawing.Color.Transparent;
            this.btn_Music_Nowpl_Mute.Image = ((System.Drawing.Image)(resources.GetObject("btn_Music_Nowpl_Mute.Image")));
            this.btn_Music_Nowpl_Mute.ImageActive = null;
            this.btn_Music_Nowpl_Mute.Location = new System.Drawing.Point(178, 88);
            this.btn_Music_Nowpl_Mute.Name = "btn_Music_Nowpl_Mute";
            this.btn_Music_Nowpl_Mute.Size = new System.Drawing.Size(17, 16);
            this.btn_Music_Nowpl_Mute.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Music_Nowpl_Mute.TabIndex = 14;
            this.btn_Music_Nowpl_Mute.TabStop = false;
            this.btn_Music_Nowpl_Mute.Zoom = 10;
            // 
            // btn_Music_Nowpl_Mix
            // 
            this.btn_Music_Nowpl_Mix.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Music_Nowpl_Mix.BackColor = System.Drawing.Color.Transparent;
            this.btn_Music_Nowpl_Mix.Image = ((System.Drawing.Image)(resources.GetObject("btn_Music_Nowpl_Mix.Image")));
            this.btn_Music_Nowpl_Mix.ImageActive = null;
            this.btn_Music_Nowpl_Mix.Location = new System.Drawing.Point(115, 87);
            this.btn_Music_Nowpl_Mix.Name = "btn_Music_Nowpl_Mix";
            this.btn_Music_Nowpl_Mix.Size = new System.Drawing.Size(19, 18);
            this.btn_Music_Nowpl_Mix.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Music_Nowpl_Mix.TabIndex = 17;
            this.btn_Music_Nowpl_Mix.TabStop = false;
            this.btn_Music_Nowpl_Mix.Zoom = 10;
            // 
            // btn_Music_Nowpl_Next
            // 
            this.btn_Music_Nowpl_Next.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Music_Nowpl_Next.BackColor = System.Drawing.Color.Transparent;
            this.btn_Music_Nowpl_Next.Image = ((System.Drawing.Image)(resources.GetObject("btn_Music_Nowpl_Next.Image")));
            this.btn_Music_Nowpl_Next.ImageActive = null;
            this.btn_Music_Nowpl_Next.Location = new System.Drawing.Point(79, 88);
            this.btn_Music_Nowpl_Next.Name = "btn_Music_Nowpl_Next";
            this.btn_Music_Nowpl_Next.Size = new System.Drawing.Size(27, 16);
            this.btn_Music_Nowpl_Next.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Music_Nowpl_Next.TabIndex = 18;
            this.btn_Music_Nowpl_Next.TabStop = false;
            this.btn_Music_Nowpl_Next.Zoom = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(59, 61);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.listView1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 112);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(643, 299);
            this.panel3.TabIndex = 24;
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(45)))));
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(643, 299);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
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
            ((System.ComponentModel.ISupportInitialize)(this.btn_Music_Nowpl_More)).EndInit();
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
        private Bunifu.Framework.UI.BunifuProgressBar pb_Music_Player;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuImageButton btn_Music_Nowpl_Pause;
        private Bunifu.Framework.UI.BunifuImageButton btn_Music_Nowpl_Before;
        private Bunifu.Framework.UI.BunifuImageButton btn_Music_Nowpl_Replay;
        private Bunifu.Framework.UI.BunifuImageButton btn_Music_Nowpl_More;
        private System.Windows.Forms.Label lb_NamePl;
        private Bunifu.Framework.UI.BunifuImageButton btn_Music_Nowpl_Mute;
        private Bunifu.Framework.UI.BunifuImageButton btn_Music_Nowpl_Mix;
        private Bunifu.Framework.UI.BunifuImageButton btn_Music_Nowpl_Next;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListView listView1;
    }
}