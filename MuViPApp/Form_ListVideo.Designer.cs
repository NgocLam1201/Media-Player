namespace MuViPApp
{
    partial class Form_ListVideo
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
            System.Windows.Forms.ColumnHeader fpath;
            this.listView_myvideo = new System.Windows.Forms.ListView();
            this.namevideo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.date_mod = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Size = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Length = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.likeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unlikeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.playToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.addToToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nowPlayingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.newPlaylistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            fpath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MenuStrip.SuspendLayout();
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
            this.listView_myvideo.ContextMenuStrip = this.MenuStrip;
            this.listView_myvideo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView_myvideo.ForeColor = System.Drawing.SystemColors.Info;
            this.listView_myvideo.FullRowSelect = true;
            this.listView_myvideo.HideSelection = false;
            this.listView_myvideo.Location = new System.Drawing.Point(0, 0);
            this.listView_myvideo.Name = "listView_myvideo";
            this.listView_myvideo.Size = new System.Drawing.Size(800, 450);
            this.listView_myvideo.Sorting = System.Windows.Forms.SortOrder.Descending;
            this.listView_myvideo.TabIndex = 3;
            this.listView_myvideo.UseCompatibleStateImageBehavior = false;
            this.listView_myvideo.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView_myvideo_ColumnClick);
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
            // MenuStrip
            // 
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.likeToolStripMenuItem,
            this.unlikeToolStripMenuItem,
            this.toolStripMenuItem1,
            this.deleteToolStripMenuItem,
            this.toolStripMenuItem2,
            this.playToolStripMenuItem,
            this.toolStripMenuItem3,
            this.addToToolStripMenuItem,
            this.toolStripMenuItem5,
            this.selectAllToolStripMenuItem,
            this.cancelToolStripMenuItem});
            this.MenuStrip.Name = "contextMenuStrip1";
            this.MenuStrip.Size = new System.Drawing.Size(123, 182);
            // 
            // likeToolStripMenuItem
            // 
            this.likeToolStripMenuItem.Name = "likeToolStripMenuItem";
            this.likeToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.likeToolStripMenuItem.Text = "Like";
            this.likeToolStripMenuItem.Click += new System.EventHandler(this.likeToolStripMenuItem_Click);
            // 
            // unlikeToolStripMenuItem
            // 
            this.unlikeToolStripMenuItem.Name = "unlikeToolStripMenuItem";
            this.unlikeToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.unlikeToolStripMenuItem.Text = "Unlike";
            this.unlikeToolStripMenuItem.Click += new System.EventHandler(this.unlikeToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(119, 6);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(119, 6);
            // 
            // playToolStripMenuItem
            // 
            this.playToolStripMenuItem.Name = "playToolStripMenuItem";
            this.playToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.playToolStripMenuItem.Text = "Play";
            this.playToolStripMenuItem.Click += new System.EventHandler(this.playToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(119, 6);
            // 
            // addToToolStripMenuItem
            // 
            this.addToToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nowPlayingToolStripMenuItem,
            this.toolStripMenuItem4,
            this.newPlaylistToolStripMenuItem});
            this.addToToolStripMenuItem.Name = "addToToolStripMenuItem";
            this.addToToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.addToToolStripMenuItem.Text = "Add to";
            // 
            // nowPlayingToolStripMenuItem
            // 
            this.nowPlayingToolStripMenuItem.Name = "nowPlayingToolStripMenuItem";
            this.nowPlayingToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.nowPlayingToolStripMenuItem.Text = "Now playing";
            this.nowPlayingToolStripMenuItem.Click += new System.EventHandler(this.nowPlayingToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(138, 6);
            // 
            // newPlaylistToolStripMenuItem
            // 
            this.newPlaylistToolStripMenuItem.Name = "newPlaylistToolStripMenuItem";
            this.newPlaylistToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.newPlaylistToolStripMenuItem.Text = "New playlist";
            this.newPlaylistToolStripMenuItem.Click += new System.EventHandler(this.newPlaylistToolStripMenuItem_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(119, 6);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.selectAllToolStripMenuItem.Text = "Select All";
            this.selectAllToolStripMenuItem.Click += new System.EventHandler(this.selectAllToolStripMenuItem_Click);
            // 
            // cancelToolStripMenuItem
            // 
            this.cancelToolStripMenuItem.Name = "cancelToolStripMenuItem";
            this.cancelToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.cancelToolStripMenuItem.Text = "Cancel";
            this.cancelToolStripMenuItem.Click += new System.EventHandler(this.cancelToolStripMenuItem_Click);
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
            this.MenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ListView listView_myvideo;

        private System.Windows.Forms.ColumnHeader namevideo;
        private System.Windows.Forms.ColumnHeader date_mod;
        private System.Windows.Forms.ColumnHeader Size;
        private System.Windows.Forms.ColumnHeader Length;
        public System.Windows.Forms.ContextMenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem likeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unlikeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem playToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem addToToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nowPlayingToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem newPlaylistToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelToolStripMenuItem;
    }
}