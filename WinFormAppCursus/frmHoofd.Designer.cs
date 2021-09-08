
namespace WinFormAppCursus
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
            this.btnToonVenster = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnToonVenster
            // 
            this.btnToonVenster.Location = new System.Drawing.Point(222, 168);
            this.btnToonVenster.Name = "btnToonVenster";
            this.btnToonVenster.Size = new System.Drawing.Size(75, 23);
            this.btnToonVenster.TabIndex = 0;
            this.btnToonVenster.Text = "Toon venster";
            this.btnToonVenster.UseVisualStyleBackColor = true;
            this.btnToonVenster.Click += new System.EventHandler(this.btnToonVenster_Click);
            // 
            // frmHoofd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnToonVenster);
            this.Name = "frmHoofd";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnToonVenster;
    }
}

