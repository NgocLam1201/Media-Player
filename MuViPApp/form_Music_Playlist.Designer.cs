namespace MuViPApp
{
    partial class form_Music_Playlist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_Music_Playlist));
            System.Windows.Forms.ColumnHeader Link_Music;
            System.Windows.Forms.ColumnHeader Link_Picture;
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Number_song = new System.Windows.Forms.Label();
            this.lb_NamePl = new System.Windows.Forms.Label();
            this.btn_Delete = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_Rename = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_Addto = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_Playall = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lv_My_Music = new System.Windows.Forms.ListView();
            this.Name_Music = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Artist_Music = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Genre_Music = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Date_Added_Music = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Length_Music = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            Link_Music = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            Link_Picture = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(59, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(89, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(42)))), ((int)(((byte)(56)))));
            this.panel1.Controls.Add(this.Number_song);
            this.panel1.Controls.Add(this.lb_NamePl);
            this.panel1.Controls.Add(this.btn_Delete);
            this.panel1.Controls.Add(this.btn_Rename);
            this.panel1.Controls.Add(this.btn_Addto);
            this.panel1.Controls.Add(this.btn_Playall);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(643, 99);
            this.panel1.TabIndex = 1;
            // 
            // Number_song
            // 
            this.Number_song.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Number_song.AutoSize = true;
            this.Number_song.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Number_song.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Number_song.Location = new System.Drawing.Point(193, 42);
            this.Number_song.Name = "Number_song";
            this.Number_song.Size = new System.Drawing.Size(39, 13);
            this.Number_song.TabIndex = 8;
            this.Number_song.Text = "0 song";
            // 
            // lb_NamePl
            // 
            this.lb_NamePl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_NamePl.AutoSize = true;
            this.lb_NamePl.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_NamePl.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lb_NamePl.Location = new System.Drawing.Point(191, 12);
            this.lb_NamePl.Name = "lb_NamePl";
            this.lb_NamePl.Size = new System.Drawing.Size(70, 25);
            this.lb_NamePl.TabIndex = 7;
            this.lb_NamePl.Text = "name";
            // 
            // btn_Delete
            // 
            this.btn_Delete.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_Delete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(42)))), ((int)(((byte)(56)))));
            this.btn_Delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Delete.BorderRadius = 0;
            this.btn_Delete.ButtonText = "Delete";
            this.btn_Delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Delete.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Delete.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_Delete.Iconimage")));
            this.btn_Delete.Iconimage_right = null;
            this.btn_Delete.Iconimage_right_Selected = null;
            this.btn_Delete.Iconimage_Selected = null;
            this.btn_Delete.IconMarginLeft = 0;
            this.btn_Delete.IconMarginRight = 0;
            this.btn_Delete.IconRightVisible = true;
            this.btn_Delete.IconRightZoom = 0D;
            this.btn_Delete.IconVisible = true;
            this.btn_Delete.IconZoom = 35D;
            this.btn_Delete.IsTab = false;
            this.btn_Delete.Location = new System.Drawing.Point(532, 70);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(42)))), ((int)(((byte)(56)))));
            this.btn_Delete.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(42)))), ((int)(((byte)(56)))));
            this.btn_Delete.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Delete.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btn_Delete.selected = false;
            this.btn_Delete.Size = new System.Drawing.Size(70, 20);
            this.btn_Delete.TabIndex = 6;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Delete.Textcolor = System.Drawing.Color.White;
            this.btn_Delete.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btn_Rename
            // 
            this.btn_Rename.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_Rename.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Rename.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(42)))), ((int)(((byte)(56)))));
            this.btn_Rename.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Rename.BorderRadius = 0;
            this.btn_Rename.ButtonText = "Rename";
            this.btn_Rename.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Rename.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Rename.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Rename.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Rename.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_Rename.Iconimage")));
            this.btn_Rename.Iconimage_right = null;
            this.btn_Rename.Iconimage_right_Selected = null;
            this.btn_Rename.Iconimage_Selected = null;
            this.btn_Rename.IconMarginLeft = 0;
            this.btn_Rename.IconMarginRight = 0;
            this.btn_Rename.IconRightVisible = true;
            this.btn_Rename.IconRightZoom = 0D;
            this.btn_Rename.IconVisible = true;
            this.btn_Rename.IconZoom = 35D;
            this.btn_Rename.IsTab = false;
            this.btn_Rename.Location = new System.Drawing.Point(409, 70);
            this.btn_Rename.Name = "btn_Rename";
            this.btn_Rename.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(42)))), ((int)(((byte)(56)))));
            this.btn_Rename.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(42)))), ((int)(((byte)(56)))));
            this.btn_Rename.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Rename.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btn_Rename.selected = false;
            this.btn_Rename.Size = new System.Drawing.Size(82, 20);
            this.btn_Rename.TabIndex = 5;
            this.btn_Rename.Text = "Rename";
            this.btn_Rename.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Rename.Textcolor = System.Drawing.Color.White;
            this.btn_Rename.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Rename.Click += new System.EventHandler(this.btn_Rename_Click);
            // 
            // btn_Addto
            // 
            this.btn_Addto.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_Addto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Addto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(42)))), ((int)(((byte)(56)))));
            this.btn_Addto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Addto.BorderRadius = 0;
            this.btn_Addto.ButtonText = "Add to";
            this.btn_Addto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Addto.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Addto.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Addto.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Addto.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_Addto.Iconimage")));
            this.btn_Addto.Iconimage_right = null;
            this.btn_Addto.Iconimage_right_Selected = null;
            this.btn_Addto.Iconimage_Selected = null;
            this.btn_Addto.IconMarginLeft = 0;
            this.btn_Addto.IconMarginRight = 0;
            this.btn_Addto.IconRightVisible = true;
            this.btn_Addto.IconRightZoom = 0D;
            this.btn_Addto.IconVisible = true;
            this.btn_Addto.IconZoom = 35D;
            this.btn_Addto.IsTab = false;
            this.btn_Addto.Location = new System.Drawing.Point(300, 70);
            this.btn_Addto.Name = "btn_Addto";
            this.btn_Addto.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(42)))), ((int)(((byte)(56)))));
            this.btn_Addto.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(42)))), ((int)(((byte)(56)))));
            this.btn_Addto.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Addto.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btn_Addto.selected = false;
            this.btn_Addto.Size = new System.Drawing.Size(72, 20);
            this.btn_Addto.TabIndex = 4;
            this.btn_Addto.Text = "Add to";
            this.btn_Addto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Addto.Textcolor = System.Drawing.Color.White;
            this.btn_Addto.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btn_Playall
            // 
            this.btn_Playall.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_Playall.AllowDrop = true;
            this.btn_Playall.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Playall.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(42)))), ((int)(((byte)(56)))));
            this.btn_Playall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Playall.BorderRadius = 0;
            this.btn_Playall.ButtonText = "Play All";
            this.btn_Playall.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Playall.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Playall.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Playall.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Playall.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_Playall.Iconimage")));
            this.btn_Playall.Iconimage_right = null;
            this.btn_Playall.Iconimage_right_Selected = null;
            this.btn_Playall.Iconimage_Selected = null;
            this.btn_Playall.IconMarginLeft = 0;
            this.btn_Playall.IconMarginRight = 0;
            this.btn_Playall.IconRightVisible = true;
            this.btn_Playall.IconRightZoom = 0D;
            this.btn_Playall.IconVisible = true;
            this.btn_Playall.IconZoom = 35D;
            this.btn_Playall.IsTab = false;
            this.btn_Playall.Location = new System.Drawing.Point(196, 70);
            this.btn_Playall.Name = "btn_Playall";
            this.btn_Playall.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(42)))), ((int)(((byte)(56)))));
            this.btn_Playall.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(42)))), ((int)(((byte)(56)))));
            this.btn_Playall.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Playall.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btn_Playall.selected = false;
            this.btn_Playall.Size = new System.Drawing.Size(75, 20);
            this.btn_Playall.TabIndex = 3;
            this.btn_Playall.Text = "Play All";
            this.btn_Playall.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Playall.Textcolor = System.Drawing.Color.White;
            this.btn_Playall.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Playall.Click += new System.EventHandler(this.btn_Playall_Click);
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
            this.columnHeader1,
            Link_Music,
            Link_Picture});
            this.lv_My_Music.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lv_My_Music.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lv_My_Music.ForeColor = System.Drawing.SystemColors.Info;
            this.lv_My_Music.FullRowSelect = true;
            this.lv_My_Music.HideSelection = false;
            this.lv_My_Music.Location = new System.Drawing.Point(0, 98);
            this.lv_My_Music.Name = "lv_My_Music";
            this.lv_My_Music.ShowItemToolTips = true;
            this.lv_My_Music.Size = new System.Drawing.Size(643, 313);
            this.lv_My_Music.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lv_My_Music.TabIndex = 7;
            this.lv_My_Music.UseCompatibleStateImageBehavior = false;
            this.lv_My_Music.View = System.Windows.Forms.View.Details;
            // 
            // Name_Music
            // 
            this.Name_Music.Text = "Name";
            this.Name_Music.Width = 192;
            // 
            // Artist_Music
            // 
            this.Artist_Music.Text = "Artist";
            this.Artist_Music.Width = 148;
            // 
            // Genre_Music
            // 
            this.Genre_Music.Text = "Genre";
            this.Genre_Music.Width = 109;
            // 
            // Date_Added_Music
            // 
            this.Date_Added_Music.Text = "Date Added";
            this.Date_Added_Music.Width = 98;
            // 
            // Length_Music
            // 
            this.Length_Music.Text = "Length";
            this.Length_Music.Width = 100;
            // 
            // columnHeader1
            // 
            this.columnHeader1.DisplayIndex = 7;
            this.columnHeader1.Text = "";
            this.columnHeader1.Width = 0;
            // 
            // Link_Music
            // 
            Link_Music.Text = "";
            Link_Music.Width = 0;
            // 
            // Link_Picture
            // 
            Link_Picture.DisplayIndex = 5;
            Link_Picture.Text = "";
            Link_Picture.Width = 0;
            // 
            // form_Music_Playlist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(643, 411);
            this.Controls.Add(this.lv_My_Music);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(189, 0);
            this.Name = "form_Music_Playlist";
            this.Text = "form_Music_Playlist";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Playall;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Delete;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Rename;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Addto;
        private System.Windows.Forms.Label Number_song;
        public System.Windows.Forms.Label lb_NamePl;
        public System.Windows.Forms.ListView lv_My_Music;
        private System.Windows.Forms.ColumnHeader Name_Music;
        private System.Windows.Forms.ColumnHeader Artist_Music;
        private System.Windows.Forms.ColumnHeader Genre_Music;
        private System.Windows.Forms.ColumnHeader Date_Added_Music;
        private System.Windows.Forms.ColumnHeader Length_Music;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}