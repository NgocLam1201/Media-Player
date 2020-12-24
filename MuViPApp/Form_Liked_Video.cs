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
<<<<<<< Updated upstream
        public Form_Liked_Video(Form_Muvip parent = null)
=======
        public Form_Liked_Video(Form_Muvip parent)
>>>>>>> Stashed changes
        {
            this.parent = parent;
            InitializeComponent();
        }
    }
}
