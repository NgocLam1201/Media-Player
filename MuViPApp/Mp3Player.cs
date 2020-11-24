using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using WMPLib;

namespace MuViPApp
{
    public class Mp3Player
    {
        /*[DllImport("winmm.dll")]
        private static extern long mciSendString(string lpstrCommand, StringBuilder lpstrReturnString, int uReturnLength, int hwdCallBack);

        public void open(string File)
        {
            string Format = @"open ""{0}"" type MPEGVideo alias MediaFile";
            string command = string.Format(Format, File);
            mciSendString(command, null, 0, 0);
        }

        public void play()
        {
            string command = "play MediaFile";
            mciSendString(command, null, 0, 0);
        }
        public void stop()
        {
            string command = "stop MediaFile";
            mciSendString(command, null, 0, 0);
        }*/
        private WindowsMediaPlayer sound;

        public Mp3Player()
        {
            sound = new WindowsMediaPlayer();
        }

        public void Open(string _filePath)
        {
            sound.URL = _filePath;

        }

        public void Play()
        {
            sound.controls.play();
        }

        public void Stop()
        {
            sound.controls.stop();
        }

        public void Pause()
        {
            sound.controls.pause();
        }

        public void Resume()
        {
            if (sound.status == "Paused")
                sound.controls.play();
        }
    }
}
