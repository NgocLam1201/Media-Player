using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MuViPApp.Video;

namespace MuViPApp
{
    class PlaylistVideo
    {
        private static PlaylistVideo instance;

        public static PlaylistVideo Instance
        {
            get { if (instance == null) instance = new PlaylistVideo(); return instance; }
            private set { instance = value; }
        }

        private List<PlayListInfoVideo> Listvideo = new List<PlayListInfoVideo>();

        public void AddItems(PlayListInfoVideo item)
        {
            Listvideo.Add(item);
        }

        public List<PlayListInfoVideo> GetAllPlayListVideo()
        {
            return Listvideo;
        }

        public PlayListInfoVideo GetListVideo(int index)
        {
            return Listvideo[index];
        }

        public void Remove()
        {
            Listvideo.Clear();
        }

        public void Remove(int index)
        {
            Listvideo.RemoveAt(index);
        }
    }
}
