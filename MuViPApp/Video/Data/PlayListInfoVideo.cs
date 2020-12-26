using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MuViPApp.Video;

namespace MuViPApp
{
    public class PlayListInfoVideo
    {
        private static PlayListInfoVideo instance;

        public static PlayListInfoVideo Instance
        {
            get { if (instance == null) instance = new PlayListInfoVideo(); return PlayListInfoVideo.instance; }
            private set { PlayListInfoVideo.instance = value; }
        }

        public PlayListInfoVideo() { }

        public PlayListInfoVideo(DateTime date_create, string name_PL)
        {
            Name_PL = name_PL;
        }

        private string name_PL;
        public string Name_PL
        {
            get { return name_PL; }
            set { name_PL = value; }
        }

        private DateTime date_Create;
        public DateTime Date_Create
        {
            get { return date_Create; }
            set { date_Create = value; }
        }



        private List<VideoInfo> Listvideo = new List<VideoInfo>();

        public void AddItems(VideoInfo item)
        {
            Listvideo.Add(item);
        }

        public List<VideoInfo> GetVideo()
        {
            return Listvideo;
        }

        public VideoInfo GetVideo(int index)
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
