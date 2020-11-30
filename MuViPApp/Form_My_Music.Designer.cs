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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ColumnHeader Link_Music;
            System.Windows.Forms.ColumnHeader Link_Picture;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_My_Music));
            this.pn_Top = new System.Windows.Forms.Panel();
            this.lb_view = new System.Windows.Forms.Label();
            this.Cb_My_Music_View = new Bunifu.Framework.UI.BunifuDropdown();
            this.count_items = new System.Windows.Forms.Label();
            this.btn_My_Music_Play_all = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lb_My_Music = new System.Windows.Forms.Label();
            this.pn_List = new System.Windows.Forms.Panel();
            this.lv_My_Music = new System.Windows.Forms.ListView();
            this.Name_Music = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Artist_Music = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Genre_Music = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Date_Added_Music = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Length_Music = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.largeIML = new System.Windows.Forms.ImageList(this.components);
            this.smallIML = new System.Windows.Forms.ImageList(this.components);
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            Link_Music = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            Link_Picture = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pn_Top.SuspendLayout();
            this.pn_List.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_Top
            // 
            this.pn_Top.Controls.Add(this.lb_view);
            this.pn_Top.Controls.Add(this.Cb_My_Music_View);
            this.pn_Top.Controls.Add(this.count_items);
            this.pn_Top.Controls.Add(this.btn_My_Music_Play_all);
            this.pn_Top.Controls.Add(this.lb_My_Music);
            this.pn_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_Top.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.pn_Top.Location = new System.Drawing.Point(0, 0);
            this.pn_Top.Name = "pn_Top";
            this.pn_Top.Size = new System.Drawing.Size(800, 133);
            this.pn_Top.TabIndex = 0;
            // 
            // lb_view
            // 
            this.lb_view.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_view.AutoSize = true;
            this.lb_view.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_view.Location = new System.Drawing.Point(630, 97);
            this.lb_view.Name = "lb_view";
            this.lb_view.Size = new System.Drawing.Size(42, 16);
            this.lb_view.TabIndex = 11;
            this.lb_view.Text = "View :";
            // 
            // Cb_My_Music_View
            // 
            this.Cb_My_Music_View.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Cb_My_Music_View.BackColor = System.Drawing.Color.Transparent;
            this.Cb_My_Music_View.BorderRadius = 3;
            this.Cb_My_Music_View.ForeColor = System.Drawing.Color.MediumOrchid;
            this.Cb_My_Music_View.Items = new string[] {
        "Details",
        "Title",
        "Large icon",
        "Small icon"};
            this.Cb_My_Music_View.Location = new System.Drawing.Point(671, 93);
            this.Cb_My_Music_View.Name = "Cb_My_Music_View";
            this.Cb_My_Music_View.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(33)))), ((int)(((byte)(45)))));
            this.Cb_My_Music_View.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(33)))), ((int)(((byte)(45)))));
            this.Cb_My_Music_View.selectedIndex = 0;
            this.Cb_My_Music_View.Size = new System.Drawing.Size(117, 25);
            this.Cb_My_Music_View.TabIndex = 10;
            this.Cb_My_Music_View.onItemSelected += new System.EventHandler(this.Cb_My_Music_View_onItemSelected);
            // 
            // count_items
            // 
            this.count_items.AutoSize = true;
            this.count_items.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.count_items.Location = new System.Drawing.Point(221, 44);
            this.count_items.Name = "count_items";
            this.count_items.Size = new System.Drawing.Size(0, 21);
            this.count_items.TabIndex = 9;
            // 
            // btn_My_Music_Play_all
            // 
            this.btn_My_Music_Play_all.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(33)))), ((int)(((byte)(45)))));
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
            this.btn_My_Music_Play_all.Click += new System.EventHandler(this.btn_My_Music_Play_all_Click);
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
            this.lv_My_Music.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.lv_My_Music.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lv_My_Music.ForeColor = System.Drawing.SystemColors.Info;
            this.lv_My_Music.FullRowSelect = true;
            this.lv_My_Music.HideSelection = false;
            this.lv_My_Music.LargeImageList = this.largeIML;
            this.lv_My_Music.Location = new System.Drawing.Point(0, 0);
            this.lv_My_Music.Name = "lv_My_Music";
            this.lv_My_Music.ShowItemToolTips = true;
            this.lv_My_Music.Size = new System.Drawing.Size(800, 317);
            this.lv_My_Music.SmallImageList = this.smallIML;
            this.lv_My_Music.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lv_My_Music.TabIndex = 0;
            this.lv_My_Music.UseCompatibleStateImageBehavior = false;
            this.lv_My_Music.View = System.Windows.Forms.View.Details;
            this.lv_My_Music.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lv_My_Music_ColumnClick);
            this.lv_My_Music.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Key_Enter_Down);
            // 
            // Name_Music
            // 
            this.Name_Music.Text = "Name";
            this.Name_Music.Width = 206;
            // 
            // Artist_Music
            // 
            this.Artist_Music.Text = "Artist";
            this.Artist_Music.Width = 139;
            // 
            // Genre_Music
            // 
            this.Genre_Music.Text = "Genre";
            this.Genre_Music.Width = 130;
            // 
            // Date_Added_Music
            // 
            this.Date_Added_Music.Text = "Date Added";
            this.Date_Added_Music.Width = 130;
            // 
            // Length_Music
            // 
            this.Length_Music.Text = "Length";
            this.Length_Music.Width = 100;
            // 
            // Link_Music
            // 
            Link_Music.DisplayIndex = 6;
            Link_Music.Text = "";
            Link_Music.Width = 0;
            // 
            // Link_Picture
            // 
            Link_Picture.DisplayIndex = 5;
            Link_Picture.Text = "";
            Link_Picture.Width = 0;
            // 
            // largeIML
            // 
            this.largeIML.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("largeIML.ImageStream")));
            this.largeIML.TransparentColor = System.Drawing.Color.Transparent;
            this.largeIML.Images.SetKeyName(0, "music-note.jpg");
            // 
            // smallIML
            // 
            this.smallIML.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("smallIML.ImageStream")));
            this.smallIML.TransparentColor = System.Drawing.Color.Transparent;
            this.smallIML.Images.SetKeyName(0, "musical-note.png");
            // 
            // columnHeader1
            // 
            this.columnHeader1.DisplayIndex = 7;
            this.columnHeader1.Text = "";
            this.columnHeader1.Width = 0;
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
        private System.Windows.Forms.ColumnHeader Name_Music;
        private System.Windows.Forms.ColumnHeader Artist_Music;
        private System.Windows.Forms.ColumnHeader Genre_Music;
        private System.Windows.Forms.ColumnHeader Date_Added_Music;
        private System.Windows.Forms.Label count_items;
        private System.Windows.Forms.ColumnHeader Length_Music;
        public System.Windows.Forms.ListView lv_My_Music;
        private Bunifu.Framework.UI.BunifuDropdown Cb_My_Music_View;
        private System.Windows.Forms.ImageList smallIML;
        private System.Windows.Forms.ImageList largeIML;
        private System.Windows.Forms.Label lb_view;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}