using MuViPApp.Music;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MuViPApp
{
    public partial class Form_My_Music : Form
    {
        public int count;
        Form_Muvip parent;
        Form_ListMusic FlistMusic;
        ContextMenuStrip toolStrip = new ContextMenuStrip();

        private static Form_My_Music instance;

        public static Form_My_Music Instance
        {
            get { if (instance == null) instance = new Form_My_Music(); return instance; }
            private set { instance = value; }
        }
        public Form_My_Music(Form_Muvip parent = null)
        {
            this.parent = parent;
            InitializeComponent();
            if (Mp3Player.Instance.CurrentMilisecond > 0)
            {
                this.parent.Is_Playing_NowPlaying = false;
                this.parent.Is_Playing = true;
                this.parent.SetActive_PanelPlayer();
            }
            else
                this.parent.Is_Playing = false;
            ShowListMusic();
            toolStrip.ItemClicked += ClickItem;
        }

        void ShowListMusic()
        {          
            FlistMusic = new Form_ListMusic(this.parent, ListMyMusic.Instance.GetMusic());
            FlistMusic.TopLevel = false;
            FlistMusic.FormBorderStyle = FormBorderStyle.None;
            FlistMusic.Dock = DockStyle.Fill;
            this.pn_List.Controls.Add(FlistMusic);
            this.pn_List.Tag = FlistMusic;
            FlistMusic.BringToFront();
            FlistMusic.Show();
            count = ListMyMusic.Instance.GetMusic().Count;
            count_items.Text = "(" + count + ")";
        }

        private void Cb_My_Music_View_onItemSelected(object sender, EventArgs e)
        {
            FlistMusic.ViewList(Cb_My_Music_View.selectedIndex);
        }

        private void btn_My_Music_Play_all_Click(object sender, EventArgs e)
        {
            FlistMusic.PlayAllMusic();
        }

        private void ChoiceFolderMusic_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    ListFolderLocalMusic.Instance.Additem(fbd.SelectedPath);
                    ListFolderLocalMusic.Instance.Export();
                    ShowListMusic();
                }
            }
        }

        private void ClickItem(object sender, ToolStripItemClickedEventArgs e)
        {
            ListFolderLocalMusic.Instance.Remove(e.ClickedItem.Text);
            ListFolderLocalMusic.Instance.Export();
            this.parent.Controls.Remove(toolStrip);
        }

        private void DeleteFolderMusic_Click(object sender, EventArgs e)
        {
            toolStrip.Items.Clear();
            toolStrip.LayoutStyle = ToolStripLayoutStyle.VerticalStackWithOverflow;
            foreach (string item in ListFolderLocalMusic.Instance.GetLink())
            {
                toolStrip.Items.Add(item);
            }
            toolStrip.Show(MousePosition);
            toolStrip.BringToFront();
            toolStrip.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip.Dock = DockStyle.None;
        }        
    }
}
