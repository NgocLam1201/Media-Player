using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuViPApp.Music
{
    class ListMyMusic
    {
        private static ListMyMusic instance;

        public static ListMyMusic Instance
        {
            get { if (instance == null) instance = new ListMyMusic(); return instance; }
            private set { instance = value; }
        }

        private List<Music_Song> Listmusic = new List<Music_Song>();

        public ListMyMusic()
        {
            foreach (string item in ListFolderLocalMusic.Instance.GetLink())
            {
                if (Directory.Exists(item))
                    foreach (var child in Directory.GetFiles(item))
                    {
                        FileInfo info = new FileInfo(child);
                        if (info.Extension == ".mp3" || info.Extension ==  "wav" || info.Extension == "aiff" || info.Extension == "acc")
                        {
                            Listmusic.Add(new Music_Song(info.FullName));
                        }
                    }
                else
                    if (File.Exists(item) && item.Contains(".mp3"))
                    Listmusic.Add(new Music_Song(item));
            }
        }

        public bool IsExist(Music_Song item)
        {
            foreach (Music_Song music_Song in Listmusic)
            {
                if (item.Link_Music == music_Song.Link_Music)
                {
                    return true;
                }
            }
            return false;
        }

        public void AddItems(Music_Song item)
        {
            if (File.Exists(item.Link_Music))
                if (!IsExist(item))
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
