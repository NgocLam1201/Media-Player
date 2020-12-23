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
        private static Music_Playlist instance;

        public static Music_Playlist Instance
        {
            get { if (instance == null) instance = new Music_Playlist(); return Music_Playlist.instance; }
            private set { Music_Playlist.instance = value; }
        }

        private int iD_Playlist;
        public int ID_Playlist
        { 
            get { return iD_Playlist; } 
            set { iD_Playlist = value; } 
        }

        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private int number_song;
        public int Number_song
        {
            get { return number_song; }
            set { number_song = value; }
        }

        public Form_Muvip parent;

        public Music_Playlist(Form_Muvip parent = null)
        {
            InitializeComponent();
        }

        public Music_Playlist(int ID_Playlist, string name, int total, Form_Muvip parent = null)
        {
            InitializeComponent();
            this.parent = parent;
            this.ID_Playlist = ID_Playlist;
            this.Name = name;
            lb_Playlist_Name.Text = this.Name;
            this.Number_song = total;
            lb_Number_Of_Song.Text += ": " + this.Number_song.ToString();
        }

        private void Music_Playlist_Click(object sender, EventArgs e)
        {
            this.parent.openChildForm(new form_Music_Playlist(this));
        }
    }
}
