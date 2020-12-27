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
    public partial class Form_Video_NewPlaylist : Form
    {
        Form_Muvip parent;
        public Form_Video_NewPlaylist(Form_Muvip parent)
        {
            this.parent = parent;
            InitializeComponent();
        }

        List<VideoInfo> listVideo = new List<VideoInfo>();

        public Form_Video_NewPlaylist(Form_Muvip parent, List<VideoInfo> listVideo)
        {
            this.parent = parent;
            this.listVideo = listVideo;
        }
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Ok_video_Click(object sender, EventArgs e)
        {
            if (tb_Name.Text == "")
                MessageBox.Show("Enter a playlist's name", "Notify");
            else
            {
                PlaylistVideo.Instance.AddItems(new PlayListInfoVideo(DateTime.Now, tb_Name.Text));
                Form_Video_Playlist NewForm = new Form_Video_Playlist(new Video_Playlist(PlaylistVideo.Instance.GetAllPlayListVideo().Count - 1, this.tb_Name.Text, 0, this.parent));
                this.parent.openChildForm(NewForm);
                this.Close();
            }
        }
    }
}
