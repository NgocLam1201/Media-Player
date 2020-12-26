using System;
using System.Collections.Generic;
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
