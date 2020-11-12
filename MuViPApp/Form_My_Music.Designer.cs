namespace MuViPApp
{
    partial class Form_My_Music
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
            this.label1 = new System.Windows.Forms.Label();
            this.lb_My_music_sort = new System.Windows.Forms.Label();
            this.cb_My_music_sort = new Bunifu.Framework.UI.BunifuDropdown();
            this.btn_My_Music_Play_all = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lb_My_Music = new System.Windows.Forms.Label();
            this.pn_List = new System.Windows.Forms.Panel();
            this.lv_My_Music = new System.Windows.Forms.ListView();
            this.Name_Music = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Artist_Music = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Genre_Music = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Date_Added_Music = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Size_Music = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pn_Top.SuspendLayout();
            this.pn_List.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_Top
            // 
            this.pn_Top.Controls.Add(this.label1);
            this.pn_Top.Controls.Add(this.lb_My_music_sort);
            this.pn_Top.Controls.Add(this.cb_My_music_sort);
            this.pn_Top.Controls.Add(this.btn_My_Music_Play_all);
            this.pn_Top.Controls.Add(this.lb_My_Music);
            this.pn_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_Top.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.pn_Top.Location = new System.Drawing.Point(0, 0);
            this.pn_Top.Name = "pn_Top";
            this.pn_Top.Size = new System.Drawing.Size(800, 133);
            this.pn_Top.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(221, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 21);
            this.label1.TabIndex = 9;
            this.label1.Text = "(0)";
            // 
            // lb_My_music_sort
            // 
            this.lb_My_music_sort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_My_music_sort.AutoSize = true;
            this.lb_My_music_sort.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_My_music_sort.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lb_My_music_sort.Location = new System.Drawing.Point(591, 106);
            this.lb_My_music_sort.Name = "lb_My_music_sort";
            this.lb_My_music_sort.Size = new System.Drawing.Size(57, 16);
            this.lb_My_music_sort.TabIndex = 8;
            this.lb_My_music_sort.Text = "Sort by :";
            // 
            // cb_My_music_sort
            // 
            this.cb_My_music_sort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_My_music_sort.BackColor = System.Drawing.Color.Transparent;
            this.cb_My_music_sort.BorderRadius = 3;
            this.cb_My_music_sort.ForeColor = System.Drawing.Color.MediumOrchid;
            this.cb_My_music_sort.Items = new string[] {
        "A to Z",
        "Date Added",
        "Artist",
        ""};
            this.cb_My_music_sort.Location = new System.Drawing.Point(654, 106);
            this.cb_My_music_sort.Name = "cb_My_music_sort";
            this.cb_My_music_sort.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(33)))), ((int)(((byte)(45)))));
            this.cb_My_music_sort.onHoverColor = System.Drawing.SystemColors.ButtonFace;
            this.cb_My_music_sort.selectedIndex = 0;
            this.cb_My_music_sort.Size = new System.Drawing.Size(124, 16);
            this.cb_My_music_sort.TabIndex = 7;
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
            this.btn_My_Music_Play_all.Location = new System.Drawing.Point(95, 62);
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
            // lb_My_Music
            // 
            this.lb_My_Music.AutoSize = true;
            this.lb_My_Music.Font = new System.Drawing.Font("Microsoft Tai Le", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_My_Music.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lb_My_Music.Location = new System.Drawing.Point(47, 25);
            this.lb_My_Music.Name = "lb_My_Music";
            this.lb_My_Music.Size = new System.Drawing.Size(177, 47);
            this.lb_My_Music.TabIndex = 0;
            this.lb_My_Music.Text = "My Music";
            // 
            // pn_List
            // 
            this.pn_List.Controls.Add(this.lv_My_Music);
            this.pn_List.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_List.Location = new System.Drawing.Point(0, 133);
            this.pn_List.Name = "pn_List";
            this.pn_List.Size = new System.Drawing.Size(800, 317);
            this.pn_List.TabIndex = 1;
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
            this.Size_Music});
            this.lv_My_Music.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lv_My_Music.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lv_My_Music.ForeColor = System.Drawing.SystemColors.Info;
            this.lv_My_Music.HideSelection = false;
            this.lv_My_Music.Location = new System.Drawing.Point(0, 0);
            this.lv_My_Music.Name = "lv_My_Music";
            this.lv_My_Music.Size = new System.Drawing.Size(800, 317);
            this.lv_My_Music.TabIndex = 0;
            this.lv_My_Music.UseCompatibleStateImageBehavior = false;
            this.lv_My_Music.View = System.Windows.Forms.View.Details;
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
            // Size_Music
            // 
            this.Size_Music.Text = "Size";
            // 
            // Form_My_Music
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(33)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pn_List);
            this.Controls.Add(this.pn_Top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_My_Music";
            this.Text = "Form_My_Music";
            this.pn_Top.ResumeLayout(false);
            this.pn_Top.PerformLayout();
            this.pn_List.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn_Top;
        private System.Windows.Forms.Label lb_My_Music;
        private System.Windows.Forms.Panel pn_List;
        private Bunifu.Framework.UI.BunifuFlatButton btn_My_Music_Play_all;
        private System.Windows.Forms.Label lb_My_music_sort;
        protected internal Bunifu.Framework.UI.BunifuDropdown cb_My_music_sort;
        private System.Windows.Forms.ListView lv_My_Music;
        private System.Windows.Forms.ColumnHeader Name_Music;
        private System.Windows.Forms.ColumnHeader Artist_Music;
        private System.Windows.Forms.ColumnHeader Genre_Music;
        private System.Windows.Forms.ColumnHeader Date_Added_Music;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader Size_Music;
    }
}