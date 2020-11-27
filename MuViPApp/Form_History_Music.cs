using MuViPApp.DAO;
using MuViPApp.Music;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MuViPApp
{
    public partial class Form_History_Music : Form
    {
        Form_Muvip parent;
        public Form_History_Music(Form_Muvip parent = null)
        {
            this.parent = parent;
            InitializeComponent();
            LoadHistory();
            for (int i = 0; i < this.lv_History_Music.SelectedItems.Count; i++)
            {
                lv_History_Music.KeyDown += Key_Enter_Down;
            }
            lv_History_Music.DoubleClick += Music_Click;
        }

        void LoadHistory()
        {
            if (this.parent.ID_Account == null) return;
            string query = "USP_History @ID_Acc";

            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { this.parent.ID_Account });
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
                lv_History_Music.Items.Add(items);
            }
        }

        public void Music_Click(object sender, EventArgs e)
        {
            int index = 0;
            if (lv_History_Music.SelectedItems.Count > 1)
            {
                ListMusicPlaying.Instance.Remove();
                for (int i = 0; i < lv_History_Music.SelectedItems.Count; i++)
                {
                    ListViewItem items = new ListViewItem(new[] {lv_History_Music.SelectedItems[i].SubItems[0].Text,
                                                        lv_History_Music.SelectedItems[i].SubItems[1].Text,
                                                        lv_History_Music.SelectedItems[i].SubItems[2].Text,
                                                        lv_History_Music.SelectedItems[i].SubItems[3].Text,
                                                        lv_History_Music.SelectedItems[i].SubItems[4].Text,
                                                        lv_History_Music.SelectedItems[i].SubItems[5].Text,
                                                        lv_History_Music.SelectedItems[i].SubItems[6].Text });
                    ListMusicPlaying.Instance.AddItems(items);
                }
            }
            else
            {
                for (int i=0;i<Form_My_Music.Instance.count;i++)
                {
                    if (Form_My_Music.Instance.lv_My_Music.Items[i].SubItems[0].Text == lv_History_Music.SelectedItems[0].SubItems[0].Text)
                    {
                        index = i;
                        break;
                    }    
                }    
            }
            this.parent.PlayMusic(index);
            lv_History_Music.Items.Clear();
            LoadHistory();
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
