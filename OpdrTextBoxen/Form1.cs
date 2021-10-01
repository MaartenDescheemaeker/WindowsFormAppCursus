using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpdrTextBoxen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            if(txtGebruikersnaam.Text == "Administrator" && txtPaswoord.Text == "1234")
            {
                this.Text = txtGebruikersnaam.Text + " is ingelogd";
                panel1.Visible=false;
            }
            if (txtGebruikersnaam.Text != "" && txtPaswoord.Text == "5678")
            {
                this.Text = txtGebruikersnaam.Text + " is ingelogd";
                panel1.Visible = false;
            }
        }

        private void txtGebruikersnaam_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void btnAnnuleer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
