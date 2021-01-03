using System;
using System.Collections.Generic;
using System.IO;
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

        string path = @"Playlist_Video_MuVipApp.txt";

        public PlaylistVideo()
        {
            using (StreamWriter sw = new StreamWriter(path, true))
                sw.Close();
            using (StreamReader sr = new StreamReader(path))
            {
                string lines;
                PlayListInfoVideo playListInfo = new PlayListInfoVideo();
                while ((lines = sr.ReadLine()) != null)
                {
                    string[] words = lines.Split('\t');
                    playListInfo.Name_PL = words[0];
                    playListInfo.Date_Create = Convert.ToDateTime(words[1]);
                    playListInfo.Import();
                    Listvideo.Add(playListInfo);
                }
                sr.Close();
            }
        }
        public void Export()
        {
            if (File.Exists(path))
                File.Delete(path);
            using (StreamWriter sw = new StreamWriter(path, true))
            {
                foreach (PlayListInfoVideo item in Listvideo)
                {
                    sw.WriteLine(item.Name_PL + '\t' + item.Date_Create);
                }
                sw.Close();
            }
        }
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
