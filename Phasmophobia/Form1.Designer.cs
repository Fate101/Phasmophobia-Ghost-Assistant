﻿namespace PhasmophobiaGhostAssistant
{
    partial class Form1
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
            this.cbEvi1 = new System.Windows.Forms.ComboBox();
            this.cbEvi2 = new System.Windows.Forms.ComboBox();
            this.cbEvi3 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaybe1 = new System.Windows.Forms.Label();
            this.txtMaybe2 = new System.Windows.Forms.Label();
            this.txtMaybe3 = new System.Windows.Forms.Label();
            this.lblEvi3 = new System.Windows.Forms.Label();
            this.lblEvi2 = new System.Windows.Forms.Label();
            this.lblEvi1 = new System.Windows.Forms.Label();
            this.lblCredits = new System.Windows.Forms.Label();
            this.lblStrenght = new System.Windows.Forms.Label();
            this.lblWeakness = new System.Windows.Forms.Label();
            this.btnResetSize = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbEvi1
            // 
            this.cbEvi1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEvi1.FormattingEnabled = true;
            this.cbEvi1.Items.AddRange(new object[] {
            "Freezing Temperatures",
            "EMF 5",
            "Spirit Box",
            "Ghost Writing",
            "Ghost Orbs",
            "Fingerprints",
            "None"});
            this.cbEvi1.Location = new System.Drawing.Point(12, 32);
            this.cbEvi1.Name = "cbEvi1";
            this.cbEvi1.Size = new System.Drawing.Size(121, 21);
            this.cbEvi1.TabIndex = 0;
            this.cbEvi1.SelectedIndexChanged += new System.EventHandler(this.CbEvi1_SelectedIndexChanged);
            // 
            // cbEvi2
            // 
            this.cbEvi2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEvi2.FormattingEnabled = true;
            this.cbEvi2.Items.AddRange(new object[] {
            "Freezing Temperatures",
            "EMF 5",
            "Spirit Box",
            "Ghost Writing",
            "Ghost Orbs",
            "Fingerprints",
            "None"});
            this.cbEvi2.Location = new System.Drawing.Point(168, 32);
            this.cbEvi2.Name = "cbEvi2";
            this.cbEvi2.Size = new System.Drawing.Size(121, 21);
            this.cbEvi2.TabIndex = 1;
            this.cbEvi2.SelectedIndexChanged += new System.EventHandler(this.CbEvi2_SelectedIndexChanged);
            // 
            // cbEvi3
            // 
            this.cbEvi3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEvi3.FormattingEnabled = true;
            this.cbEvi3.Items.AddRange(new object[] {
            "Freezing Temperatures",
            "EMF 5",
            "Spirit Box",
            "Ghost Writing",
            "Ghost Orbs",
            "Fingerprints",
            "None"});
            this.cbEvi3.Location = new System.Drawing.Point(320, 32);
            this.cbEvi3.Name = "cbEvi3";
            this.cbEvi3.Size = new System.Drawing.Size(121, 21);
            this.cbEvi3.TabIndex = 2;
            this.cbEvi3.SelectedIndexChanged += new System.EventHandler(this.CbEvi3_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Evidence 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(165, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Evidence 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(317, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Evidence 3";
            // 
            // txtMaybe1
            // 
            this.txtMaybe1.AutoSize = true;
            this.txtMaybe1.Location = new System.Drawing.Point(12, 81);
            this.txtMaybe1.Name = "txtMaybe1";
            this.txtMaybe1.Size = new System.Drawing.Size(0, 13);
            this.txtMaybe1.TabIndex = 6;
            this.txtMaybe1.Click += new System.EventHandler(this.txtMaybe1_Click);
            // 
            // txtMaybe2
            // 
            this.txtMaybe2.AutoSize = true;
            this.txtMaybe2.Location = new System.Drawing.Point(12, 108);
            this.txtMaybe2.Name = "txtMaybe2";
            this.txtMaybe2.Size = new System.Drawing.Size(0, 13);
            this.txtMaybe2.TabIndex = 7;
            this.txtMaybe2.Click += new System.EventHandler(this.txtMaybe2_Click);
            // 
            // txtMaybe3
            // 
            this.txtMaybe3.AutoSize = true;
            this.txtMaybe3.Location = new System.Drawing.Point(12, 137);
            this.txtMaybe3.Name = "txtMaybe3";
            this.txtMaybe3.Size = new System.Drawing.Size(0, 13);
            this.txtMaybe3.TabIndex = 8;
            this.txtMaybe3.Click += new System.EventHandler(this.txtMaybe3_Click);
            // 
            // lblEvi3
            // 
            this.lblEvi3.AutoSize = true;
            this.lblEvi3.Location = new System.Drawing.Point(128, 137);
            this.lblEvi3.Name = "lblEvi3";
            this.lblEvi3.Size = new System.Drawing.Size(0, 13);
            this.lblEvi3.TabIndex = 11;
            // 
            // lblEvi2
            // 
            this.lblEvi2.AutoSize = true;
            this.lblEvi2.Location = new System.Drawing.Point(128, 108);
            this.lblEvi2.Name = "lblEvi2";
            this.lblEvi2.Size = new System.Drawing.Size(0, 13);
            this.lblEvi2.TabIndex = 10;
            // 
            // lblEvi1
            // 
            this.lblEvi1.AutoSize = true;
            this.lblEvi1.Location = new System.Drawing.Point(128, 81);
            this.lblEvi1.Name = "lblEvi1";
            this.lblEvi1.Size = new System.Drawing.Size(0, 13);
            this.lblEvi1.TabIndex = 9;
            // 
            // lblCredits
            // 
            this.lblCredits.AutoSize = true;
            this.lblCredits.Location = new System.Drawing.Point(289, 154);
            this.lblCredits.Name = "lblCredits";
            this.lblCredits.Size = new System.Drawing.Size(144, 13);
            this.lblCredits.TabIndex = 12;
            this.lblCredits.Text = "By Sekynn | Modified by Fate";
            // 
            // lblStrenght
            // 
            this.lblStrenght.AutoSize = true;
            this.lblStrenght.Location = new System.Drawing.Point(12, 168);
            this.lblStrenght.Name = "lblStrenght";
            this.lblStrenght.Size = new System.Drawing.Size(0, 13);
            this.lblStrenght.TabIndex = 13;
            // 
            // lblWeakness
            // 
            this.lblWeakness.AutoSize = true;
            this.lblWeakness.Location = new System.Drawing.Point(12, 194);
            this.lblWeakness.Name = "lblWeakness";
            this.lblWeakness.Size = new System.Drawing.Size(0, 13);
            this.lblWeakness.TabIndex = 14;
            // 
            // btnResetSize
            // 
            this.btnResetSize.Location = new System.Drawing.Point(416, 186);
            this.btnResetSize.Name = "btnResetSize";
            this.btnResetSize.Size = new System.Drawing.Size(25, 25);
            this.btnResetSize.TabIndex = 15;
            this.btnResetSize.Text = "^";
            this.btnResetSize.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnResetSize.UseVisualStyleBackColor = true;
            this.btnResetSize.Click += new System.EventHandler(this.btnResetSize_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 182);
            this.Controls.Add(this.btnResetSize);
            this.Controls.Add(this.lblWeakness);
            this.Controls.Add(this.lblStrenght);
            this.Controls.Add(this.lblCredits);
            this.Controls.Add(this.lblEvi3);
            this.Controls.Add(this.lblEvi2);
            this.Controls.Add(this.lblEvi1);
            this.Controls.Add(this.txtMaybe3);
            this.Controls.Add(this.txtMaybe2);
            this.Controls.Add(this.txtMaybe1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbEvi3);
            this.Controls.Add(this.cbEvi2);
            this.Controls.Add(this.cbEvi1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phasmophobia Ghost Assistant";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbEvi1;
        private System.Windows.Forms.ComboBox cbEvi2;
        private System.Windows.Forms.ComboBox cbEvi3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label txtMaybe1;
        private System.Windows.Forms.Label txtMaybe2;
        private System.Windows.Forms.Label txtMaybe3;
        private System.Windows.Forms.Label lblEvi3;
        private System.Windows.Forms.Label lblEvi2;
        private System.Windows.Forms.Label lblEvi1;
        private System.Windows.Forms.Label lblCredits;
        private System.Windows.Forms.Label lblStrenght;
        private System.Windows.Forms.Label lblWeakness;
        private System.Windows.Forms.Button btnResetSize;
    }
}

