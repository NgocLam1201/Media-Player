namespace MuViPApp
{
    partial class form_Music_AllPlaylist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_Music_AllPlaylist));
            this.lb_AllPl_Title = new System.Windows.Forms.Label();
            this.btn_AllPl_Add = new Bunifu.Framework.UI.BunifuFlatButton();
            this.cb_Sortby = new Bunifu.Framework.UI.BunifuDropdown();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.FLP_playlist = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_AllPl_Title
            // 
            this.lb_AllPl_Title.AutoSize = true;
            this.lb_AllPl_Title.Font = new System.Drawing.Font("Microsoft Tai Le", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_AllPl_Title.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_AllPl_Title.Location = new System.Drawing.Point(41, 10);
            this.lb_AllPl_Title.Name = "lb_AllPl_Title";
            this.lb_AllPl_Title.Size = new System.Drawing.Size(134, 47);
            this.lb_AllPl_Title.TabIndex = 1;
            this.lb_AllPl_Title.Text = "Playlist";
            // 
            // btn_AllPl_Add
            // 
            this.btn_AllPl_Add.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(45)))));
            this.btn_AllPl_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(45)))));
            this.btn_AllPl_Add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_AllPl_Add.BorderRadius = 0;
            this.btn_AllPl_Add.ButtonText = "Add Playlist";
            this.btn_AllPl_Add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_AllPl_Add.DisabledColor = System.Drawing.Color.Gray;
            this.btn_AllPl_Add.Font = new System.Drawing.Font("Microsoft Tai Le", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AllPl_Add.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_AllPl_Add.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_AllPl_Add.Iconimage")));
            this.btn_AllPl_Add.Iconimage_right = null;
            this.btn_AllPl_Add.Iconimage_right_Selected = null;
            this.btn_AllPl_Add.Iconimage_Selected = null;
            this.btn_AllPl_Add.IconMarginLeft = 0;
            this.btn_AllPl_Add.IconMarginRight = 0;
            this.btn_AllPl_Add.IconRightVisible = true;
            this.btn_AllPl_Add.IconRightZoom = 0D;
            this.btn_AllPl_Add.IconVisible = true;
            this.btn_AllPl_Add.IconZoom = 90D;
            this.btn_AllPl_Add.IsTab = false;
            this.btn_AllPl_Add.Location = new System.Drawing.Point(49, 72);
            this.btn_AllPl_Add.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_AllPl_Add.Name = "btn_AllPl_Add";
            this.btn_AllPl_Add.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(45)))));
            this.btn_AllPl_Add.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(45)))));
            this.btn_AllPl_Add.OnHoverTextColor = System.Drawing.Color.DarkViolet;
            this.btn_AllPl_Add.selected = false;
            this.btn_AllPl_Add.Size = new System.Drawing.Size(126, 21);
            this.btn_AllPl_Add.TabIndex = 2;
            this.btn_AllPl_Add.Text = "Add Playlist";
            this.btn_AllPl_Add.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_AllPl_Add.Textcolor = System.Drawing.Color.White;
            this.btn_AllPl_Add.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AllPl_Add.Click += new System.EventHandler(this.btn_AllPl_Add_Click);
            // 
            // cb_Sortby
            // 
            this.cb_Sortby.BackColor = System.Drawing.Color.Transparent;
            this.cb_Sortby.BorderRadius = 3;
            this.cb_Sortby.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cb_Sortby.Font = new System.Drawing.Font("Microsoft Tai Le", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Sortby.ForeColor = System.Drawing.Color.MediumOrchid;
            this.cb_Sortby.Items = new string[] {
        "A to Z",
        "Date modified"};
            this.cb_Sortby.Location = new System.Drawing.Point(257, 76);
            this.cb_Sortby.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cb_Sortby.Name = "cb_Sortby";
            this.cb_Sortby.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(45)))));
            this.cb_Sortby.onHoverColor = System.Drawing.Color.GhostWhite;
            this.cb_Sortby.selectedIndex = 0;
            this.cb_Sortby.Size = new System.Drawing.Size(125, 18);
            this.cb_Sortby.TabIndex = 3;
            this.cb_Sortby.onItemSelected += new System.EventHandler(this.cb_Sortby_onItemSelected);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(199, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Sort by:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lb_AllPl_Title);
            this.panel2.Controls.Add(this.btn_AllPl_Add);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.cb_Sortby);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 111);
            this.panel2.TabIndex = 6;
            // 
            // FLP_playlist
            // 
            this.FLP_playlist.AutoScrollMargin = new System.Drawing.Size(20, 20);
            this.FLP_playlist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(45)))));
            this.FLP_playlist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FLP_playlist.Location = new System.Drawing.Point(0, 111);
            this.FLP_playlist.Margin = new System.Windows.Forms.Padding(20);
            this.FLP_playlist.Name = "FLP_playlist";
            this.FLP_playlist.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.FLP_playlist.Size = new System.Drawing.Size(800, 339);
            this.FLP_playlist.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(322, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(8, 8);
            this.panel1.TabIndex = 25;
            // 
            // form_Music_AllPlaylist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.FLP_playlist);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "form_Music_AllPlaylist";
            this.Text = "form_Music_AllPlaylist";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuDropdown cb_Sortby;
        private Bunifu.Framework.UI.BunifuFlatButton btn_AllPl_Add;
        private System.Windows.Forms.Label lb_AllPl_Title;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel FLP_playlist;
        private System.Windows.Forms.Panel panel1;
    }
}