namespace MuViPApp
{
    partial class Form_History_Music
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
            this.lb_History_Music = new System.Windows.Forms.Label();
            this.lv_History_Music = new System.Windows.Forms.ListView();
            this.Name_Music = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Artist_Music = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Genre_Music = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Date_View_Music = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Length_Music = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Link_Music = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Link_Picture = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pn_Top.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_Top
            // 
            this.pn_Top.Controls.Add(this.lb_History_Music);
            this.pn_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_Top.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.pn_Top.Location = new System.Drawing.Point(0, 0);
            this.pn_Top.Name = "pn_Top";
            this.pn_Top.Size = new System.Drawing.Size(800, 100);
            this.pn_Top.TabIndex = 2;
            // 
            // lb_History_Music
            // 
            this.lb_History_Music.AutoSize = true;
            this.lb_History_Music.Font = new System.Drawing.Font("Microsoft Tai Le", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_History_Music.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lb_History_Music.Location = new System.Drawing.Point(47, 25);
            this.lb_History_Music.Name = "lb_History_Music";
            this.lb_History_Music.Size = new System.Drawing.Size(137, 47);
            this.lb_History_Music.TabIndex = 0;
            this.lb_History_Music.Text = "History";
            // 
            // lv_History_Music
            // 
            this.lv_History_Music.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(33)))), ((int)(((byte)(45)))));
            this.lv_History_Music.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lv_History_Music.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Name_Music,
            this.Artist_Music,
            this.Genre_Music,
            this.Date_View_Music,
            this.Length_Music,
            this.Link_Music,
            this.Link_Picture});
            this.lv_History_Music.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lv_History_Music.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lv_History_Music.ForeColor = System.Drawing.SystemColors.Info;
            this.lv_History_Music.FullRowSelect = true;
            this.lv_History_Music.HideSelection = false;
            this.lv_History_Music.Location = new System.Drawing.Point(0, 100);
            this.lv_History_Music.Name = "lv_History_Music";
            this.lv_History_Music.ShowItemToolTips = true;
            this.lv_History_Music.Size = new System.Drawing.Size(800, 350);
            this.lv_History_Music.TabIndex = 3;
            this.lv_History_Music.UseCompatibleStateImageBehavior = false;
            this.lv_History_Music.View = System.Windows.Forms.View.Details;
            // 
            // Name_Music
            // 
            this.Name_Music.Text = "Name";
            this.Name_Music.Width = 226;
            // 
            // Artist_Music
            // 
            this.Artist_Music.Text = "Artist";
            this.Artist_Music.Width = 150;
            // 
            // Genre_Music
            // 
            this.Genre_Music.Text = "Genre";
            this.Genre_Music.Width = 139;
            // 
            // Date_View_Music
            // 
            this.Date_View_Music.Text = "Date";
            this.Date_View_Music.Width = 113;
            // 
            // Length_Music
            // 
            this.Length_Music.Text = "Length";
            this.Length_Music.Width = 108;
            // 
            // Link_Music
            // 
            this.Link_Music.Text = "";
            this.Link_Music.Width = 0;
            // 
            // Link_Picture
            // 
            this.Link_Picture.Text = "";
            this.Link_Picture.Width = 0;
            // 
            // Form_History_Music
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(33)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lv_History_Music);
            this.Controls.Add(this.pn_Top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_History_Music";
            this.Text = "Form_History_Music";
            this.pn_Top.ResumeLayout(false);
            this.pn_Top.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn_Top;
        private System.Windows.Forms.Label lb_History_Music;
        public System.Windows.Forms.ListView lv_History_Music;
        private System.Windows.Forms.ColumnHeader Name_Music;
        private System.Windows.Forms.ColumnHeader Artist_Music;
        private System.Windows.Forms.ColumnHeader Genre_Music;
        private System.Windows.Forms.ColumnHeader Date_View_Music;
        private System.Windows.Forms.ColumnHeader Length_Music;
        private System.Windows.Forms.ColumnHeader Link_Music;
        private System.Windows.Forms.ColumnHeader Link_Picture;
    }
}