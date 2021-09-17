using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormAppCursus
{
    public partial class frmPanels : Form
    {
        public frmPanels()
        {
            InitializeComponent();
        }

        private void plnRight_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlTop_Click(object sender, EventArgs e)
        {
            foreach (Control ctr in pnlTop.Controls)
                ctr.ForeColor = Color.Green;
        }
    }
}
