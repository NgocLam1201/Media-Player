namespace MuViPApp
{
    partial class Video_Playlist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Video_Playlist));
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.lb_Number_Of_Video = new System.Windows.Forms.Label();
            this.lb_Playlist_Name = new System.Windows.Forms.Label();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.bunifuImageButton1);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.Black;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.DimGray;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.DimGray;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.DimGray;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(125, 96);
            this.bunifuGradientPanel1.TabIndex = 6;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(18, 21);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(82, 60);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 0;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            // 
            // lb_Number_Of_Video
            // 
            this.lb_Number_Of_Video.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_Number_Of_Video.AutoSize = true;
            this.lb_Number_Of_Video.Font = new System.Drawing.Font("Microsoft YaHei UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Number_Of_Video.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_Number_Of_Video.Location = new System.Drawing.Point(15, 118);
            this.lb_Number_Of_Video.Name = "lb_Number_Of_Video";
            this.lb_Number_Of_Video.Size = new System.Drawing.Size(85, 14);
            this.lb_Number_Of_Video.TabIndex = 5;
            this.lb_Number_Of_Video.Text = "Number of videos";
            // 
            // lb_Playlist_Name
            // 
            this.lb_Playlist_Name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_Playlist_Name.AutoSize = true;
            this.lb_Playlist_Name.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Playlist_Name.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_Playlist_Name.Location = new System.Drawing.Point(7, 99);
            this.lb_Playlist_Name.Name = "lb_Playlist_Name";
            this.lb_Playlist_Name.Size = new System.Drawing.Size(108, 17);
            this.lb_Playlist_Name.TabIndex = 4;
            this.lb_Playlist_Name.Text = "Playlist\'s Name";
            // 
            // Video_Playlist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Controls.Add(this.lb_Number_Of_Video);
            this.Controls.Add(this.lb_Playlist_Name);
            this.MaximumSize = new System.Drawing.Size(125, 132);
            this.MinimumSize = new System.Drawing.Size(125, 132);
            this.Name = "Video_Playlist";
            this.Size = new System.Drawing.Size(125, 132);
            this.bunifuGradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.Label lb_Number_Of_Video;
        private System.Windows.Forms.Label lb_Playlist_Name;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
    }
}
