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
    public partial class Form_Muvip : Form
    {
        
        public Form_Muvip()
        {
            InitializeComponent();
            panel_Music_Playlist.Visible = false;
        }
        
        private void btn_Home_Click(object sender, EventArgs e)
        {
          
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            DialogResult mess = MessageBox.Show
              ("Are you sure you want to exit?", "Error", MessageBoxButtons.OKCancel);
            if (mess == DialogResult.OK)
                this.Close();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = @"D:\",
                Title = "Browse Text Files",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "mp3",
                Filter = "mp3 files (*.mp3)|*.mp3",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
               // textBox1.Text = openFileDialog1.FileName;
            }
        }

 

        private void btn_Playlist_Click(object sender, EventArgs e)
        {
            if (panel_Music_Playlist.Visible == false) panel_Music_Playlist.Visible = true;
            else panel_Music_Playlist.Visible = false;
            

        }

        private void pn_Childform_Paint(object sender, PaintEventArgs e)
        {

        }

        private Form activeForm = null;
        public void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pn_Childform.Controls.Add(childForm);
            pn_Childform.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void bt_AddPlaylist_Click(object sender, EventArgs e)
        {
            Form form_Playlist = new form_Music_NewPlaylist(this);
            form_Playlist.Show();

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}