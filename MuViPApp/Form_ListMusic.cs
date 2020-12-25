using MuViPApp.Music;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            sp_SelectMusic = null;
            this.parent.Is_Playing = true;
            this.parent.SetActive_PanelPlayer();
            lv_My_Music.Items.Clear();
            LoadMusic();
        }

        public void SelectMusic(object sender, MouseEventArgs e)
        {
            /*if (lv_My_Music.Items[lv_My_Music.Items.IndexOf(lv_My_Music.SelectedItems[0])].Selected == true)
            {
                lv_My_Music.SelectedItems[0].Selected = false;
            }*/    
            if (sp_SelectMusic == null)
            {
                this.parent.Is_Playing = false;
                this.parent.SetActive_PanelPlayer();
                sp_SelectMusic = new SubPanelSelect(this);
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
            for (int i = 0; i < lv_My_Music.SelectedItems.Count; i++)
            {
                ListMusicPlaying.Instance.Remove(lv_My_Music.Items.IndexOf(lv_My_Music.SelectedItems[i]));
            }
            LoadMusic();
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
            lv_My_Music.Items.Clear();
            LoadMusic();
        }

        public void AddToPlaylist(PlayListInfo P_list)
        {
            for (int i = 0; i < lv_My_Music.SelectedItems.Count; i++)
            {
                P_list.AddItems(new Music_Song(lv_My_Music.SelectedItems[i].SubItems[6].Text));
            }
        }

        public void AddtoNowPlaying()
        {
            for (int i=0;i<lv_My_Music.SelectedItems.Count;i++)
            {
                ListMusicPlaying.Instance.AddItems(new Music_Song(lv_My_Music.SelectedItems[i].SubItems[6].Text));
            }
            ListMusicPlaying.Instance.export();
        }

        public void AddToNewPlaylist()
        {
            List<Music_Song> lstMusic = new List<Music_Song>();
            for (int i = 0; i < lv_My_Music.SelectedItems.Count; i++)
            {
                lstMusic.Add(new Music_Song(lv_My_Music.SelectedItems[i].SubItems[6].Text));
            }
            form_Music_NewPlaylist form_Playlist = new form_Music_NewPlaylist(this.parent,lstMusic);
            Point p = new Point(this.Width / 2 - form_Playlist.Width / 2, this.Height / 2 - form_Playlist.Height / 2);
            form_Playlist.StartPosition = FormStartPosition.CenterParent;
            form_Playlist.ShowDialog();
        }
    }
}
