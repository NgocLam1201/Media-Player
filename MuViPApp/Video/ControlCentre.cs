using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MuViPApp.Video
{
    class ControlCentre
    {

        public static int lastVolume = 50;
        public static bool Mix = false;
        public static bool Loop = false;
        public static bool Playing = false;
        private static bool isMute = false;


        public static void TogglePlayPause(AxWMPLib.AxWindowsMediaPlayer player)
        {
            if (player.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                player.Ctlcontrols.pause();
            }
            else if (player.playState == WMPLib.WMPPlayState.wmppsPaused)
            {
                player.Ctlcontrols.play();
            }
        }
        public static void OpenMedia(string MediaAddress, AxWMPLib.AxWindowsMediaPlayer Player)
        {
            if (MediaAddress != null)
            {
                Player.Visible = true;
                Player.URL = MediaAddress;
                Player.Ctlcontrols.play();
            }
            else
            {
                MessageBox.Show("No Media To Play");
            }
        }

        public static void ODialog(AxWMPLib.AxWindowsMediaPlayer Player)
        {
            OpenFileDialog od = new OpenFileDialog();
            if (od.ShowDialog() == DialogResult.OK)
            {
                OpenMedia(od.FileName, Player);
            }
        }
    }
}
