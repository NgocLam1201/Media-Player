using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MuViPApp.Music
{
    public class ListMusicPlaying
    {
        public List<ListViewItem> Listmusic = new List<ListViewItem>();

        private static ListMusicPlaying instance;

        public static ListMusicPlaying Instance
        {
            get { if (instance == null) instance = new ListMusicPlaying(); return instance; }
            private set { instance = value; }
        }

        public void AddItems(ListViewItem item)
        {
            Listmusic.Add(item);
        }

        
        public ListViewItem GetMusic(int index)
        {
            return Listmusic[index];
        }

        public void Remove()
        {
            Listmusic.Clear();
        }
    }
}
