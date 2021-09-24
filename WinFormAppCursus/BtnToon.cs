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
    public partial class BtnToon : Form
    {
        public BtnToon()
        {
            InitializeComponent();
        }

        private void txtTekst_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUitlijnen_btnClick(object sender, EventArgs e)
        {
            Button btnHulp = sender as Button;
            if(btnHulp!=null)
            {
                switch(btnHulp.Name)
                {
                    case "btnRight":
                        txtTekst.TextAlign = HorizontalAlignment.Right;
                        break;
                    case "btnLeft":
                        txtTekst.TextAlign = HorizontalAlignment.Left;
                        break;
                    case "btnCentreer":
                        txtTekst.TextAlign = HorizontalAlignment.Center;
                        break;

                }
            }
        }
    }
}
