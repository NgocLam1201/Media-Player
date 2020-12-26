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
            foreach (var item in ListFolderLocalMusic.Instance.GetLink())
            {
                if (Directory.Exists(item))
                    foreach (var child in Directory.GetFiles(item))
                    {
                        FileInfo info = new FileInfo(child);
                        if (info.Extension == ".mp3")
                        {
                            Listmusic.Add(new Music_Song(info.FullName));
                        }
                    }
                else
                    if (File.Exists(item))
                        Listmusic.Add(new Music_Song(item));
            }
        }        

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
