using MuViPApp.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MuViPApp
{
    class Account
    {
        private static Account instance;
        public static Account Instance
        {
            get { if (instance == null) instance = new Account(); return instance; }
            private set { instance = value; }
        }
        public static string MD5Hash(string input)
        {
            StringBuilder hash = new StringBuilder();
            MD5CryptoServiceProvider md5provider = new MD5CryptoServiceProvider();
            byte[] bytes = md5provider.ComputeHash(new UTF8Encoding().GetBytes(input));

            for (int i = 0; i < bytes.Length; i++)
            {
                hash.Append(bytes[i].ToString("x2"));
            }
            return hash.ToString();
        }

        public bool Login(string email, string password)
        {            
            string query = "USP_Login @email , @passWord";

            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { email, MD5Hash(password) });

            return result.Rows.Count > 0;
        }
        public void SignUp(string email, string password)
        {
            string constr = @"Server=ADMIN\SQLEXPRESS;Database=MuViPApp;User Id=sa;Password=0337651201;";
            SqlConnection connection = new SqlConnection(constr);
            connection.Open();
            try
            {
                string ID_Acc ="AC";
                int a = 0;
                string query = "select count(*) from Account";
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.HasRows)
                {
                    if (!reader.Read()) 
                        break;
                    a = reader.GetInt32(0) + 1;
                }
                if (a < 10)
                {
                    ID_Acc += '0' + a.ToString();
                }
                else
                    ID_Acc += a.ToString();
                connection.Close();
                connection.Open();
                password = MD5Hash(password);
                String sqlQuery = @"Insert into Account(ID_Account,Username,Password) values (N'"+ID_Acc + @"',N'"+ email + @"',N'"+ @password + @"')";
                SqlCommand command = new SqlCommand(sqlQuery, connection);
                command.ExecuteNonQuery();
            }
            finally
            {
                connection.Close();
            }
        }

        public bool CheckInput(string email, string password)
        {
            if (!email.Contains('@'))
                return false;
            if (email.Contains('|') || password.Contains('|'))
                return false;
            return true;
        }
        public bool CheckRePassword(string pass, string rePass)
        {
            if (String.Compare(pass, rePass) != 0)
                return false;
            return true;
        }
        public bool isEmailExist(string email)
        {
            string query = "USP_Check_Email @email";

            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { email });

            return result.Rows.Count > 0;
        }

        public bool isLengthLargeThanEight(string pass)
        {
            return (pass.Length >= 8);
        }

        public string RandomString(int size, bool lowerCase)
        {
            StringBuilder sb = new StringBuilder();
            char c;
            Random rand = new Random();
            for (int i = 0; i < size; i++)
            {
                c = Convert.ToChar(Convert.ToInt32(rand.Next(65, 90)));
                sb.Append(c);
            }

            if (lowerCase)
            {
                return sb.ToString().ToLower();
            }

            for (int i = 0; i < 4 - size; i++)
            {
                c = Convert.ToChar(Convert.ToInt32(rand.Next(30, 39)));
                sb.Append(c);
            }
            return sb.ToString();
        }
    }
}