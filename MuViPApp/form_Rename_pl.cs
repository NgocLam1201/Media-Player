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
    
    public partial class form_Rename_pl : Form
    {
        private string reName;
        public string ReName { get { return reName; } set{ reName = value; } }

        form_Music_Playlist parent;
        Form_Video_Playlist mother;

        public form_Rename_pl(form_Music_Playlist parent = null)
        {
            this.parent = parent;
            InitializeComponent();
        }

        public form_Rename_pl(Form_Video_Playlist mother = null)
        {
            this.mother = mother;
            InitializeComponent();
        }

        private void btn_Rename_Ok_Click(object sender, EventArgs e)
        {
            reName = tb_NewName.Text;
            bool check = true;
            if (tb_NewName.Text == "")
                MessageBox.Show("Enter a playlist's name", "Notify");
            else
            {
                if (this.parent != null)
                {
                    foreach (PlayListInfo item in Playlist.Instance.GetAllPlayListMusic())
                    {
                        if (tb_NewName.Text == item.Name_PL)
                        {
                            check = false;
                            MessageBox.Show("This name is already.", "Error");
                        }
                    }
                    if (check == true)
                    {
                        this.parent.lb_NamePl.Text = tb_NewName.Text;
                        Playlist.Instance.GetListMusic(this.parent.parent.ID_Playlist).Name_PL = tb_NewName.Text;
                        Playlist.Instance.Export();
                        Playlist.Instance.GetListMusic(Playlist.Instance.GetAllPlayListMusic().Count - 1).Export();
                        Close();
                    }
                }
                else
                {
                    foreach (PlayListInfo item in Playlist.Instance.GetAllPlayListMusic())
                    {
                        if (tb_NewName.Text == item.Name_PL)
                        {
                            check = false;
                            MessageBox.Show("This name is already.", "Error");
                        }
                    }
                    if (check == true)
                    {
                        this.mother.lb_NamePl.Text = tb_NewName.Text;
                        PlaylistVideo.Instance.GetListVideo(this.mother.parent.ID_Playlist).Name_PL = tb_NewName.Text;
                        PlaylistVideo.Instance.Export();
                        PlaylistVideo.Instance.GetListVideo(PlaylistVideo.Instance.GetAllPlayListVideo().Count - 1).Export();
                        Close();
                    }
                }    
            }
            this.Close();
        }

        private void btn_Rename_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void form_Rename_pl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                reName = tb_NewName.Text;
                this.Close();
            }
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }
    }
}
