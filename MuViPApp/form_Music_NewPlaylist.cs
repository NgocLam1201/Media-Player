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
    public partial class form_Music_NewPlaylist : Form
    {
        Form_Muvip parent;
        public form_Music_NewPlaylist(Form_Muvip parent)
        {
            this.parent = parent;
            InitializeComponent();
        }

        List<Music_Song> listMusic = new List<Music_Song>();

        public form_Music_NewPlaylist(Form_Muvip parent, List<Music_Song> listMusic)
        {
            this.parent = parent;
            InitializeComponent();
            this.listMusic = listMusic;
            this.KeyDown += Key_OK;
        }

        private void Key_OK(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btn_Ok_Click(this, new EventArgs());
            else
                if (e.KeyCode == Keys.Escape)
                btn_Cancel_Click(this, new EventArgs());
        }

        private void btn_Ok_Click(object sender, EventArgs e)
        {
            bool check = true;
            if (tb_Name.Text == "")
                MessageBox.Show("Enter a playlist's name","Notify");
            else
            {
                foreach (PlayListInfo item in Playlist.Instance.GetAllPlayListMusic())
                {
                    if (tb_Name.Text == item.Name_PL)
                    {
                        check = false;
                        MessageBox.Show("This name is already.", "Error");
                    }
                }
                if (check == true)
                {
                    Playlist.Instance.AddItems(new PlayListInfo(DateTime.Now.ToString(), tb_Name.Text, listMusic));
                    form_Music_Playlist NewForm = new form_Music_Playlist(new Music_Playlist(Playlist.Instance.GetAllPlayListMusic().Count - 1, this.tb_Name.Text, 0, this.parent));
                    this.parent.openChildForm(NewForm);
                    Playlist.Instance.Export();
                    Playlist.Instance.GetListMusic(Playlist.Instance.GetAllPlayListMusic().Count - 1).Export();
                    Close();
                }
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
