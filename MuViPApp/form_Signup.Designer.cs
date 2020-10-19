namespace MuViPApp
{
    partial class form_Signup
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.signuppass = new System.Windows.Forms.Label();
            this.signupuser = new System.Windows.Forms.Label();
            this.tb_SignUp_RePass = new System.Windows.Forms.TextBox();
            this.tb_Signup_PassWord = new System.Windows.Forms.TextBox();
            this.tb_SignUp_UserName = new System.Windows.Forms.TextBox();
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btn_SignUp_Cancel = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_Signup = new Bunifu.Framework.UI.BunifuFlatButton();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Purple;
            this.label1.Location = new System.Drawing.Point(103, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 73);
            this.label1.TabIndex = 22;
            this.label1.Text = "Sign Up";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Purple;
            this.label2.Location = new System.Drawing.Point(21, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "Confirm password";
            // 
            // signuppass
            // 
            this.signuppass.AutoSize = true;
            this.signuppass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signuppass.ForeColor = System.Drawing.Color.Purple;
            this.signuppass.Location = new System.Drawing.Point(21, 159);
            this.signuppass.Name = "signuppass";
            this.signuppass.Size = new System.Drawing.Size(68, 16);
            this.signuppass.TabIndex = 20;
            this.signuppass.Text = "Password";
            // 
            // signupuser
            // 
            this.signupuser.AutoSize = true;
            this.signupuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signupuser.ForeColor = System.Drawing.Color.Purple;
            this.signupuser.Location = new System.Drawing.Point(21, 121);
            this.signupuser.Name = "signupuser";
            this.signupuser.Size = new System.Drawing.Size(71, 16);
            this.signupuser.TabIndex = 19;
            this.signupuser.Text = "Username";
            // 
            // tb_SignUp_RePass
            // 
            this.tb_SignUp_RePass.Location = new System.Drawing.Point(151, 196);
            this.tb_SignUp_RePass.Name = "tb_SignUp_RePass";
            this.tb_SignUp_RePass.PasswordChar = '•';
            this.tb_SignUp_RePass.Size = new System.Drawing.Size(233, 20);
            this.tb_SignUp_RePass.TabIndex = 18;
            // 
            // tb_Signup_PassWord
            // 
            this.tb_Signup_PassWord.Location = new System.Drawing.Point(151, 158);
            this.tb_Signup_PassWord.Name = "tb_Signup_PassWord";
            this.tb_Signup_PassWord.PasswordChar = '•';
            this.tb_Signup_PassWord.Size = new System.Drawing.Size(233, 20);
            this.tb_Signup_PassWord.TabIndex = 17;
            // 
            // tb_SignUp_UserName
            // 
            this.tb_SignUp_UserName.Location = new System.Drawing.Point(151, 121);
            this.tb_SignUp_UserName.Name = "tb_SignUp_UserName";
            this.tb_SignUp_UserName.Size = new System.Drawing.Size(233, 20);
            this.tb_SignUp_UserName.TabIndex = 16;
            this.tb_SignUp_UserName.Click += new System.EventHandler(this.txtEmail_Click);
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 5;
            this.bunifuElipse2.TargetControl = this;
            // 
            // btn_SignUp_Cancel
            // 
            this.btn_SignUp_Cancel.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_SignUp_Cancel.BackColor = System.Drawing.Color.Thistle;
            this.btn_SignUp_Cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_SignUp_Cancel.BorderRadius = 0;
            this.btn_SignUp_Cancel.ButtonText = "Cancel";
            this.btn_SignUp_Cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_SignUp_Cancel.DisabledColor = System.Drawing.Color.Gray;
            this.btn_SignUp_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SignUp_Cancel.ForeColor = System.Drawing.Color.Purple;
            this.btn_SignUp_Cancel.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_SignUp_Cancel.Iconimage = null;
            this.btn_SignUp_Cancel.Iconimage_right = null;
            this.btn_SignUp_Cancel.Iconimage_right_Selected = null;
            this.btn_SignUp_Cancel.Iconimage_Selected = null;
            this.btn_SignUp_Cancel.IconMarginLeft = 0;
            this.btn_SignUp_Cancel.IconMarginRight = 0;
            this.btn_SignUp_Cancel.IconRightVisible = true;
            this.btn_SignUp_Cancel.IconRightZoom = 0D;
            this.btn_SignUp_Cancel.IconVisible = true;
            this.btn_SignUp_Cancel.IconZoom = 90D;
            this.btn_SignUp_Cancel.IsTab = false;
            this.btn_SignUp_Cancel.Location = new System.Drawing.Point(263, 251);
            this.btn_SignUp_Cancel.Name = "btn_SignUp_Cancel";
            this.btn_SignUp_Cancel.Normalcolor = System.Drawing.Color.Thistle;
            this.btn_SignUp_Cancel.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_SignUp_Cancel.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_SignUp_Cancel.selected = false;
            this.btn_SignUp_Cancel.Size = new System.Drawing.Size(78, 29);
            this.btn_SignUp_Cancel.TabIndex = 24;
            this.btn_SignUp_Cancel.Text = "Cancel";
            this.btn_SignUp_Cancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_SignUp_Cancel.Textcolor = System.Drawing.Color.Purple;
            this.btn_SignUp_Cancel.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SignUp_Cancel.Click += new System.EventHandler(this.btn_SignUp_Cancel_Click);
            // 
            // btn_Signup
            // 
            this.btn_Signup.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_Signup.BackColor = System.Drawing.Color.Purple;
            this.btn_Signup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Signup.BorderRadius = 0;
            this.btn_Signup.ButtonText = "Sign Up";
            this.btn_Signup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Signup.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Signup.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Signup.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Signup.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Signup.Iconimage = null;
            this.btn_Signup.Iconimage_right = null;
            this.btn_Signup.Iconimage_right_Selected = null;
            this.btn_Signup.Iconimage_Selected = null;
            this.btn_Signup.IconMarginLeft = 0;
            this.btn_Signup.IconMarginRight = 0;
            this.btn_Signup.IconRightVisible = true;
            this.btn_Signup.IconRightZoom = 0D;
            this.btn_Signup.IconVisible = true;
            this.btn_Signup.IconZoom = 90D;
            this.btn_Signup.IsTab = false;
            this.btn_Signup.Location = new System.Drawing.Point(134, 251);
            this.btn_Signup.Name = "btn_Signup";
            this.btn_Signup.Normalcolor = System.Drawing.Color.Purple;
            this.btn_Signup.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_Signup.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Signup.selected = false;
            this.btn_Signup.Size = new System.Drawing.Size(78, 29);
            this.btn_Signup.TabIndex = 23;
            this.btn_Signup.Text = "Sign Up";
            this.btn_Signup.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Signup.Textcolor = System.Drawing.Color.White;
            this.btn_Signup.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Signup.Click += new System.EventHandler(this.btn_Signup_Click);
            // 
            // form_Signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 319);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.signuppass);
            this.Controls.Add(this.signupuser);
            this.Controls.Add(this.tb_SignUp_RePass);
            this.Controls.Add(this.tb_Signup_PassWord);
            this.Controls.Add(this.tb_SignUp_UserName);
            this.Controls.Add(this.btn_SignUp_Cancel);
            this.Controls.Add(this.btn_Signup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "form_Signup";
            this.Text = "form_Signup";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_Signup_FormClosed);
            this.Load += new System.EventHandler(this.Form_Signup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label signuppass;
        private System.Windows.Forms.Label signupuser;
        private System.Windows.Forms.TextBox tb_SignUp_RePass;
        private System.Windows.Forms.TextBox tb_Signup_PassWord;
        private System.Windows.Forms.TextBox tb_SignUp_UserName;
        private Bunifu.Framework.UI.BunifuFlatButton btn_SignUp_Cancel;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Signup;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
    }
}