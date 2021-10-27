
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.txtVoorbeeld = new System.Windows.Forms.RichTextBox();
            this.MenuLetter = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuFont = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuVet = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSchuin = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuCourierNew = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuArial = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuLetter});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // statusStrip1
            // 
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
            // txtVoorbeeld
            // 
            this.txtVoorbeeld.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtVoorbeeld.Location = new System.Drawing.Point(0, 0);
            this.txtVoorbeeld.Name = "txtVoorbeeld";
            this.txtVoorbeeld.Size = new System.Drawing.Size(800, 379);
            this.txtVoorbeeld.TabIndex = 0;
            this.txtVoorbeeld.Text = "";
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
            this.MenuFont.Size = new System.Drawing.Size(180, 22);
            this.MenuFont.Text = "&Font";
            // 
            // MenuVet
            // 
            this.MenuVet.Name = "MenuVet";
            this.MenuVet.Size = new System.Drawing.Size(180, 22);
            this.MenuVet.Text = "&Vetdruk";
            this.MenuVet.Click += new System.EventHandler(this.MenuVet_Click);
            // 
            // MenuSchuin
            // 
            this.MenuSchuin.Name = "MenuSchuin";
            this.MenuSchuin.Size = new System.Drawing.Size(180, 22);
            this.MenuSchuin.Text = "&Schuindruk";
            this.MenuSchuin.Click += new System.EventHandler(this.MenuSchuin_Click);
            // 
            // MenuCourierNew
            // 
            this.MenuCourierNew.Name = "MenuCourierNew";
            this.MenuCourierNew.Size = new System.Drawing.Size(180, 22);
            this.MenuCourierNew.Text = "Courier New";
            // 
            // MenuArial
            // 
            this.MenuArial.Name = "MenuArial";
            this.MenuArial.Size = new System.Drawing.Size(180, 22);
            this.MenuArial.Text = "Arial";
            this.MenuArial.Click += new System.EventHandler(this.arialToolStripMenuItem_Click);
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
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
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
    }
}