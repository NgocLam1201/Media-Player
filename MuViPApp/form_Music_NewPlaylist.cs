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
  
        private void btn_Ok_Click(object sender, EventArgs e)
        {
            if (tb_Name.Text == "")
                MessageBox.Show("Enter a playlist's name","Notify");
            else
            {
                Playlist.Instance.AddItems(new PlayListInfo(DateTime.Now, tb_Name.Text));
                form_Music_Playlist NewForm = new form_Music_Playlist(new Music_Playlist(Playlist.Instance.GetAllPlayListMusic().Count - 1,this.tb_Name.Text,0,this.parent));
                this.parent.openChildForm(NewForm);
                this.Close();
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }     
    }
}
