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
            ShowPlayList();
        }

        void ShowPlayList()
        {
            FLP_videoplaylist.Controls.Clear();
            List<Video_Playlist> listpl = new List<Video_Playlist>();
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
            switch (cb_Sortby.selectedIndex)
            {
                case 0:
                    List<PlayListInfoVideo> listInfos = PlaylistVideo.Instance.GetAllPlayListVideo().OrderBy(L => L.Name_PL).ToList();
                    PlaylistVideo.Instance.Remove();
                    foreach (PlayListInfoVideo item in listInfos)
                    {
                        PlaylistVideo.Instance.AddItems(item);
                    }
                    break;
                case 1:
                    List<PlayListInfoVideo> All_ListPl_Sortby_Date = PlaylistVideo.Instance.GetAllPlayListVideo().OrderBy(L => L.Date_Create).ToList();
                    PlaylistVideo.Instance.Remove();
                    foreach (PlayListInfoVideo item in All_ListPl_Sortby_Date)
                    {
                        PlaylistVideo.Instance.AddItems(item);
                    }
                    break;
            }
            PlaylistVideo.Instance.Export();
            ShowPlayList();
        }

    }
}
