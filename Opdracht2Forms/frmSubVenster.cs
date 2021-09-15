using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Opdracht2Forms
{
    public partial class frmSubVenster : Form
    {
        public frmSubVenster()
        {
            InitializeComponent();
        }

        private void frmSubVenster_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private void frmSubVenster_Load(object sender, EventArgs e)
        {

        }

        private void Onzichtbaar1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
