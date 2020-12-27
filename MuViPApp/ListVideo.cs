using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MuViPApp.Video;

namespace MuViPApp
{
    public partial class ListVideo : Form
    {
        public Form_Muvip parent;
        List<VideoInfo> ListVid = new List<VideoInfo>();
        public SubPanelSelectVideo sp_Select;
        public Form_Delete form_Delete = new Form_Delete();
        ToolStripMenuItem toolStripMenuItem = new ToolStripMenuItem();
        public ListVideo(Form_Muvip parent = null, List<VideoInfo> ListVid = null)
        {
            this.parent = parent;
            this.ListVid = ListVid;
            InitializeComponent();
            ShowListVid();
            for (int i = 0; i < this.listView_myvideo.SelectedItems.Count; i++)
            {
                listView_myvideo.KeyDown += Key_Enter_Down;
            }
            listView_myvideo.DoubleClick += Video_Click;
            listView_myvideo.MouseClick += SelectVideo;
            foreach (PlayListInfoVideo item in PlaylistVideo.Instance.GetAllPlayListVideo())
            {
                toolStripMenuItem = new ToolStripMenuItem(item.Name_PL);
                addToToolStripMenuItem.DropDownItems.Add(toolStripMenuItem);
            }
            toolStripMenuItem.Click += ToolStripMenuItem_Click;
        }
        private void ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (PlayListInfoVideo item in PlaylistVideo.Instance.GetAllPlayListVideo())
            {
                if (item.Name_PL == toolStripMenuItem.Text)
                {
                    this.AddToPlaylist(item);
                    break;
                }
            }
        }
        public void ShowListVid()
        {
            foreach (VideoInfo item in ListVid)
            {
                ListViewItem items = new ListViewItem(new[] { item.Name, item.Date, item.Size, item.Length, item.Length, item.FilePath });
                listView_myvideo.Items.Add(items);
            }
        }

        public void Video_Click(object sender, EventArgs e)
        {
            ListVideoPlaying.Instance.Remove();
            if (listView_myvideo.SelectedItems.Count == 1)
            {
                int index = listView_myvideo.Items.IndexOf(listView_myvideo.SelectedItems[0]);
                for (int i = index; i < listView_myvideo.Items.Count; i++)
                {
                    ListVideoPlaying.Instance.AddItems(new VideoInfo(listView_myvideo.Items[i].SubItems[5].Text));
                }
                for (int i = 0; i < index; i++)
                {
                    ListVideoPlaying.Instance.AddItems(new VideoInfo(listView_myvideo.Items[i].SubItems[5].Text));
                }
            }
            else
                for (int i = 0; i < listView_myvideo.SelectedItems.Count; i++)
                {
                    ListVideoPlaying.Instance.AddItems(new VideoInfo(listView_myvideo.Items[i].SubItems[5].Text));
                }
            this.parent.btn_NowPlaying.selected = true;
            this.parent.btn_My_Video.selected = false;
            this.parent.openChildForm(new form_Video_Nowpl());
            listView_myvideo.Items.Clear();
        }

        public void SelectVideo(object sender, MouseEventArgs e)
        {
            if (sp_Select == null)
            {
                this.parent.Is_Playing = false;
                this.parent.SetActive_PanelPlayer();
                sp_Select = new SubPanelSelectVideo(this);
                this.Controls.Add(sp_Select);
                sp_Select.Dock = DockStyle.Bottom;
                sp_Select.BringToFront();
            }
        }

        public void AfterClick()
        {
            this.Controls.Remove(sp_Select);
            listView_myvideo.Items.Clear();
            ShowListVid();
        }

        private ListViewColumnSorter lvwColumnSorter;
        private void listView_myvideo_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            lvwColumnSorter = new ListViewColumnSorter();
            listView_myvideo.ListViewItemSorter = lvwColumnSorter;

            if (e.Column == lvwColumnSorter.SortColumn)
            {
                if (lvwColumnSorter.Order == SortOrder.Ascending)
                {
                    lvwColumnSorter.Order = SortOrder.Descending;
                }
                else
                {
                    lvwColumnSorter.Order = SortOrder.Ascending;
                }
            }
            else
            {
                lvwColumnSorter.SortColumn = e.Column;
                lvwColumnSorter.Order = SortOrder.Ascending;
            }

