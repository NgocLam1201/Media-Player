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
    public partial class Form_Liked_Video : Form
    {
        Form_Muvip parent;
        public Form_Liked_Video(Form_Muvip parent = null)
        {
            this.parent = parent;
            InitializeComponent();
        }
    }
}
