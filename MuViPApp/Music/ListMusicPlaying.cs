using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MuViPApp.Music
{
    public class ListMusicPlaying
    {
        
        private static ListMusicPlaying instance;

        public static ListMusicPlaying Instance
        {
            get { if (instance == null) instance = new ListMusicPlaying(); return instance; }
            private set { instance = value; }
        }

        private List<Music_Song> Listmusic = new List<Music_Song>();

        string path = @"List_Music_Now_Playing_MuVipApp.txt";

        private ListMusicPlaying()
        {
            using (StreamWriter sw = new StreamWriter(path, true))
                sw.Close();
            using (StreamReader sr = new StreamReader(path))
            {
                string lines;
                while ((lines = sr.ReadLine()) != null)
                {
                    if (File.Exists(lines))
                        foreach (string  item in ListFolderLocalMusic.Instance.GetLink())
                        {
                            if (lines.Contains(item))
                            {
                                Listmusic.Add(new Music_Song(lines));
                                break;
                            }    
                        }
                        
                }
                sr.Close();
            }
        }

        public void AddItems(Music_Song item)
        {
            Listmusic.Add(item);
            export();
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
