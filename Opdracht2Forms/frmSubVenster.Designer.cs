
namespace Opdracht2Forms
{
    partial class frmSubVenster
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
            this.Onzichtbaar1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Onzichtbaar1
            // 
            this.Onzichtbaar1.Location = new System.Drawing.Point(243, 89);
            this.Onzichtbaar1.Name = "Onzichtbaar1";
            this.Onzichtbaar1.Size = new System.Drawing.Size(194, 23);
            this.Onzichtbaar1.TabIndex = 0;
            this.Onzichtbaar1.Text = "Onzichtbaar maken";
            this.Onzichtbaar1.UseVisualStyleBackColor = true;
            this.Onzichtbaar1.Click += new System.EventHandler(this.Onzichtbaar1_Click);
            // 
            // frmSubVenster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Onzichtbaar1);
            this.Name = "frmSubVenster";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSubVenster";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSubVenster_FormClosing);
            this.Load += new System.EventHandler(this.frmSubVenster_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Onzichtbaar1;
    }
}