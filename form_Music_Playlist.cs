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
        
        public form_Music_Playlist(string s)
        {
            
            InitializeComponent();
            lb_NamePl.Text = s;

        }

        private void btn_Rename_Click(object sender, EventArgs e)
        {
           // lb_NamePl.Text.;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_GotoCollection_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void text_Addsong_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
