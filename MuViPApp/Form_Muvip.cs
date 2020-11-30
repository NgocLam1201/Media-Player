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
using MuViPApp.DAO;
using System.IO;

namespace MuViPApp
{
    public partial class Form_Muvip : Form
    {
        public string ID_Account = null;

        public bool Is_Playing = false;
        private static Form_Muvip instance;

        public static Form_Muvip Instance
        {
            get { if (instance == null) instance = new Form_Muvip(); return instance; }
            private set { instance = value; }
        }

        public int index = -1;
        bool Mix_Music = false;
        int length;
        int volume;
        public Form_Muvip()
        {
            InitializeComponent();
            panel_Music_Playlist.Visible = false;
            btn_Music.selected = true;
            btn_My_Music.selected = true;
            btn_Music_Play.Visible = false;
            btn_Music_Pause.Visible = true;
            uint CurrVol = 0;
            Mp3Player.waveOutGetVolume(IntPtr.Zero, out CurrVol);
            ushort CalcVol = (ushort)(CurrVol & 0x0000ffff);
            Is_Loop.Visible = false;
            Is_Mix.Visible = false;
<<<<<<< HEAD
            if (Volume_Slider.Value == 0)
                Volume_Slider.Value = CalcVol / (ushort.MaxValue / 10);
            SetIconVolume();
=======
            panel_Player.Visible = false;
            // gán 1 giá trị tăng lên bằng 1/10 âm lượng
            //trackBar2.Value = CalcVol / (ushort.MaxValue / 10);
>>>>>>> cb9d679a3c2084d0bcb2f47aa5f17196fce3516f
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
        
        public void btn_Music_Play_Click(object sender, EventArgs e)
        {
            if (btn_Music_Play.Visible == true)
            {
                btn_Music_Play.Visible = false;
                btn_Music_Pause.Visible = true;
                Mp3Player.Instance.Pause();
                Time_real.Stop();
            }
        }

        public void btn_Music_Pause_Click(object sender, EventArgs e)
        {
            if (btn_Music_Pause.Visible == true)
            {
                btn_Music_Pause.Visible = false;
                btn_Music_Play.Visible = true;
                Mp3Player.Instance.Play();
                Time_real.Start();
            }
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
                    FileInfo fileInfo = new FileInfo(ofd_music.FileName);
                    Mp3Player.Instance.Open(ofd_music.FileName);
                    //MessageBox.Show();
                    /*try
                    {

                        string s = "";
                        for (int i = 0; i < this..currentMedia.attributeCount; i++)
{
                            s += this.axWindowsMediaPlayer1.currentMedia.getAttributeName(i) + " : ";
                            s += this.axWindowsMediaPlayer1.currentMedia.getItemInf o(this.axWindowsMediaPlayer1.currentMedia.getAttri buteName(i)) + "\n";
                        }
                        MessageBox.Show(s, this.Text);
                    }
                    catch (Exception loi) { MessageBox.Show(loi.Message); }*/
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
            if (btn_User.Visible == true)
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
                    openChildForm(new form_Music_AllPlaylist(this));
                }
                if (btn_Video.selected == true)
                {
                    openChildForm(new form_Video_AllPlaylist(this));
                }
            }
            else
            {
                MessageBox.Show("Please login to use this feature", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                openChildForm(new Form_Music_Nowpl(this));
            }
            if (btn_Video.selected == true)
            {
                openChildForm(new form_Video_Nowpl(this));
            }
        }

        private void btn_My_Music_Click(object sender, EventArgs e)
        {
            if (Is_Playing == true) panel_Player.Visible = true;
            btn_Playlist.selected = false;
            if (btn_Music.selected == true)
                openChildForm(new Form_My_Music(this));
        }

        private void btn_My_Video_Click(object sender, EventArgs e)
        {
            if (Is_Playing == true) panel_Player.Visible = true;
            btn_Playlist.selected = false;
            if (btn_Video.selected == true)
                openChildForm(new Form_My_Video());
        }

