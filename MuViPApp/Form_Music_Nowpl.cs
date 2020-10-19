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
        private Mp3Player mp3Player_Nowpl;
        public Form_Music_Nowpl(Mp3Player mp3)
        {
            mp3Player_Nowpl = mp3;
            InitializeComponent();
        }

        private void btn_Music_Nowpl_Pause_Click(object sender, EventArgs e)
        {
           
                btn_Music_Nowpl_Pause.Visible = false;
                btn_Music_Nowpl_Play.Visible = true;
                mp3Player_Nowpl.play();
            
        }

        private void btn_Music_Nowpl_Play_Click(object sender, EventArgs e)
        {
            
                btn_Music_Nowpl_Play.Visible = false;
                btn_Music_Nowpl_Pause.Visible = true;
                mp3Player_Nowpl.stop();
                                                                    
        }
    }
}
