using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace MuViPApp
{
    public partial class Form_Muvip : Form
    {
        private Mp3Player mp3Player = new Mp3Player();
        public Form_Muvip()
        {
            InitializeComponent();
            panel_Music_Playlist.Visible = false;
            btn_Music.selected = true;
            btn_My_Music.selected = true;
            //openChildForm(new Form_My_Music());
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

       

        private void Exit_Click(object sender, EventArgs e)
        {
            btn_Playlist.selected = false;
            DialogResult mess = MessageBox.Show
             ("Are you sure you want to exit?", "Error", MessageBoxButtons.OKCancel);
            if (mess == DialogResult.OK)
                Application.Exit();
        }
        private void Music_File_Dialog()
        {
            OpenFileDialog ofd_music = new OpenFileDialog()
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
            using (ofd_music)
            {

                if (ofd_music.ShowDialog() == DialogResult.OK)
                {
                    mp3Player.open(ofd_music.FileName);

                }
            }
        }
        private void Video_File_Dialog()
        {
            OpenFileDialog ofd_video = new OpenFileDialog()
            {

                InitialDirectory = @"Video\",
                Title = "Add MP4 Files",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "mp4",
                Filter = "Mp4 Files| *.mp4;  *.vid",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };
            using (ofd_video)
            {

                if (ofd_video.ShowDialog() == DialogResult.OK)
                {
                    mp3Player.open(ofd_video.FileName);

                }
            }
        }
        private void btn_Add_Click(object sender, EventArgs e)
        {
            
            btn_Playlist.selected = false;
            if (btn_Music.selected == true)
            {
                Music_File_Dialog();
            }
            if (btn_Video.selected == true)
            {
                Video_File_Dialog();
            }
            
        }

        private void btn_Playlist_Click(object sender, EventArgs e)
        {
            panel_Player.Visible = true;
            if (panel_Music_Playlist.Visible == false) 
                panel_Music_Playlist.Visible = true;
            else panel_Music_Playlist.Visible = false;
            btn_My_Music.selected = false;
            btn_Liked.selected = false;
            btn_NowPlaying.selected = false;
            btn_History.selected = false;
            btn_Help.selected = false;
            btn_Exit.selected = false;
            if (btn_Music.selected == true)
            {
                openChildForm(new form_Music_AllPlaylist());
            }
            if (btn_Video.selected == true)
            {
                openChildForm(new form_Video_AllPlaylist());
            }
        }

        private void btn_Music_Click(object sender, EventArgs e)
        {
            btn_My_Music.Visible = true;
            btn_My_Video.Visible = false;
            btn_My_Music.selected = true;

            btn_Add.selected = false;
            btn_Liked.selected = false;
            btn_Playlist.selected = false;
            btn_NowPlaying.selected = false;
            btn_History.selected = false;
            btn_Help.selected = false;
            btn_Exit.selected = false;
            openChildForm(new Form_My_Music());
        }

        private void btn_Video_Click(object sender, EventArgs e)
        {
            btn_My_Video.Visible = true;
            btn_My_Music.Visible = false;
            btn_My_Video.selected = true;

            btn_Add.selected = false; 
            btn_Liked.selected = false;
            btn_Playlist.selected = false;
            btn_NowPlaying.selected = false;
            btn_History.selected = false;
            btn_Help.selected = false;
            btn_Exit.selected = false;
            openChildForm(new Form_My_Video());
        }

        private void btn_AddPl_Click(object sender, EventArgs e)
        {
            if (btn_User.Visible == true)
            {
                form_Music_NewPlaylist form_Playlist = new form_Music_NewPlaylist(this);
                Point p = new Point(this.Width / 2 - form_Playlist.Width / 2, this.Height / 2 - form_Playlist.Height / 2);
                form_Playlist.StartPosition = FormStartPosition.CenterParent;
                form_Playlist.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please login to use this feature", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_NowPlaying_Click(object sender, EventArgs e)
        {
            btn_Playlist.selected = false;
            panel_Player.Visible = false;
            if (btn_Music.selected == true)
            {
                openChildForm(new Form_Music_Nowpl(mp3Player));
            }
            if (btn_Video.selected == true)
            {
                openChildForm(new form_Video_Nowpl(mp3Player));
            }
        }

        private void btn_My_Music_Click(object sender, EventArgs e)
        {
            panel_Player.Visible = true;
            btn_Playlist.selected = false;
            if (btn_Music.selected == true)
                openChildForm(new Form_My_Music());
        }

        private void btn_My_Video_Click(object sender, EventArgs e)
        {
            panel_Player.Visible = true;
            btn_Playlist.selected = false;
            if (btn_Video.selected == true)
                openChildForm(new Form_My_Video());
        }

        private void btn_Liked_Click(object sender, EventArgs e)
        {
            panel_Player.Visible = true;
            btn_Playlist.selected = false;
            if (btn_Music.selected==true)
            {
                openChildForm(new Form_Liked_Music());
            }
            if (btn_Video.selected==true)
            {
                openChildForm(new Form_Liked_Video());
            }
        }

        private void btn_History_Click(object sender, EventArgs e)
        {
            panel_Player.Visible = true;
            btn_Playlist.selected = false;
            if (btn_Music.selected == true)
            {
                openChildForm(new Form_History_Music());
            }
            if (btn_Video.selected == true)
            {
                openChildForm(new Form_History_Video());
            }
        }

        private void Login_Click(object sender, EventArgs e)
        {
            form_Login lgin = new form_Login(this);
            lgin.ShowDialog();

        }
    }
}