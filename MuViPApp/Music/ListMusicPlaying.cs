﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MuViPApp.Music
{
    public class ListMusicPlaying
    {
        
        private static ListMusicPlaying instance;

        public static ListMusicPlaying Instance
        {
            get { if (instance == null) instance = new ListMusicPlaying(); return instance; }
            private set { instance = value; }
        }

        private List<Music_Song> Listmusic = new List<Music_Song>();

        public void AddItems(Music_Song item)
        {
            Listmusic.Add(item);
        }

        public List<Music_Song> GetMusic()
        {
            return Listmusic;
        }

        public Music_Song GetMusic(int index)
        {
            return Listmusic[index];
        }

        public void Remove()
        {
            Listmusic.Clear();
        }

        public void Remove(int index)
        {
            Listmusic.RemoveAt(index);
        }
    }
}