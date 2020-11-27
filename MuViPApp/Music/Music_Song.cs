using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuViPApp.Music
{
    public class Music_Song
    {
        private static Music_Song instance;

        public static Music_Song Instance
        {
            get { if (instance == null) instance = new Music_Song(); return instance; }
            private set { instance = value; }
        }
        private string iD_Genre;
        private string ID_Genre
        {
            get { return iD_Genre; }
            set { iD_Genre = value; }
        }
        private string iD_Playlist;
        private string ID_Playlist
        {
            get { return iD_Playlist; }
            set { iD_Playlist = value; }
        }
        private string name_Song;
        private string Name_Song
        {
            get { return name_Song; }
            set { name_Song = value; }
        }
        private string singer;
        private string Singer
        {
            get { return singer; }
            set { singer = value; }
        }
        private string link_Music;
        private string Link_Music
        {
            get { return link_Music; }
            set { link_Music = value; }
        }
        private string picture_Song;
        private string Picture_Song
        {
            get { return picture_Song; }
            set { picture_Song = value; }
        }
        private DateTime date_Add;
        private DateTime Date_Add
        {
            get { return date_Add; }
            set { date_Add = value; }
        }
        private TimeSpan length;
        private TimeSpan Length
        {
            get { return length; }
            set { length = value; }
        }
        private string name_Genre;
        private string Name_Genre
        {
            get { return name_Genre; }
            set { name_Genre = value; }
        }

        public Music_Song() { }

        public Music_Song(string ID_Pl, string ID_Genre, string Name, string Singer, string LinkSong, string LinkPic, DateTime DateAdd, TimeSpan length, string name_Genre)
        {
            this.ID_Genre = ID_Genre;
            this.ID_Playlist = ID_Pl;
            this.Length = length;
            this.Picture_Song = LinkPic;
            this.Name_Song = Name;
            this.Singer = Singer;
            this.Link_Music = LinkSong;
            this.Date_Add = DateAdd;
            this.Name_Genre = name_Genre;
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
            this.Name_Genre = (string)row["size"];
        }
    }
}
