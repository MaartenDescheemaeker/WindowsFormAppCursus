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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void arialToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void MenuVet_Click(object sender, EventArgs e)
        {
            FontStyle style = txtVoorbeeld.Font.Style;
            if(!txtVoorbeeld.Font.Bold)
            {
                style |= FontStyle.Bold;
                MenuVet.Checked = true;
            }
            else
            {
                style &= ~FontStyle.Bold;
                MenuVet.Checked = false;
            }
            txtVoorbeeld.Font = new Font(txtVoorbeeld.Font, style);
        }

        private void MenuSchuin_Click(object sender, EventArgs e)
        {
            FontStyle style = txtVoorbeeld.Font.Style;
            if (!txtVoorbeeld.Font.Italic)
            {
                style |= FontStyle.Italic;
                MenuSchuin.Checked = true;
            }
            else
            {
                style &= ~FontStyle.Italic;
                MenuSchuin.Checked = false;
            }
            txtVoorbeeld.Font = new Font(txtVoorbeeld.Font, style);
        }
    }
}
