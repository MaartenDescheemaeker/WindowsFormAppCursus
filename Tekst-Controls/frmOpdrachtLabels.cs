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
                    if(lblfiguur.Right < ClientSize.Width)
                    lblfiguur.Left+=10;
                    break;
                case Keys.Left:
                    if (lblfiguur.Left > 10)
                        lblfiguur.Left -= 10;
                    break;
                case Keys.Up:
                    if (lblfiguur.Top > 0)
                        lblfiguur.Top -= 10;
                    break;
                case Keys.Down:
                    if (lblfiguur.Bottom < ClientSize.Height)
                        lblfiguur.Top += 10;
                   
                    break;
            }
        }

        private void frmOpdrachtLabels_Load(object sender, EventArgs e)
        {

        }
    }
}
