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

        public form_Music_AllPlaylist(Form_Muvip parent)
        {
            this.parent = parent;
            InitializeComponent();
            ShowPlayList(this.parent.ID_Account);
        }

        void ShowPlayList(string ID)
        {
            List<Music_Playlist> listpl = new List<Music_Playlist>();
            for (int i = 0; i < Playlist.Instance.GetAllPlayListMusic().Count; i++)
            {
                PlayListInfo Playlistmusic = Playlist.Instance.GetListMusic(i);
                Music_Playlist music_Playlist = new Music_Playlist(i,Playlistmusic.Name_PL, Playlistmusic.GetMusic().Count,this.parent);
                listpl.Add(music_Playlist);
                FLP_playlist.Controls.Add(listpl[i]);
            }
        }

        #region Events

        #endregion

    }
}
