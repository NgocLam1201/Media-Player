using System;
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
            Number_song.Text = this.parent.Number_song + " song";
        }

        protected form_Rename_pl form_Rename;

        private void btn_Rename_Click(object sender, EventArgs e)
        {
            form_Rename = new form_Rename_pl();
            form_Rename.ShowDialog(this);
            this.lb_NamePl.Text = form_Rename.s;

        }
    }
}
