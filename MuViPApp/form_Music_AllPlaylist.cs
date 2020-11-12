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

        public form_Music_AllPlaylist()
        {
            InitializeComponent();
            String connString = @"Server=ADMIN\SQLEXPRESS;Database=MuViPApp;User Id=sa;Password=0337651201;";

            SqlConnection connection = new SqlConnection(connString);
            connection.Open();

            String sqlQuery = " select Name_Playlist, COUNT(Music.ID_Playlist) as Soluong " +
                              " from Playlist, Music " +
                              " where Playlist.ID_Playlist = Music.ID_Playlist " +
                              " group by Name_Playlist ";
            SqlCommand command = new SqlCommand(sqlQuery, connection);

            SqlDataReader reader = command.ExecuteReader();

            while (reader.HasRows)
            {
                if (reader.Read() == false) break;
                Music_Playlist listpl = new MuViPApp.Music_Playlist(reader.GetString(0), reader.GetInt32(1));
                this.panel3.Controls.Add(listpl);
            }
            connection.Close();
        }

        private void cb_Sortby_onItemSelected(object sender, EventArgs e)
        {

        }

        private void music_Playlist1_Load(object sender, EventArgs e)
        {

        }
    }
}
