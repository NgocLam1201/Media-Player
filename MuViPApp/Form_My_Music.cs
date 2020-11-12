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
    public partial class Form_My_Music : Form
    {
        public Form_My_Music()
        {
            InitializeComponent();

            String connString = @"Server=ADMIN\SQLEXPRESS;Database=MuViPApp;User Id=sa;Password=0337651201;";

            SqlConnection connection = new SqlConnection(connString);
            connection.Open();

            String sqlQuery = " select Name_Song, Singer, Name_Genre, Date_Add, Size " +
                              " from Music join Genre on Music.ID_Genre = Genre.ID_Genre ";
            SqlCommand command = new SqlCommand(sqlQuery, connection);

            SqlDataReader reader = command.ExecuteReader();

            while (reader.HasRows)
            {
                if (reader.Read() == false) break;
                var items = new ListViewItem(new[] { reader.GetString(0), reader.GetString(1), reader.GetString(2)});
                lv_My_Music.Items.Add(items);
            }

            connection.Close();
        }
    }
}
