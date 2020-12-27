using MuViPApp.Music;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MuViPApp
{
    public partial class Form_Music_Nowpl : Form
    {
        Form_Muvip parent;
        Form_ListMusic FlistMusic;

        private static Form_Music_Nowpl instance;

        public static Form_Music_Nowpl Instance
        {
            get { if (instance == null) instance = new Form_Music_Nowpl(); return instance; }
            private set { instance = value; }
        }

        public Form_Music_Nowpl(Form_Muvip parent = null)
        {
            this.parent = parent;
            InitializeComponent();
            LoadMusic();
            this.timer_play.Start();
            this.parent.Is_Playing_NowPlaying = true;
            SetPlay();
            setMixIcon();
            setLoopIcon();
        }

        public void LoadMusic()
        {
            FlistMusic = new Form_ListMusic(this.parent, ListMusicPlaying.Instance.GetMusic());
            FlistMusic.TopLevel = false;
            FlistMusic.FormBorderStyle = FormBorderStyle.None;
            FlistMusic.Dock = DockStyle.Fill;
            this.pn_List.Controls.Add(FlistMusic);
            this.pn_List.Tag = FlistMusic;
            FlistMusic.BringToFront();
            FlistMusic.Show();
        }

        private void SetPlay()
        {
            if (this.parent.play.Value == 0)
            {
                this.lb_NamePl.Visible = false;
                this.lb_Info_Music.Visible = false;
            }
            else
            {
                this.lb_NamePl.Visible = true;
                this.lb_Info_Music.Visible = true;
                this.picturesong.Image = this.parent.picturesong.Image;
                if (this.parent.index > -1)
                    this.lb_Info_Music.Text = this.parent.Artist.Text + " - " + this.parent.RestTime.Text + " - " + ListMusicPlaying.Instance.GetMusic(this.parent.index).Date_Add;
                this.lb_NamePl.Text = this.parent.NameMedia.Text;
                this.play.MaximumValue = this.parent.play.MaximumValue;
                this.play.Value = this.parent.play.Value;
                this.Volume_Slider.Value = this.parent.Volume_Slider.Value;
                this.RestTime.Text = this.parent.RestTime.Text;
                this.BeginTime.Text = this.parent.BeginTime.Text;
            }
        }

        private void setMixIcon()
        {
            if (Mp3Player.Instance.Mix == true)
            {
                Is_Mix.Visible = true;
                btn_Music_Nowpl_Mix.Visible = false;
            }
            else
            {
                Is_Mix.Visible = false ;
                btn_Music_Nowpl_Mix.Visible = true;
            }                

        }
        //play music 
        public void SetPlayIcon()
        {
            if (Mp3Player.Instance.Is_playing)
            {
                btn_Music_Nowpl_Pause.Visible = false;
                btn_Music_Nowpl_Play.Visible = true;
            }
            else
            {
                btn_Music_Nowpl_Pause.Visible = true;
                btn_Music_Nowpl_Play.Visible = false;
            }
        }
        private void btn_Music_Nowpl_Pause_Click(object sender, EventArgs e)
        {         
            Mp3Player.Instance.Play();
            SetPlayIcon();
            parent.SetPlayIcon();
        }

        private void btn_Music_Nowpl_Play_Click(object sender, EventArgs e)
        {
            Mp3Player.Instance.Pause();
            SetPlayIcon();
            parent.SetPlayIcon();
        }

        private void btn_Music_Nowpl_Replay_Click(object sender, EventArgs e)
        {
            this.parent.LoopMusic(this, new EventArgs());
        }

        private void btn_Music_Nowpl_Next_Click(object sender, EventArgs e)
        {
            this.parent.Next_Play_Click(this.parent, new EventArgs());
            SetPlay();
            SetPlayIcon();
        }

        private void btn_Music_Nowpl_Before_Click(object sender, EventArgs e)
        {
            this.parent.Pre_Play_Click(this, new EventArgs());
            SetPlay();
            SetPlayIcon();
        }

        private void btn_Music_Nowpl_Mix_Click(object sender, EventArgs e)
        {
            Mp3Player.Instance.Mix = true;
            setMixIcon();
            parent.SetMixIcon();
        }

        private void Volume_Slider_ValueChanged(object sender, EventArgs e)
        {
            Mp3Player.Instance.SetVolume(this.Volume_Slider.Value);
            this.parent.Volume_Slider.Value = this.Volume_Slider.Value;
            SetIconVolume();
        }

        private void max_Volume_Click(object sender, EventArgs e)
        {
            this.parent.max_Volume_Click(this, new EventArgs());
        }

        private void Mute_Click(object sender, EventArgs e)
        {
            this.parent.Mute_Click(this, new EventArgs());
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

        private void Is_Mix_Click(object sender, EventArgs e)
        {
            Mp3Player.Instance.Mix = false;
            setMixIcon();
            parent.SetMixIcon();
        }

        //Loop
        private void setLoopIcon()
        {
            if (Mp3Player.Instance.loop)
            {
                Is_Loop.Visible = true;
                Loop.Visible = false;
            }    
            else
            {
                Is_Loop.Visible = false;
                Loop.Visible = true;
            }    
        }

        private void Is_Loop_Click(object sender, EventArgs e)
        {
            Mp3Player.Instance.loop = false;
            setLoopIcon();
            parent.Is_Loop_Click(sender, e);
        }

        private void Loop_Click(object sender, EventArgs e)
        {
            Mp3Player.Instance.loop = true;
            setLoopIcon();
            parent.LoopMusic(sender, e);
        }

        private void timer_play_Tick_1(object sender, EventArgs e)
        {
            SetPlay();
        }

        private void play_ValueChanged(object sender, EventArgs e)
        {
            Mp3Player.Instance.Seek(this.play.Value * 1000);
            this.parent.Set_PlayValue(this.play.Value);
        }
    }
}
