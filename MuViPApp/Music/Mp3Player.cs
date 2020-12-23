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
        public bool Is_playing = false;
        public bool loop = false;
        public bool Mix = false;
        private const int BUFFER_LENGTH = 255;
        StringBuilder _buffer = new StringBuilder(BUFFER_LENGTH);
        private static Mp3Player instance;

        public static Mp3Player Instance
        {
            get { if (instance == null) instance = new Mp3Player(); return instance; }
            private set { instance = value; }
        }
        public void Open(string fileName)
        {
            _command = "open \"" + fileName + "\" type mpegvideo alias MuVipApp";
            mciSendString(_command, null, 0, IntPtr.Zero);
        }
        public void Close()
        {
            _command = "close MuVipApp";
            mciSendString(_command, null, 0, IntPtr.Zero);
        }
        public void Play()
        {
            Is_playing = true;
            _command = "play MuVipApp";
            if (loop)
                _command += " repeat";
            mciSendString(_command, null, 0, IntPtr.Zero);
        }

        public void Pause()
        {
            Is_playing = false;
            _command = "pause MuVipApp";
            mciSendString(_command, null, 0, IntPtr.Zero);

        }
        public void Stop()
        {
            mciSendString("stop MuVipApp", null, 0, IntPtr.Zero);
        }
        public void Seek(int miliseconds)
        {
            if (this.Status.Equals("playing", StringComparison.OrdinalIgnoreCase))
            {
                _command = "play MuVipApp from " + miliseconds;
                mciSendString(_command, null, 0, IntPtr.Zero);
            }
            else
            {
                _command = "seek MuVipApp to " + miliseconds;
                mciSendString(_command, null, 0, IntPtr.Zero);
            }
        }

        public void DisplayMediaWindow()
        {
            mciSendString("put MuVipApp", null, 0, IntPtr.Zero);
        }

        public void DisplayMediaWindow(Rectangle rec)
        {
            mciSendString(String.Format("put MuVipApp window at {0} {1} {2} {3}",
                                        rec.Left, rec.Top, rec.Width, rec.Height), null, 0, IntPtr.Zero);
        }

        public string Status
        {
            get
            {
                mciSendString("status MuVipApp mode", _buffer, BUFFER_LENGTH, IntPtr.Zero);
                return _buffer.ToString();
            }
        }

        private string FormatSeconds(int seconds)
        {
            int hour = 0;
            int minus = 0;
            if (seconds < 3600)
            {

                minus = seconds / 60;

                seconds = seconds % 60;

                return minus.ToString().PadLeft(2, '0') + ":" + seconds.ToString().PadLeft(2, '0');
            }
            else
            {
                hour = seconds / 3600;
                seconds %= 3600;

                minus = seconds / 60;

                seconds = seconds % 60;

                return hour.ToString().PadLeft(2, '0') + ":" + minus.ToString().PadLeft(2, '0') + ":" + seconds.ToString().PadLeft(2, '0');
            }
        }           

        public int Length
        {
            get
            {
                mciSendString("status MuVipApp length", _buffer, BUFFER_LENGTH, IntPtr.Zero);
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
                mciSendString("status MuVipApp position", _buffer, BUFFER_LENGTH, IntPtr.Zero);
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

        public void SetVolume(int value)
        {
            int NewVolume = ((ushort.MaxValue / 10) * value);

            uint NewVolumeAllChannels = (((uint)NewVolume & 0x0000ffff) | ((uint)NewVolume << 16));

            waveOutSetVolume(IntPtr.Zero, NewVolumeAllChannels);
        }

        public void GetInfo()
        {
            //this.
        }
    }
}
