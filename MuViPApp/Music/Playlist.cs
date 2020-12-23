using MuViPApp.Music;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuViPApp
{
    class Playlist
    {

        private static Playlist instance;

        public static Playlist Instance
        {
            get { if (instance == null) instance = new Playlist(); return instance; }
            private set { instance = value; }
        }

        private List<PlayListInfo> Listmusic = new List<PlayListInfo>();

        public void AddItems(PlayListInfo item)
        {
            Listmusic.Add(item);
        }

        public List<PlayListInfo> GetAllPlayListMusic()
        {
            return Listmusic;
        }

        public PlayListInfo GetListMusic(int index)
        {
            return Listmusic[index];
        }

        public void Remove()
        {
            Listmusic.Clear();
        }

        public void Remove(int index)
        {
            Listmusic.RemoveAt(index);
        }
    }
}
