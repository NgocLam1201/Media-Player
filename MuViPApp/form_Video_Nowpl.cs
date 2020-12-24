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
    public partial class form_Video_Nowpl : Form
    {
        Form_Muvip parent;

        public form_Video_Nowpl(Form_Muvip parent = null)
        {
            this.parent = parent;
            InitializeComponent();
        }
        //Play
        private void SetPlayIcon()
        {
            if (Mp3Player.Instance.Is_playing)
            {
                btn_Pause.Visible = false;
                btn_Play.Visible = true;
            }
            else
            {
                btn_Pause.Visible = true;
                btn_Play.Visible = false;
            }
        }
        private void btn_Pause_Click(object sender, EventArgs e)
        {
            Mp3Player.Instance.Is_playing = false;
            MediaPlayer.Ctlcontrols.play();
            SetPlayIcon();
            parent.SetPlayIcon();
        }

        private void btn_Play_Click(object sender, EventArgs e)
        {
            Mp3Player.Instance.Is_playing = true;
            MediaPlayer.Ctlcontrols.play();
            SetPlayIcon();
            parent.SetPlayIcon();
        }

     


    }
}
