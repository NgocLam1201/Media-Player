using MuViPApp.Music;
using System;
using System.Data;
using System.Windows.Forms;

namespace MuViPApp
{
    public partial class form_Music_Playlist : Form
    {
        Music_Playlist parent;
        public form_Music_Playlist(Music_Playlist parent = null)
        {
            this.parent = parent;
            InitializeComponent();
            lb_NamePl.Text = this.parent.Name;
            LoadListMusic();
            for (int i = 0; i < this.lv_My_Music.SelectedItems.Count; i++)
            {
                lv_My_Music.KeyDown += Key_Enter_Down;
            }
            lv_My_Music.DoubleClick += Music_Click;
        }

        private void LoadListMusic()
        {
            foreach (Music_Song item in Playlist.Instance.GetListMusic(this.parent.ID_Playlist).GetMusic())
            {
                this.lv_My_Music.Items.Add(new ListViewItem(new[] { item.Name_Song, item.Singer, item.Name_Genre, item.Date_Add, item.Length, " ", item.Link_Music }));
            }
            Number_song.Text = this.lv_My_Music.Items.Count + " song";
        }

        public void Music_Click(object sender, EventArgs e)
        {
            ListMusicPlaying.Instance.Remove();
            this.parent.parent.Is_Playing = true;
            this.parent.parent.SetActive_PanelPlayer();
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
            this.parent.parent.PlayMusic(0);
            lv_My_Music.Items.Clear();
            LoadListMusic();
        }

        public void Key_Enter_Down(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Music_Click(this, new EventArgs());
            }
        }

        private void btn_Rename_Click(object sender, EventArgs e)
        {
            form_Rename_pl form_Rename = new form_Rename_pl();
            if (form_Rename.ShowDialog(this) == DialogResult.OK)
                this.lb_NamePl.Text = form_Rename.s;
        }

        private void btn_Playall_Click(object sender, EventArgs e)
        {
            lv_My_Music.Items[0].Selected = true;
            Music_Click(this, new EventArgs());
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lv_My_Music.SelectedItems.Count; i++)
            {
                ListMusicPlaying.Instance.Remove(lv_My_Music.Items.IndexOf(lv_My_Music.SelectedItems[i]));
            }
            LoadListMusic();
        }

        private void btn_Addto_Click(object sender, EventArgs e)
        {

        }
    }
}
