﻿namespace Hoo.Relaxant {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
			this.spinEdit1 = new DevExpress.XtraEditors.SpinEdit();
			this.monitorServiceButton = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.spinEdit1.Properties)).BeginInit();
			this.SuspendLayout();
			// 
			// spinEdit1
			// 
			this.spinEdit1.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
			this.spinEdit1.Location = new System.Drawing.Point(0, 0);
			this.spinEdit1.Name = "spinEdit1";
			this.spinEdit1.Size = new System.Drawing.Size(100, 20);
			this.spinEdit1.TabIndex = 0;
			// 
			// monitorServiceButton
			// 
			this.monitorServiceButton.Location = new System.Drawing.Point(41, 49);
			this.monitorServiceButton.Name = "monitorServiceButton";
			this.monitorServiceButton.Size = new System.Drawing.Size(160, 40);
			this.monitorServiceButton.TabIndex = 1;
			this.monitorServiceButton.Text = "Monitor Service";
			this.monitorServiceButton.UseVisualStyleBackColor = true;
			this.monitorServiceButton.Click += new System.EventHandler(this.monitorServiceButton_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(292, 263);
			this.Controls.Add(this.monitorServiceButton);
			this.Controls.Add(this.spinEdit1);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.spinEdit1.Properties)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SpinEdit spinEdit1;
		private System.Windows.Forms.Button monitorServiceButton;
    }
}