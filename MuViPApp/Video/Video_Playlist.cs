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
    public partial class Video_Playlist : UserControl
    {
        private static Video_Playlist instance;
        private int iD_Playlist;
        private string namePlay;
        private int number_video;
        public Form_Muvip parent;

        public static Video_Playlist Instance
        {
            get { if (instance == null) instance = new Video_Playlist(); return Video_Playlist.instance; }
            private set { Video_Playlist.instance = value; }
        }

        public int ID_Playlist
        {
            get { return iD_Playlist; }
            set { iD_Playlist = value; }
        }

        public string NamePlay
        {
            get { return namePlay; }
            set { namePlay = value; }
        }

        public int Number_video
        {
            get { return number_video; }
            set { number_video = value; }
        }

        ContextMenuStrip contextMenuStrip = new ContextMenuStrip();


        public Video_Playlist(Form_Muvip parent = null)
        {
            InitializeComponent();
            contextMenuStrip.Items.Add("Delete");
            contextMenuStrip.ItemClicked += (s, e) =>
            {
                PlaylistVideo.Instance.Remove(Number_song);
                PlaylistVideo.Instance.Export();
                this.parent.openChildForm(new form_Music_AllPlaylist());
            };
            this.ContextMenuStrip = contextMenuStrip;

        }
        private int number_song;
        public int Number_song
        {
            get { return number_song; }
            set { number_song = value; }
        }
        public Video_Playlist(int ID_Playlist, string NamePlay, int total, Form_Muvip parent = null)
        {
            InitializeComponent();
            this.parent = parent;
            this.ID_Playlist = ID_Playlist;
            this.NamePlay = NamePlay;
            lb_Playlist_Name.Text = this.NamePlay;
            this.Number_song = total;
            lb_Number_Of_Video.Text += ": " + this.Number_song.ToString();
            contextMenuStrip.Items.Add("Delete");
            contextMenuStrip.ItemClicked += (s, e) =>
            {
                Playlist.Instance.Remove(Number_song);
                Playlist.Instance.Export();
                this.parent.openChildForm(new form_Music_AllPlaylist());
            };
            this.ContextMenuStrip = contextMenuStrip;

        }

        
        private void Video_Playlist_Click(object sender, EventArgs e)
        {
            this.parent.openChildForm(new Form_Video_Playlist(this));
        }
    }
}
