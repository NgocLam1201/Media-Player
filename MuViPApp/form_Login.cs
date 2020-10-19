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
    public partial class form_Login : Form
    {
        public Form_Muvip parent;

        public form_Login()
        {
            InitializeComponent();
        }

        public form_Login(Form_Muvip parent)
        {
            this.parent = parent;
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (Login(tb_Login_UserName.Text, tb_Login_PassWord.Text)) 
            {
                this.parent.btn_User.Visible = true;
                this.parent.btn_Login.Visible = false;
                this.Close();
            }
            else
            {
                MessageBox.Show("The e-mail or password that you've entered is incorrect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool Login(string email, string password)
        {
            return Account.Instance.Login(email, password);
        }

        private void lb_Login_Signup_Click(object sender, EventArgs e)
        {
            form_Signup frmSignUp = new form_Signup(this);
            frmSignUp.ShowDialog();
        }

        private void btn_Login_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
