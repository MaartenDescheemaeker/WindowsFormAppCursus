using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpdrListBox
{
    public partial class frmListBox : Form
    {
        public frmListBox()
        {
            InitializeComponent();
        }

        private void btnSortAZ_Click(object sender, EventArgs e)
        {
            lstItems.Sorted = true;
        }

        private void btnSortZA_Click(object sender, EventArgs e)
        {
            lstItems.Sorted = true;
            for(int i =0; i < lstItems.Items.Count/2; i++)
            {
                    object hulp = lstItems.Items[i];
                    object laatste = lstItems.Items[lstItems.Items.Count-1 - i];

                    lstItems.Items[i] = laatste;
                    lstItems.Items[lstItems.Items.Count-1 - i] = hulp;
            }
        }
    }
}
