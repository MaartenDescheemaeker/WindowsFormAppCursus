using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpdrachtButtons
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtTekst_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void rdb_Checked(object sender, EventArgs e)
        {
            if (chkLabel.Checked)
            {
                if (rdbRechts.Checked) lblLabel.TextAlign = ContentAlignment.MiddleRight;
                if (rdbLinks.Checked) lblLabel.TextAlign = ContentAlignment.MiddleLeft;
                if (rdbCenter.Checked) lblLabel.TextAlign = ContentAlignment.MiddleCenter;
            }
            if (chkInvoervak.Checked)
            {
                if (rdbRechts.Checked) txtTekst.TextAlign = HorizontalAlignment.Right;
                if (rdbLinks.Checked) txtTekst.TextAlign = HorizontalAlignment.Left;
                if (rdbCenter.Checked) txtTekst.TextAlign = HorizontalAlignment.Center;
            }
        }

        private void lblLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
