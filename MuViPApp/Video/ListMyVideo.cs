using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuViPApp.Video
{
    class ListMyVideo
    {
        private static ListMyVideo instance;

        public static ListMyVideo Instance
        {
            get { if (instance == null) instance = new ListMyVideo(); return instance; }
            private set { instance = value; }
        }

        private List<VideoInfo> ListVideo = new List<VideoInfo>();

        public ListMyVideo()
        {
            foreach (var item in ListFolderLocalVideo.Instance.GetLink())
            {
                if (Directory.Exists(item))
                    foreach (var child in Directory.GetFiles(item))
                    {
                        FileInfo info = new FileInfo(child);

                        if (info.Extension == ".mp4"|| info.Extension == ".wmv")
                        {
                            ListVideo.Add(new VideoInfo(info.FullName));
                        }
                    }
                else
                    if (File.Exists(item))
                    ListVideo.Add(new VideoInfo(item));
            }
        }

        public void AddItems(VideoInfo item)
        {
            ListVideo.Add(item);
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
