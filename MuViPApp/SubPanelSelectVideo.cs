using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MuViPApp.Video;

namespace MuViPApp
{
    public partial class SubPanelSelectVideo : UserControl
    {
        ListVideo parent;
        ToolStrip toolStrip = new ToolStrip();
        public SubPanelSelectVideo(ListVideo parent = null)
        {
            this.parent = parent;
            InitializeComponent();
            toolStrip.ItemClicked += ClickItem;
        }

        private void ClickItem(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Text)
            {
                case "Now playing":
                    this.parent.AddtoNowPlaying();
                    break;
                case "New playlist":
                    this.parent.AddToNewPlaylist();
                    break;
                default:
                    foreach (PlayListInfoVideo item in PlaylistVideo.Instance.GetAllPlayListVideo())
                    {
                        if (item.Name_PL == e.ClickedItem.Text)
                        {
                            this.parent.AddToPlaylist(item);
                            break;
                        }
                    }
                    break;
            }
            toolStrip = null;
            this.parent.AfterClick();
        }

        private void btn_SelectAll_Click(object sender, EventArgs e)
        {
            this.parent.SelectAll();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            this.parent.AfterClick();

        }

        private void btn_Addto_Click(object sender, EventArgs e)
        {
            if (toolStrip == null)
            {
                toolStrip.Items.Add("Now playing");
                toolStrip.LayoutStyle = ToolStripLayoutStyle.VerticalStackWithOverflow;
                toolStrip.Items.Add("-");
                toolStrip.Items.Add("New playlist");
                int Y = 400;
                foreach (PlayListInfoVideo item in PlaylistVideo.Instance.GetAllPlayListVideo())
                {
                    toolStrip.Items.Add(item.Name_PL);
                    Y -= 22;
                }
                toolStrip.Location = new Point(btn_Addto.Location.X + 70, btn_Addto.Location.Y + Y);
                this.parent.Controls.Add(toolStrip);
                toolStrip.BringToFront();
                toolStrip.GripStyle = ToolStripGripStyle.Hidden;
                toolStrip.Dock = DockStyle.None;
            }
        }

        private void btn_PlayNext_Click(object sender, EventArgs e)
        {
            if (ListVideoPlaying.Instance.GetMusic().Count > 0)
            {
                List<VideoInfo> TempList = new List<VideoInfo>();
                int i = 0;
                foreach (VideoInfo item in ListVideoPlaying.Instance.GetMusic())
                {
                    TempList.Add(item);
                    i++;
                    if (item.Name == this.parent.parent.NameMedia.Text)
                    {
                        break;
                    }
                }
                for (int j = 0; j < this.parent.listView_myvideo.SelectedItems.Count; j++)
                {
                    TempList.Add(new VideoInfo(this.parent.listView_myvideo.SelectedItems[j].SubItems[2].Text));
                }

                for (int j = i; j < ListVideoPlaying.Instance.GetMusic().Count; j++)
                {
                    TempList.Add(ListVideoPlaying.Instance.GetMusic(j));
                }

                ListVideoPlaying.Instance.Remove();
                foreach (VideoInfo item in TempList)
                {
                    ListVideoPlaying.Instance.AddItems(item);
                }
                ListVideoPlaying.Instance.export();
                this.parent.AfterClick();
            }
        }

        private void btn_Play_Click(object sender, EventArgs e)
        {
            this.parent.Video_Click(this, new EventArgs());
            this.parent.AfterClick();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.parent.CancelSelect();
            this.parent.AfterClick();
        }
    }
}
                                                                                                                                                                                                         