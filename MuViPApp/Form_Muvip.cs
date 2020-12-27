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
using System.Threading;
using MuViPApp.Music;
using System.IO;

namespace MuViPApp
{
    public partial class Form_Muvip : Form
    {
        public bool Is_Playing = false;
        public bool Is_Playing_NowPlaying = false;
        private static Form_Muvip instance;

        public static Form_Muvip Instance
        {
            get { if (instance == null) instance = new Form_Muvip(); return instance; }
            private set { instance = value; }
        }

        public int index = -1;
        int length;
        int volume;
        public Form_Muvip()
        {
            InitializeComponent();
            btn_Music.selected = true;
            btn_Music_Play.Visible = false;
            btn_Music_Pause.Visible = true;
            uint CurrVol = 0;
            Mp3Player.waveOutGetVolume(IntPtr.Zero, out CurrVol);
            ushort CalcVol = (ushort)(CurrVol & 0x0000ffff);
            Is_Loop.Visible = false;
            Is_Mix.Visible = false;
            if (Volume_Slider.Value == 0)
                Volume_Slider.Value = CalcVol / (ushort.MaxValue / 10);
            SetIconVolume();
            
            if (play.Value > 0)
            {
                Is_Playing = true;
            }
            else
                Is_Playing = false;
            SetActive_PanelPlayer();
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
        public void SetActive_PanelPlayer()
        {
            if (btn_Music.selected == true)
            {
                if (Is_Playing == true && Is_Playing_NowPlaying == false) panel_Player.Visible = true;
                else
                    panel_Player.Visible = false;
            }
            if (btn_Video.selected==true) panel_Player.Visible = false;
        }

        public void SetPlayIcon()
        {
            if (Mp3Player.Instance.Is_playing)
            {
                btn_Music_Play.Visible = true;
                btn_Music_Pause.Visible = false;
            }
            else
            {
                btn_Music_Play.Visible = false;
                btn_Music_Pause.Visible = true;
            }                
        }
        public void btn_Music_Play_Click(object sender, EventArgs e)
        {
                Mp3Player.Instance.Pause();
                SetPlayIcon();
                Time_real.Stop();
        }

        public void btn_Music_Pause_Click(object sender, EventArgs e)
        {
            Mp3Player.Instance.Play();
            SetPlayIcon();
            Time_real.Start();
        }

        public void Exit_Click(object sender, EventArgs e)
        {
            btn_Playlist.selected = false;
            DialogResult mess = MessageBox.Show("Are you sure you want to exit?", "Error", MessageBoxButtons.OKCancel);
            if (mess == DialogResult.OK)
                Application.Exit();
        }
        private void Music_File_Dialog()
        {
            OpenFileDialog ofd_music = new OpenFileDialog()
            {
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic),
                Title = "Add MP3 Files",

                CheckFileExists = false,
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
                    FileInfo fileInfo = new FileInfo(ofd_music.FileName);
                    ListFolderLocalMusic.Instance.Additem(fileInfo.FullName);
                    ListFolderLocalMusic.Instance.Export();
                    this.openChildForm(new Form_My_Music(this));
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
                    Mp3Player.Instance.Open(ofd_video.FileName);

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
            SetActive_PanelPlayer();
            btn_My_Music.selected = false;
            btn_Liked.selected = false;
            btn_NowPlaying.selected = false;
            btn_History.selected = false;
            btn_Exit.selected = false;
            if (btn_Music.selected == true)
            {
                openChildForm(new form_Music_AllPlaylist(this));
            }
            if (btn_Video.selected == true)
            {
                openChildForm(new form_Video_AllPlaylist(this));
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
            btn_Exit.selected = false;
            openChildForm(new Form_My_Music(this));
        }

        private void btn_Video_Click(object sender, EventArgs e)
        {
            btn_Music_Play_Click(sender, e);
            btn_Video.selected = true;
            btn_My_Video.Visible = true;
            btn_My_Music.Visible = false;
            btn_My_Video.selected = true;
            btn_Add.selected = false; 
            btn_Liked.selected = false;
            btn_Playlist.selected = false;
            btn_NowPlaying.selected = false;
            btn_History.selected = false;
            btn_Exit.selected = false;
            openChildForm(new Form_My_Video(this));
        }

        public void btn_AddPl_Click(object sender, EventArgs e)
        {
            if (btn_Music.selected == true)
            {
                form_Music_NewPlaylist form_Playlist = new form_Music_NewPlaylist(this);
                Point p = new Point(this.Width / 2 - form_Playlist.Width / 2, this.Height / 2 - form_Playlist.Height / 2);
                form_Playlist.StartPosition = FormStartPosition.CenterParent;
                form_Playlist.ShowDialog();
            }
            if (btn_Video.selected == true)
            {
                Form_Video_NewPlaylist form_Playlist = new Form_Video_NewPlaylist(this);
                Point p = new Point(this.Width / 2 - form_Playlist.Width / 2, this.Height / 2 - form_Playlist.Height / 2);
                form_Playlist.StartPosition = FormStartPosition.CenterParent;
                form_Playlist.ShowDialog();
            }
        }

        private void btn_NowPlaying_Click(object sender, EventArgs e)
        {
            btn_Playlist.selected = false;
            panel_Player.Visible = false;
            if (btn_Music.selected == true)
            {
                openChildForm(new Form_Music_Nowpl(this));
            }
            if (btn_Video.selected == true)
            {
                openChildForm(new form_Video_Nowpl());
            }
        }

        private void btn_My_Music_Click(object sender, EventArgs e)
        {
            SetActive_PanelPlayer();
            btn_Playlist.selected = false;
            if (btn_Music.selected == true)
                openChildForm(new Form_My_Music(this));
        }

        private void btn_My_Video_Click(object sender, EventArgs e)
        {
            btn_Playlist.selected = false;
            if (btn_Video.selected == true)
                openChildForm(new Form_My_Video(this));
        }

        private void btn_Liked_Click(object sender, EventArgs e)
        {
            SetActive_PanelPlayer();
            btn_Playlist.selected = false;
            if (btn_Music.selected==true)
            {
                openChildForm(new Form_Liked_Music(this));
            }
            if (btn_Video.selected==true)
            {
                openChildForm(new Form_Liked_Video(this));
            }
        }

        private void btn_History_Click(object sender, EventArgs e)
        {
            SetActive_PanelPlayer();
            btn_Playlist.selected = false;
            if (btn_Music.selected == true)
            {
                openChildForm(new Form_History_Music(this));
            }
            if (btn_Video.selected == true)
            {
                openChildForm(new Form_History_Video(this));
            }
        }

        private int a, b, c;

        private void Time_real_Tick(object sender, EventArgs e)
        {
            if (play.Value < play.MaximumValue)
                play.Value++;
            Set_PlayValue(play.Value);
            if (BeginTime.Text == RestTime.Text)
            {
                Time_real.Stop();
                Thread.Sleep(1000);
                btn_Music_Play_Click(this, new EventArgs());
                Next_Play_Click(this, new EventArgs());
            }
        }

        public void Set_PlayValue(int value)
        {
            int value_time = value;
            a = value_time / 3600;
            value_time -= a * 3600;
            b = value_time / 60;
            c = value_time - b * 60;
            this.BeginTime.Text = "";
            if (a < 10)
            {
                BeginTime.Text += "0" + a.ToString();
            }
            else
                BeginTime.Text += a.ToString() + "";
            BeginTime.Text += ":";
            if (b < 10)
            {
                BeginTime.Text += "0" + b.ToString();
            }
            else
                BeginTime.Text += b.ToString() + "";
            BeginTime.Text += ":";
            if (c < 10)
            {
                BeginTime.Text += "0" + c.ToString();
            }
            else
                BeginTime.Text += c.ToString() + "";
            this.play.Value = value;
        }

        private void play_ValueChanged(object sender, EventArgs e)
        {
            Mp3Player.Instance.Seek(play.Value * 1000);
            Set_PlayValue(play.Value);
        }

        public void Next_Play_Click(object sender, EventArgs e)
        {
            var rand = new Random();
            int count = ListMusicPlaying.Instance.GetMusic().Count;
            if (Mp3Player.Instance.Mix)
            {
                int ran = rand.Next(0, count);
                while (ran == index)
                    ran = rand.Next(0, count);
                index = ran;
            }   
            else 
                index ++;
            if (index == count)
            {
                index = 0;
            }
            PlayMusic(index);
        }

        public void PlayMusic(int index)
        {
            this.index = index;
            Mp3Player.Instance.Close();
            btn_Music_Play_Click(this, new EventArgs());
            Music_Song Music = ListMusicPlaying.Instance.GetMusic(index);
            DateTime time = Convert.ToDateTime(Music.Length);
            this.length = time.Hour * 3600 + time.Minute * 60 + time.Second;
            this.play.MaximumValue = this.length;
            this.NameMedia.Text = Music.Name_Song;
            this.Artist.Text = Music.Singer;
            this.RestTime.Text = Music.Length;
            this.picturesong.Image = Music.Picture_Song;
            Mp3Player.Instance.Open(Music.Link_Music);
            Mp3Player.Instance.Play();
            btn_Music_Pause_Click(this, new EventArgs());
            Time_Media_Play();
            AddHistory(Music);
        }

        private void AddHistory(Music_Song Music)
        {
            ListMusicRecently.Instance.AddItems(Music);
        }

        public void LoopMusic(object sender, EventArgs e)
        {
            Mp3Player.Instance.loop = true;
            Is_Loop.Visible = true;
            Loop.Visible = false;
        }
        public void Is_Loop_Click(object sender, EventArgs e)
        {
            Mp3Player.Instance.loop = false;
            Is_Loop.Visible = false;
            Loop.Visible = true;
        }

        //Mix Music
        public void SetMixIcon()
        {
            if (Mp3Player.Instance.Mix==true)
            {
                Is_Mix.Visible = true;
                Mix_Media.Visible = false;
            }
            else
            {
                Is_Mix.Visible = false;
                Mix_Media.Visible = true;
            }
        }
        public void Is_Mix_Click(object sender, EventArgs e)
        {
            Mp3Player.Instance.Mix = false;
            SetMixIcon();
        }
        public void Mix_Media_Click(object sender, EventArgs e)
        {
            Mp3Player.Instance.Mix = true;
            SetMixIcon();
        }

        public void Pre_Play_Click(object sender, EventArgs e)
        {
            var rand = new Random();
            int length = ListMusicPlaying.Instance.GetMusic().Count;
            if (Mp3Player.Instance.Mix)
            {
                int ran = rand.Next(0, length);
                while (ran == index)
                    ran = rand.Next(0, length);
                index = ran;
            }
            else
                index--;
            if (index < 0)
            {
                index = length - 1;
            }
            PlayMusic(index);
        }
        //volume//
        public void max_Volume_Click(object sender, EventArgs e)
        {
            Volume_Slider.Value = 0;
            medium_Volume.Visible = false;
            max_Volume.Visible = false;
            Mute.Visible = true;
            Volume_Slider_ValueChanged(this, new EventArgs());
        }

        public void Volume_Slider_ValueChanged(object sender, EventArgs e)
        {
            Mp3Player.Instance.SetVolume(Volume_Slider.Value);
            if (Volume_Slider.Value > 0)
                this.volume = Volume_Slider.Value;
            SetIconVolume();
        }

        void SetIconVolume()
        {
            if (Volume_Slider.Value == 0)
            {
                Mute.Visible = true;
                max_Volume.Visible = false;
                medium_Volume.Visible = false;
            }
            else if (Volume_Slider.Value <= 50)
            {
                Mute.Visible = false;
                max_Volume.Visible = false;
                medium_Volume.Visible = true;
            }

            if (Volume_Slider.Value > 50)
            {
                Mute.Visible = false;
                max_Volume.Visible = true;
                medium_Volume.Visible = false;
            }
        }

        public void Mute_Click(object sender, EventArgs e)
        {
            Volume_Slider.Value = volume;
            SetIconVolume();
            Volume_Slider_ValueChanged(this, new EventArgs());
        }

        public void Time_Media_Play()
        {
            BeginTime.Text = "00:00:00";
            a = b = c = 0;
            Time_real.Start();
            play.Value = 0;
            play.MaximumValue = this.length;
        }

    }
}