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
        public Video_Playlist parent;
        ListVideo lvideo;
        ContextMenuStrip toolStrip = new ContextMenuStrip();
        public Form_Video_Playlist(Video_Playlist parent = null)
        {
            this.parent = parent;
            InitializeComponent();
            lb_NamePl.Text = this.parent.NamePlay;
            this.parent.parent.Is_Playing_NowPlaying = false;
            if (PlaylistVideo.Instance.GetListVideo(this.parent.ID_Playlist).count()>0) 
                LoadListVideo();
            toolStrip.ItemClicked += ClickItem;
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
            form_Rename_pl form_Rename = new form_Rename_pl(this);
            form_Rename.StartPosition = FormStartPosition.CenterParent;
            form_Rename.ShowDialog();
        }

        private void btn_Playall_Click(object sender, EventArgs e)
        {
            lvideo.PlayAllVideo();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            lvideo.DeleteVideo();
        }

        private void ClickItem(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Text)
            {
                case "Now playing":
                    lvideo.AddtoNowPlaying();
                    break;
                case "New playlist":
                    lvideo.AddToNewPlaylist();
                    break;
                default:
                    foreach (PlayListInfoVideo item in PlaylistVideo.Instance.GetAllPlayListVideo())
                    {
                        if (item.Name_PL == e.ClickedItem.Text)
                        {
                            lvideo.AddToPlaylist(item);
                            break;
                        }
                    }
                    break;
            }
            toolStrip = null;
            lvideo.AfterClick();
        }

        private void btn_Addto_Click(object sender, EventArgs e)
        {
            toolStrip.Items.Add("Now playing");
            toolStrip.LayoutStyle = ToolStripLayoutStyle.VerticalStackWithOverflow;
            toolStrip.Items.Add("-");
            toolStrip.Items.Add("New playlist");
            foreach (PlayListInfoVideo item in PlaylistVideo.Instance.GetAllPlayListVideo())
            {
                toolStrip.Items.Add(item.Name_PL);
            }
            toolStrip.Show(MousePosition);
            toolStrip.BringToFront();
            toolStrip.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip.Dock = DockStyle.None;
        }

      
        private void label3_Click(object sender, EventArgs e)
        {
            this.parent.parent.activeForm = null;
            this.parent.parent.openChildForm(new Form_My_Video());
        }
    }
}
