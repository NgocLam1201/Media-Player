using MuViPApp.DAO;
using System;
using System.Data;
using System.Windows.Forms;

namespace MuViPApp
{
    public partial class form_Music_Playlist : Form
    {
        Music_Playlist parent;
        public form_Music_Playlist(Music_Playlist parent = null)
        {
            this.parent = parent;
            InitializeComponent();
            lb_NamePl.Text = this.parent.Name;
            Number_song.Text = this.parent.Number_song + " song";
            LoadListMusic();
        }

        private void LoadListMusic()
        {
            string query = "USP_Music_Of_Playlist @ID_Playlist";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { this.parent.ID_Playlist });
            for (int i = 0; i < result.Rows.Count; i++)
            {
                string[] date = result.Rows[i].Field<DateTime>(3).ToString().Split(' ');
                ListViewItem items = new ListViewItem(new[] { result.Rows[i].Field<string>(0),
                                                            result.Rows[i].Field<string>(1),
                                                            result.Rows[i].Field<string>(2),
                                                            date[0],
                                                            result.Rows[i].Field<TimeSpan>(4).ToString()," ",
                                                            result.Rows[i].Field<string>(5),
                                                            result.Rows[i].Field<string>(6)});
                lv_My_Music.Items.Add(items);
                items.ImageIndex = 0;
            }
        }

        protected form_Rename_pl form_Rename;

        private void btn_Rename_Click(object sender, EventArgs e)
        {
            form_Rename = new form_Rename_pl();
            form_Rename.ShowDialog(this);
            this.lb_NamePl.Text = form_Rename.s;

        }

        private void btn_Playall_Click(object sender, EventArgs e)
        {

        }
    }
}
