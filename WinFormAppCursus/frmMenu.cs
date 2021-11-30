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
        private void Lettertype(object sender)
        {
            //huidige style onthouden
            FontStyle style = txtVoorbeeld.Font.Style;
            ToolStripMenuItem hetLettertype = (ToolStripMenuItem)sender;
            //nieuw lettertype
            txtVoorbeeld.Font = new Font(hetLettertype.Text, txtVoorbeeld.Font.Size);
            //oude stijl erbij instellen
            txtVoorbeeld.Font = new Font(txtVoorbeeld.Font, style);
        }

        private void MenuFont_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            Lettertype(e.ClickedItem);
            foreach(ToolStripMenuItem huidig in MenuFont.DropDownItems)
            {
                huidig.Checked = false;
            }
            ((ToolStripMenuItem)e.ClickedItem).Checked = true;
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            //alle fonts toevoegen aan menu font en comboboxFont
            System.Drawing.Text.InstalledFontCollection fonts = new System.Drawing.Text.InstalledFontCollection();
            int Arialindex = -1, count = -14;
            foreach (FontFamily family in fonts.Families)
            {
                MenuFont.DropDown.Items.Add(family.Name);
                //index Arial onthouden
                count++;
                if (family.Name == "Arial")
                    Arialindex = count;
            }
            // lettertype op arial instellen
            txtVoorbeeld.Font = new Font("Arial", 12);
        }

        private void knippenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtVoorbeeld.Cut();
        }

        private void kopiërenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtVoorbeeld.Copy();
        }

        private void plakkenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtVoorbeeld.Paste();
        }
    }
}
