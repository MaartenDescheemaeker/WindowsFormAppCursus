﻿
namespace OpdrListBox
{
    partial class frmListBox
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
            this.lstItems = new System.Windows.Forms.ListBox();
            this.txtItem = new System.Windows.Forms.TextBox();
            this.btnSortAZ = new System.Windows.Forms.Button();
            this.btnSortZA = new System.Windows.Forms.Button();
            this.btnWis = new System.Windows.Forms.Button();
            this.btnToevoegen = new System.Windows.Forms.Button();
            this.chkSelect = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lstItems
            // 
            this.lstItems.FormattingEnabled = true;
            this.lstItems.Items.AddRange(new object[] {
            "examen",
            "fiets",
            "school",
            "les",
            "test"});
            this.lstItems.Location = new System.Drawing.Point(383, 101);
            this.lstItems.Name = "lstItems";
            this.lstItems.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstItems.Size = new System.Drawing.Size(120, 95);
            this.lstItems.TabIndex = 0;
            // 
            // txtItem
            // 
            this.txtItem.Location = new System.Drawing.Point(562, 101);
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(100, 20);
            this.txtItem.TabIndex = 1;
            // 
            // btnSortAZ
            // 
            this.btnSortAZ.Location = new System.Drawing.Point(383, 226);
            this.btnSortAZ.Name = "btnSortAZ";
            this.btnSortAZ.Size = new System.Drawing.Size(92, 23);
            this.btnSortAZ.TabIndex = 2;
            this.btnSortAZ.Text = "SorterenAZ";
            this.btnSortAZ.UseVisualStyleBackColor = true;
            this.btnSortAZ.Click += new System.EventHandler(this.btnSortAZ_Click);
            // 
            // btnSortZA
            // 
            this.btnSortZA.Location = new System.Drawing.Point(383, 256);
            this.btnSortZA.Name = "btnSortZA";
            this.btnSortZA.Size = new System.Drawing.Size(92, 23);
            this.btnSortZA.TabIndex = 3;
            this.btnSortZA.Text = "SorterenZA";
            this.btnSortZA.UseVisualStyleBackColor = true;
            this.btnSortZA.Click += new System.EventHandler(this.btnSortZA_Click);
            // 
            // btnWis
            // 
            this.btnWis.Location = new System.Drawing.Point(383, 285);
            this.btnWis.Name = "btnWis";
            this.btnWis.Size = new System.Drawing.Size(92, 23);
            this.btnWis.TabIndex = 4;
            this.btnWis.Text = "Selectie Wissen";
            this.btnWis.UseVisualStyleBackColor = true;
            this.btnWis.Click += new System.EventHandler(this.btnWis_Click);
            // 
            // btnToevoegen
            // 
            this.btnToevoegen.Location = new System.Drawing.Point(383, 314);
            this.btnToevoegen.Name = "btnToevoegen";
            this.btnToevoegen.Size = new System.Drawing.Size(92, 23);
            this.btnToevoegen.TabIndex = 5;
            this.btnToevoegen.Text = "Voeg Toe";
            this.btnToevoegen.UseVisualStyleBackColor = true;
            this.btnToevoegen.Click += new System.EventHandler(this.btnToevoegen_Click);
            // 
            // chkSelect
            // 
            this.chkSelect.AutoSize = true;
            this.chkSelect.Location = new System.Drawing.Point(577, 231);
            this.chkSelect.Name = "chkSelect";
            this.chkSelect.Size = new System.Drawing.Size(147, 17);
            this.chkSelect.TabIndex = 6;
            this.chkSelect.Text = "Toevoegen Voor Selectie";
            this.chkSelect.UseVisualStyleBackColor = true;
            // 
            // frmListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chkSelect);
            this.Controls.Add(this.btnToevoegen);
            this.Controls.Add(this.btnWis);
            this.Controls.Add(this.btnSortZA);
            this.Controls.Add(this.btnSortAZ);
            this.Controls.Add(this.txtItem);
            this.Controls.Add(this.lstItems);
            this.Name = "frmListBox";
            this.Text = "ListBox Gebruiken";
            this.Load += new System.EventHandler(this.frmListBox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstItems;
        private System.Windows.Forms.TextBox txtItem;
        private System.Windows.Forms.Button btnSortAZ;
        private System.Windows.Forms.Button btnSortZA;
        private System.Windows.Forms.Button btnWis;
        private System.Windows.Forms.Button btnToevoegen;
        private System.Windows.Forms.CheckBox chkSelect;
    }
}

