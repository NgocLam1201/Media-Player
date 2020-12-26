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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_Sortby = new Bunifu.Framework.UI.BunifuDropdown();
            this.btn_AllPl_Add = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lb_AllPl_Title = new System.Windows.Forms.Label();
            this.FLP_videoplaylist = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(45)))));
            this.panel1.Controls.Add(this.FLP_videoplaylist);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.cb_Sortby);
            this.panel2.Controls.Add(this.btn_AllPl_Add);
            this.panel2.Controls.Add(this.lb_AllPl_Title);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 100);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(183, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Sort by:";
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
            this.cb_Sortby.Location = new System.Drawing.Point(241, 74);
            this.cb_Sortby.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cb_Sortby.Name = "cb_Sortby";
            this.cb_Sortby.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(45)))));
            this.cb_Sortby.onHoverColor = System.Drawing.Color.GhostWhite;
            this.cb_Sortby.selectedIndex = 0;
            this.cb_Sortby.Size = new System.Drawing.Size(125, 18);
            this.cb_Sortby.TabIndex = 7;
            // 
            // btn_AllPl_Add
            // 
            this.btn_AllPl_Add.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(45)))));
            this.btn_AllPl_Add.BackColor = System.Drawing.Color.Transparent;
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
            this.btn_AllPl_Add.Location = new System.Drawing.Point(33, 70);
            this.btn_AllPl_Add.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_AllPl_Add.Name = "btn_AllPl_Add";
            this.btn_AllPl_Add.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(45)))));
            this.btn_AllPl_Add.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(45)))));
            this.btn_AllPl_Add.OnHoverTextColor = System.Drawing.Color.DarkViolet;
            this.btn_AllPl_Add.selected = false;
            this.btn_AllPl_Add.Size = new System.Drawing.Size(126, 21);
            this.btn_AllPl_Add.TabIndex = 6;
            this.btn_AllPl_Add.Text = "Add Playlist";
            this.btn_AllPl_Add.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_AllPl_Add.Textcolor = System.Drawing.Color.White;
            this.btn_AllPl_Add.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // lb_AllPl_Title
            // 
            this.lb_AllPl_Title.AutoSize = true;
            this.lb_AllPl_Title.Font = new System.Drawing.Font("Microsoft Tai Le", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_AllPl_Title.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_AllPl_Title.Location = new System.Drawing.Point(25, 8);
            this.lb_AllPl_Title.Name = "lb_AllPl_Title";
            this.lb_AllPl_Title.Size = new System.Drawing.Size(134, 47);
            this.lb_AllPl_Title.TabIndex = 5;
            this.lb_AllPl_Title.Text = "Playlist";
            // 
            // FLP_videoplaylist
            // 
            this.FLP_videoplaylist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FLP_videoplaylist.Location = new System.Drawing.Point(0, 100);
            this.FLP_videoplaylist.Name = "FLP_videoplaylist";
            this.FLP_videoplaylist.Size = new System.Drawing.Size(800, 350);
            this.FLP_videoplaylist.TabIndex = 1;
            // 
            // form_Video_AllPlaylist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "form_Video_AllPlaylist";
            this.Text = "form_Video_AllPlaylist";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuDropdown cb_Sortby;
        private Bunifu.Framework.UI.BunifuFlatButton btn_AllPl_Add;
        private System.Windows.Forms.Label lb_AllPl_Title;
        private System.Windows.Forms.FlowLayoutPanel FLP_videoplaylist;
    }
}