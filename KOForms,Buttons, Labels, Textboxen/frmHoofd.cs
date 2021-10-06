using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KOForms_Buttons__Labels__Textboxen
{
    public partial class frmHoofd : Form
    {
        public frmHoofd()
        {
            InitializeComponent();
        }

        frmDialoog dialoog = new frmDialoog();
        private void frmHoofd_MouseClick(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    this.frmhoofd = frmHoofd.MaximizeBox;
                    break;
            }
        }

        private void btnAfsluiten_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDialoogvenster_Click(object sender, EventArgs e)
        {
            this.dialoog.Show();
        }

        private void frmHoofd_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void frmHoofd_KeyUp(object sender, KeyEventArgs e)
        {
           
        }

        private void frmHoofd_MouseMove(object sender, MouseEventArgs e)
        {
            Label lblHulp = sender as Label;
            if(lblHulp!=null)
            {
                switch(lblHulp.Name)
                {
                    case "lblGroen":
                        this.BackColor = Color.Lime;
                        break;
                    case "lblWit":
                        this.BackColor = Color.White;
                        break;
                    case "lblBlauw":
                        this.BackColor = Color.Blue;
                        break;

                }
            }
        }
    }
}
