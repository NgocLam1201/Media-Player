using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuViPApp
{
    class Playlist
    {
        private string connectionSTR = @"Server=ADMIN\SQLEXPRESS;Database=MuViPApp;User Id=sa;Password=0337651201;";

        private static Playlist instance; // Ctrl + R + E

        public static Playlist Instance
        {
            get { if (instance == null) instance = new Playlist(); return Playlist.instance; }
            private set { Playlist.instance = value; }
        }


    }
}
