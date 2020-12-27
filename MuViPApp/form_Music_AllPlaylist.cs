using MuViPApp.Music;
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
        Form_Muvip parent;
        List<Music_Playlist> listpl = new List<Music_Playlist>();
        public form_Music_AllPlaylist(Form_Muvip parent = null)
        {
            this.parent = parent;
            InitializeComponent();
            ShowPlayList();
        }

        void ShowPlayList()
        {
            FLP_playlist.Controls.Clear();
            listpl.Clear();
            for (int i = 0; i < Playlist.Instance.GetAllPlayListMusic().Count; i++)
            {
                PlayListInfo Playlistmusic = Playlist.Instance.GetListMusic(i);
                Music_Playlist music_Playlist = new Music_Playlist(i,Playlistmusic.Name_PL, Playlistmusic.GetMusic().Count,this.parent);
                listpl.Add(music_Playlist);
                FLP_playlist.Controls.Add(listpl[i]);
            }
        }

        #region Events
        private void cb_Sortby_onItemSelected(object sender, EventArgs e)
        {
            List<PlayListInfo> listInfos = Playlist.Instance.GetAllPlayListMusic();
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
            Playlist.Instance.Remove();
            foreach (PlayListInfo item in listInfos)
            {
                Playlist.Instance.AddItems(item);
            }
            Playlist.Instance.Export();
            ShowPlayList();
        }
        #endregion
    }
}
