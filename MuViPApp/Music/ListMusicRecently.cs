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
            using (StreamWriter sw = new StreamWriter(path, true))
                sw.Close();
            using (StreamReader sr = new StreamReader(path))
            {
                string lines;
                while ((lines = sr.ReadLine()) != null)
                {
                    string[] words = lines.Split('\t');
                    if (File.Exists(words[0]))
                    {
                        Music_Song music_Song = new Music_Song(words[0]);
                        music_Song.Date_Add = words[1];
                        Listmusic.Add(music_Song);
                    }
                }
                sr.Close();
            }
        }

        public void AddItems(Music_Song item)
        {
            item.Date_Add = DateTime.Now.ToString();
            foreach (Music_Song music_Song in Listmusic)
            {
                if (music_Song.Link_Music == item.Link_Music)
                {
                    Listmusic.Remove(music_Song);
                    break;
                }
            }
            Listmusic.Add(item);
            Listmusic = Listmusic.OrderByDescending(L => L.Date_Add).ToList();
            Export();
        }

        public void Export()
        {
            if (File.Exists(path))
                File.Delete(path);
            using (StreamWriter sw = new StreamWriter(path, true))
            {
                foreach (Music_Song item in Listmusic)
                {
                    sw.WriteLine(item.Link_Music + '\t' + item.Date_Add);
                }
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

        public void Remove(Music_Song music_Song)
        {
            for (int i = 0; i < Listmusic.Count; i++)
            {
                if (music_Song.Link_Music == Listmusic[i].Link_Music)
                {
                    Listmusic.RemoveAt(i);
                    break;
                }
            }
        }
    }
}
