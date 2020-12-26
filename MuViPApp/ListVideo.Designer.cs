namespace MuViPApp
{
    partial class ListVideo
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
            System.Windows.Forms.ColumnHeader fpath;
            this.listView_myvideo = new System.Windows.Forms.ListView();
            this.namevideo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.date_mod = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Size = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Length = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            fpath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // fpath
            // 
            fpath.Text = "";
            fpath.Width = 0;
            // 
            // listView_myvideo
            // 
            this.listView_myvideo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(33)))), ((int)(((byte)(45)))));
            this.listView_myvideo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView_myvideo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.namevideo,
            this.date_mod,
            this.Size,
            this.Length,
            fpath});
            this.listView_myvideo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView_myvideo.ForeColor = System.Drawing.SystemColors.Info;
            this.listView_myvideo.FullRowSelect = true;
            this.listView_myvideo.HideSelection = false;
            this.listView_myvideo.Location = new System.Drawing.Point(0, 0);
            this.listView_myvideo.Name = "listView_myvideo";
            this.listView_myvideo.Size = new System.Drawing.Size(800, 450);
            this.listView_myvideo.TabIndex = 3;
            this.listView_myvideo.UseCompatibleStateImageBehavior = false;
            this.listView_myvideo.View = System.Windows.Forms.View.Details;
            // 
            // namevideo
            // 
            this.namevideo.Text = "Name";
            this.namevideo.Width = 337;
            // 
            // date_mod
            // 
            this.date_mod.Text = "Date Modifiled";
            this.date_mod.Width = 161;
            // 
            // Size
            // 
            this.Size.Text = "Size";
            this.Size.Width = 109;
            // 
            // Length
            // 
            this.Length.Text = "Length";
            this.Length.Width = 120;
            // 
            // ListVideo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listView_myvideo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListVideo";
            this.Text = "ListVideo";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView_myvideo;
        private System.Windows.Forms.ColumnHeader namevideo;
        private System.Windows.Forms.ColumnHeader date_mod;
        private System.Windows.Forms.ColumnHeader Size;
        private System.Windows.Forms.ColumnHeader Length;
    }
}