        private void btn_Liked_Click(object sender, EventArgs e)
        {
            if (Is_Playing == true) panel_Player.Visible = true;
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
            if (Is_Playing==true) panel_Player.Visible = true;
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

        private void Login_Click(object sender, EventArgs e)
        {
            form_Login lgin = new form_Login(this);
            Point p = new Point(this.Width / 2 - lgin.Width / 2, this.Height / 2 - lgin.Height / 2);
            lgin.StartPosition = FormStartPosition.CenterParent;
            lgin.ShowDialog();

        }

        private void btn_User_Click(object sender, EventArgs e)
        {

        }
        private int a, b, c;

        private void Time_real_Tick(object sender, EventArgs e)
        {
            if (play.Value < play.MaximumValue)
                play.Value++;
            string[] time = BeginTime.Text.Split(':');
            a = Convert.ToInt32(time[0]);
            b = Convert.ToInt32(time[1]);
            c = Convert.ToInt32(time[2]);
            BeginTime.Text = "";
            c += 1;
            if (c > 59)
            {
                b++;
                if (b > 59)
                {
                    a++;
                }
            }
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
            if (BeginTime.Text == RestTime.Text)
            {
                Time_real.Stop();
                Thread.Sleep(1000);
                btn_Music_Play_Click(this, new EventArgs());
                Next_Play_Click(this, new EventArgs());
            }
        }

        private void play_ValueChanged(object sender, EventArgs e)
        {
            Mp3Player.Instance.Seek(play.Value*1000);
            int value_time = play.Value;
            a = value_time / 3600;
            value_time -= a * 3600;
            b = value_time / 60;
            c = value_time - b * 60;
            BeginTime.Text = "";
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
        }

        public void Next_Play_Click(object sender, EventArgs e)
        {
            var rand = new Random();
            int count = ListMusicPlaying.Instance.Listmusic.Count;
            if (Mix_Music)
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
            ListViewItem Music = ListMusicPlaying.Instance.GetMusic(index);
            DateTime length = Convert.ToDateTime(Music.SubItems[4].Text);
            this.length = length.Hour * 3600 + length.Minute * 60 + length.Second;
            this.NameMedia.Text = NameMedia.Text.Replace(NameMedia.Text, Music.SubItems[0].Text);
            this.Artist.Text = Music.SubItems[1].Text;
            this.RestTime.Text = Music.SubItems[4].Text;
            Mp3Player.Instance.Open(Music.SubItems[5].Text);
            Mp3Player.Instance.Play();
            btn_Music_Pause_Click(this, new EventArgs());
            Time_Media_Play();
            if (ID_Account != null)
            {
                AddHistory(Music);
            }
        }

        private void AddHistory(ListViewItem Music)
        {
            string Sql = @"insert into History values (N'" +
                Music.SubItems[0].Text + @"',N'" +
                Music.SubItems[1].Text + @"',N'" +
                Music.SubItems[2].Text + @"',GETDATE(),N'" +
                Music.SubItems[4].Text + @"',N'" +
                Music.SubItems[5].Text + @"',N'" +
                Music.SubItems[6].Text + @"','Music',N'" +
                ID_Account + @"')";
            DataProvider.Instance.ExecuteNonQuery(Sql);
        }

        //Loop

        public void LoopMusic(object sender, EventArgs e)
        {
            Mp3Player.Instance.loop = true;
            Is_Loop.Visible = true;
            Loop.Visible = false;
        }
        private void Is_Loop_Click(object sender, EventArgs e)
        {
            Mp3Player.Instance.loop = false;
            Is_Loop.Visible = false;
            Loop.Visible = true;
        }

        //Mix Music
        private void Is_Mix_Click(object sender, EventArgs e)
        {
            Mix_Music = false;
            Is_Mix.Visible = false;
            Mix_Media.Visible = true;
        }
        public void Mix_Media_Click(object sender, EventArgs e)
        {   
            Mix_Music = true;
            Is_Mix.Visible = true;
            Mix_Media.Visible = false;
        }

        public void Pre_Play_Click(object sender, EventArgs e)
        {
            var rand = new Random();
            int length = ListMusicPlaying.Instance.Listmusic.Count;
            if (Mix_Music)
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

        public void Volume_MouseLeave(object sender, EventArgs e)
        {
            Volume_Slider.Visible = false;
        }

        public void Volume_MouseMove(object sender, MouseEventArgs e)
        {
            Volume_Slider.Visible = true;
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
            Time_real_Tick(this, new EventArgs());
            play.Value = 0;
            play.MaximumValue = this.length;
        }

    }
}