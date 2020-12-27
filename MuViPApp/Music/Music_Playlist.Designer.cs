namespace MuViPApp
{
    partial class Music_Playlist
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Music_Playlist));
            this.lb_Playlist_Name = new System.Windows.Forms.Label();
            this.lb_Number_Of_Song = new System.Windows.Forms.Label();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.Image_Playlist = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Image_Playlist)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_Playlist_Name
            // 
            this.lb_Playlist_Name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_Playlist_Name.AutoSize = true;
            this.lb_Playlist_Name.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Playlist_Name.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_Playlist_Name.Location = new System.Drawing.Point(11, 96);
            this.lb_Playlist_Name.Name = "lb_Playlist_Name";
            this.lb_Playlist_Name.Size = new System.Drawing.Size(108, 17);
            this.lb_Playlist_Name.TabIndex = 1;
            this.lb_Playlist_Name.Text = "Playlist\'s Name";
            this.lb_Playlist_Name.Click += new System.EventHandler(this.Music_Playlist_Click);
            // 
            // lb_Number_Of_Song
            // 
            this.lb_Number_Of_Song.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_Number_Of_Song.AutoSize = true;
            this.lb_Number_Of_Song.Font = new System.Drawing.Font("Microsoft YaHei UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Number_Of_Song.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_Number_Of_Song.Location = new System.Drawing.Point(11, 115);
            this.lb_Number_Of_Song.Name = "lb_Number_Of_Song";
            this.lb_Number_Of_Song.Size = new System.Drawing.Size(83, 14);
            this.lb_Number_Of_Song.TabIndex = 2;
            this.lb_Number_Of_Song.Text = "Number of songs";
            this.lb_Number_Of_Song.Click += new System.EventHandler(this.Music_Playlist_Click);
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.Image_Playlist);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.Black;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.DimGray;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.DimGray;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.DimGray;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(123, 96);
            this.bunifuGradientPanel1.TabIndex = 3;
            this.bunifuGradientPanel1.Click += new System.EventHandler(this.Music_Playlist_Click);
            // 
            // Image_Playlist
            // 
            this.Image_Playlist.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Image_Playlist.BackColor = System.Drawing.Color.Transparent;
            this.Image_Playlist.Image = ((System.Drawing.Image)(resources.GetObject("Image_Playlist.Image")));
            this.Image_Playlist.ImageActive = null;
            this.Image_Playlist.Location = new System.Drawing.Point(14, 13);
            this.Image_Playlist.Name = "Image_Playlist";
            this.Image_Playlist.Size = new System.Drawing.Size(93, 68);
            this.Image_Playlist.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Image_Playlist.TabIndex = 0;
            this.Image_Playlist.TabStop = false;
            this.Image_Playlist.Zoom = 10;
            this.Image_Playlist.Click += new System.EventHandler(this.Music_Playlist_Click);
            // 
            // Music_Playlist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Controls.Add(this.lb_Number_Of_Song);
            this.Controls.Add(this.lb_Playlist_Name);
            this.DoubleBuffered = true;
            this.MaximumSize = new System.Drawing.Size(125, 132);
            this.MinimumSize = new System.Drawing.Size(125, 132);
            this.Name = "Music_Playlist";
            this.Size = new System.Drawing.Size(123, 130);
            this.Click += new System.EventHandler(this.Music_Playlist_Click);
            this.bunifuGradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Image_Playlist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lb_Number_Of_Song;
        public Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        public Bunifu.Framework.UI.BunifuImageButton Image_Playlist;
        public System.Windows.Forms.Label lb_Playlist_Name;
    }
}
