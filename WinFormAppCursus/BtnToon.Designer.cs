
namespace WinFormAppCursus
{
    partial class BtnToon
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
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnCentreer = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.txtTekst = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(221, 212);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(75, 23);
            this.btnLeft.TabIndex = 0;
            this.btnLeft.Text = "btnLeft";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnUitlijnen_btnClick);
            // 
            // btnCentreer
            // 
            this.btnCentreer.Location = new System.Drawing.Point(418, 211);
            this.btnCentreer.Name = "btnCentreer";
            this.btnCentreer.Size = new System.Drawing.Size(75, 23);
            this.btnCentreer.TabIndex = 1;
            this.btnCentreer.Text = "btnCentreer";
            this.btnCentreer.UseVisualStyleBackColor = true;
            this.btnCentreer.Click += new System.EventHandler(this.btnUitlijnen_btnClick);
            // 
            // btnRight
            // 
            this.btnRight.Location = new System.Drawing.Point(667, 211);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(75, 23);
            this.btnRight.TabIndex = 2;
            this.btnRight.Text = "btnRight";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnUitlijnen_btnClick);
            // 
            // txtTekst
            // 
            this.txtTekst.Location = new System.Drawing.Point(221, 117);
            this.txtTekst.Name = "txtTekst";
            this.txtTekst.Size = new System.Drawing.Size(521, 20);
            this.txtTekst.TabIndex = 3;
            this.txtTekst.Text = "6ICT";
            this.txtTekst.TextChanged += new System.EventHandler(this.txtTekst_TextChanged);
            // 
            // BtnToon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtTekst);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnCentreer);
            this.Controls.Add(this.btnLeft);
            this.Name = "BtnToon";
            this.Text = "BtnToon";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnCentreer;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.TextBox txtTekst;
    }
}