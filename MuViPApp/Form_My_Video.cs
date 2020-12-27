using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MuViPApp.Video;
using System.IO;

namespace MuViPApp
{
    public partial class Form_My_Video : Form
    {
        Form_Muvip parent = new Form_Muvip();
        ListVideo FlistVideo;
        ToolStrip toolStrip = new ToolStrip();
        public Form_My_Video(Form_Muvip parent=null)
        {
            InitializeComponent();
            this.parent = parent;
            ShowListVid();
        }
        public void ShowListVid()
        {
            ListMyVideo.Instance.Remove();

            foreach (var child in Directory.GetFiles(@"C:\Users\Admin\Videos\"))

            {
                FileInfo info = new FileInfo(child);
                if (info.Extension == ".mp4"|| info.Extension == ".wmv")
                {
                    ListMyVideo.Instance.AddItems(new VideoInfo(info.FullName));
                }
            }
            ListVideo lvideo = new ListVideo(this.parent, ListMyVideo.Instance.GetMusic());
            lvideo.TopLevel = false;
            lvideo.Dock = DockStyle.Fill; 
            pn_List.Controls.Add(lvideo);
            lvideo.BringToFront();
            lvideo.Show();

        }


        private void ClickItem(object sender, ToolStripItemClickedEventArgs e)
        {
            ListFolderLocalVideo.Instance.Remove(e.ClickedItem.Text);
            ListFolderLocalVideo.Instance.Export();
            this.parent.Controls.Remove(toolStrip);
        }

        private void FormClick(object s, EventArgs e)
        {
            this.parent.Controls.Remove(toolStrip);
        }


        private void btn_Play_all_Click(object sender, EventArgs e)
        {
            FlistVideo.PlayAllMusic();
        }

        private void Cb_View_onItemSelected_1(object sender, EventArgs e)
        {
            FlistVideo.ViewList(Cb_View.selectedIndex);
        }

        private void ChoiceFolderMusic_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    ListFolderLocalVideo.Instance.Additem(fbd.SelectedPath);
                }
            }
            ListFolderLocalVideo.Instance.Export();
            ShowListVid();
        }



        private void DeleteFolderMusic_Click(object sender, EventArgs e)
        {
            this.parent.Controls.Remove(toolStrip);
            toolStrip.LayoutStyle = ToolStripLayoutStyle.VerticalStackWithOverflow;
            int Y = 60;
            foreach (string item in ListFolderLocalVideo.Instance.GetLink())
            {
                toolStrip.Items.Add(item);
            }
            toolStrip.Location = new Point(DeleteFolderMusic.Location.X + 250, DeleteFolderMusic.Location.Y + Y);
            this.parent.Controls.Add(toolStrip);
            toolStrip.BringToFront();
            toolStrip.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip.Dock = DockStyle.None;
        }
    }
}
