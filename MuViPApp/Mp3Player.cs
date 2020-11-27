using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using WMPLib;
using System.Drawing;

namespace MuViPApp
{
    public class Mp3Player
    {
        [DllImport("winmm.dll")]
        private static extern int mciSendString(string strCommand, StringBuilder strReturn, int iReturnLength, IntPtr hwndCallback);
        [DllImport("winmm.dll")]
        public static extern int waveOutGetVolume(IntPtr hwo, out uint dwVolume);
        [DllImport("winmm.dll")]
        public static extern int waveOutSetVolume(IntPtr hwo, uint dwVolume);
        public enum PlayerStatus { Ready, Playing, Paused, Stopped };
        string _command;
        public bool loop = false;
        private static Mp3Player instance;

        public static Mp3Player Instance
        {
            get { if (instance == null) instance = new Mp3Player(); return instance; }
            private set { instance = value; }
        }
        public void Open(string fileName)
        {
            _command = "open \"" + fileName + "\" type mpegvideo alias YinYangMedia";
            mciSendString(_command, null, 0, IntPtr.Zero);
        }
        public void Close()
        {
            _command = "close YinYangMedia";
            mciSendString(_command, null, 0, IntPtr.Zero);
        }
        public void Play()
        {
            _command = "play YinYangMedia";
            if (loop)
                _command += " repeat";
            mciSendString(_command, null, 0, IntPtr.Zero);
        }

        public void Pause()
        {
            _command = "pause YinYangMedia";
            mciSendString(_command, null, 0, IntPtr.Zero);

        }
        public void Stop()
        {
            mciSendString("stop YinYangMedia", null, 0, IntPtr.Zero);
        }
        public void Seek(int miliseconds)
        {
            _command = "play YinYangMedia from " + miliseconds;
            mciSendString(_command, null, 0, IntPtr.Zero);
        }

        public void DisplayMediaWindow()
        {
            mciSendString("put YinYangMedia", null, 0, IntPtr.Zero);
        }

        public void DisplayMediaWindow(Rectangle rec)
        {
            mciSendString(String.Format("put YinYangMedia window at {0} {1} {2} {3}",
                                        rec.Left, rec.Top, rec.Width, rec.Height), null, 0, IntPtr.Zero);
        }
        StringBuilder _buffer;
        public int Length
        {
            get
            {
                mciSendString("status YinYangMedia length", _buffer, 0, IntPtr.Zero);
                try
                {
                    return (int)Math.Floor(Convert.ToDouble(_buffer.ToString().Trim()));
                }
                catch { return 0; }
            }
        }
        public int CurrentMilisecond
        {
            get
            {
                mciSendString("status YinYangMedia position", _buffer, 0, IntPtr.Zero);
                try
                {
                    return (int)Math.Floor(Convert.ToDouble(_buffer.ToString().Trim()));
                }
                catch { return 0; }
            }
            set
            {
                Seek(value);
            }
        }
        /*
        [DllImport("winmm.dll")]
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
        /*private WindowsMediaPlayer sound;

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
        }*/
    }
}
