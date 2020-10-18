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
    public partial class form_Music_Playlist : Form
    {
        form_Rename_pl childform;
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
          //  this.lb_NamePl.Text = form_Rename.

        }
    }
}
