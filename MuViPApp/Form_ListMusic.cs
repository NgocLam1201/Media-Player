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
        Form_Muvip parent;
        List<Music_Song> Listmusic = new List<Music_Song>();
        public Form_ListMusic(Form_Muvip parent = null, List<Music_Song> Listmusic = null)
        {
            this.parent = parent;
            this.Listmusic = Listmusic;
            InitializeComponent();
            LoadMusic();
            for (int i = 0; i < this.lv_My_Music.SelectedItems.Count; i++)
            {
                lv_My_Music.KeyDown += Key_Enter_Down;
            }
            lv_My_Music.DoubleClick += Music_Click;
        }

        public void LoadMusic()
        {
            int i = 0;
            ImageList listimage = new ImageList();
            foreach (Music_Song item in Listmusic)
            {
                ListViewItem items = new ListViewItem(new[] { item.Name_Song, item.Singer, item.Name_Genre, item.Date_Add, item.Length, " ", item.Link_Music });
                items.ImageIndex = i++;
                lv_My_Music.Items.Add(items);
                listimage.Images.Add(item.Picture_Song);
            }
            lv_My_Music.LargeImageList = listimage;
            lv_My_Music.SmallImageList = listimage;
        }

        public void Music_Click(object sender, EventArgs e)
        {
            ListMusicPlaying.Instance.Remove();
            this.parent.Is_Playing = true;
            this.parent.SetActive_PanelPlayer();
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
            this.parent.PlayMusic(0);
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
    }
}
