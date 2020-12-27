using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuViPApp.Music
{
    class ListMusicRecently
    {
        private List<Music_Song> Listmusic = new List<Music_Song>();

        private static ListMusicRecently instance;

        public static ListMusicRecently Instance
        {
            get { if (instance == null) instance = new ListMusicRecently(); return instance; }
            private set { instance = value; }
        }
        string path = @"History_Music_MuVipApp.txt";

        private ListMusicRecently()
        {
            if (File.Exists(path))
            using (StreamReader sr = new StreamReader(path))
            {
                string lines;
                while ((lines = sr.ReadLine()) != null)
                {
                    if (File.Exists(lines))
                        Listmusic.Add(new Music_Song(lines));
                }
            }
            for (int i=0;i<Listmusic.Count/2;i++)
            {
                Music_Song temp = Listmusic[i];
                Listmusic[Listmusic.Count - i - 1] = Listmusic[i];
                Listmusic[i] = temp;
            }    
        }

        public void AddItems(Music_Song item)
        {
            Listmusic.Add(item);
            using (StreamWriter sw = new StreamWriter(path, true))
            {
                sw.WriteLine(item.Link_Music);
                sw.Close();
            }
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
