using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuViPApp.Video
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
            using (StreamWriter sw = new StreamWriter(path, true))
                sw.Close();
            using (StreamReader sr = new StreamReader(path))
            {
                string lines;
                while ((lines = sr.ReadLine()) != null)
                {
                    if (File.Exists(lines))
                        ListVideo.Add(new VideoInfo(lines));
                }
                sr.Close();
            }
            for (int i = 0; i < ListVideo.Count / 2; i++)
            {
                VideoInfo temp = ListVideo[i];
                ListVideo[ListVideo.Count - i - 1] = ListVideo[i];
                ListVideo[i] = temp;
            }
        }

        public void AddItems(VideoInfo item)
        {
            item.Date = DateTime.Now.ToString();
            foreach (VideoInfo music_Song in ListVideo)
            {
                if (music_Song.FilePath == item.FilePath)
                    ListVideo.Remove(item);
            }
            ListVideo.Add(item);
            using (StreamWriter sw = new StreamWriter(path, true))
            {
                sw.WriteLine(item.FilePath);
                sw.Close();
            }
        }

        public List<VideoInfo> GetVideo()
        {
            return ListVideo;
        }

        public VideoInfo GetVideo(int index)
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
