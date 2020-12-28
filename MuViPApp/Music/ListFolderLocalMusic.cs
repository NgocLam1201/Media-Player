using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Threading;
using MuViPApp.Music;
using MuViPApp.Video;
using System.IO;

namespace MuViPApp.Music
{
    class ListFolderLocalMusic
    {
        List<string> listPath = new List<string>();

        string path = Application.StartupPath + "\\InPut\\MyMusic_MuVipApp.txt";

        private static ListFolderLocalMusic instance;

        public static ListFolderLocalMusic Instance
        {
            get { if (instance == null) instance = new ListFolderLocalMusic(); return instance; }
            private set { instance = value; }
        }

        public ListFolderLocalMusic()
        {
            if (true)
               
            if (!File.Exists(path))
            {
                using (StreamWriter sw = new StreamWriter(path,true))
                {
                    sw.WriteLine(Environment.GetFolderPath(Environment.SpecialFolder.MyMusic));
                    sw.Close();
                }
            }
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
                }
                sw.Close();

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
