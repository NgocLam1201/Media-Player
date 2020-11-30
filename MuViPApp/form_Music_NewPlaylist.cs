using MuViPApp.DAO;
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
    public partial class form_Music_NewPlaylist : Form
    {
        Form_Muvip parent;
        public form_Music_NewPlaylist(Form_Muvip parent)
        {
            this.parent = parent;
            InitializeComponent();
        }
  
        private void btn_Ok_Click(object sender, EventArgs e)
        {
            if (tb_Name.Text == "")
                MessageBox.Show("Enter a playlist's name","Notify");
            else
            {
                string query = @"select count(ID_Playlist) from Playlist where ID_Account = '" + this.parent.ID_Account+@"'";
                DataTable result = DataProvider.Instance.ExecuteQuery(query);
                string ID = "Pl";
                if (result.Rows.Count + 1 < 10)
                {
                    ID += "0" + result.Rows.Count + 1;
                }
                else
                    ID += (result.Rows.Count + 1).ToString();
                query = @"insert into Playlist values('" + this.parent.ID_Account + @"','" + ID + @"',N'" + this.tb_Name.Text + @"',null,GETDATE(),'Music')";
                DataProvider.Instance.ExecuteNonQuery(query);
                form_Music_Playlist NewForm = new form_Music_Playlist(new Music_Playlist(ID,this.tb_Name.Text,0,this.parent));
                this.parent.openChildForm(NewForm);
                this.Close();
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }     
    }
}
