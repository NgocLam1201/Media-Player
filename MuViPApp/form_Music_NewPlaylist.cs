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
        Form_Muvip parent = new Form_Muvip();
        public form_Music_NewPlaylist(Form_Muvip pr)
        {
            parent = pr;
            InitializeComponent();
        }
  
        private void btn_Ok_Click(object sender, EventArgs e)
        {
            /*if (tb_Name.Text == "") lb_Notice.Text = "Enter Playlist's Name.";
            else
            {
                form_Music_Playlist nf = new form_Music_Playlist(tb_Name.Text);
                parent.openChildForm(nf);
               // Music
                this.Close();
            }*/
        }
        public void OpenForm(Form parent)
        {          
            //this.StartPosition = FormStartPosition.CenterParent;
            //this.ShowDialog();
        }
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void form_Music_NewPlaylist_Load(object sender, EventArgs e)
        {

        }
        
    }
}
