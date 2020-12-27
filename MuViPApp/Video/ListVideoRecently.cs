using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuViPApp.Video.Data
{
    class ListVideoRecently
    {
        private List<VideoInfo> ListVideo = new List<VideoInfo>();

        private static ListVideoRecently instance;

        public static ListVideoRecently Instance
        {
            get { if (instance == null) instance = new ListVideoRecently(); return instance; }
            private set { instance = value; }
        }
        string path = @"History_Video_MuVipApp.txt";

        private ListVideoRecently()
        {
            if (File.Exists(path))
                using (StreamReader sr = new StreamReader(path))
                {
                    string lines;
                    while ((lines = sr.ReadLine()) != null)
                    {
                        if (File.Exists(lines))
                            ListVideo.Add(new VideoInfo(lines));
                    }
                }
        }

        public void AddItems(VideoInfo item)
        {
            ListVideo.Add(item);
            using (StreamWriter sw = new StreamWriter(path, true))
            {
                sw.WriteLine(item.FilePath);
                sw.Close();
            }
        }

        public List<VideoInfo> GetMusic()
        {
            return ListVideo;
        }

        public VideoInfo GetMusic(int index)
        {
            return ListVideo[index];
        }

        public void Remove()
        {
            ListVideo.Clear();
        }

        public void Remove(int index)
        {
            ListVideo.RemoveAt(index);
        }
    }
}
