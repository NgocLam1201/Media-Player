using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;
using System.IO;

namespace MuViPApp.Video
{
    public class VideoInfo
    {
        public string Name;
        public string Date;
        public string Size;
        public string Length;
        public string FilePath;

        private static VideoInfo instance;

        public static VideoInfo Instance
        {
            get { if (instance == null) instance = new VideoInfo(); return instance; }
            private set { instance = value; }
        }

        public string Duration(String file)
        {
            WindowsMediaPlayer wmp = new WindowsMediaPlayerClass();
            IWMPMedia mediainfo = wmp.newMedia(file);
            int maxTime= Convert.ToInt32( mediainfo.duration);
            return string.Format("{0:00}:{1:00}:{2:00}", maxTime / 3600, (maxTime / 60) % 60, maxTime % 60);
        }
        public string SizeFile(FileInfo inf)
        {
            long size = inf.Length;
            return Math.Round(Convert.ToDecimal(size / 1048576), 2).ToString()+"MB";

        }

        public VideoInfo() { } 
        public VideoInfo(string path)
        {
            FileInfo info = new FileInfo(path);
            if (info.Exists)
            {
                this.Name = info.Name.ToString();
                this.Date = info.CreationTime.ToString();
                this.Size = SizeFile(info);
                this.Length = Duration(path);
                this.FilePath = path;
            }
        }
    }
}
