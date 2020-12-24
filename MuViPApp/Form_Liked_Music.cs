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
    public partial class Form_Liked_Music : Form
    {
        Form_ListMusic FlistMusic;
        Form_Muvip parent;
        public Form_Liked_Music(Form_Muvip parent = null)
        {
            this.parent = parent;
            InitializeComponent();
            
        }

        public void ShowListMusic()
        {
            FlistMusic = new Form_ListMusic(this.parent, ListMusicLiked.Instance.GetMusic());
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
