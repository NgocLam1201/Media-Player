using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuViPApp.Music
{
    class ListFolderLocalMusic
    {
        List<string> listPath = new List<string>();

        string path = "MyMusic_MuVipApp.txt";

        private static ListFolderLocalMusic instance;

        public static ListFolderLocalMusic Instance
        {
            get { if (instance == null) instance = new ListFolderLocalMusic(); return instance; }
            private set { instance = value; }
        }

        public ListFolderLocalMusic()
        {
            using (StreamReader sr = new StreamReader(path))
            {
                string lines;
                PlayListInfo playListInfo = new PlayListInfo();
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

        public List<string>  GetLink()
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
