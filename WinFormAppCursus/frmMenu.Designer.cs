
namespace WinFormAppCursus
{
    partial class frmMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.editerenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.knippenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kopiërenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.plakkenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuLetter = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuFont = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuCourierNew = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuArial = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuVet = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSchuin = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.txtVoorbeeld = new System.Windows.Forms.RichTextBox();
            this.editeerBalk = new System.Windows.Forms.ToolStrip();
            this.LettertypeBalk = new System.Windows.Forms.ToolStrip();
            this.tscmbFont = new System.Windows.Forms.ToolStripComboBox();
            this.tsbtnPaste = new System.Windows.Forms.ToolStripButton();
            this.tsbtnCut = new System.Windows.Forms.ToolStripButton();
            this.tsbtnCopy = new System.Windows.Forms.ToolStripButton();
            this.tsbtnItalic = new System.Windows.Forms.ToolStripButton();
            this.tsbtnBold = new System.Windows.Forms.ToolStripButton();
            this.statusLettertype = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusSchuin = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusVet = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.editeerBalk.SuspendLayout();
            this.LettertypeBalk.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editerenToolStripMenuItem,
            this.MenuLetter});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // editerenToolStripMenuItem
            // 
            this.editerenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.knippenToolStripMenuItem,
            this.kopiërenToolStripMenuItem,
            this.plakkenToolStripMenuItem});
            this.editerenToolStripMenuItem.Name = "editerenToolStripMenuItem";
            this.editerenToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.editerenToolStripMenuItem.Text = "&Editeren";
            // 
            // knippenToolStripMenuItem
            // 
            this.knippenToolStripMenuItem.Name = "knippenToolStripMenuItem";
            this.knippenToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.knippenToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.knippenToolStripMenuItem.Text = "Knippen";
            this.knippenToolStripMenuItem.Click += new System.EventHandler(this.knippenToolStripMenuItem_Click);
            // 
            // kopiërenToolStripMenuItem
            // 
            this.kopiërenToolStripMenuItem.Name = "kopiërenToolStripMenuItem";
            this.kopiërenToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.kopiërenToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.kopiërenToolStripMenuItem.Text = "Kopiëren";
            this.kopiërenToolStripMenuItem.Click += new System.EventHandler(this.kopiërenToolStripMenuItem_Click);
            // 
            // plakkenToolStripMenuItem
            // 
            this.plakkenToolStripMenuItem.Name = "plakkenToolStripMenuItem";
            this.plakkenToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.plakkenToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.plakkenToolStripMenuItem.Text = "Plakken";
            this.plakkenToolStripMenuItem.Click += new System.EventHandler(this.plakkenToolStripMenuItem_Click);
            // 
            // MenuLetter
            // 
            this.MenuLetter.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuFont,
            this.MenuVet,
            this.MenuSchuin});
            this.MenuLetter.Name = "MenuLetter";
            this.MenuLetter.Size = new System.Drawing.Size(72, 20);
            this.MenuLetter.Text = "&Lettertype";
            // 
            // MenuFont
            // 
            this.MenuFont.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuCourierNew,
            this.MenuArial});
            this.MenuFont.Name = "MenuFont";
            this.MenuFont.Size = new System.Drawing.Size(171, 22);
            this.MenuFont.Text = "&Font";
            this.MenuFont.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MenuFont_DropDownItemClicked);
            // 
            // MenuCourierNew
            // 
            this.MenuCourierNew.Name = "MenuCourierNew";
            this.MenuCourierNew.Size = new System.Drawing.Size(140, 22);
            this.MenuCourierNew.Text = "Courier New";
            // 
            // MenuArial
            // 
            this.MenuArial.Name = "MenuArial";
            this.MenuArial.Size = new System.Drawing.Size(140, 22);
            this.MenuArial.Text = "Arial";
            this.MenuArial.Click += new System.EventHandler(this.arialToolStripMenuItem_Click);
            // 
            // MenuVet
            // 
            this.MenuVet.Name = "MenuVet";
            this.MenuVet.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.MenuVet.Size = new System.Drawing.Size(171, 22);
            this.MenuVet.Text = "&Vetdruk";
            this.MenuVet.Click += new System.EventHandler(this.MenuVet_Click);
            // 
            // MenuSchuin
            // 
            this.MenuSchuin.Name = "MenuSchuin";
            this.MenuSchuin.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.MenuSchuin.Size = new System.Drawing.Size(171, 22);
            this.MenuSchuin.Text = "&Schuindruk";
            this.MenuSchuin.Click += new System.EventHandler(this.MenuSchuin_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLettertype,
            this.statusSchuin,
            this.StatusVet});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.txtVoorbeeld);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(800, 379);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 24);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(800, 404);
            this.toolStripContainer1.TabIndex = 2;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.editeerBalk);
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.LettertypeBalk);
            // 
            // txtVoorbeeld
            // 
            this.txtVoorbeeld.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtVoorbeeld.Location = new System.Drawing.Point(0, 0);
            this.txtVoorbeeld.Name = "txtVoorbeeld";
            this.txtVoorbeeld.Size = new System.Drawing.Size(800, 379);
            this.txtVoorbeeld.TabIndex = 0;
            this.txtVoorbeeld.Text = "";
            // 
            // editeerBalk
            // 
            this.editeerBalk.Dock = System.Windows.Forms.DockStyle.None;
            this.editeerBalk.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnPaste,
            this.tsbtnCut,
            this.tsbtnCopy});
            this.editeerBalk.Location = new System.Drawing.Point(3, 0);
            this.editeerBalk.Name = "editeerBalk";
            this.editeerBalk.Size = new System.Drawing.Size(81, 25);
            this.editeerBalk.TabIndex = 0;
            // 
            // LettertypeBalk
            // 
            this.LettertypeBalk.Dock = System.Windows.Forms.DockStyle.None;
            this.LettertypeBalk.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnItalic,
            this.tsbtnBold,
            this.tscmbFont});
            this.LettertypeBalk.Location = new System.Drawing.Point(96, 0);
            this.LettertypeBalk.Name = "LettertypeBalk";
            this.LettertypeBalk.Size = new System.Drawing.Size(181, 25);
            this.LettertypeBalk.TabIndex = 1;
            // 
            // tscmbFont
            // 
            this.tscmbFont.Name = "tscmbFont";
            this.tscmbFont.Size = new System.Drawing.Size(121, 25);
            this.tscmbFont.SelectedIndexChanged += new System.EventHandler(this.tscmbFont_SelectedIndexChanged);
            // 
            // tsbtnPaste
            // 
            this.tsbtnPaste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnPaste.Image = global::WinFormAppCursus.Properties.Resources.paste;
            this.tsbtnPaste.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnPaste.Name = "tsbtnPaste";
            this.tsbtnPaste.Size = new System.Drawing.Size(23, 22);
            this.tsbtnPaste.Text = "Paste";
            this.tsbtnPaste.Click += new System.EventHandler(this.plakkenToolStripMenuItem_Click);
            // 
            // tsbtnCut
            // 
            this.tsbtnCut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnCut.Image = global::WinFormAppCursus.Properties.Resources.cut;
            this.tsbtnCut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnCut.Name = "tsbtnCut";
            this.tsbtnCut.Size = new System.Drawing.Size(23, 22);
            this.tsbtnCut.Text = "Cut";
            this.tsbtnCut.Click += new System.EventHandler(this.knippenToolStripMenuItem_Click);
            // 
            // tsbtnCopy
            // 
            this.tsbtnCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnCopy.Image = global::WinFormAppCursus.Properties.Resources.copy;
            this.tsbtnCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnCopy.Name = "tsbtnCopy";
            this.tsbtnCopy.Size = new System.Drawing.Size(23, 22);
            this.tsbtnCopy.Text = "Copy";
            this.tsbtnCopy.Click += new System.EventHandler(this.kopiërenToolStripMenuItem_Click);
            // 
            // tsbtnItalic
            // 
            this.tsbtnItalic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnItalic.Image = global::WinFormAppCursus.Properties.Resources.italic;
            this.tsbtnItalic.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnItalic.Name = "tsbtnItalic";
            this.tsbtnItalic.Size = new System.Drawing.Size(23, 22);
            this.tsbtnItalic.Text = "Italic";
            this.tsbtnItalic.Click += new System.EventHandler(this.MenuSchuin_Click);
            // 
            // tsbtnBold
            // 
            this.tsbtnBold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnBold.Image = global::WinFormAppCursus.Properties.Resources.bold;
            this.tsbtnBold.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnBold.Name = "tsbtnBold";
            this.tsbtnBold.Size = new System.Drawing.Size(23, 22);
            this.tsbtnBold.Text = "Bold";
            this.tsbtnBold.Click += new System.EventHandler(this.MenuVet_Click);
            // 
            // statusLettertype
            // 
            this.statusLettertype.Name = "statusLettertype";
            this.statusLettertype.Size = new System.Drawing.Size(31, 17);
            this.statusLettertype.Text = "Arial";
            // 
            // statusSchuin
            // 
            this.statusSchuin.Name = "statusSchuin";
            this.statusSchuin.Size = new System.Drawing.Size(43, 17);
            this.statusSchuin.Text = "Schuin";
            // 
            // StatusVet
            // 
            this.StatusVet.Name = "StatusVet";
            this.StatusVet.Size = new System.Drawing.Size(23, 17);
            this.StatusVet.Text = "Vet";
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStripContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMenu";
            this.Text = "VbOefMenu";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.editeerBalk.ResumeLayout(false);
            this.editeerBalk.PerformLayout();
            this.LettertypeBalk.ResumeLayout(false);
            this.LettertypeBalk.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.RichTextBox txtVoorbeeld;
        private System.Windows.Forms.ToolStripMenuItem MenuLetter;
        private System.Windows.Forms.ToolStripMenuItem MenuFont;
        private System.Windows.Forms.ToolStripMenuItem MenuCourierNew;
        private System.Windows.Forms.ToolStripMenuItem MenuArial;
        private System.Windows.Forms.ToolStripMenuItem MenuVet;
        private System.Windows.Forms.ToolStripMenuItem MenuSchuin;
        private System.Windows.Forms.ToolStripMenuItem editerenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem knippenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kopiërenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem plakkenToolStripMenuItem;
        private System.Windows.Forms.ToolStrip editeerBalk;
        private System.Windows.Forms.ToolStripButton tsbtnPaste;
        private System.Windows.Forms.ToolStripButton tsbtnCut;
        private System.Windows.Forms.ToolStripButton tsbtnCopy;
        private System.Windows.Forms.ToolStrip LettertypeBalk;
        private System.Windows.Forms.ToolStripButton tsbtnItalic;
        private System.Windows.Forms.ToolStripButton tsbtnBold;
        private System.Windows.Forms.ToolStripComboBox tscmbFont;
        private System.Windows.Forms.ToolStripStatusLabel statusLettertype;
        private System.Windows.Forms.ToolStripStatusLabel statusSchuin;
        private System.Windows.Forms.ToolStripStatusLabel StatusVet;
    }
}