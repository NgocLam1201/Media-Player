namespace MuViPApp
{
    partial class Form_Delete
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
            this.title = new System.Windows.Forms.Label();
            this.btn_cancel = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_ok = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.title.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.Purple;
            this.title.Location = new System.Drawing.Point(33, 19);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(224, 19);
            this.title.TabIndex = 28;
            this.title.Text = "Do you sure you want to delete ";
            // 
            // btn_cancel
            // 
            this.btn_cancel.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_cancel.BackColor = System.Drawing.Color.Thistle;
            this.btn_cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_cancel.BorderRadius = 0;
            this.btn_cancel.ButtonText = "Cancel";
            this.btn_cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancel.DisabledColor = System.Drawing.Color.Gray;
            this.btn_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.ForeColor = System.Drawing.Color.Purple;
            this.btn_cancel.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_cancel.Iconimage = null;
            this.btn_cancel.Iconimage_right = null;
            this.btn_cancel.Iconimage_right_Selected = null;
            this.btn_cancel.Iconimage_Selected = null;
            this.btn_cancel.IconMarginLeft = 0;
            this.btn_cancel.IconMarginRight = 0;
            this.btn_cancel.IconRightVisible = true;
            this.btn_cancel.IconRightZoom = 0D;
            this.btn_cancel.IconVisible = true;
            this.btn_cancel.IconZoom = 90D;
            this.btn_cancel.IsTab = false;
            this.btn_cancel.Location = new System.Drawing.Point(221, 103);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Normalcolor = System.Drawing.Color.Thistle;
            this.btn_cancel.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_cancel.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_cancel.selected = false;
            this.btn_cancel.Size = new System.Drawing.Size(78, 29);
            this.btn_cancel.TabIndex = 32;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_cancel.Textcolor = System.Drawing.Color.Purple;
            this.btn_cancel.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_ok
            // 
            this.btn_ok.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_ok.BackColor = System.Drawing.Color.Purple;
            this.btn_ok.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_ok.BorderRadius = 0;
            this.btn_ok.ButtonText = "OK";
            this.btn_ok.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ok.DisabledColor = System.Drawing.Color.Gray;
            this.btn_ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ok.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_ok.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_ok.Iconimage = null;
            this.btn_ok.Iconimage_right = null;
            this.btn_ok.Iconimage_right_Selected = null;
            this.btn_ok.Iconimage_Selected = null;
            this.btn_ok.IconMarginLeft = 0;
            this.btn_ok.IconMarginRight = 0;
            this.btn_ok.IconRightVisible = true;
            this.btn_ok.IconRightZoom = 0D;
            this.btn_ok.IconVisible = true;
            this.btn_ok.IconZoom = 90D;
            this.btn_ok.IsTab = false;
            this.btn_ok.Location = new System.Drawing.Point(90, 103);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Normalcolor = System.Drawing.Color.Purple;
            this.btn_ok.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_ok.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_ok.selected = false;
            this.btn_ok.Size = new System.Drawing.Size(78, 29);
            this.btn_ok.TabIndex = 31;
            this.btn_ok.Text = "OK";
            this.btn_ok.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_ok.Textcolor = System.Drawing.Color.White;
            this.btn_ok.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Purple;
            this.label1.Location = new System.Drawing.Point(32, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 17);
            this.label1.TabIndex = 33;
            this.label1.Text = "If you click \"OK\", it won\'t be on this device anymore.";
            // 
            // Form_Delete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(381, 159);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.title);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_ok);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form_Delete";
            this.Text = "MuVipApp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuFlatButton btn_cancel;
        public Bunifu.Framework.UI.BunifuFlatButton btn_ok;
        public System.Windows.Forms.Label title;
        public System.Windows.Forms.Label label1;
    }
}