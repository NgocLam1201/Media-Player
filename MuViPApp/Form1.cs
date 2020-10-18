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
        private Mp3Player mp3Player = new Mp3Player();
        public Form_Muvip()
        {
            InitializeComponent();
            panel_Music_Playlist.Visible = false;
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
        
        private void btn_Music_Play_Click(object sender, EventArgs e)
        {
            if (btn_Music_Play.Visible == true)
            {
                btn_Music_Play.Visible = false;
                btn_Music_Pause.Visible = true;
                mp3Player.stop();
            }
        }

        private void btn_Music_Pause_Click(object sender, EventArgs e)
        {
             if (btn_Music_Pause.Visible == true)
            {
                btn_Music_Pause.Visible = false;
                btn_Music_Play.Visible = true;
                mp3Player.play();
            }
        }

       

        private void Exit_Click_1(object sender, EventArgs e)
        {
            //activeForm.Close();
            DialogResult mess = MessageBox.Show
             ("Are you sure you want to exit?", "Error", MessageBoxButtons.OKCancel);
            if (mess == DialogResult.OK)
                Application.Exit();
        }

        private void btn_Add_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog()
            {
                InitialDirectory = @"Music\",
                Title = "Add MP3 Files",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "mp3",
                Filter = "Mp3 Files| *.mp3",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };
            using (ofd)
            {

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    mp3Player.open(ofd.FileName);

                }
            }
        }

        private void btn_Playlist_Click_1(object sender, EventArgs e)
        {
            if (panel_Music_Playlist.Visible == false) panel_Music_Playlist.Visible = true;
            else panel_Music_Playlist.Visible = false;
        }

        private void btn_Music_Click(object sender, EventArgs e)
        {
            btn_Music.selected = true;
        }
        
        private void btn_AddPl_Click(object sender, EventArgs e)
        {
            form_Music_NewPlaylist form_Playlist = new form_Music_NewPlaylist(this);
            Point p = new Point(this.Width / 2 - form_Playlist.Width / 2, this.Height / 2 - form_Playlist.Height / 2);
            form_Playlist.StartPosition = FormStartPosition.CenterParent;
            form_Playlist.ShowDialog();
        }

        private void btn_NowPlaying_Click(object sender, EventArgs e)
        {
            Form form_Music_Npl = new Form_Music_Nowpl();
            form_Music_Npl.ShowDialog();
        }
    }
}