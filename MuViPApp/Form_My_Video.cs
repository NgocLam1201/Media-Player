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
using System.IO;

namespace MuViPApp
{
    public partial class Form_My_Video : Form
    {
        Form_Muvip parent = new Form_Muvip();
        public Form_My_Video(Form_Muvip parent=null)
        {
            InitializeComponent();
            this.parent = parent;
            ShowListVid();
        }
        public void ShowListVid()
        {
            ListMyVideo.Instance.Remove();

<<<<<<< HEAD
            //foreach (var child in Directory.GetFiles(@"C:\Users\Admin\Videos\"))

            foreach (var child in Directory.GetFiles(@"C:\Users\Admin\Videos\"))

=======
            foreach (var child in Directory.GetFiles(@"C:\Users\Admin\Videos\"))
            //foreach (var child in Directory.GetFiles(@"C:\Users\ACER\Videos\"))
>>>>>>> Last_Update_Music
            {
                FileInfo info = new FileInfo(child);
                if (info.Extension == ".mp4"|| info.Extension == ".wmv")
                {
                    ListMyVideo.Instance.AddItems(new VideoInfo(info.FullName));
                }
            }
            ListVideo lvideo = new ListVideo(this.parent, ListMyVideo.Instance.GetMusic());
            lvideo.TopLevel = false;
            lvideo.Dock = DockStyle.Fill; 
            panel_List.Controls.Add(lvideo);
            lvideo.BringToFront();
            lvideo.Show();

        }
       
    }
}
