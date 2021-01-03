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

namespace MuViPApp
{
    public partial class Form_History_Video : Form
    {
        Form_Muvip parent;
        ListVideo FlistMusic;
        public Form_History_Video(Form_Muvip parent = null)
        {
            this.parent = parent;
            InitializeComponent();
            LoadHistory();
        }

        void LoadHistory()
        {
            ListVideoRecently.Instance.Load();
            FlistMusic = new ListVideo(this.parent, ListVideoRecently.Instance.GetVideo());
            FlistMusic.TopLevel = false;
            FlistMusic.FormBorderStyle = FormBorderStyle.None;
            FlistMusic.Dock = DockStyle.Fill;
            this.pn_List.Controls.Add(FlistMusic);
            this.pn_List.Tag = FlistMusic;
            FlistMusic.BringToFront();
            FlistMusic.Show();
        }
    }
}
