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
    public partial class frmHoofd : Form
    {
        public frmHoofd()
        {
            InitializeComponent();
        }
        frmSubVenster frmVenster1 = new frmSubVenster();
        private void btnToonVenster_Click(object sender, EventArgs e)
        {
            frmVenster1.Show();
        }
    }
}
