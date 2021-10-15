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
    public partial class frmRadioButtons : Form
    {
        public frmRadioButtons()
        {
            InitializeComponent();
        }

        private void rdbAchter_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbAchterStandaard.Checked)
                this.BackColor = SystemColors.Control;
            if (rdbAchterWit.Checked)
                this.BackColor = Color.White;
            if (rdbAchterZwart.Checked)
                this.BackColor = Color.Black;
        }

        private void rdbVoor_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbVoorRood.Checked)
                this.ForeColor = Color.Red;
            if (rdbVoorWit.Checked)
                this.ForeColor = Color.White;
            if (rdbVoorZwart.Checked)
                this.ForeColor = Color.Black;
        }

        private void frmRadioButtons_Load(object sender, EventArgs e)
        {

        }
    }
}
