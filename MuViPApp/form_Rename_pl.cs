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
    
    public partial class form_Rename_pl : Form
    {
        public string s { get; set; }
       
        public form_Rename_pl()
        {
            
            InitializeComponent();
            
        }

        private void btn_Rename_Ok_Click(object sender, EventArgs e)
        {
            
             s= tb_NewName.Text;
            this.Close();
        }

        private void btn_Rename_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
