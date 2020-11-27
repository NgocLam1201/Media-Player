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
    public partial class Form_My_Video : Form
    {
        public Form_My_Video()
        {
            InitializeComponent();
            string _cmd = "/Media-Player/data/video/Tik Tok Trung Quốc 🇨🇳 __ Các bài tập để có đôi tay đẹp ❤ ❤ (2).mp4";
            Mp3Player.Instance.Open(_cmd);
            Mp3Player.Instance.DisplayMediaWindow();
            Mp3Player.Instance.Play();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}
