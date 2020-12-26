using MuViPApp.Music;
using System;
using System.Collections.Generic;
using System.IO;
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

        string path = @"Playlist_Music_MuVipApp.txt";

        public Playlist()
        {
            if (!File.Exists(path))
                File.Create(path);
            using (StreamReader sr = new StreamReader(path))
            {
                string lines;
                PlayListInfo playListInfo = new PlayListInfo();
                while ((lines = sr.ReadLine()) != null)
                {
                    string[] words = lines.Split('\t');
                    playListInfo.Name_PL = words[0];
                    playListInfo.Date_Create = Convert.ToDateTime(words[1]);
                    playListInfo.Import();
                }
                sr.Close();
            }
        }

        public void Export()
        {
            if (File.Exists(path))
                File.Delete(path);
            using (StreamWriter sw = new StreamWriter(path, true))
            {
                foreach (PlayListInfo item in Listmusic)
                {
                    sw.WriteLine(item.Name_PL + '\t' + item.Date_Create);
                }
                sw.Close();
            }
        }

        public void AddItems(PlayListInfo item)
        {
            Listmusic.Add(item);
            item.Export();
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
