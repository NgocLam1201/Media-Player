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
        private Mp3Player mp3Player_Nowpl;
        public form_Video_Nowpl(Mp3Player mp3)
        {
            mp3Player_Nowpl = mp3;
            InitializeComponent();
        }

      
    }
}
