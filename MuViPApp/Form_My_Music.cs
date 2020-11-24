using MuViPApp.DAO;
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
        Form_Muvip parent;
        public Form_My_Music(Form_Muvip parent)
        {
            this.parent = parent;
            InitializeComponent();
            string query = "USP_AllMusic";

            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] {});

            for (int i = 0;i < result.Rows.Count; i++)
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
            for (int i = 0; i < this.lv_My_Music.SelectedItems.Count; i++)
            {
                lv_My_Music.KeyDown += Key_Enter_Down;
            }
            lv_My_Music.DoubleClick += Music_Click;
        }

        

        private void Music_Click(object sender, EventArgs e)
        {
            this.parent.Time_Media.Stop();
            this.parent.btn_Music_Play_Click(sender, e);
            DateTime length = Convert.ToDateTime(lv_My_Music.SelectedItems[0].SubItems[4].Text);
            //this.parent.Time_Media.Interval = (length.Hour * 3600 + length.Minute * 60 + length.Second) * 1000;
            //this.parent.Time_Media.Start();
            this.parent.NameMedia.Text = lv_My_Music.SelectedItems[0].SubItems[0].Text;
            this.parent.Artist.Text = lv_My_Music.SelectedItems[0].SubItems[1].Text;
            this.parent.RestTime.Text = lv_My_Music.SelectedItems[0].SubItems[4].Text;
            this.parent.mp3Player.Open(lv_My_Music.SelectedItems[0].SubItems[5].Text);
            //this.parent.mp3Player.open(lv_My_Music.SelectedItems[0].SubItems[5].Text);
            /*using (var soundPlayer = new SoundPlayer(lv_My_Music.SelectedItems[0].SubItems[5].Text))
            {
                soundPlayer.Play(); 
            }*/
            this.parent.btn_Music_Pause_Click(sender,e);
            
        }

        private void Key_Enter_Down(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                
            }    
        }
    }
}
