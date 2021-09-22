using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tekst_Controls
{
    public partial class frmOpdrachtLabels : Form
    {
        public frmOpdrachtLabels()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmOpdrachtLabels_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void frmOpdrachtLabels_KeyUp(object sender, KeyEventArgs e)
        {
            switch(e.KeyCode)
            {
                case Keys.Right:
                    this.label1 = 
                    break;
            }
        }
    }
}
