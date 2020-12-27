using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MuViPApp.Video;
using System.IO;

namespace MuViPApp
{
    public class PlayListInfoVideo
    {
        private static PlayListInfoVideo instance;

        public static PlayListInfoVideo Instance
        {
            get { if (instance == null) instance = new PlayListInfoVideo(); return PlayListInfoVideo.instance; }
            private set { PlayListInfoVideo.instance = value; }
        }

        public PlayListInfoVideo() { }

        public PlayListInfoVideo(DateTime date_create, string name_PL, List<VideoInfo> listvideo = null)
        {
            this.Date_Create = date_Create;
            Name_PL = name_PL;
            this.Listvideo = listvideo;
        }

        private string name_PL;
        public string Name_PL
        {
            get { return name_PL; }
            set
            {
                if (File.Exists(Name_PL + ".txt"))
                {
                    File.Move(Name_PL + ".txt", value);
                    File.Delete(Name_PL + ".txt");
                }
                name_PL = value;
            }
        }

        private DateTime date_Create;
        public DateTime Date_Create
        {
            get { return date_Create; }
            set { date_Create = value; }
        }

        private List<VideoInfo> Listmusic = new List<VideoInfo>();
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
                        Listmusic.Add(new VideoInfo(lines));
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
                foreach (VideoInfo item in Listmusic)
                {
                    sw.WriteLine(item.FilePath);
                }
                sw.Close();
            }
        }


        private List<VideoInfo> Listvideo = new List<VideoInfo>();

        public void AddItems(VideoInfo item)
        {
            Listvideo.Add(item);
        }

        public List<VideoInfo> GetVideo()
        {
            return Listvideo;
        }

        public VideoInfo GetVideo(int index)
        {
            return Listvideo[index];
        }

        public void Remove()
        {
            Listvideo.Clear();
        }

        public void Remove(int index)
        {
            Listvideo.RemoveAt(index);
        }
    }
}
