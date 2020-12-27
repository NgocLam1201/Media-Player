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
            this.lb_AllPl_Title = new System.Windows.Forms.Label();
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
            this.cb_Sortby.Location = new System.Drawing.Point(642, 74);
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
            this.label1.Location = new System.Drawing.Point(584, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Sort by:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lb_AllPl_Title);
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
        private System.Windows.Forms.Label lb_AllPl_Title;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel FLP_playlist;
        private System.Windows.Forms.Panel panel1;
    }
}