using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuViPApp.Video
{
    class ListFolderLocalVideo
    {
        List<string> listPath = new List<string>();

        string path = "MyVideo_MuVipApp.txt";

        private static ListFolderLocalVideo instance;

        public static ListFolderLocalVideo Instance
        {
            get { if (instance == null) instance = new ListFolderLocalVideo(); return instance; }
            private set { instance = value; }
        }

        public ListFolderLocalVideo()
        {
            if (!File.Exists(path))
            {
                using (StreamWriter sw = new StreamWriter(path, true))
                {
                    sw.WriteLine(Environment.GetFolderPath(Environment.SpecialFolder.MyVideos));
                    sw.Close();
                }
            }
            using (StreamReader sr = new StreamReader(path))
            {
                string lines;
                PlayListInfoVideo playListInfo = new PlayListInfoVideo();
                while ((lines = sr.ReadLine()) != null)
                {
                    if (Directory.Exists(lines))
                        listPath.Add(lines);
                    else
                        if (File.Exists(lines))
                        listPath.Add(lines);
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
                foreach (string item in listPath)
                {
                    sw.WriteLine(item);
                    sw.Close();
                }
            }
        }

        public List<string> GetLink()
        {
            return listPath;
        }

        public string GetLink(int index)
        {
            return listPath[index];
        }

        public void Additem(string path)
        {
            listPath.Add(path);
        }

        public void Remove(string path)
        {
            listPath.Remove(path);
        }
    }
}
