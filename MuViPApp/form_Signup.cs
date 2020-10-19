using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MuViPApp
{
    public partial class form_Signup : Form
    {
        public Form parent;
        public form_Signup()
        {
            InitializeComponent();
        }

        public form_Signup(Form parent)
        {
            this.parent = parent;
            InitializeComponent();
        }

        private void btn_SignUp_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Signup_Click(object sender, EventArgs e)
        {
            if (SignUp(tb_SignUp_UserName.Text, tb_Signup_PassWord.Text, tb_SignUp_RePass.Text))
            {
                Account.Instance.SignUp(tb_SignUp_UserName.Text, tb_Signup_PassWord.Text);
                this.Close();
                this.parent.Show();
            }
        }

        private bool SignUp(string email, string password, string rePass)
        {
            if (!Account.Instance.isLengthLargeThanEight(password))
            {
                ShowError("Your password must be more than 8 characters long");
                return false;
            }
            if (!Account.Instance.CheckInput(email, password))
            {
                ShowError("Please enter a valid email address or password");
                return false;
            }
            if (!Account.Instance.CheckRePassword(password, rePass))
            {
                ShowError("Your password is not match. Please try again");
                return false;
            }
            if (Account.Instance.isEmailExist(email))
            {
                ShowError("That email is already in use. Please try again");
                return false;
            }
            return true;
        }

        private void ShowError(string text)
        {
            MessageBox.Show(text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void txtEmail_Click(object sender, EventArgs e)
        {
            tb_SignUp_UserName.Clear();
        }

        private void Form_Signup_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.parent.Show();
        }

        private void Form_Signup_Load(object sender, EventArgs e)
        {
            this.parent.Hide();
        }
    }
}
