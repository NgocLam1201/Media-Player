using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MuViPApp.Video.Classes
{
    class ControlCentre
    {
         public static string currentMediaAddress;
        public static int lastVolume = 100;
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
                //currentMediaAddress = MediaAddress;
                //AutoPlaylist.CurrentTrack = MediaAddress;
               // MainForm.isReady = true;
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
