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
            get {instance = new ListMyVideo(); return instance; }
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

                        if (info.Extension == ".mp4"|| info.Extension == ".wmv"|| info.Extension == ".webm")
                        {
                            ListVideo.Add(new VideoInfo(info.FullName));
                        }
                    }
                else
                    if (File.Exists(item) && (item.Contains(".mp4")|| item.Contains(".wmv")|| item.Contains(".webm")))
                    ListVideo.Add(new VideoInfo(item));
            }
        }
        public bool IsExist(VideoInfo item)
        {
            foreach (VideoInfo video in ListVideo)
            {
                if (item.link_Video == video.link_Video)
                {
                    return true;
                }
            }
            return false;
        }
        public void AddItems(VideoInfo item)
        {

            if (File.Exists(item.link_Video))
                if (!IsExist(item))
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
        }
    }
}
