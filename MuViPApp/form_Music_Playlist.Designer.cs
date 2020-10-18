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
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_NamePl = new System.Windows.Forms.Label();
            this.btn_Delete = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_Rename = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_Addto = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_Playall = new Bunifu.Framework.UI.BunifuFlatButton();
            this.text_Addsong = new System.Windows.Forms.TextBox();
            this.tb_GotoCollection = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
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
            this.panel1.Controls.Add(this.label1);
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
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(193, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "0 song";
            // 
            // lb_NamePl
            // 
            this.lb_NamePl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_NamePl.AutoSize = true;
            this.lb_NamePl.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_NamePl.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lb_NamePl.Location = new System.Drawing.Point(191, 12);
            this.lb_NamePl.Name = "lb_NamePl";
            this.lb_NamePl.Size = new System.Drawing.Size(0, 25);
            this.lb_NamePl.TabIndex = 7;
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
            this.btn_Delete.Location = new System.Drawing.Point(532, 72);
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
            this.btn_Rename.Location = new System.Drawing.Point(409, 72);
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
            this.btn_Addto.Location = new System.Drawing.Point(300, 72);
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
            this.btn_Playall.Location = new System.Drawing.Point(196, 72);
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
            // 
            // text_Addsong
            // 
            this.text_Addsong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(45)))));
            this.text_Addsong.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_Addsong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_Addsong.ForeColor = System.Drawing.SystemColors.Info;
            this.text_Addsong.Location = new System.Drawing.Point(59, 189);
            this.text_Addsong.Name = "text_Addsong";
            this.text_Addsong.Size = new System.Drawing.Size(172, 14);
            this.text_Addsong.TabIndex = 3;
            this.text_Addsong.Text = "Add song from my collection";
            // 
            // tb_GotoCollection
            // 
            this.tb_GotoCollection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(45)))));
            this.tb_GotoCollection.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_GotoCollection.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_GotoCollection.ForeColor = System.Drawing.Color.DarkOrchid;
            this.tb_GotoCollection.Location = new System.Drawing.Point(59, 204);
            this.tb_GotoCollection.Name = "tb_GotoCollection";
            this.tb_GotoCollection.Size = new System.Drawing.Size(93, 14);
            this.tb_GotoCollection.TabIndex = 4;
            this.tb_GotoCollection.Text = "Go to collection";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(19, 189);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(34, 29);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(15, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(278, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "What\'s a playlist without music?";
            // 
            // form_Music_Playlist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(643, 411);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.tb_GotoCollection);
            this.Controls.Add(this.text_Addsong);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(189, 0);
            this.Name = "form_Music_Playlist";
            this.Text = "form_Music_Playlist";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Playall;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Delete;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Rename;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Addto;
        private System.Windows.Forms.TextBox text_Addsong;
        private System.Windows.Forms.TextBox tb_GotoCollection;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lb_NamePl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}