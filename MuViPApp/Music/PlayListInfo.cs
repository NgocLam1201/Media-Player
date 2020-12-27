using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
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

        public PlayListInfo() { }

        public PlayListInfo(string date_create,string name_PL, List<Music_Song> listmusic = null) 
        {
            this.Date_Create = date_create;
            Name_PL = name_PL;
            this.Listmusic = listmusic;
            Import();
        }

        private string name_PL;
        public string Name_PL
        {
            get { return name_PL; }
            set
            {
                if (File.Exists(Name_PL + ".txt"))
                {
                    File.Move(Name_PL + ".txt", value + ".txt"); 
                    File.Delete(Name_PL + ".txt");
                }
                name_PL = value;
            }
        }

        private string date_Create;
        public string Date_Create
        {
            get { return date_Create; }
            set { date_Create = value; }
        }

        private List<Music_Song> Listmusic = new List<Music_Song>();

        public void Import()
        {
            string path = this.Name_PL + ".txt";
            using (StreamWriter sw = new StreamWriter(path, true))
                sw.Close();
            using (StreamReader sr = new StreamReader(this.name_PL + ".txt"))
            {
                string lines;
                while ((lines = sr.ReadLine()) != null)
                {
                    if (File.Exists(lines))
                        Listmusic.Add(new Music_Song(lines));
                }
                sr.Close();
            }
        }

        public void Export()
        {
            if (File.Exists(this.Name_PL + ".txt"))
                File.Delete(this.Name_PL + ".txt");
            using (StreamWriter sw = new StreamWriter(this.Name_PL + ".txt", true))
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
