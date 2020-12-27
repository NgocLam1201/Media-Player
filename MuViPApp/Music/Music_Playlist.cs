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

        private string namePlay;
        public string NamePlay
        {
            get { return namePlay; }
            set { namePlay = value; }
        }

        private int number_song;
        public int Number_song
        {
            get { return number_song; }
            set { number_song = value; }
        }
        ContextMenuStrip contextMenuStrip = new ContextMenuStrip();

        public Form_Muvip parent;

        public Music_Playlist(Form_Muvip parent = null)
        {
            InitializeComponent();
            contextMenuStrip.Items.Add("Delete");
            contextMenuStrip.ItemClicked += (s, e) =>
             {
                 Playlist.Instance.Remove(Number_song);
                 Playlist.Instance.Export();
             };
            this.ContextMenuStrip = contextMenuStrip;

        }

        public Music_Playlist(int ID_Playlist, string NamePlay, int total, Form_Muvip parent = null)
        {
            InitializeComponent();
            this.parent = parent;
            this.ID_Playlist = ID_Playlist;
            this.NamePlay = NamePlay;
            lb_Playlist_Name.Text = this.NamePlay;
            this.Number_song = total;
            lb_Number_Of_Song.Text += ": " + this.Number_song.ToString();
        }

        private void Music_Playlist_Click(object sender, EventArgs e)
        {
            this.parent.openChildForm(new form_Music_Playlist(this));
        }
    }
}
