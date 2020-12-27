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
    public partial class Form_Delete : Form
    {
        public Form_Delete()
        {
            InitializeComponent();
        }
        public bool delete_on_this_PC = false;
        private void btn_ok_Click(object sender, EventArgs e)
        {
            delete_on_this_PC = true;
            this.Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
