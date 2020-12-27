using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
