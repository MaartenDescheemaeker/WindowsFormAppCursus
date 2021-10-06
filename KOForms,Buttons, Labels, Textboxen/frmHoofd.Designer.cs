
namespace KOForms_Buttons__Labels__Textboxen
{
    partial class frmHoofd
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
            this.btnAfsluiten = new System.Windows.Forms.Button();
            this.btnDialoogvenster = new System.Windows.Forms.Button();
            this.lblGroen = new System.Windows.Forms.Label();
            this.lblWit = new System.Windows.Forms.Label();
            this.lblBlauw = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAfsluiten
            // 
            this.btnAfsluiten.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnAfsluiten.Location = new System.Drawing.Point(268, 168);
            this.btnAfsluiten.Name = "btnAfsluiten";
            this.btnAfsluiten.Size = new System.Drawing.Size(75, 23);
            this.btnAfsluiten.TabIndex = 1;
            this.btnAfsluiten.Text = "Afsluiten";
            this.btnAfsluiten.UseMnemonic = false;
            this.btnAfsluiten.UseVisualStyleBackColor = false;
            this.btnAfsluiten.Click += new System.EventHandler(this.btnAfsluiten_Click);
            // 
            // btnDialoogvenster
            // 
            this.btnDialoogvenster.AutoSize = true;
            this.btnDialoogvenster.Location = new System.Drawing.Point(470, 167);
            this.btnDialoogvenster.Name = "btnDialoogvenster";
            this.btnDialoogvenster.Size = new System.Drawing.Size(127, 23);
            this.btnDialoogvenster.TabIndex = 0;
            this.btnDialoogvenster.Text = "Dialoogvenster openen";
            this.btnDialoogvenster.UseVisualStyleBackColor = true;
            this.btnDialoogvenster.Click += new System.EventHandler(this.btnDialoogvenster_Click);
            // 
            // lblGroen
            // 
            this.lblGroen.AutoSize = true;
            this.lblGroen.BackColor = System.Drawing.Color.Lime;
            this.lblGroen.Location = new System.Drawing.Point(126, 244);
            this.lblGroen.Name = "lblGroen";
            this.lblGroen.Size = new System.Drawing.Size(36, 13);
            this.lblGroen.TabIndex = 2;
            this.lblGroen.Text = "Groen";
            this.lblGroen.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmHoofd_MouseMove);
            // 
            // lblWit
            // 
            this.lblWit.AutoSize = true;
            this.lblWit.BackColor = System.Drawing.Color.White;
            this.lblWit.Location = new System.Drawing.Point(225, 325);
            this.lblWit.Name = "lblWit";
            this.lblWit.Size = new System.Drawing.Size(23, 13);
            this.lblWit.TabIndex = 3;
            this.lblWit.Text = "Wit";
            this.lblWit.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmHoofd_MouseMove);
            // 
            // lblBlauw
            // 
            this.lblBlauw.AutoSize = true;
            this.lblBlauw.BackColor = System.Drawing.Color.Blue;
            this.lblBlauw.Location = new System.Drawing.Point(409, 324);
            this.lblBlauw.Name = "lblBlauw";
            this.lblBlauw.Size = new System.Drawing.Size(36, 13);
            this.lblBlauw.TabIndex = 4;
            this.lblBlauw.Text = "Blauw";
            this.lblBlauw.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmHoofd_MouseMove);
            // 
            // frmHoofd
            // 
            this.AcceptButton = this.btnDialoogvenster;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnAfsluiten;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblBlauw);
            this.Controls.Add(this.lblWit);
            this.Controls.Add(this.lblGroen);
            this.Controls.Add(this.btnDialoogvenster);
            this.Controls.Add(this.btnAfsluiten);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmHoofd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KO1 Descheemaeker Maarten";
            this.Enter += new System.EventHandler(this.btnDialoogvenster_Click);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmHoofd_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmHoofd_KeyUp);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.frmHoofd_MouseClick);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmHoofd_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAfsluiten;
        private System.Windows.Forms.Button btnDialoogvenster;
        private System.Windows.Forms.Label lblGroen;
        private System.Windows.Forms.Label lblWit;
        private System.Windows.Forms.Label lblBlauw;
    }
}

