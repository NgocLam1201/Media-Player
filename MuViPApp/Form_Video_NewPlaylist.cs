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
            InitializeComponent();
            this.listVideo = listVideo;
            this.KeyDown += Key_OK;
        }
        private void Key_OK(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btn_Ok_Click(this, new EventArgs());
            else
                if (e.KeyCode == Keys.Escape)
                btn_Cancel_Click(this, new EventArgs());
        }

        private void btn_Ok_Click(object sender, EventArgs e)
        {
            bool check = true;
            if (tb_Name.Text == "")
                MessageBox.Show("Enter a playlist's name", "Notify");
            else
            {
                foreach (PlayListInfoVideo item in PlaylistVideo.Instance.GetAllPlayListVideo())
                {
                    if (tb_Name.Text == item.Name_PL)
                    {
                        check = false;
                        MessageBox.Show("This name is already.", "Error");
                    }
                }
                if (check == true)
                {
                    PlaylistVideo.Instance.AddItems(new PlayListInfoVideo(DateTime.Now, tb_Name.Text, listVideo));
                    form_Music_Playlist NewForm = new form_Music_Playlist(new Music_Playlist(Playlist.Instance.GetAllPlayListMusic().Count - 1, this.tb_Name.Text, 0, this.parent));
                    this.parent.openChildForm(NewForm);
                    Playlist.Instance.Export();
                    Playlist.Instance.GetListMusic(Playlist.Instance.GetAllPlayListMusic().Count - 1).Export();
                    Close();
                }
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Ok_video_Click(object sender, EventArgs e)
        {
            bool check = true;
            if (tb_Name.Text == "")
                MessageBox.Show("Enter a playlist's name", "Notify");
            else
            {
                foreach (PlayListInfoVideo item in PlaylistVideo.Instance.GetAllPlayListVideo())
                {
                    if (tb_Name.Text == item.Name_PL)
                    {
                        check = false;
                        MessageBox.Show("This name is already.", "Error");
                    }
                }
                if (check == true)
                {
                    PlaylistVideo.Instance.AddItems(new PlayListInfoVideo(DateTime.Now, tb_Name.Text, listVideo));
                    Form_Video_Playlist NewForm = new Form_Video_Playlist(new Video_Playlist( PlaylistVideo.Instance.GetAllPlayListVideo().Count - 1, this.tb_Name.Text, 0, this.parent));
                    this.parent.openChildForm(NewForm);
                    PlaylistVideo.Instance.Export();
                    PlaylistVideo.Instance.GetListVideo(PlaylistVideo.Instance.GetAllPlayListVideo().Count - 1).Export();
                    Close();
                }
            }
        }
    }
}
