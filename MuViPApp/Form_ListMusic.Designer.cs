namespace MuViPApp
{
    partial class Form_ListMusic
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
            System.Windows.Forms.ColumnHeader Link_Music;
            this.lv_My_Music = new System.Windows.Forms.ListView();
            this.Name_Music = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Artist_Music = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Genre_Music = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Date_Added_Music = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Length_Music = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            Link_Music = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // Link_Music
            // 
            Link_Music.DisplayIndex = 5;
            Link_Music.Text = "";
            Link_Music.Width = 0;
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
            Link_Music});
            this.lv_My_Music.Dock = System.Windows.Forms.DockStyle.Top;
            this.lv_My_Music.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lv_My_Music.ForeColor = System.Drawing.SystemColors.Info;
            this.lv_My_Music.FullRowSelect = true;
            this.lv_My_Music.HideSelection = false;
            this.lv_My_Music.Location = new System.Drawing.Point(0, 0);
            this.lv_My_Music.Name = "lv_My_Music";
            this.lv_My_Music.ShowItemToolTips = true;
            this.lv_My_Music.Size = new System.Drawing.Size(724, 446);
            this.lv_My_Music.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lv_My_Music.TabIndex = 1;
            this.lv_My_Music.UseCompatibleStateImageBehavior = false;
            this.lv_My_Music.View = System.Windows.Forms.View.Details;
            this.lv_My_Music.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lv_My_Music_ColumnClick);
            this.lv_My_Music.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Key_Enter_Down);
            // 
            // Name_Music
            // 
            this.Name_Music.Text = "      Name";
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
            // columnHeader1
            // 
            this.columnHeader1.DisplayIndex = 6;
            this.columnHeader1.Text = "";
            this.columnHeader1.Width = 0;
            // 
            // Form_ListMusic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(724, 450);
            this.Controls.Add(this.lv_My_Music);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_ListMusic";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ListView lv_My_Music;
        private System.Windows.Forms.ColumnHeader Name_Music;
        private System.Windows.Forms.ColumnHeader Artist_Music;
        private System.Windows.Forms.ColumnHeader Genre_Music;
        private System.Windows.Forms.ColumnHeader Date_Added_Music;
        private System.Windows.Forms.ColumnHeader Length_Music;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}