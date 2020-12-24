using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.DirectX.AudioVideoPlayback;
using System.IO;

namespace MuViPApp
{
    public partial class form_Video_Nowpl : Form
    {
        Form_Muvip parent;

        public form_Video_Nowpl(Form_Muvip parent = null)
        {
            this.parent = parent;
            InitializeComponent();
        }

            private Video video;
            private string[] videoPaths;
            private string folderPath = @"C:\Users\Admin\Videos\";
            private int selectedIndex = 0;
            private Size formSize;
            private Size pnlSize;


            private void form_Video_Nowpl_Load(object sender, EventArgs e)
            {
                formSize = new Size(this.Width, this.Height);
                pnlSize = new Size(pn_Video.Width, pn_Video.Height);

                videoPaths = Directory.GetFiles(folderPath, "*.wmv", SearchOption.AllDirectories);

                if (videoPaths != null)
                {
                    foreach (string path in videoPaths)
                    {
                        string vid = path.Replace(folderPath, string.Empty);
                        vid = vid.Replace(".wmv", string.Empty);
                        list_Video.Items.Add(vid);
                    }
                }
               list_Video.SelectedIndex = selectedIndex;
                video = new Video(videoPaths[0], false);

        }

      

            private void Video_Ending(object sender, EventArgs e)
            {
                Task.Factory.StartNew(() =>
                {
                    System.Threading.Thread.Sleep(2000);

                    if (InvokeRequired)
                    {
                        this.Invoke(new Action(() =>
                        {
                            NextVideo();
                        }));
                    }
                });
            }

            private void NextVideo()
            {
                int index = list_Video.SelectedIndex;
                index++;
                if (index > videoPaths.Length - 1)
                    index = 0;
                selectedIndex = index;
                list_Video.SelectedIndex = index;
            }

            private void btnNext_Click(object sender, EventArgs e)
            {
                NextVideo();
            }

            private void btnPrevious_Click(object sender, EventArgs e)
            {
                PreviousVideo();
            }

            private void PreviousVideo()
            {
                int index = list_Video.SelectedIndex;
                index--;
                if (index == -1)
                    index = videoPaths.Length - 1;
                selectedIndex = index;
                list_Video.SelectedIndex = index;
            }

            private void btnPlayPause_Click(object sender, EventArgs e)
            {
                if (!video.Playing)
                {
                    video.Play();
                    tmrVideo.Enabled = true;
                    //btnPlayPause.Text = "Pause";
                }
                else if (video.Playing)
                {
                    video.Pause();
                    tmrVideo.Enabled = false;
                    //btnPlayPause.Text = "Play";
                }
            }

            private void btnFullscreen_Click(object sender, EventArgs e)
            {
                FormBorderStyle = FormBorderStyle.None;
                WindowState = FormWindowState.Maximized;
                video.Owner = this;
            }

            private void Form1_KeyDown(object sender, KeyEventArgs e)
            {
                if (e.KeyCode == Keys.Escape)
                {
                    //exit full screen when escape is pressed
                    FormBorderStyle = FormBorderStyle.Sizable;
                    WindowState = FormWindowState.Normal;
                    this.Size = formSize;
                    video.Owner = pn_Video;
                    pn_Video.Size = pnlSize;
                }
            }

            private void trackVolume_Scroll(object sender, EventArgs e)
            {
               // video.Audio.Volume = trackVolume.Value;
            }

            private void btnVolume_Click(object sender, EventArgs e)
            {
                //trackVolume.Visible = !trackVolume.Visible;
            }

            private void tmrVideo_Tick(object sender, EventArgs e)
            {
                int currentTime = Convert.ToInt32(video.CurrentPosition);
                int maxTime = Convert.ToInt32(video.Duration);

               // lblVideoPosition.Text = string.Format("{0:00}:{1:00}:{2:00}", currentTime / 3600, (currentTime / 60) % 60, currentTime % 60)
                 //                       + " / " +
                  //                      string.Format("{0:00}:{1:00}:{2:00}", maxTime / 3600, (maxTime / 60) % 60, maxTime % 60);
            }

        private void btn_Play_Click(object sender, EventArgs e)
        {

        }

        private void list_Video_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            int index = list_Video.SelectedIndex;
                selectedIndex = index;
                video = new Video(videoPaths[index], false);
                video.Owner = pn_Video;
                pn_Video.Size = pnlSize;
                video.Play();
                tmrVideo.Enabled = true;
                //btnPlayPause.Text = "Pause";
                video.Ending += Video_Ending;
            //lblVideo.Text = lstVideos.Text;
            

        }
    }
}




