namespace MuViPApp
{
    partial class Form_Liked_Music
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
            this.pn_Top = new System.Windows.Forms.Panel();
            this.btn_My_Music_Play_all = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lb_Liked_Music = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lv_Liked_My_Music = new System.Windows.Forms.ListView();
            this.Name_Music = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Artist_Music = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Album_Music = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Genre_Music = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Date_Added_Music = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.pn_Top.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_Top
            // 
            this.pn_Top.Controls.Add(this.label1);
            this.pn_Top.Controls.Add(this.btn_My_Music_Play_all);
            this.pn_Top.Controls.Add(this.lb_Liked_Music);
            this.pn_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_Top.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.pn_Top.Location = new System.Drawing.Point(0, 0);
            this.pn_Top.Name = "pn_Top";
            this.pn_Top.Size = new System.Drawing.Size(800, 133);
            this.pn_Top.TabIndex = 1;
            // 
            // btn_My_Music_Play_all
            // 
            this.btn_My_Music_Play_all.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(33)))), ((int)(((byte)(45)))));
            this.btn_My_Music_Play_all.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_My_Music_Play_all.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(33)))), ((int)(((byte)(45)))));
            this.btn_My_Music_Play_all.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_My_Music_Play_all.BorderRadius = 0;
            this.btn_My_Music_Play_all.ButtonText = "Play all";
            this.btn_My_Music_Play_all.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_My_Music_Play_all.DisabledColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_My_Music_Play_all.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_My_Music_Play_all.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_My_Music_Play_all.Iconimage = null;
            this.btn_My_Music_Play_all.Iconimage_right = null;
            this.btn_My_Music_Play_all.Iconimage_right_Selected = null;
            this.btn_My_Music_Play_all.Iconimage_Selected = null;
            this.btn_My_Music_Play_all.IconMarginLeft = 0;
            this.btn_My_Music_Play_all.IconMarginRight = 0;
            this.btn_My_Music_Play_all.IconRightVisible = true;
            this.btn_My_Music_Play_all.IconRightZoom = 0D;
            this.btn_My_Music_Play_all.IconVisible = true;
            this.btn_My_Music_Play_all.IconZoom = 35D;
            this.btn_My_Music_Play_all.IsTab = false;
            this.btn_My_Music_Play_all.Location = new System.Drawing.Point(93, 62);
            this.btn_My_Music_Play_all.Name = "btn_My_Music_Play_all";
            this.btn_My_Music_Play_all.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(33)))), ((int)(((byte)(45)))));
            this.btn_My_Music_Play_all.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(33)))), ((int)(((byte)(45)))));
            this.btn_My_Music_Play_all.OnHoverTextColor = System.Drawing.Color.DarkViolet;
            this.btn_My_Music_Play_all.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btn_My_Music_Play_all.selected = false;
            this.btn_My_Music_Play_all.Size = new System.Drawing.Size(129, 47);
            this.btn_My_Music_Play_all.TabIndex = 6;
            this.btn_My_Music_Play_all.Text = "Play all";
            this.btn_My_Music_Play_all.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_My_Music_Play_all.Textcolor = System.Drawing.Color.White;
            this.btn_My_Music_Play_all.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // lb_Liked_Music
            // 
            this.lb_Liked_Music.AutoSize = true;
            this.lb_Liked_Music.Font = new System.Drawing.Font("Microsoft Tai Le", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Liked_Music.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lb_Liked_Music.Location = new System.Drawing.Point(47, 25);
            this.lb_Liked_Music.Name = "lb_Liked_Music";
            this.lb_Liked_Music.Size = new System.Drawing.Size(216, 47);
            this.lb_Liked_Music.TabIndex = 0;
            this.lb_Liked_Music.Text = "Liked Songs";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lv_Liked_My_Music);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 133);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 317);
            this.panel1.TabIndex = 2;
            // 
            // lv_Liked_My_Music
            // 
            this.lv_Liked_My_Music.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(33)))), ((int)(((byte)(45)))));
            this.lv_Liked_My_Music.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lv_Liked_My_Music.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Name_Music,
            this.Artist_Music,
            this.Album_Music,
            this.Genre_Music,
            this.Date_Added_Music});
            this.lv_Liked_My_Music.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lv_Liked_My_Music.HideSelection = false;
            this.lv_Liked_My_Music.Location = new System.Drawing.Point(0, 0);
            this.lv_Liked_My_Music.Name = "lv_Liked_My_Music";
            this.lv_Liked_My_Music.Size = new System.Drawing.Size(800, 317);
            this.lv_Liked_My_Music.TabIndex = 1;
            this.lv_Liked_My_Music.UseCompatibleStateImageBehavior = false;
            this.lv_Liked_My_Music.View = System.Windows.Forms.View.Details;
            // 
            // Name_Music
            // 
            this.Name_Music.Text = "Name";
            this.Name_Music.Width = 183;
            // 
            // Artist_Music
            // 
            this.Artist_Music.Text = "Artist";
            this.Artist_Music.Width = 113;
            // 
            // Album_Music
            // 
            this.Album_Music.Text = "Album";
            this.Album_Music.Width = 108;
            // 
            // Genre_Music
            // 
            this.Genre_Music.Text = "Genre";
            this.Genre_Music.Width = 88;
            // 
            // Date_Added_Music
            // 
            this.Date_Added_Music.Text = "Date Added";
            this.Date_Added_Music.Width = 193;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(260, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "(0)";
            // 
            // Form_Liked_Music
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(33)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pn_Top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Liked_Music";
            this.Text = "Form_Liked";
            this.pn_Top.ResumeLayout(false);
            this.pn_Top.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn_Top;
        private Bunifu.Framework.UI.BunifuFlatButton btn_My_Music_Play_all;
        private System.Windows.Forms.Label lb_Liked_Music;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView lv_Liked_My_Music;
        private System.Windows.Forms.ColumnHeader Name_Music;
        private System.Windows.Forms.ColumnHeader Artist_Music;
        private System.Windows.Forms.ColumnHeader Album_Music;
        private System.Windows.Forms.ColumnHeader Genre_Music;
        private System.Windows.Forms.ColumnHeader Date_Added_Music;
        private System.Windows.Forms.Label label1;
    }
}