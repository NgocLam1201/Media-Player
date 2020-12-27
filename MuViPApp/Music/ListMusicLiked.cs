using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuViPApp.Music
{
    class ListMusicLiked
    {
        private static ListMusicLiked instance;

        public static ListMusicLiked Instance
        {
            get { if (instance == null) instance = new ListMusicLiked(); return instance; }
            private set { instance = value; }
        }

        private List<Music_Song> Listmusic = new List<Music_Song>();

        string path = @"Liked_Music_MuVipApp.txt";

        public ListMusicLiked()
        {
            using (StreamWriter sw = new StreamWriter(path, true))
                sw.Close();
            using (StreamReader sr = new StreamReader(path))
            {
                string lines;
                while ((lines = sr.ReadLine()) != null)
                {
                    if (File.Exists(lines))
                        Listmusic.Add(new Music_Song(lines));
                }
            }
        }

        public void export()
        {
            if (File.Exists(path))
                File.Delete(path);
            using (StreamWriter sw = new StreamWriter(path, true))
            {
                foreach (Music_Song item in Listmusic)
                {
                    sw.WriteLine(item.Link_Music);
                }
                sw.Close();
            }
        }

        public void AddItems(Music_Song item)
        {
            foreach (Music_Song music_Song in Listmusic)
            {
                if (item == music_Song)
                    return;
            }
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

        public void Remove(Music_Song music_Song)
        {
            Listmusic.Remove(music_Song);
        }
    }
}
