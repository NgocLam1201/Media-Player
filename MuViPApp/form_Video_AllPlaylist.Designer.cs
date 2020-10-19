namespace MuViPApp
{
    partial class form_Video_AllPlaylist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_Video_AllPlaylist));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.lb_AllPl_Title = new System.Windows.Forms.Label();
            this.btn_AllPl_Add = new Bunifu.Framework.UI.BunifuFlatButton();
            this.cb_Sortby = new Bunifu.Framework.UI.BunifuDropdown();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.video_Playlist3 = new MuViPApp.Video_Playlist();
            this.video_Playlist2 = new MuViPApp.Video_Playlist();
            this.video_Playlist1 = new MuViPApp.Video_Playlist();
            this.video_Playlist5 = new MuViPApp.Video_Playlist();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 5;
            this.bunifuElipse2.TargetControl = this;
            // 
            // lb_AllPl_Title
            // 
            this.lb_AllPl_Title.AutoSize = true;
            this.lb_AllPl_Title.Font = new System.Drawing.Font("Microsoft Tai Le", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_AllPl_Title.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_AllPl_Title.Location = new System.Drawing.Point(52, 13);
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
            this.btn_AllPl_Add.Location = new System.Drawing.Point(60, 75);
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
            this.cb_Sortby.Location = new System.Drawing.Point(268, 80);
            this.cb_Sortby.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cb_Sortby.Name = "cb_Sortby";
            this.cb_Sortby.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(45)))));
            this.cb_Sortby.onHoverColor = System.Drawing.Color.GhostWhite;
            this.cb_Sortby.selectedIndex = 0;
            this.cb_Sortby.Size = new System.Drawing.Size(125, 18);
            this.cb_Sortby.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(210, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Sort by:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(45)))));
            this.panel3.Controls.Add(this.video_Playlist5);
            this.panel3.Controls.Add(this.video_Playlist3);
            this.panel3.Controls.Add(this.video_Playlist2);
            this.panel3.Controls.Add(this.video_Playlist1);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.cb_Sortby);
            this.panel3.Controls.Add(this.btn_AllPl_Add);
            this.panel3.Controls.Add(this.lb_AllPl_Title);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 450);
            this.panel3.TabIndex = 29;
            // 
            // video_Playlist3
            // 
            this.video_Playlist3.BackColor = System.Drawing.Color.Transparent;
            this.video_Playlist3.Location = new System.Drawing.Point(239, 154);
            this.video_Playlist3.MaximumSize = new System.Drawing.Size(125, 132);
            this.video_Playlist3.MinimumSize = new System.Drawing.Size(125, 132);
            this.video_Playlist3.Name = "video_Playlist3";
            this.video_Playlist3.Size = new System.Drawing.Size(125, 132);
            this.video_Playlist3.TabIndex = 7;
            // 
            // video_Playlist2
            // 
            this.video_Playlist2.BackColor = System.Drawing.Color.Transparent;
            this.video_Playlist2.Location = new System.Drawing.Point(605, 154);
            this.video_Playlist2.MaximumSize = new System.Drawing.Size(125, 132);
            this.video_Playlist2.MinimumSize = new System.Drawing.Size(125, 132);
            this.video_Playlist2.Name = "video_Playlist2";
            this.video_Playlist2.Size = new System.Drawing.Size(125, 132);
            this.video_Playlist2.TabIndex = 6;
            // 
            // video_Playlist1
            // 
            this.video_Playlist1.BackColor = System.Drawing.Color.Transparent;
            this.video_Playlist1.Location = new System.Drawing.Point(420, 154);
            this.video_Playlist1.MaximumSize = new System.Drawing.Size(125, 132);
            this.video_Playlist1.MinimumSize = new System.Drawing.Size(125, 132);
            this.video_Playlist1.Name = "video_Playlist1";
            this.video_Playlist1.Size = new System.Drawing.Size(125, 132);
            this.video_Playlist1.TabIndex = 5;
            // 
            // video_Playlist5
            // 
            this.video_Playlist5.BackColor = System.Drawing.Color.Transparent;
            this.video_Playlist5.Location = new System.Drawing.Point(61, 154);
            this.video_Playlist5.MaximumSize = new System.Drawing.Size(125, 132);
            this.video_Playlist5.MinimumSize = new System.Drawing.Size(125, 132);
            this.video_Playlist5.Name = "video_Playlist5";
            this.video_Playlist5.Size = new System.Drawing.Size(125, 132);
            this.video_Playlist5.TabIndex = 8;
            // 
            // form_Video_AllPlaylist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "form_Video_AllPlaylist";
            this.Text = "form_Video_AllPlaylist";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuDropdown cb_Sortby;
        private Bunifu.Framework.UI.BunifuFlatButton btn_AllPl_Add;
        private System.Windows.Forms.Label lb_AllPl_Title;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Video_Playlist video_Playlist3;
        private Video_Playlist video_Playlist2;
        private Video_Playlist video_Playlist1;
        private Video_Playlist video_Playlist5;
    }
}