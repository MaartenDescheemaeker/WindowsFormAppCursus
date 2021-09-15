
namespace Opdracht2Forms
{
    partial class frmSubVenster2
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
            this.Onzichtbaar2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Onzichtbaar2
            // 
            this.Onzichtbaar2.Location = new System.Drawing.Point(242, 109);
            this.Onzichtbaar2.Name = "Onzichtbaar2";
            this.Onzichtbaar2.Size = new System.Drawing.Size(311, 23);
            this.Onzichtbaar2.TabIndex = 0;
            this.Onzichtbaar2.Text = "Onzichtbaar maken";
            this.Onzichtbaar2.UseVisualStyleBackColor = true;
            this.Onzichtbaar2.Click += new System.EventHandler(this.Onzichtbaar2_Click);
            // 
            // frmSubVenster2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Onzichtbaar2);
            this.Name = "frmSubVenster2";
            this.Text = "frmSubVenster2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Onzichtbaar2;
    }
}