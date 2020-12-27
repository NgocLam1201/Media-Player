namespace MuViPApp
{
    partial class Form_Liked_Video
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
            this.lb_My_Video = new System.Windows.Forms.Label();
            this.pn_Liked_Video = new System.Windows.Forms.Panel();
            this.pn_Top.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_Top
            // 
            this.pn_Top.Controls.Add(this.lb_My_Video);
            this.pn_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_Top.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.pn_Top.Location = new System.Drawing.Point(0, 0);
            this.pn_Top.Name = "pn_Top";
            this.pn_Top.Size = new System.Drawing.Size(800, 88);
            this.pn_Top.TabIndex = 2;
            // 
            // lb_My_Video
            // 
            this.lb_My_Video.AutoSize = true;
            this.lb_My_Video.Font = new System.Drawing.Font("Microsoft Tai Le", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_My_Video.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lb_My_Video.Location = new System.Drawing.Point(47, 25);
            this.lb_My_Video.Name = "lb_My_Video";
            this.lb_My_Video.Size = new System.Drawing.Size(226, 47);
            this.lb_My_Video.TabIndex = 0;
            this.lb_My_Video.Text = "Liked Videos";
            // 
            // pn_Liked_Video
            // 
            this.pn_Liked_Video.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_Liked_Video.Location = new System.Drawing.Point(0, 88);
            this.pn_Liked_Video.Name = "pn_Liked_Video";
            this.pn_Liked_Video.Size = new System.Drawing.Size(800, 362);
            this.pn_Liked_Video.TabIndex = 3;
            // 
            // Form_Liked_Video
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(33)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pn_Liked_Video);
            this.Controls.Add(this.pn_Top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Liked_Video";
            this.Text = "Form_Liked_Video";
            this.pn_Top.ResumeLayout(false);
            this.pn_Top.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn_Top;
        private System.Windows.Forms.Label lb_My_Video;
        private System.Windows.Forms.Panel pn_Liked_Video;
    }
}