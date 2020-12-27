using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MuViPApp.Video;
using System.IO;
using AxWMPLib;


namespace MuViPApp
{
    public partial class form_Video_Nowpl : Form
    {
        Form_Muvip parent;
        private int index = 0;
        public form_Video_Nowpl(Form_Muvip parent = null)
        {
            this.parent = parent;
            InitializeComponent();
            ShowList();
            if (listView_VideoPlaying.Items.Count > 0)
           { 
                PlayVideo(0); 
          }
            setMixIcon();
            setLoopIcon();
            Volume_Slider.Value = ControlCentre.lastVolume;
            setPlayIcon();
            
        }
        public void ShowList()
        {

            foreach (VideoInfo item in ListVideoPlaying.Instance.GetVideo())
            {
                ListViewItem items = new ListViewItem(new[] {item.Name,item.Length,item.Link_Video});
                listView_VideoPlaying.Items.Add(items);
            }
        }

        //Play Video

        private void setPlayIcon()
        {
            if (ControlCentre.Playing)
            {
                btn_Play.Visible = true;
                btn_Pause.Visible = false;
            }
            else
            {
                btn_Play.Visible = false;
                btn_Pause.Visible = true;
            }
        }
        public void PlayVideo(int i)
        {
            index = i;
            listView_VideoPlaying.Items[i].Selected = true;
            MediaPlayer.URL = listView_VideoPlaying.Items[i].SubItems[2].Text;
            lb_Length.Text = listView_VideoPlaying.Items[i].SubItems[1].Text;
            lb_NameVid.Text = listView_VideoPlaying.Items[i].SubItems[0].Text;
            ControlCentre.Playing = true;
            MediaPlayer.Ctlcontrols.play();
            setPlayIcon();
            timer_Video.Start();
            VideoInfo Video = ListVideoPlaying.Instance.GetVideo(index);
            //parent.AddHistoryvideo(Video);
        }


        
        private void listView_VideoPlaying_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView_VideoPlaying.SelectedItems.Count>0)
            {
                listView_VideoPlaying.SelectedItems[0].Focused= true;
                PlayVideo(listView_VideoPlaying.SelectedItems[0].Index);


            }
        }

        private void btn_Before_Click(object sender, EventArgs e)
        {

            var rand = new Random();
            int count = listView_VideoPlaying.Items.Count;
            if (ControlCentre.Mix)
            {
                if (ListVideoPlayed.Instance.count() > 1)
                {
                    ListVideoPlayed.Instance.RemoveLastItem();
                    index = ListVideoPlayed.Instance.GetLastItem();
                    
                }
                else
                {
                    int ran = rand.Next(0, count);
                    while (ran == index)
                        ran = rand.Next(0, count);
                    index = ran;
                }
            }
            else
            {
                if (index == 0) index = listView_VideoPlaying.Items.Count;
                index--;
            }
            PlayVideo(index);

            
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            var rand = new Random();
            int count =listView_VideoPlaying.Items.Count;
            if (ControlCentre.Mix)
            {
                int ran = rand.Next(0, count);
                while (ran == index)
                    ran = rand.Next(0, count);
                index = ran;
            }
            else
            {
                index++;
                if (index == count) index = 0; 
            }
            ListVideoPlayed.Instance.AddItems(index);
            PlayVideo(index);

        }

        private void btn_Pause_Click(object sender, EventArgs e)
        {
            ControlCentre.Playing = true;
            MediaPlayer.Ctlcontrols.play();
            setPlayIcon();
        }

        private void btn_Play_Click(object sender, EventArgs e)
        {
            ControlCentre.Playing = false;
            MediaPlayer.Ctlcontrols.pause();
            setPlayIcon();
        }

        //Mix
        private void setMixIcon()
        {
            if (ControlCentre.Mix)
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
        private void Mix_Media_Click(object sender, EventArgs e)
        {
            ControlCentre.Mix = true;
            setMixIcon();
        }

        private void Is_Mix_Click(object sender, EventArgs e)
        {
            ControlCentre.Mix = false;
            setMixIcon();
        }
        //Loop
        private void setLoopIcon()
        {
            if (ControlCentre.Loop)
            {
                Loop.Visible = false;
                Is_Loop.Visible = true;
            }
            else
            {
                Loop.Visible = true;
                Is_Loop.Visible = false;
            }
        }

        private void Loop_Click(object sender, EventArgs e)
        {
            ControlCentre.Loop = true;
            setLoopIcon();
        }

        private void Is_Loop_Click(object sender, EventArgs e)
        {
            ControlCentre.Loop = false;
            setLoopIcon();
        }

        //Volume

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
            MediaPlayer.settings.volume = Volume_Slider.Value;
            if (Volume_Slider.Value > 0)
                ControlCentre.lastVolume = Volume_Slider.Value;
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
            Volume_Slider.Value = ControlCentre.lastVolume;
            SetIconVolume();
            Volume_Slider_ValueChanged(this, new EventArgs());
        }

        //Video Slider
        private void timer_Video_Tick(object sender, EventArgs e)
        {
            lb_currentTime.Text = MediaPlayer.Ctlcontrols.currentPositionString;
            lb_Endtime.Text = MediaPlayer.currentMedia.durationString;
            Video_Slider.Value = (int)MediaPlayer.Ctlcontrols.currentPosition;
            Video_Slider.MaximumValue = (int)MediaPlayer.currentMedia.duration;
            if (Video_Slider.Value == Video_Slider.MaximumValue&& Video_Slider.MaximumValue!=0)
            {
                timer_Video.Stop();
                if (ControlCentre.Loop) PlayVideo(index);
                else btn_Next_Click(sender, new EventArgs());
            }
        }

        private void Video_Slider_ValueChanged(object sender, EventArgs e)
        {
            MediaPlayer.Ctlcontrols.currentPosition = Video_Slider.Value;
            Video_Slider.MaximumValue = (int)MediaPlayer.currentMedia.duration;
           
        }
    }
}
