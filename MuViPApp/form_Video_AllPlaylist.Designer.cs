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
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.FLP_videoplaylist = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_Sortby = new Bunifu.Framework.UI.BunifuDropdown();
            this.lb_AllPl_Title = new System.Windows.Forms.Label();
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
            // FLP_videoplaylist
            // 
            this.FLP_videoplaylist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FLP_videoplaylist.Location = new System.Drawing.Point(0, 100);
            this.FLP_videoplaylist.Name = "FLP_videoplaylist";
            this.FLP_videoplaylist.Size = new System.Drawing.Size(800, 350);
            this.FLP_videoplaylist.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.cb_Sortby);
            this.panel2.Controls.Add(this.lb_AllPl_Title);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 100);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(591, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Sort by:";
            // 
            // cb_Sortby
            // 
            this.cb_Sortby.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_Sortby.BackColor = System.Drawing.Color.Transparent;
            this.cb_Sortby.BorderRadius = 3;
            this.cb_Sortby.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cb_Sortby.Font = new System.Drawing.Font("Microsoft Tai Le", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Sortby.ForeColor = System.Drawing.Color.MediumOrchid;
            this.cb_Sortby.Items = new string[] {
        "Default",
        "A to Z",
        "Z to A",
        "Date modified"};
            this.cb_Sortby.Location = new System.Drawing.Point(649, 64);
            this.cb_Sortby.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cb_Sortby.Name = "cb_Sortby";
            this.cb_Sortby.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(45)))));
            this.cb_Sortby.onHoverColor = System.Drawing.Color.GhostWhite;
            this.cb_Sortby.selectedIndex = -1;
            this.cb_Sortby.Size = new System.Drawing.Size(125, 18);
            this.cb_Sortby.TabIndex = 6;
            this.cb_Sortby.onItemSelected += new System.EventHandler(this.cb_Sortby_onItemSelected);
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
        private System.Windows.Forms.Label lb_AllPl_Title;
        private System.Windows.Forms.FlowLayoutPanel FLP_videoplaylist;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuDropdown cb_Sortby;
    }
}