using MuViPApp.DAO;
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
            string query = "USP_AllMusic";

            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] {});

            for (int i = 0;i < result.Rows.Count; i++)
            {
                string[] date = result.Rows[i].Field<DateTime>(3).ToString().Split(' ');
                ListViewItem items = new ListViewItem(new[] { result.Rows[i].Field<string>(0), 
                                                            result.Rows[i].Field<string>(1), 
                                                            result.Rows[i].Field<string>(2),
                                                            date[0],
                                                            result.Rows[i].Field<TimeSpan>(4).ToString()});
                lv_My_Music.Items.Add(items);
            }

            
        }
    }
}
