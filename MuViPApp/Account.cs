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
            /*//xac dinh duong dan den database 
            String connString = @"Server=DESKTOP-PNMDCU1\SQLEXPRESS;Database=MuvidApp;User Id=sa;Password=0337651201;";

            //ket noi csdl bang Sqlconnection 
            SqlConnection connection = new SqlConnection(connString);
            connection.Open();

            //Chuan bi cau lenh query viet bang SQL 
            String sqlQuery = "select * from Account";
            //Tao mot Sqlcommand de thuc hien cau lenh truy van da chuan bi voi ket noi hien tai 
            SqlCommand command = new SqlCommand(sqlQuery, connection);

            //Thuc hien cau truy van va nhan ve mot doi tuong reader ho tro do du lieu
            SqlDataReader reader = command.ExecuteReader();

            //Su dung reader de doc tung dong du lieu //va thuc hien thao tac xu ly mong muon voi du lieu doc len 
            while (reader.HasRows)
            {
                if (reader.Read() == false) break;
                if (email == reader.GetString(1) && GetMD5(password) == reader.GetString(2))
                    return true;
            }
            return false;*/
            
            string query = "USP_Login @email , @passWord";

            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { email, MD5Hash(password) });

            return result.Rows.Count > 0;
        }
        public void SignUp(string email, string password)
        {
            string constr = @"Server=DESKTOP-PNMDCU1\SQLEXPRESS;Database=MuvidApp;User Id=sa;Password=0337651201;";
            SqlConnection connection = new SqlConnection(constr);
            connection.Open();
            try
            {
                //Chuan bi cau lenh query viet bang SQL
                String sqlQuery = "Insert into Account(ID_Account,Username,Password) value (@ID_Acc,@email,@password)";
                //Tao mot Sqlcommand de thuc hien cau lenh truy van da chuan bi voi ket noi hien tai
                SqlCommand command = new SqlCommand(sqlQuery, connection);
                string ID_Acc ="";
                ID_Acc += RandomString(1,true);
                password = MD5Hash(password);
                command.Parameters.AddWithValue("@ID_Acc", "ID_Account");
                command.Parameters.AddWithValue("@email", "Username");
                command.Parameters.AddWithValue("@password", "Password");
                //Thuc hien cau truy van
                int rs = command.ExecuteNonQuery();
                //Su dung reader de doc tung dong du lieu
                //va thuc hien thao tac xu ly mong muon voi du lieu doc len
                if (rs != 1)
                {
                    throw new Exception("Failed Query");
                }
            }
            catch (Exception ex)
            {
                //xu ly khi ket noi co van de
                MessageBox.Show("Failed!");
            }
            finally
            {
                //Dong ket noi sau khi thao tac ket thuc
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
        {/*
            string query = "USP_Login @email";

            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { email });

            return result.Rows.Count > 0;*/
            String connString = @"Server=DESKTOP-PNMDCU1\SQLEXPRESS;Database=MuvidApp;User Id=sa;Password=0337651201;";

            SqlConnection connection = new SqlConnection(connString);
            connection.Open();

            String sqlQuery = "select * from Account";
            SqlCommand command = new SqlCommand(sqlQuery, connection);

            //Thuc hien cau truy van va nhan ve mot doi tuong reader ho tro do du lieu
            SqlDataReader reader = command.ExecuteReader();

            //Su dung reader de doc tung dong du lieu //va thuc hien thao tac xu ly mong muon voi du lieu doc len 
            while (reader.HasRows)
            {
                if (reader.Read() == false) break;
                if (email == reader.GetString(1))
                    return true;
            }
            return false;
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