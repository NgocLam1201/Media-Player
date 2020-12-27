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
    public partial class Form_Liked_Video : Form
    {
        ListVideo FlistVideo;
        Form_Muvip parent;
        public Form_Liked_Video(Form_Muvip parent = null)
        {
            this.parent = parent;
            InitializeComponent();
            ShowListVideo();
        }

        public void ShowListVideo()
        {
            FlistVideo = new ListVideo(this.parent, ListVideoLiked.Instance.GetVideo());
            FlistVideo.TopLevel = false;
            FlistVideo.FormBorderStyle = FormBorderStyle.None;
            FlistVideo.Dock = DockStyle.Fill;
            this.pn_Liked_Video.Controls.Add(FlistVideo);
            this.pn_Liked_Video.Tag = FlistVideo;
            FlistVideo.BringToFront();
            FlistVideo.Show();
        }
    }
}
