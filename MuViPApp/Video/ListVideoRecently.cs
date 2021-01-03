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
            
        }
        public void Load()
        {
            for (int i = 0; i < ListVideo.Count / 2; i++)
            {
                VideoInfo temp = ListVideo[i];
                ListVideo[i] = ListVideo[ListVideo.Count - i - 1];
                ListVideo[ListVideo.Count - i - 1] = temp;
            }
        }

        public void AddItems(VideoInfo item)
        {
            item.Date_Add = DateTime.Now.ToString();
            foreach (VideoInfo video in ListVideo)
            {
                if (video.Link_Video == item.Link_Video)
                {
                    ListVideo.Remove(video);
                    break;
                }
            }
            ListVideo.Add(item);
            Export();
        }

        public void Export()
        {
            if (File.Exists(path))
                File.Delete(path);
            using (StreamWriter sw = new StreamWriter(path, true))
            {
                foreach (VideoInfo item in ListVideo)
                {
                    sw.WriteLine(item.Link_Video);
                }
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

        public void Remove(VideoInfo video)
        {
            for (int i = 0; i < ListVideo.Count; i++)
            {
                if (video.Link_Video == ListVideo[i].Link_Video)
                {
                    ListVideo.RemoveAt(i);
                    break;
                }
            }
            Export();
        }
    }
}
