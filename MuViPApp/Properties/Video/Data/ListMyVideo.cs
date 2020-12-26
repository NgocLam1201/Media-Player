using System;
using System.Collections.Generic;
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

        public void AddItems(VideoInfo item)
        {
            ListVideo.Add(item);
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
