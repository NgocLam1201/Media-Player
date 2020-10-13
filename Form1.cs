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
    public partial class Form_Muvip : Form
    {
        public Form_Muvip()
        {
            InitializeComponent();
        }

        private void btn_Home_Click(object sender, EventArgs e)
        {
            panel_Player.Hide();
        }
    }
}