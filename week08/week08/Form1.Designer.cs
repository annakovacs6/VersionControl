﻿namespace week08
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
			this.components = new System.ComponentModel.Container();
			this.mainPanel = new System.Windows.Forms.Panel();
			this.createTimer = new System.Windows.Forms.Timer(this.components);
			this.conveyorTimer = new System.Windows.Forms.Timer(this.components);
			this.btnSelectCar = new System.Windows.Forms.Button();
			this.btnSelectBall = new System.Windows.Forms.Button();
			this.lblNext = new System.Windows.Forms.Label();
			this.btnColor = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// mainPanel
			// 
			this.mainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.mainPanel.Location = new System.Drawing.Point(12, 207);
			this.mainPanel.Name = "mainPanel";
			this.mainPanel.Size = new System.Drawing.Size(692, 231);
			this.mainPanel.TabIndex = 0;
			// 
			// createTimer
			// 
			this.createTimer.Enabled = true;
			this.createTimer.Interval = 3000;
			this.createTimer.Tick += new System.EventHandler(this.createTimer_Tick);
			// 
			// conveyorTimer
			// 
			this.conveyorTimer.Enabled = true;
			this.conveyorTimer.Interval = 10;
			this.conveyorTimer.Tick += new System.EventHandler(this.conveyorTimer_Tick);
			// 
			// btnSelectCar
			// 
			this.btnSelectCar.Location = new System.Drawing.Point(13, 13);
			this.btnSelectCar.Name = "btnSelectCar";
			this.btnSelectCar.Size = new System.Drawing.Size(134, 63);
			this.btnSelectCar.TabIndex = 1;
			this.btnSelectCar.Text = "CAR";
			this.btnSelectCar.UseVisualStyleBackColor = true;
			this.btnSelectCar.Click += new System.EventHandler(this.SelectCar_Click);
			// 
			// btnSelectBall
			// 
			this.btnSelectBall.Location = new System.Drawing.Point(176, 13);
			this.btnSelectBall.Name = "btnSelectBall";
			this.btnSelectBall.Size = new System.Drawing.Size(134, 63);
			this.btnSelectBall.TabIndex = 2;
			this.btnSelectBall.Text = "BALL";
			this.btnSelectBall.UseVisualStyleBackColor = true;
			this.btnSelectBall.Click += new System.EventHandler(this.SelectBall_Click);
			// 
			// lblNext
			// 
			this.lblNext.AutoSize = true;
			this.lblNext.Location = new System.Drawing.Point(328, 13);
			this.lblNext.Name = "lblNext";
			this.lblNext.Size = new System.Drawing.Size(89, 17);
			this.lblNext.TabIndex = 3;
			this.lblNext.Text = "Coming next:";
			// 
			// btnColor
			// 
			this.btnColor.BackColor = System.Drawing.Color.Red;
			this.btnColor.Location = new System.Drawing.Point(176, 83);
			this.btnColor.Name = "btnColor";
			this.btnColor.Size = new System.Drawing.Size(134, 23);
			this.btnColor.TabIndex = 4;
			this.btnColor.UseVisualStyleBackColor = false;
			this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnColor);
			this.Controls.Add(this.lblNext);
			this.Controls.Add(this.btnSelectBall);
			this.Controls.Add(this.btnSelectCar);
			this.Controls.Add(this.mainPanel);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel mainPanel;
		private System.Windows.Forms.Timer createTimer;
		private System.Windows.Forms.Timer conveyorTimer;
		private System.Windows.Forms.Button btnSelectCar;
		private System.Windows.Forms.Button btnSelectBall;
		private System.Windows.Forms.Label lblNext;
		private System.Windows.Forms.Button btnColor;
	}
}

