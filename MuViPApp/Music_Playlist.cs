using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MuViPApp
{
    public partial class Music_Playlist : UserControl
    {
        private static Music_Playlist instance;

        public static Music_Playlist Instance
        {
            get { if (instance == null) instance = new Music_Playlist(); return Music_Playlist.instance; }
            private set { Music_Playlist.instance = value; }
        }

        public Music_Playlist()
        {
            InitializeComponent();
        }

        public Music_Playlist(string name, int total)
        {
            InitializeComponent();
            lb_Playlist_Name.Text = name;
        }

        private void Playlist_Load(object sender, EventArgs e)
        {

        }
    }
}
