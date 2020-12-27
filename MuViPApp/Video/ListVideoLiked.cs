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


        string path = @"Liked_Music_MuVipApp.txt";

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
                    sw.WriteLine(item.FilePath);
                }
                sw.Close();
            }
        }
        public void AddItems(VideoInfo item)
        {
            list_VidLiked.Add(item);
        }

        public List<VideoInfo> GetMusic()
        {
            return list_VidLiked;
        }

        public VideoInfo GetMusic(int index)
        {
            return list_VidLiked[index];
        }

        public void Remove()
        {
            list_VidLiked.Clear();
        }

        public void Remove(int index)
        {
            list_VidLiked.RemoveAt(index);
        }
    }
}
