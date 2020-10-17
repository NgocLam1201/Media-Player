namespace MuViPApp
{
    partial class form_Music_NewPlaylist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_Music_NewPlaylist));
            this.tb_Name = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btn_Ok = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_Cancel = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.lb_Notice = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_Name
            // 
            this.tb_Name.BorderColor = System.Drawing.Color.SeaGreen;
            this.tb_Name.Location = new System.Drawing.Point(47, 165);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(213, 20);
            this.tb_Name.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(99, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(110, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Astronova", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(92, 136);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(130, 16);
            this.bunifuCustomLabel1.TabIndex = 2;
            this.bunifuCustomLabel1.Text = "Playlist\'s Name";
            // 
            // btn_Ok
            // 
            this.btn_Ok.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_Ok.BackColor = System.Drawing.Color.DarkOrchid;
            this.btn_Ok.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Ok.BorderRadius = 0;
            this.btn_Ok.ButtonText = "OK";
            this.btn_Ok.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Ok.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Ok.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Ok.Iconimage = null;
            this.btn_Ok.Iconimage_right = null;
            this.btn_Ok.Iconimage_right_Selected = null;
            this.btn_Ok.Iconimage_Selected = null;
            this.btn_Ok.IconMarginLeft = 0;
            this.btn_Ok.IconMarginRight = 0;
            this.btn_Ok.IconRightVisible = true;
            this.btn_Ok.IconRightZoom = 0D;
            this.btn_Ok.IconVisible = true;
            this.btn_Ok.IconZoom = 90D;
            this.btn_Ok.IsTab = false;
            this.btn_Ok.Location = new System.Drawing.Point(120, 223);
            this.btn_Ok.Name = "btn_Ok";
            this.btn_Ok.Normalcolor = System.Drawing.Color.DarkOrchid;
            this.btn_Ok.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_Ok.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Ok.selected = false;
            this.btn_Ok.Size = new System.Drawing.Size(65, 27);
            this.btn_Ok.TabIndex = 6;
            this.btn_Ok.Text = "OK";
            this.btn_Ok.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Ok.Textcolor = System.Drawing.Color.White;
            this.btn_Ok.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Ok.Click += new System.EventHandler(this.btn_Ok_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_Cancel.BackColor = System.Drawing.Color.Transparent;
            this.btn_Cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Cancel.BorderRadius = 0;
            this.btn_Cancel.ButtonText = "Cancel";
            this.btn_Cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Cancel.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Cancel.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Cancel.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Cancel.Iconimage = null;
            this.btn_Cancel.Iconimage_right = null;
            this.btn_Cancel.Iconimage_right_Selected = null;
            this.btn_Cancel.Iconimage_Selected = null;
            this.btn_Cancel.IconMarginLeft = 0;
            this.btn_Cancel.IconMarginRight = 0;
            this.btn_Cancel.IconRightVisible = true;
            this.btn_Cancel.IconRightZoom = 0D;
            this.btn_Cancel.IconVisible = true;
            this.btn_Cancel.IconZoom = 90D;
            this.btn_Cancel.IsTab = false;
            this.btn_Cancel.Location = new System.Drawing.Point(120, 256);
            this.btn_Cancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Normalcolor = System.Drawing.Color.Transparent;
            this.btn_Cancel.OnHovercolor = System.Drawing.Color.White;
            this.btn_Cancel.OnHoverTextColor = System.Drawing.Color.Indigo;
            this.btn_Cancel.selected = false;
            this.btn_Cancel.Size = new System.Drawing.Size(65, 27);
            this.btn_Cancel.TabIndex = 7;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Cancel.Textcolor = System.Drawing.Color.GhostWhite;
            this.btn_Cancel.TextFont = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // lb_Notice
            // 
            this.lb_Notice.AutoSize = true;
            this.lb_Notice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Notice.ForeColor = System.Drawing.Color.White;
            this.lb_Notice.Location = new System.Drawing.Point(96, 197);
            this.lb_Notice.Name = "lb_Notice";
            this.lb_Notice.Size = new System.Drawing.Size(0, 15);
            this.lb_Notice.TabIndex = 8;
            // 
            // form_Music_NewPlaylist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(306, 298);
            this.Controls.Add(this.lb_Notice);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Ok);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tb_Name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(189, 0);
            this.Name = "form_Music_NewPlaylist";
            this.Text = "form_Music_NewPlaylist";
            this.Load += new System.EventHandler(this.form_Music_NewPlaylist_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private WindowsFormsControlLibrary1.BunifuCustomTextbox tb_Name;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Ok;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Cancel;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label lb_Notice;
    }
}