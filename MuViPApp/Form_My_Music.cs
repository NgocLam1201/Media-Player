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
            this.parent.Is_Playing_NowPlaying = true;
            ShowListMusic();
        }        

        void ShowListMusic()
        {
            ListMyMusic.Instance.Remove();
            foreach (var child in Directory.GetFiles(@"F:\Media-Player\data\music"))
            {
                FileInfo info = new FileInfo(child);
                if (info.Extension == ".mp3")
                {
                    ListMyMusic.Instance.AddItems(new Music_Song(info.FullName));
                }
            }
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
    }
}
