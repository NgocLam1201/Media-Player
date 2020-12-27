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

        public form_Music_AllPlaylist(Form_Muvip parent = null)
        {
            this.parent = parent;
            InitializeComponent();
            ShowPlayList();
        }

        void ShowPlayList()
        {
            FLP_playlist.Controls.Clear();
            List<Music_Playlist> listpl = new List<Music_Playlist>();
            for (int i = 0; i < Playlist.Instance.GetAllPlayListMusic().Count; i++)
            {
                PlayListInfo Playlistmusic = Playlist.Instance.GetListMusic(i);
                Music_Playlist music_Playlist = new Music_Playlist(i,Playlistmusic.Name_PL, Playlistmusic.GetMusic().Count,this.parent);
                music_Playlist.Dock = DockStyle.Top;
                listpl.Add(music_Playlist);
                FLP_playlist.Controls.Add(listpl[i]);
            }
        }

        #region Events
        private void cb_Sortby_onItemSelected(object sender, EventArgs e)
        {
            switch (cb_Sortby.selectedIndex)
            {
                case 0:
                    List<PlayListInfo> listInfos = Playlist.Instance.GetAllPlayListMusic().OrderBy(L => L.Name_PL).ToList();
                    Playlist.Instance.Remove();
                    foreach (PlayListInfo item in listInfos)
                    {
                        Playlist.Instance.AddItems(item);
                    }
                    break;
                case 1:
                    List<PlayListInfo> All_ListPl_Sortby_Date = Playlist.Instance.GetAllPlayListMusic().OrderBy(L => L.Date_Create).ToList();
                    Playlist.Instance.Remove();
                    foreach (PlayListInfo item in All_ListPl_Sortby_Date)
                    {
                        Playlist.Instance.AddItems(item);
                    }
                    break;
            }
            Playlist.Instance.Export();
            ShowPlayList();
        }
        #endregion
    }
}
