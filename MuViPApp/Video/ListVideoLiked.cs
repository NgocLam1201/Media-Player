using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MuViPApp.Video
{
    class ListVideoLiked
    {

        private static ListVideoLiked instance;

        public static ListVideoLiked Instance
        {
            get { if (instance == null) instance = new ListVideoLiked(); return instance; }
            private set { instance = value; }
        }

        private List<VideoInfo> list_VidLiked = new List<VideoInfo>();


        string path = @"Liked_Video_MuVipApp.txt";

        public ListVideoLiked()
        {
            using (StreamWriter sw = new StreamWriter(path, true))
                sw.Close();
            using (StreamReader sr = new StreamReader(path))
            {
                string lines;
                while ((lines = sr.ReadLine()) != null)
                {
                    if (File.Exists(lines))
                        list_VidLiked.Add(new VideoInfo(lines));
                }
            }
        }
        public void export()
        {
            if (File.Exists(path))
                File.Delete(path);
            using (StreamWriter sw = new StreamWriter(path, true))
            {
                foreach (VideoInfo item in list_VidLiked)
                {
                    sw.WriteLine(item.Link_Video);
                }
                sw.Close();
            }
        }
        public void AddItems(VideoInfo item)
        {
            foreach (VideoInfo video in list_VidLiked)
            {
                if (video.Link_Video == item.Link_Video)
                {
                    list_VidLiked.Remove(video);
                    break;
                }
            }
            list_VidLiked.Add(item);
            export();
        }
        public bool IsExist(VideoInfo item)
        {
            foreach (VideoInfo video in list_VidLiked)
            {
                if (item.link_Video == video.link_Video)
                {
                    return true;
                }
            }
            return false;
        }
        public List<VideoInfo> GetVideo()
        {
            return list_VidLiked;
        }

        public VideoInfo GetVideo(int index)
        {
            return list_VidLiked[index];
        }

        public void Remove()
        {
            list_VidLiked.Clear();
            export();
        }

        public void Remove(int index)
        {
            list_VidLiked.RemoveAt(index);
            export();
        }

        public void Remove(VideoInfo video)
        {
            for (int i = 0; i < list_VidLiked.Count; i++)
            {
                if (video.Link_Video == list_VidLiked[i].Link_Video)
                {
                    list_VidLiked.RemoveAt(i);
                    break;
                }
            }
            export();
        }
    }
}
