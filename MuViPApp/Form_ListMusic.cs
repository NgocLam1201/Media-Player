using MuViPApp.Music;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MuViPApp
{
    public partial class Form_ListMusic : Form
    {
        public Form_Muvip parent;
        public List<Music_Song> Listmusic = new List<Music_Song>();
        public SubPanelSelect sp_SelectMusic;
        public Form_Delete form_Delete = new Form_Delete();
        ToolStripMenuItem toolStripMenuItem = new ToolStripMenuItem();
        public Form_ListMusic(Form_Muvip parent = null, List<Music_Song> Listmusic = null)
        {
            this.parent = parent;
            this.Listmusic = Listmusic;
            InitializeComponent();
            lv_My_Music.Sorting = SortOrder.None;
            LoadMusic();
            for (int i = 0; i < this.lv_My_Music.SelectedItems.Count; i++)
            {
                lv_My_Music.KeyDown += Key_Enter_Down;
            }
            lv_My_Music.DoubleClick += Music_Click;
            lv_My_Music.MouseClick += SelectMusic;
            foreach (PlayListInfo item in Playlist.Instance.GetAllPlayListMusic())
            {
                toolStripMenuItem = new ToolStripMenuItem(item.Name_PL);
                addToToolStripMenuItem.DropDownItems.Add(toolStripMenuItem);
            }
            toolStripMenuItem.Click += ToolStripMenuItem_Click;
        }

        private void ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (PlayListInfo item in Playlist.Instance.GetAllPlayListMusic())
            {
                if (item.Name_PL == toolStripMenuItem.Text)
                {
                    this.AddToPlaylist(item);
                    break;
                }
            }
        }

        public void LoadMusic()
        {
            int i = 0;
            ImageList listlargeimage = new ImageList();
            ImageList listsmallimage = new ImageList();
            foreach (Music_Song item in Listmusic)
            {
                ListViewItem items = new ListViewItem(new[] { item.Name_Song, item.Singer, item.Name_Genre, item.Date_Add, item.Length, " ", item.Link_Music });
                items.ImageIndex = i++;
                lv_My_Music.Items.Add(items);
                listlargeimage.ImageSize = new Size(100, 100);
                listlargeimage.Images.Add(item.Picture_Song);
                listsmallimage.ImageSize = new Size(30, 30);
                listsmallimage.Images.Add(item.Picture_Song);
            }
            lv_My_Music.LargeImageList = listlargeimage;
            lv_My_Music.SmallImageList = listsmallimage;
        }

        public void Music_Click(object sender, EventArgs e)
        {
            ListMusicPlaying.Instance.Remove();
            if (lv_My_Music.SelectedItems.Count == 1)
            {
                int index = lv_My_Music.Items.IndexOf(lv_My_Music.SelectedItems[0]);
                for (int i = index; i < lv_My_Music.Items.Count; i++)
                {
                    ListMusicPlaying.Instance.AddItems(new Music_Song(lv_My_Music.Items[i].SubItems[6].Text));
                }
                for (int i = 0; i < index; i++)
                {
                    ListMusicPlaying.Instance.AddItems(new Music_Song(lv_My_Music.Items[i].SubItems[6].Text));
                }
            }
            else
                for (int i = 0; i < lv_My_Music.SelectedItems.Count; i++)
                {
                    ListMusicPlaying.Instance.AddItems(new Music_Song(lv_My_Music.Items[i].SubItems[6].Text));
                }
            ListMusicPlaying.Instance.export();
            this.parent.PlayMusic(0);
            this.Controls.Remove(sp_SelectMusic);
            sp_SelectMusic = null;
            this.parent.Is_Playing = true;
            this.parent.SetActive_PanelPlayer();
            lv_My_Music.Items.Clear();
            LoadMusic();
        }

        public void SelectMusic(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Controls.Remove(sp_SelectMusic);
                this.parent.Is_Playing = false;
                this.parent.SetActive_PanelPlayer();
                sp_SelectMusic = new SubPanelSelect(this);
                if (this.parent.play.Value > 0)
                    this.parent.Is_Playing = true;
                this.Controls.Add(sp_SelectMusic);
                sp_SelectMusic.Dock = DockStyle.Bottom;
                sp_SelectMusic.BringToFront();
            }
            
        }

        public void AfterClick()
        {
            this.Controls.Remove(sp_SelectMusic);
            lv_My_Music.Items.Clear();
            LoadMusic();
            this.parent.SetActive_PanelPlayer();
        }

        private ListViewColumnSorter lvwColumnSorter;
        private void lv_My_Music_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            lvwColumnSorter = new ListViewColumnSorter();
            lv_My_Music.ListViewItemSorter = lvwColumnSorter;

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

            this.lv_My_Music.Sort();
        }

        public void Key_Enter_Down(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Music_Click(this, new EventArgs());
            }
        }

        public void ViewList(int view)
        {
            switch (view)
            {
                case 0:
                    lv_My_Music.View = View.Details;
                    break;
                case 1:
                    lv_My_Music.View = View.Tile;
                    break;
                case 2:
                    lv_My_Music.View = View.LargeIcon;
                    break;
                case 3:
                    lv_My_Music.View = View.SmallIcon;
                    break;
            }
        }

        public void PlayAllMusic()
        {
            lv_My_Music.Items[0].Selected = true;
            Music_Click(this, new EventArgs());
        }

        public void DeleteMusic()
        {
            if (lv_My_Music.SelectedItems.Count > 0)
            {
                if (this.parent.btn_My_Music.selected == true)
                {
                    form_Delete.StartPosition = FormStartPosition.CenterParent;
                    form_Delete.title.Text += lv_My_Music.SelectedItems.Count + " selected item(s).";
                    form_Delete.ShowDialog();
                    if (form_Delete.delete_on_this_PC == true)
                    {
                        for (int i = 0; i < lv_My_Music.SelectedItems.Count; i++)
                        {
                            File.Delete(lv_My_Music.SelectedItems[i].SubItems[6].Text);
                            Listmusic.Remove(new Music_Song(lv_My_Music.SelectedItems[i].SubItems[6].Text));
                        }
                    }
                }
                else
                    for (int i = 0; i < lv_My_Music.SelectedItems.Count; i++)
                    {
                        Listmusic.Remove(new Music_Song(lv_My_Music.SelectedItems[i].SubItems[6].Text));
                    }
                ListMusicPlaying.Instance.export();
                PlayListInfo.Instance.Export();
                ListMusicLiked.Instance.export();
                lv_My_Music.Items.Clear();
                LoadMusic();
            }
        }

        public void SelectAll()
        {
            for (int i=0;i<lv_My_Music.Items.Count;i++)
            {
                lv_My_Music.Items[i].Selected = true;
            }
        }

        public void CancelSelect()
        {
            AfterClick();
        }

        public void AddToPlaylist(PlayListInfo P_list)
        {
            if (lv_My_Music.SelectedItems.Count == 0)
                SelectAll();
            for (int i = 0; i < lv_My_Music.SelectedItems.Count; i++)
            {
                P_list.AddItems(new Music_Song(lv_My_Music.SelectedItems[i].SubItems[6].Text));
            }
            P_list.Export();
        }

        public void AddtoNowPlaying()
        {
            if (lv_My_Music.SelectedItems.Count == 0)
                SelectAll();
            for (int i=0;i<lv_My_Music.SelectedItems.Count;i++)
            {
                ListMusicPlaying.Instance.AddItems(new Music_Song(lv_My_Music.SelectedItems[i].SubItems[6].Text));
            }
            ListMusicPlaying.Instance.export();
        }

        public void AddToNewPlaylist()
        {
            if (lv_My_Music.SelectedItems.Count == 0)
                SelectAll();
            List<Music_Song> lstMusic = new List<Music_Song>();
            for (int i = 0; i < lv_My_Music.SelectedItems.Count; i++)
            {
                lstMusic.Add(new Music_Song(lv_My_Music.SelectedItems[i].SubItems[6].Text));
            }
            form_Music_NewPlaylist form_Playlist = new form_Music_NewPlaylist(this.parent,lstMusic);
            form_Playlist.StartPosition = FormStartPosition.CenterParent;
            form_Playlist.ShowDialog();
        }

        private void likeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lv_My_Music.SelectedItems.Count > 0)
            {
                ListMusicLiked.Instance.AddItems(new Music_Song(lv_My_Music.SelectedItems[0].SubItems[6].Text));
                ListMusicLiked.Instance.export();
            }
        }

        private void unlikeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lv_My_Music.SelectedItems.Count > 0)
            {
                ListMusicLiked.Instance.Remove(new Music_Song(lv_My_Music.SelectedItems[0].SubItems[6].Text));
                lv_My_Music.Items.Clear();
                LoadMusic();
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteMusic();
        }

        private void playToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lv_My_Music.SelectedItems.Count>0)
                Music_Click(this,new EventArgs());
        }

        private void playNextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lv_My_Music.SelectedItems.Count > 0)
                Playnext();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelectAll();
        }

        private void cancelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CancelSelect();
        }

        public void Playnext()
        {
            if (ListMusicPlaying.Instance.GetMusic().Count > 0)
            {
                List<Music_Song> TempList = new List<Music_Song>();
                int i = 0;
                foreach (Music_Song item in ListMusicPlaying.Instance.GetMusic())
                {
                    TempList.Add(item);
                    i++;
                    if (item.Name_Song == this.parent.NameMedia.Text)
                    {
                        break;
                    }
                }
                for (int j = 0; j < this.lv_My_Music.SelectedItems.Count; j++)
                {
                    TempList.Add(new Music_Song(this.lv_My_Music.SelectedItems[j].SubItems[6].Text));
                }

                for (int j = i; j < ListMusicPlaying.Instance.GetMusic().Count; j++)
                {
                    TempList.Add(ListMusicPlaying.Instance.GetMusic(j));
                }

                ListMusicPlaying.Instance.Remove();
                foreach (Music_Song item in TempList)
                {
                    ListMusicPlaying.Instance.AddItems(item);
                }
                ListMusicPlaying.Instance.export();
            }
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
