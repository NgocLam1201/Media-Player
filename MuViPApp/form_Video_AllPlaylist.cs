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
        List<Video_Playlist> listpl = new List<Video_Playlist>();

        public form_Video_AllPlaylist(Form_Muvip parent = null)
        {
            this.parent = parent;
            InitializeComponent();
            ShowPlayList();
        }

        void ShowPlayList()
        {
            FLP_videoplaylist.Controls.Clear();
            listpl.Clear();
            for (int i = 0; i < PlaylistVideo.Instance.GetAllPlayListVideo().Count; i++)
            {
                PlayListInfoVideo Playlistvideo = PlaylistVideo.Instance.GetListVideo(i);
                Video_Playlist video_Playlist = new Video_Playlist(i, Playlistvideo.Name_PL, Playlistvideo.GetVideo().Count, this.parent);
                listpl.Add(video_Playlist);
                FLP_videoplaylist.Controls.Add(listpl[i]);
            }
        }

        private void cb_Sortby_onItemSelected(object sender, EventArgs e)
        {
            List<PlayListInfoVideo> listInfos = PlaylistVideo.Instance.GetAllPlayListVideo();
            switch (cb_Sortby.selectedIndex)
            {
                case 1:
                    listInfos = listInfos.OrderBy(L => L.Name_PL).ToList();
                    break;
                case 2:
                    listInfos = listInfos.OrderByDescending(L => L.Name_PL).ToList();
                    break;
                case 3:
                    listInfos = listInfos.OrderByDescending(L => L.Date_Create).ToList();
                    break;
                default:
                    listInfos = listInfos.OrderBy(L => L.Date_Create).ToList();
                    break;
            }
            PlaylistVideo.Instance.Remove();
            foreach (PlayListInfoVideo item in listInfos)
            {
                PlaylistVideo.Instance.AddItems(item);
            }
            PlaylistVideo.Instance.Export();
            ShowPlayList();
        }

    }
}
