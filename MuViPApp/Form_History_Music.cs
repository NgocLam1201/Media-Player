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
    public partial class Form_History_Music : Form
    {
        Form_Muvip parent;
        Form_ListMusic FlistMusic;
        public Form_History_Music(Form_Muvip parent = null)
        {
            this.parent = parent;
            InitializeComponent();
            this.parent.Is_Playing_NowPlaying = false;
            LoadHistory();
        }

        void LoadHistory()
        {
            FlistMusic = new Form_ListMusic(this.parent, ListMusicRecently.Instance.GetMusic());
            FlistMusic.TopLevel = false;
            FlistMusic.FormBorderStyle = FormBorderStyle.None;
            FlistMusic.Dock = DockStyle.Fill;
            this.pn_List.Controls.Add(FlistMusic);
            this.pn_List.Tag = FlistMusic;
            FlistMusic.BringToFront();
            FlistMusic.Show();
        }
    }
}
