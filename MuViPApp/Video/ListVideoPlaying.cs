using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuViPApp.Video
{
    class ListVideoPlaying
    {

        private static ListVideoPlaying instance;

        public static ListVideoPlaying Instance
        {
            get { if (instance == null) instance = new Video.ListVideoPlaying(); return instance; }
            private set { instance = value; }
        }

        private List<VideoInfo> List_VidPlaying = new List<VideoInfo>();


        string path = @"List_Video_Now_Playing_MuVipApp.txt";

        public ListVideoPlaying()
        {
            using (StreamWriter sw = new StreamWriter(path, true))
                sw.Close();
            using (StreamReader sr = new StreamReader(path))
            {
                string lines;
                while ((lines = sr.ReadLine()) != null)
                {
                    if (File.Exists(lines))
                        List_VidPlaying.Add(new VideoInfo(lines));
                }
                sr.Close();
            }
        }
        
        public void export()
        {
            if (File.Exists(path))
                File.Delete(path);
            using (StreamWriter sw = new StreamWriter(path, true))
            {
                foreach (VideoInfo item in List_VidPlaying)
                {
                    sw.WriteLine(item.Link_Video);
                }
                sw.Close();
            }
        }

        public void AddItems(VideoInfo item)
        {
            List_VidPlaying.Add(item);
        }

        public List<VideoInfo> GetMusic()
        {
            return List_VidPlaying;
        }

        public VideoInfo GetMusic(int index)
        {
            return List_VidPlaying[index];
        }

        public void Remove()
        {
            List_VidPlaying.Clear();
        }

        public void Remove(int index)
        {
            List_VidPlaying.RemoveAt(index);
        }
    }
}
