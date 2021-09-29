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
    public partial class frmCheckButtons : Form
    {
        public frmCheckButtons()
        {
            InitializeComponent();
        }

        private void btnBestel_Click(object sender, EventArgs e)
        {
            string tekst = "U hebt pizza ";
            bool first = true;
            foreach(Control hulp in this.Controls)
            {
                CheckBox chkHulp = hulp as CheckBox;
                if(chkHulp != null && chkHulp.Checked)
                {
                    if (first == true) tekst += "met " + chkHulp.Text;
                    else tekst += ", " + chkHulp.Text;
                    first = false;
                }
            }
            if (first == true) tekst += "zonder toppings besteld.";
            else tekst += " besteld.";
            MessageBox.Show(tekst, "Bevestiging");
        }
    }
}
