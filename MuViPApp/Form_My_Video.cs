using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Windows.Forms;
using WMPLib;
using MuViPApp.Music;


namespace MuViPApp
{
    public partial class Form_My_Video : Form
    {
        public Form_My_Video()
        {
            InitializeComponent();
            string[] fpath = System.IO.Directory.GetFiles(@"C:\Users\Admin\Videos\", "*.mp4");
            GetInfo(fpath);
            // Mp3Player.Instance.Open();
            //Mp3Player.Instance.DisplayMediaWindow();
            //Mp3Player.Instance.Play();
        }

        public string GetSizeFile(FileInfo f)
        {
            long size=f.Length/1048576;
            Math.Round(Convert.ToDecimal(size), 2);
            return size.ToString()+ "MB";

        }
        public string Duration(String file)
        {
            WindowsMediaPlayer wmp = new WindowsMediaPlayerClass();
            IWMPMedia mediainfo = wmp.newMedia(file);
            int maxTime = Convert.ToInt32(mediainfo.duration);
            return string.Format("{0:00}:{1:00}:{2:00}", maxTime / 3600, (maxTime / 60) % 60, maxTime % 60);
        }
        public void GetInfo(string[] fpath)
        {
            int i = 0;
            foreach (string path in fpath)
            {
                i++;
                FileInfo info = new FileInfo(path);
                if (info.Exists)
                {
                    ListViewItem items = new ListViewItem(new[] { Path.GetFileNameWithoutExtension(info.Name).ToString(), info.CreationTime.ToString(), GetSizeFile(info), Duration(path), path });
                    listView_myvideo.Items.Add(items);
                }
            }
        }
    }
}
