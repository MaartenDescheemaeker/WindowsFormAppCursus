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
                tsbtnBold.Checked = true;
                StatusVet.Font = new Font(StatusVet.Font, FontStyle.Bold);
            }
            else
            {
                style &= ~FontStyle.Bold;
                MenuVet.Checked = false;
                tsbtnBold.Checked = false;
                StatusVet.Font = new Font(StatusVet.Font, FontStyle.Regular);
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
                tsbtnItalic.Checked = true;
                statusSchuin.Font = new Font(statusSchuin.Font, FontStyle.Italic);
            }
            else
            {
                style &= ~FontStyle.Italic;
                MenuSchuin.Checked = false;
                tsbtnItalic.Checked = false;
                statusSchuin.Font = new Font(statusSchuin.Font, FontStyle.Regular);
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
            statusLettertype.Text = txtVoorbeeld.Font.Name;
        }

        private void MenuFont_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            Lettertype(e.ClickedItem);
            foreach(ToolStripMenuItem huidig in MenuFont.DropDownItems)
            {
                huidig.Checked = false;
            }
            ((ToolStripMenuItem)e.ClickedItem).Checked = true;
            tscmbFont.SelectedText = ((ToolStripMenuItem)e.ClickedItem).Text;
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            //alle fonts toevoegen aan menu font en comboboxFont
            System.Drawing.Text.InstalledFontCollection fonts = new System.Drawing.Text.InstalledFontCollection();
            int Arialindex = -1, count = -1;
            foreach (FontFamily family in fonts.Families)
            {
                MenuFont.DropDown.Items.Add(family.Name);
                tscmbFont.Items.Add(family.Name);
                //index Arial onthouden
                count++;
                if (family.Name == "Arial")
                    Arialindex = count;
            }
            // lettertype op arial instellen
            txtVoorbeeld.Font = new Font("Arial", 12);
            tscmbFont.SelectedIndex = Arialindex;
            statusLettertype.Text = "Arial";
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

        private void tscmbFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach(ToolStripMenuItem huidig in MenuFont.DropDownItems)
            {
                huidig.Checked = false;
            }
            ((ToolStripMenuItem)MenuFont.DropDownItems[tscmbFont.SelectedIndex]).Checked = true;
            Lettertype((ToolStripMenuItem)MenuFont.DropDownItems[tscmbFont.SelectedIndex]);
        }
    }
}
