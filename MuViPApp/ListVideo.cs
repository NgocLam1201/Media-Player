using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MuViPApp.Video;

namespace MuViPApp
{
    public partial class ListVideo : Form
    {
        Form_Muvip parent;
        List<VideoInfo> ListVid = new List<VideoInfo>();
        public ListVideo(Form_Muvip parent = null, List<VideoInfo> ListVid = null)
        {
            this.parent = parent;
            this.ListVid = ListVid;
            InitializeComponent();
            ShowListVid();
        }
        public ListVideo()
        {

        }
        public void ShowListVid()
        {
            foreach (VideoInfo item in ListVid)
            {
                ListViewItem items = new ListViewItem(new[] { item.Name, item.Date, item.Size, item.Length, item.Length, item.FilePath });
                listView_myvideo.Items.Add(items);
            }
        }

    }
}
