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
using MuViPApp.Video.Classes;
using System.IO;
using AxWMPLib;


namespace MuViPApp
{
    public partial class form_Video_Nowpl : Form
    {
        Form_Muvip parent;
        public form_Video_Nowpl(Form_Muvip parent = null)
        {
            this.parent = parent;
            
            InitializeComponent();
            ShowList();
        }
        public void ShowList()
        {
            ListVideoPlaying.Instance.Remove();
            foreach (var child in Directory.GetFiles(@"C:\Users\Admin\Videos\"))
            {
                FileInfo info = new FileInfo(child);
                if (info.Extension == ".mp4" || info.Extension == ".wmv")
                {
                    ListVideoPlaying.Instance.AddItems(new VideoInfo(info.FullName));
                }
            }

            foreach (VideoInfo item in ListVideoPlaying.Instance.GetMusic())
            {
                ListViewItem items = new ListViewItem(new[] {item.Name,item.FilePath});
                listView_VideoPlaying.Items.Add(items);
            }
        }

        private void listView_VideoPlaying_SelectedIndexChanged(object sender, EventArgs e)
        {
            ControlCentre.OpenMedia(listView_VideoPlaying.SelectedItems[0].SubItems[1].Text, MediaPlayer);
        }
    }
}
