using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuViPApp.Music
{
    class Music_Song
    {
        private static Music_Song instance;

        public static Music_Song Instance
        {
            get { if (instance == null) instance = new Music_Song(); return instance; }
            private set { instance = value; }
        }

        private string ID_Genre { get => ID_Genre; set => ID_Genre = value; }
        private string ID_Playlist { get => ID_Playlist; set => ID_Playlist = value; }
        private string Name_Song { get => Name_Song; set => Name_Song = value; }
        private string Singer { get => Singer; set => Singer = value; }
        private string Link_Music { get => Link_Music; set => Link_Music = value; }
        private string Picture_Song { get => Picture_Song; set => Picture_Song = value; }
        private DateTime Date_Add { get => Date_Add; set => Date_Add = value; }
        private TimeSpan Length { get => Length; set => Length = value; }

        public Music_Song() { }

        public Music_Song(string ID_Genre, string ID_Pl, string Name, string Singer, string LinkSong, string LinkPic, DateTime DateAdd, TimeSpan length)
        {
            this.ID_Genre = ID_Genre;
            this.ID_Playlist = ID_Pl;
            this.Length = length;
            this.Picture_Song = LinkPic;
            this.Name_Song = Name;
            this.Singer = Singer;
            this.Link_Music = LinkSong;
            this.Date_Add = DateAdd;
        }

        public Music_Song(DataRow row)
        {
            this.ID_Playlist = (string)row["ID_Playlist"];
            this.ID_Genre = (string)row["ID_Genre"];
            this.Name_Song = (string)row["Name_Song"];
            this.Singer = (string)row["Singer"];
            this.Link_Music = (string)row["Link_Music"];
            this.Picture_Song = (string)row["Picture_Song"];
            this.Date_Add = (DateTime)row["ID_Playlist"];
            this.Length = (TimeSpan)row["size"];
        }
    }
}
