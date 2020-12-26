using MuViPApp.Music;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace MuViPApp
{
    public partial class form_Music_Playlist : Form
    {
        Music_Playlist parent;
        Form_ListMusic FlistMusic;
        ToolStrip toolStrip = new ToolStrip();

        public form_Music_Playlist(Music_Playlist parent = null)
        {
            this.parent = parent;
            InitializeComponent();
            lb_NamePl.Text = this.parent.NamePlay;
            this.parent.parent.Is_Playing_NowPlaying = false;
            LoadListMusic();
            toolStrip.ItemClicked += ClickItem;
        }

        private void LoadListMusic()
        {
            FlistMusic = new Form_ListMusic(this.parent.parent, Playlist.Instance.GetListMusic(this.parent.ID_Playlist).GetMusic());
            FlistMusic.TopLevel = false;
            FlistMusic.FormBorderStyle = FormBorderStyle.None;
            FlistMusic.Dock = DockStyle.Fill;
            this.pn_List.Controls.Add(FlistMusic);
            this.pn_List.Tag = FlistMusic;
            FlistMusic.BringToFront();
            FlistMusic.Show();
            Number_song.Text = FlistMusic.lv_My_Music.Items.Count + " song";
            this.Date_create.Text = Playlist.Instance.GetListMusic(this.parent.ID_Playlist).Date_Create.ToString();
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
            FlistMusic.PlayAllMusic();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            FlistMusic.DeleteMusic();
        }

        private void btn_Addto_Click(object sender, EventArgs e)
        {
            toolStrip.Items.Add("Now playing");
            toolStrip.LayoutStyle = ToolStripLayoutStyle.VerticalStackWithOverflow;
            toolStrip.Items.Add("-");
            toolStrip.Items.Add("New playlist");
            int Y = 400;
            foreach (PlayListInfo item in Playlist.Instance.GetAllPlayListMusic())
            {
                toolStrip.Items.Add(item.Name_PL);
            }
            toolStrip.Location = new Point(btn_Addto.Location.X + 70, btn_Addto.Location.Y + Y);
            this.parent.Controls.Add(toolStrip);
            toolStrip.BringToFront();
            toolStrip.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip.Dock = DockStyle.None;
        }

        private void ClickItem(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Text)
            {
                case "Now playing":
                    FlistMusic.AddtoNowPlaying();
                    break;
                case "New playlist":
                    FlistMusic.AddToNewPlaylist();
                    break;
                default:
                    foreach (PlayListInfo item in Playlist.Instance.GetAllPlayListMusic())
                    {
                        if (item.Name_PL == e.ClickedItem.Text)
                        {
                            FlistMusic.AddToPlaylist(item);
                            break;
                        }
                    }
                    break;
            }
            toolStrip = null;
            FlistMusic.AfterClick();
        }
    }
}
