﻿namespace Hoo.Relaxant.Test {
	partial class MonitorServiceForm {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
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
            this.turnOnButton = new System.Windows.Forms.Button();
            this.turnOffButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // turnOnButton
            // 
            this.turnOnButton.Location = new System.Drawing.Point(59, 57);
            this.turnOnButton.Name = "turnOnButton";
            this.turnOnButton.Size = new System.Drawing.Size(156, 46);
            this.turnOnButton.TabIndex = 0;
            this.turnOnButton.Text = "Turn On";
            this.turnOnButton.UseVisualStyleBackColor = true;
            this.turnOnButton.Click += new System.EventHandler(this.turnOnButton_Click);
            // 
            // turnOffButton
            // 
            this.turnOffButton.Location = new System.Drawing.Point(59, 139);
            this.turnOffButton.Name = "turnOffButton";
            this.turnOffButton.Size = new System.Drawing.Size(155, 53);
            this.turnOffButton.TabIndex = 1;
            this.turnOffButton.Text = "Turn Off";
            this.turnOffButton.UseVisualStyleBackColor = true;
            this.turnOffButton.Click += new System.EventHandler(this.turnOffButton_Click);
            // 
            // MonitorServiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Controls.Add(this.turnOffButton);
            this.Controls.Add(this.turnOnButton);
            this.Name = "MonitorServiceForm";
            this.Text = "MonitorServiceForm";
            this.Load += new System.EventHandler(this.MonitorServiceForm_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MonitorServiceForm_FormClosed);
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button turnOnButton;
		private System.Windows.Forms.Button turnOffButton;
	}
}