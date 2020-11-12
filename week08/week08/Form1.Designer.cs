namespace week08
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
			this.SelectCar = new System.Windows.Forms.Button();
			this.SelectBall = new System.Windows.Forms.Button();
			this.lblNext = new System.Windows.Forms.Label();
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
			// SelectCar
			// 
			this.SelectCar.Location = new System.Drawing.Point(13, 13);
			this.SelectCar.Name = "SelectCar";
			this.SelectCar.Size = new System.Drawing.Size(134, 63);
			this.SelectCar.TabIndex = 1;
			this.SelectCar.Text = "CAR";
			this.SelectCar.UseVisualStyleBackColor = true;
			this.SelectCar.Click += new System.EventHandler(this.SelectCar_Click);
			// 
			// SelectBall
			// 
			this.SelectBall.Location = new System.Drawing.Point(176, 13);
			this.SelectBall.Name = "SelectBall";
			this.SelectBall.Size = new System.Drawing.Size(134, 63);
			this.SelectBall.TabIndex = 2;
			this.SelectBall.Text = "BALL";
			this.SelectBall.UseVisualStyleBackColor = true;
			this.SelectBall.Click += new System.EventHandler(this.SelectBall_Click);
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
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.lblNext);
			this.Controls.Add(this.SelectBall);
			this.Controls.Add(this.SelectCar);
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
		private System.Windows.Forms.Button SelectCar;
		private System.Windows.Forms.Button SelectBall;
		private System.Windows.Forms.Label lblNext;
	}
}

