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
    public partial class form_Music_AllPlaylist : Form
    {
        private Music_Playlist listpl;

        Form_Muvip parent;

        public form_Music_AllPlaylist(Form_Muvip parent)
        {
            this.parent = parent;
            InitializeComponent();
            string sqlQuery = "USP_Playlist @ID_Acc";
            DataTable result = DataProvider.Instance.ExecuteQuery(sqlQuery, new object[] { parent.ID_Account });
            List<Music_Playlist> listpl = new List<Music_Playlist>();
            for (int i = 0; i < result.Rows.Count; i++) 
            {
                listpl.Add(new Music_Playlist(result.Rows[i].Field<string>(0),result.Rows[i].Field<int>(1)));
                FLP_playlist.Controls.Add(listpl[i]);
            }
        }

        private void cb_Sortby_onItemSelected(object sender, EventArgs e)
        {

        }

        private void music_Playlist1_Load(object sender, EventArgs e)
        {

        }
    }
}
