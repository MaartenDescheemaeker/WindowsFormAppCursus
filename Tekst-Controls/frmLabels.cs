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
    public partial class frmLabels : Form
    {
        public frmLabels()
        {
            InitializeComponent();
        }

        private void BeweegOverMIJ_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button== MouseButtons.Left) this.Text = "MouseMove event linkermuisknop";
            if (e.Button == MouseButtons.Right) this.Text = "MouseMove event rechtermuisknop";
        }

        private void BeweegOverMIJ_MouseEnter(object sender, EventArgs e)
        {
            this.Text = "MouseEnter event";
        }

        private void BeweegOverMIJ_Click(object sender, EventArgs e)
        {

        }

        private void BeweegOverMIJ_MouseLeave(object sender, EventArgs e)
        {
            this.Text = "MouseLeave event";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.Alt == true && e.KeyCode == Keys.K) this. BackColor = Color.BurlyWood;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.F1)) this.BackColor = Color.Pink;
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 65) this.BackColor = Color.Blue;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
