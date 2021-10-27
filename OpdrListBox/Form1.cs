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
            if (lstItems.Sorted == true)
            {
                for (int i = 0; i < lstItems.Items.Count / 2; i++)
                {
                    object hulp = lstItems.Items[i];
                    object laatste = lstItems.Items[lstItems.Items.Count - 1 - i];

                    lstItems.Items[i] = laatste;
                    lstItems.Items[lstItems.Items.Count - 1 - i] = hulp;
                }
            }
            lstItems.Sorted = false;
        }

        private void frmListBox_Load(object sender, EventArgs e)
        {

        }

        private void btnWis_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstItems.SelectedItems.Count; i++)
            {
                object hulp = lstItems.SelectedItems[i--];
                lstItems.Items.Remove(hulp);
            }            
        }

        private void btnToevoegen_Click(object sender, EventArgs e)
        {
            byte aantal=0;
            string invoer = txtItem.Text;
            if (invoer != "")
            {
                for (int i = 0; i < lstItems.Items.Count; i++)
                {
                    string hulp = lstItems.Items[i].ToString();
                    if (hulp != invoer)
                    {
                        aantal++;
                    }
                    else
                        aantal = 0;
                }
            }
            if(aantal == lstItems.Items.Count)
            {
                if(chkSelect.Checked)
                {
                    lstItems.Items.Insert(lstItems.SelectedIndex, invoer);
                }
                else
                lstItems.Items.Add(invoer);
            }
        }
    }
}