            this.listView_myvideo.Sort();
        }

            public void Key_Enter_Down(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Video_Click(this, new EventArgs());
            }
        }

        public void ViewList(int view)
        {
            switch (view)
            {
                case 0:
                    listView_myvideo.View = View.Details;
                    break;
                case 1:
                    listView_myvideo.View = View.Tile;
                    break;
                case 2:
                    listView_myvideo.View = View.LargeIcon;
                    break;
                case 3:
                    listView_myvideo.View = View.SmallIcon;
                    break;
            }
        }

        public void PlayAllMusic()
        {
            listView_myvideo.Items[0].Selected = true;
            Video_Click(this, new EventArgs());
        }

        public void DeleteVideo()
        {
            if (this.parent.btn_My_Video.selected == true)
            {
                form_Delete.StartPosition = FormStartPosition.CenterParent;
                form_Delete.title.Text += listView_myvideo.SelectedItems.Count+1 + " selected item(s).";
                if (form_Delete.ShowDialog() == DialogResult.OK)
                {
                    if (form_Delete.delete_on_this_PC == true)
                    {
                        for (int i = 0; i < listView_myvideo.SelectedItems.Count; i++)
                        {
                            File.Delete(listView_myvideo.SelectedItems[i].SubItems[6].Text);
                            ListVid.Remove(new VideoInfo(listView_myvideo.SelectedItems[i].SubItems[6].Text));
                        }
                    }
                }
            }
            for (int i = 0; i < listView_myvideo.SelectedItems.Count; i++)
            {
                ListVid.Remove(new VideoInfo(listView_myvideo.SelectedItems[i].SubItems[6].Text));
            }
            ListVideoPlaying.Instance.export();
            PlayListInfoVideo.Instance.Export();
            ListVideoLiked.Instance.export();
            ShowListVid();
        }

        public void SelectAll()
        {
            for (int i = 0; i < listView_myvideo.Items.Count; i++)
            {
                listView_myvideo.Items[i].Selected = true;
            }
        }

        public void CancelSelect()
        {
            listView_myvideo.Items.Clear();
            ShowListVid();
        }

        public void AddToPlaylist(PlayListInfoVideo P_list)
        {
            if (listView_myvideo.SelectedItems.Count == 0)
                SelectAll();
            for (int i = 0; i < listView_myvideo.SelectedItems.Count; i++)
            {
                P_list.AddItems(new VideoInfo(listView_myvideo.SelectedItems[i].SubItems[2].Text));
            }
        }

        public void AddtoNowPlaying()
        {
            if (listView_myvideo.SelectedItems.Count == 0)
                SelectAll();
            for (int i = 0; i < listView_myvideo.SelectedItems.Count; i++)
            {
                ListVideoPlaying.Instance.AddItems(new VideoInfo(listView_myvideo.SelectedItems[i].SubItems[5].Text));
            }
            ListVideoPlaying.Instance.export();
            this.parent.openChildForm(new form_Video_Nowpl());
        }

        public void AddToNewPlaylist()
        {
            if (listView_myvideo.SelectedItems.Count == 0)
                SelectAll();
            List<VideoInfo> listVid = new List<VideoInfo>();
            for (int i = 0; i < listView_myvideo.SelectedItems.Count; i++)
            {
                listVid.Add(new VideoInfo(listView_myvideo.SelectedItems[i].SubItems[5].Text));
            }
            Form_Video_NewPlaylist form_Playlist = new Form_Video_NewPlaylist(this.parent, listVid);
            Point p = new Point(this.Width / 2 - form_Playlist.Width / 2, this.Height / 2 - form_Playlist.Height / 2);
            form_Playlist.StartPosition = FormStartPosition.CenterParent;
            form_Playlist.ShowDialog();
        }
        private void likeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void unlikeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteVideo();
        }

        private void playToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Video_Click(this, new EventArgs());
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelectAll();
        }

        private void cancelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CancelSelect();
        }


        private void nowPlayingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddtoNowPlaying();
        }

        private void newPlaylistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddToNewPlaylist();
        }
    }
}
