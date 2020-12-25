using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MuViPApp.Video;

namespace MuViPApp
{
    public partial class form_Video_AllPlaylist : Form
    {
        Form_Muvip parent;
        public form_Video_AllPlaylist(Form_Muvip parent)
        {
            this.parent = parent;
            InitializeComponent();
        }

        void ShowPlayList()
        {
            FLP_playlist_video.Controls.Clear();
            List<Video_Playlist> listpl = new List<Video_Playlist>();
            for (int i = 0; i < PlaylistVideo.Instance.GetAllPlayListVideo().Count; i++)
            {
                PlayListInfoVideo Playlistvideo = PlaylistVideo.Instance.GetListVideo(i);
                Music_Playlist music_Playlist = new Music_Playlist(i, Playlistvideo.Name_PL, Playlistvideo.GetVideo().Count, this.parent);
                listpl.Add(Video_Playlist);
                FLP_playlist_video.Controls.Add(listpl[i]);
            }
        }
    }
}
