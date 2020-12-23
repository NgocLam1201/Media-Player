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

        public PlayListInfo(string name_PL = null) 
        {
            Name_PL = name_PL;
        }

        private string name_PL;
        public string Name_PL
        {
            get { return name_PL; }
            set { name_PL = value; }
        }

        private List<Music_Song> Listmusic = new List<Music_Song>();

        public void AddItems(Music_Song item)
        {
            Listmusic.Add(item);
        }

        public List<Music_Song> GetMusic()
        {
            return Listmusic;
        }

        public Music_Song GetMusic(int index)
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
