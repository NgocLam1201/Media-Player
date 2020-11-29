using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
                String connString = @"Server=ADMIN\SQLEXPRESS;Database=MuViPApp;User Id=sa;Password=thuytien;";

                SqlConnection connection = new SqlConnection(connString);
                connection.Open();

                String sqlQuery = " select ID_Account, nickname " +
                                  " from Account " +
                                  " where Username = '" + tb_Login_UserName.Text +"'";
                SqlCommand command = new SqlCommand(sqlQuery, connection);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.HasRows)
                {
                    if (reader.Read() == false) break;
                    string[] user = reader.GetString(1).Split(' ');
                    parent.btn_User.Text = user[user.Length - 1];
                    parent.ID_Account = reader.GetString(0);
                }

                connection.Close();
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
            form_Signup su = new form_Signup();
            Point p = new Point(parent.Width / 2 - su.Width / 2, this.Height / 2 - su.Height / 2);
            su.StartPosition = FormStartPosition.CenterParent;
            su.ShowDialog();
        }

        private void btn_Login_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Login_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}
