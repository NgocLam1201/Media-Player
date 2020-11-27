using MuViPApp.Music;
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
    public partial class Form_Music_Nowpl : Form
    {
        Form_Muvip parent;
        public Form_Music_Nowpl(Form_Muvip parent = null)
        {
            this.parent = parent;
            InitializeComponent();
            for (int i = 0; i < ListMusicPlaying.Instance.Listmusic.Count; i++)
            {
                lv_My_Music.Items.Add(ListMusicPlaying.Instance.Listmusic[i]);
            }
            this.timer_play.Interval = 1000;
            this.timer_play.Start();
            if (this.parent.index != -1 )
                this.lb_Info_Music.Text = this.parent.Artist.Text + " - " + this.parent.RestTime.Text + " - " + ListMusicPlaying.Instance.GetMusic(this.parent.index).SubItems[3].Text;
            SetPlay();
        }

        private void SetPlay()
        {
            this.lb_NamePl.Text = this.parent.NameMedia.Text;
            this.play.MaximumValue = this.parent.play.MaximumValue;
            this.play.Value = this.parent.play.Value;
        }

        private void btn_Music_Nowpl_Pause_Click(object sender, EventArgs e)
        {
                btn_Music_Nowpl_Pause.Visible = false;
                btn_Music_Nowpl_Play.Visible = true;
                Mp3Player.Instance.Play();           
        }

        private void btn_Music_Nowpl_Play_Click(object sender, EventArgs e)
        {            
                btn_Music_Nowpl_Play.Visible = false;
                btn_Music_Nowpl_Pause.Visible = true;
                Mp3Player.Instance.Pause();                                                                  
        }

        private void btn_Music_Nowpl_Replay_Click(object sender, EventArgs e)
        {
            this.parent.LoopMusic(this, new EventArgs());
        }

        private void btn_Music_Nowpl_Next_Click(object sender, EventArgs e)
        {
            this.parent.Next_Play_Click(this.parent,new EventArgs());
        }

        private void btn_Music_Nowpl_Before_Click(object sender, EventArgs e)
        {
            this.parent.Pre_Play_Click(this, new EventArgs());
        }

        private void timer_play_Tick(object sender, EventArgs e)
        {
            SetPlay();
        }

        private void btn_Music_Nowpl_Mix_Click(object sender, EventArgs e)
        {
            this.parent.Mix_Media_Click(this, new EventArgs());
        }
    }
}
