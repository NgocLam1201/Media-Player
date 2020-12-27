using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuViPApp.Video
{
    class ListVideoPlayed
    {
        private static ListVideoPlayed instance;

        public static ListVideoPlayed Instance
        {
            get { if (instance == null) instance = new ListVideoPlayed(); return instance; }
            private set { instance = value; }
        }

        private List<int> ListVideo = new List<int>();

        public void AddItems(int item)
        {
            ListVideo.Add(item);
        }

        public List<int> GetMusic()
        {
            return ListVideo;
        }

        public int GetItem(int index)
        {
            return ListVideo[index];
        }
        public int GetLastItem()
        {
            return ListVideo[ListVideo.Count - 1];
        }


        public void Remove()
        {
            ListVideo.Clear();
        }

        public void Remove(int index)
        {
            ListVideo.RemoveAt(index);
        }
        public void RemoveLastItem()
        {
            ListVideo.RemoveAt(ListVideo.Count-1);
        }
        public int count()
        {
            return ListVideo.Count;
        }

    }
}
