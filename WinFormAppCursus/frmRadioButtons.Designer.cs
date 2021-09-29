
namespace WinFormAppCursus
{
    partial class frmRadioButtons
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdbVoorZwart = new System.Windows.Forms.RadioButton();
            this.rdbVoorWit = new System.Windows.Forms.RadioButton();
            this.rdbVoorRood = new System.Windows.Forms.RadioButton();
            this.rdbAchterStandaard = new System.Windows.Forms.RadioButton();
            this.rdbAchterZwart = new System.Windows.Forms.RadioButton();
            this.rdbAchterWit = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbVoorRood);
            this.groupBox1.Controls.Add(this.rdbVoorWit);
            this.groupBox1.Controls.Add(this.rdbVoorZwart);
            this.groupBox1.Location = new System.Drawing.Point(474, 200);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Voorgrondkleur";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdbAchterWit);
            this.groupBox2.Controls.Add(this.rdbAchterZwart);
            this.groupBox2.Controls.Add(this.rdbAchterStandaard);
            this.groupBox2.Location = new System.Drawing.Point(207, 200);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Achtergrondkleur";
            // 
            // rdbVoorZwart
            // 
            this.rdbVoorZwart.AutoSize = true;
            this.rdbVoorZwart.Checked = true;
            this.rdbVoorZwart.Location = new System.Drawing.Point(21, 19);
            this.rdbVoorZwart.Name = "rdbVoorZwart";
            this.rdbVoorZwart.Size = new System.Drawing.Size(52, 17);
            this.rdbVoorZwart.TabIndex = 0;
            this.rdbVoorZwart.TabStop = true;
            this.rdbVoorZwart.Text = "Zwart";
            this.rdbVoorZwart.UseVisualStyleBackColor = true;
            this.rdbVoorZwart.CheckedChanged += new System.EventHandler(this.rdbVoor_CheckedChanged);
            // 
            // rdbVoorWit
            // 
            this.rdbVoorWit.AutoSize = true;
            this.rdbVoorWit.Location = new System.Drawing.Point(21, 43);
            this.rdbVoorWit.Name = "rdbVoorWit";
            this.rdbVoorWit.Size = new System.Drawing.Size(41, 17);
            this.rdbVoorWit.TabIndex = 1;
            this.rdbVoorWit.Text = "Wit";
            this.rdbVoorWit.UseVisualStyleBackColor = true;
            this.rdbVoorWit.CheckedChanged += new System.EventHandler(this.rdbVoor_CheckedChanged);
            // 
            // rdbVoorRood
            // 
            this.rdbVoorRood.AutoSize = true;
            this.rdbVoorRood.Location = new System.Drawing.Point(21, 67);
            this.rdbVoorRood.Name = "rdbVoorRood";
            this.rdbVoorRood.Size = new System.Drawing.Size(51, 17);
            this.rdbVoorRood.TabIndex = 2;
            this.rdbVoorRood.Text = "Rood";
            this.rdbVoorRood.UseVisualStyleBackColor = true;
            this.rdbVoorRood.CheckedChanged += new System.EventHandler(this.rdbVoor_CheckedChanged);
            // 
            // rdbAchterStandaard
            // 
            this.rdbAchterStandaard.AutoSize = true;
            this.rdbAchterStandaard.Checked = true;
            this.rdbAchterStandaard.Location = new System.Drawing.Point(7, 20);
            this.rdbAchterStandaard.Name = "rdbAchterStandaard";
            this.rdbAchterStandaard.Size = new System.Drawing.Size(74, 17);
            this.rdbAchterStandaard.TabIndex = 0;
            this.rdbAchterStandaard.TabStop = true;
            this.rdbAchterStandaard.Text = "Standaard";
            this.rdbAchterStandaard.UseVisualStyleBackColor = true;
            this.rdbAchterStandaard.CheckedChanged += new System.EventHandler(this.rdbAchter_CheckedChanged);
            // 
            // rdbAchterZwart
            // 
            this.rdbAchterZwart.AutoSize = true;
            this.rdbAchterZwart.Location = new System.Drawing.Point(7, 44);
            this.rdbAchterZwart.Name = "rdbAchterZwart";
            this.rdbAchterZwart.Size = new System.Drawing.Size(52, 17);
            this.rdbAchterZwart.TabIndex = 1;
            this.rdbAchterZwart.Text = "Zwart";
            this.rdbAchterZwart.UseVisualStyleBackColor = true;
            this.rdbAchterZwart.CheckedChanged += new System.EventHandler(this.rdbAchter_CheckedChanged);
            // 
            // rdbAchterWit
            // 
            this.rdbAchterWit.AutoSize = true;
            this.rdbAchterWit.Location = new System.Drawing.Point(7, 67);
            this.rdbAchterWit.Name = "rdbAchterWit";
            this.rdbAchterWit.Size = new System.Drawing.Size(41, 17);
            this.rdbAchterWit.TabIndex = 2;
            this.rdbAchterWit.Text = "Wit";
            this.rdbAchterWit.UseVisualStyleBackColor = true;
            this.rdbAchterWit.CheckedChanged += new System.EventHandler(this.rdbAchter_CheckedChanged);
            // 
            // frmRadioButtons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmRadioButtons";
            this.Text = "frmRadioButtons";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbVoorRood;
        private System.Windows.Forms.RadioButton rdbVoorWit;
        private System.Windows.Forms.RadioButton rdbVoorZwart;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdbAchterWit;
        private System.Windows.Forms.RadioButton rdbAchterZwart;
        private System.Windows.Forms.RadioButton rdbAchterStandaard;
    }
}