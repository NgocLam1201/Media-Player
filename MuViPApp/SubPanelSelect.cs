using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MuViPApp.Music;

namespace MuViPApp
{
    public partial class SubPanelSelect : UserControl
    {
        Form_ListMusic parent;
        ToolStrip toolStrip = new ToolStrip();
        public SubPanelSelect(Form_ListMusic parent = null)
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
                    foreach (PlayListInfo item in Playlist.Instance.GetAllPlayListMusic())
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
                foreach (PlayListInfo item in Playlist.Instance.GetAllPlayListMusic())
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
            if (ListMusicPlaying.Instance.GetMusic().Count > 0)
            {
                List<Music_Song> TempList = new List<Music_Song>();
                int i = 0;
                foreach (Music_Song item in ListMusicPlaying.Instance.GetMusic())
                {
                    TempList.Add(item);
                    i++;
                    if (item.Name_Song == this.parent.parent.NameMedia.Text)
                    {
                        break;
                    }
                }
                for (int j=0;j<this.parent.lv_My_Music.SelectedItems.Count;j++)
                {
                    TempList.Add(new Music_Song(this.parent.lv_My_Music.SelectedItems[j].SubItems[6].Text));
                }    
            
                for (int j = i;j<ListMusicPlaying.Instance.GetMusic().Count;j++)
                {
                    TempList.Add(ListMusicPlaying.Instance.GetMusic(j));
                }

                ListMusicPlaying.Instance.Remove();
                foreach (Music_Song item in TempList)
                {
                    ListMusicPlaying.Instance.AddItems(item);
                }
                ListMusicPlaying.Instance.export();
                this.parent.AfterClick();
            }
        }

        private void btn_Play_Click(object sender, EventArgs e)
        {
            this.parent.Music_Click(this, new EventArgs());
            this.parent.AfterClick();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.parent.CancelSelect();
            this.parent.AfterClick();
        }
    }
}
