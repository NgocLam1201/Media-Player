using MuViPApp.DAO;
using MuViPApp.Music;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MuViPApp
{
    public partial class Form_My_Music : Form
    {
        public int count;
        Form_Muvip parent;
        private static Form_My_Music instance;

        public static Form_My_Music Instance
        {
            get { if (instance == null) instance = new Form_My_Music(); return instance; }
            private set { instance = value; }
        }
        public Form_My_Music(Form_Muvip parent = null)
        {
            this.parent = parent;
            InitializeComponent();
            ShowListMusic();

            for (int i = 0; i < this.lv_My_Music.SelectedItems.Count; i++)
            {
                lv_My_Music.KeyDown += Key_Enter_Down;
            }
            lv_My_Music.DoubleClick += Music_Click;
        }        

        void ShowListMusic()
        {
            string query = "USP_AllMusic";

            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { });
            count = result.Rows.Count;
            for (int i = 0; i < result.Rows.Count; i++)
            {
                string[] date = result.Rows[i].Field<DateTime>(3).ToString().Split(' ');
                ListViewItem items = new ListViewItem(new[] { result.Rows[i].Field<string>(0),
                                                            result.Rows[i].Field<string>(1),
                                                            result.Rows[i].Field<string>(2),
                                                            date[0],
                                                            result.Rows[i].Field<TimeSpan>(4).ToString(),
                                                            result.Rows[i].Field<string>(5),
                                                            result.Rows[i].Field<string>(6)});
                lv_My_Music.Items.Add(items);
            }
        }

        public void Music_Click(object sender, EventArgs e)
        {
            ListMusicPlaying.Instance.Remove();
            if (lv_My_Music.SelectedItems.Count == 1)
            {
                int index = lv_My_Music.Items.IndexOf(lv_My_Music.SelectedItems[0]);
                for (int i = index; i < count; i++)
                {
                    ListViewItem items = new ListViewItem(new[] {lv_My_Music.Items[i].SubItems[0].Text,
                                                                lv_My_Music.Items[i].SubItems[1].Text,
                                                                lv_My_Music.Items[i].SubItems[2].Text,
                                                                lv_My_Music.Items[i].SubItems[3].Text,
                                                                lv_My_Music.Items[i].SubItems[4].Text,
                                                                lv_My_Music.Items[i].SubItems[5].Text,
                                                                lv_My_Music.Items[i].SubItems[6].Text});
                    ListMusicPlaying.Instance.AddItems(items);
                }
                for (int i = 0; i < index; i++)
                {
                    ListViewItem items = new ListViewItem(new[] {lv_My_Music.Items[i].SubItems[0].Text,
                                                                lv_My_Music.Items[i].SubItems[1].Text,
                                                                lv_My_Music.Items[i].SubItems[2].Text,
                                                                lv_My_Music.Items[i].SubItems[3].Text,
                                                                lv_My_Music.Items[i].SubItems[4].Text,
                                                                lv_My_Music.Items[i].SubItems[5].Text,
                                                                lv_My_Music.Items[i].SubItems[6].Text });
                    ListMusicPlaying.Instance.AddItems(items);
                }
            }
            else
                for (int i = 0; i < lv_My_Music.SelectedItems.Count; i++)
                {
                    ListViewItem items = new ListViewItem(new[] {lv_My_Music.SelectedItems[i].SubItems[0].Text,
                                                        lv_My_Music.SelectedItems[i].SubItems[1].Text,
                                                        lv_My_Music.SelectedItems[i].SubItems[2].Text,
                                                        lv_My_Music.SelectedItems[i].SubItems[3].Text,
                                                        lv_My_Music.SelectedItems[i].SubItems[4].Text,
                                                        lv_My_Music.SelectedItems[i].SubItems[5].Text,
                                                        lv_My_Music.SelectedItems[i].SubItems[6].Text });
                    ListMusicPlaying.Instance.AddItems(items);
                }
            this.parent.PlayMusic(0);
            lv_My_Music.Items.Clear();
            ShowListMusic();   
        }

        public void Key_Enter_Down(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Music_Click(this, new EventArgs());
            }    
        }
    }
}
