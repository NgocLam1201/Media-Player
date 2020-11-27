using System;
using System.Windows.Forms;

namespace MuViPApp
{
    public partial class form_Music_Playlist : Form
    {

        public form_Music_Playlist(string s)
        {

            InitializeComponent();
            lb_NamePl.Text = s;

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
