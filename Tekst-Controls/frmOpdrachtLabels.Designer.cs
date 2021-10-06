
namespace Tekst_Controls
{
    partial class frmOpdrachtLabels
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
            this.lblfiguur = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblfiguur
            // 
            this.lblfiguur.AutoSize = true;
            this.lblfiguur.Font = new System.Drawing.Font("Webdings", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.lblfiguur.Location = new System.Drawing.Point(500, 150);
            this.lblfiguur.Name = "lblfiguur";
            this.lblfiguur.Size = new System.Drawing.Size(92, 65);
            this.lblfiguur.TabIndex = 0;
            this.lblfiguur.Text = "h";
            this.lblfiguur.Click += new System.EventHandler(this.label1_Click);
            // 
            // frmOpdrachtLabels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblfiguur);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmOpdrachtLabels";
            this.Text = "Label beweegt met pijltjestoetsen";
            this.Load += new System.EventHandler(this.frmOpdrachtLabels_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmOpdrachtLabels_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmOpdrachtLabels_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblfiguur;
    }
}