using MuViPApp.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuViPApp.Music
{
    public class PlayListInfo
    {
        private static PlayListInfo instance;

        public static PlayListInfo Instance
        {
            get { if (instance == null) instance = new PlayListInfo(); return PlayListInfo.instance; }
            private set { PlayListInfo.instance = value; }
        }

        private PlayListInfo() { }

        public List<Music_Song> GetListMusic(string ID_Playlist)
        {
            List<Music_Song> ListSong = new List<Music_Song>();
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM Music WHERE ID_Playlist = " + ID_Playlist);

            foreach (DataRow item in data.Rows)
            {
                Music_Song info = new Music_Song(item);
                ListSong.Add(info);
            }
            return ListSong;
        }
    }
}
