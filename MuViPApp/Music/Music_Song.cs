using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
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
        
        private string name_Song;
        public string Name_Song
        {
            get { return name_Song; }
            set { name_Song = value; }
        }
        private string singer;
        public string Singer
        {
            get { return singer; }
            set { singer = value; }
        }
        private string link_Music;
        public string Link_Music
        {
            get { return link_Music; }
            set { link_Music = value; }
        }
        private Image picture_Song;
        public Image Picture_Song
        {
            get { return picture_Song; }
            set { picture_Song = value; }
        }
        private string date_Add;
        public string Date_Add
        {
            get { return date_Add; }
            set { date_Add = value; }
        }
        private string length;
        public string Length
        {
            get { return length; }
            set { length = value; }
        }
        private string name_Genre;
        public string Name_Genre
        {
            get { return name_Genre; }
            set { name_Genre = value; }
        }

        public Music_Song() { }

        public Music_Song(string Name, string Singer, string LinkSong, Image Picture, string DateAdd, string length, string name_Genre)
        {
            this.Length = length;
            this.Picture_Song = Picture;
            this.Name_Song = Name;
            this.Singer = Singer;
            this.Link_Music = LinkSong;
            this.Date_Add = DateAdd;
            this.Name_Genre = name_Genre;
        }

        public Music_Song(string path)
        {
            FileInfo info = new FileInfo(path);
            if (info.Extension == ".mp3")
            {
                var fileTag = TagLib.File.Create(info.FullName);
                this.Name_Song = fileTag.Tag.Title;
                this.Singer = fileTag.Tag.FirstPerformer;
                this.Name_Genre = fileTag.Tag.FirstGenre;
                this.Date_Add = info.CreationTime.ToString();
                this.Length = fileTag.Properties.Duration.ToString(@"hh\:mm\:ss");
                this.Link_Music = info.FullName;
                if (this.Name_Genre == null) this.Name_Genre = "Unknown";
                if (this.Singer == null) this.Singer = "Unknown";
                Image temp = null;
                if (fileTag.Tag.Pictures.Length >= 1)
                {
                    var bin = (byte[])(fileTag.Tag.Pictures[0].Data.Data);
                    temp = Image.FromStream(new MemoryStream(bin)).GetThumbnailImage(100, 100, null, IntPtr.Zero);
                }
                else
                {
                    temp = new Bitmap(Properties.Resources.songImg);
                }
                this.Picture_Song = temp;
            }
        }
    }
}
