using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MuViPApp
{
    public partial class Music_Playlist : UserControl
    {
        private string iD_Playlist;
        public string ID_Playlist
        { 
            get { return iD_Playlist; } 
            set { iD_Playlist = value; } 
        }
        private static Music_Playlist instance;

        public static Music_Playlist Instance
        {
            get { if (instance == null) instance = new Music_Playlist(); return Music_Playlist.instance; }
            private set { Music_Playlist.instance = value; }
        }

        public Music_Playlist()
        {
            InitializeComponent();
        }

        public Music_Playlist(string ID_Playlist, string name, int total)
        {
            InitializeComponent();
            this.ID_Playlist = ID_Playlist;
            lb_Playlist_Name.Text = name;
            lb_Number_Of_Song.Text += ": " + total.ToString();
        }

        private void Music_Playlist_Click(object sender, EventArgs e)
        {
            
        }
    }
}
