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
    public partial class frmHoofd : Form
    {
        public frmHoofd()
        {
            InitializeComponent();
        }
        frmSubVenster TweedeVenster = new frmSubVenster();
        frmSubVenster2 DerdeVenster = new frmSubVenster2();
        private void frmHoofd_Load(object sender, EventArgs e)
        {

        }

        private void knop1_MouseClick(object sender, MouseEventArgs e)
        {
            TweedeVenster.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DerdeVenster.ShowDialog();
        }

        private void knop1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
