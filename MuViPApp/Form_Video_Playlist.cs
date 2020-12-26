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
    public partial class Form_Video_Playlist : Form
    {
        Video_Playlist parent;
        ListVideo lvideo;

        public Form_Video_Playlist(Video_Playlist parent = null)
        {
            this.parent = parent;
            InitializeComponent();
            lb_NamePl.Text = this.parent.NamePlay;
            this.parent.parent.Is_Playing_NowPlaying = false;
            LoadListVideo();
        }

        private void LoadListVideo()
        {

            lvideo = new ListVideo(this.parent.parent, PlaylistVideo.Instance.GetListVideo(this.parent.ID_Playlist).GetVideo());
            lvideo.TopLevel = false;
            lvideo.Dock = DockStyle.Fill;
            this.pn_List.Controls.Add(lvideo);
            this.pn_List.Tag = lvideo;
            lvideo.BringToFront();
            lvideo.Show();
            Number_song_video.Text = lvideo.listView_myvideo.Items.Count + " video";
            this.Date_create.Text = PlaylistVideo.Instance.GetListVideo(this.parent.ID_Playlist).Date_Create.ToString();
        }

        private void btn_Rename_Click(object sender, EventArgs e)
        {
            form_Rename_pl form_Rename = new form_Rename_pl();
            if (form_Rename.ShowDialog(this) == DialogResult.OK)
            {
                this.lb_NamePl.Text = form_Rename.ReName;
                Playlist.Instance.GetListMusic(this.parent.ID_Playlist).Name_PL = lb_NamePl.Text;
            }
        }

        private void btn_Playall_Click(object sender, EventArgs e)
        {
            //lvideo.PlayAllVideo();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            //FlistMusic.DeleteMusic();
        }

        private void btn_Addto_Click(object sender, EventArgs e)
        {

        }
    }
}
