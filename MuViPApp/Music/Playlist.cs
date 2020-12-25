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

        string path = @"Playlist.txt";

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
                    for (int i = 2; i < words.Length; i++)
                    {
                        if (File.Exists(words[i]))
                            playListInfo.AddItems(new Music_Song(words[i]));
                    }
                    AddItems(playListInfo);
                }
                sr.Close();
            }
        }

        public void AddItems(PlayListInfo item)
        {
            Listmusic.Add(item);
            using (StreamWriter sw = new StreamWriter(path, true))
            {
                sw.Write(item.Name_PL + '\t' + item.Date_Create + '\t');
                for (int i = 0; i < item.GetMusic().Count; i++)
                {
                    sw.Write(item.GetMusic(i).Link_Music + '\t');
                }
                sw.WriteLine();
                sw.Close();
            }
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
