namespace Mars_Mission_Control_Dev
{
	partial class TestSam
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
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.tbX = new System.Windows.Forms.TextBox();
			this.lbX = new System.Windows.Forms.Label();
			this.lbY = new System.Windows.Forms.Label();
			this.tbY = new System.Windows.Forms.TextBox();
			this.lbTailleImage = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(57, 88);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(319, 432);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// tbX
			// 
			this.tbX.Location = new System.Drawing.Point(30, 20);
			this.tbX.Name = "tbX";
			this.tbX.Size = new System.Drawing.Size(55, 20);
			this.tbX.TabIndex = 1;
			// 
			// lbX
			// 
			this.lbX.AutoSize = true;
			this.lbX.Location = new System.Drawing.Point(12, 20);
			this.lbX.Name = "lbX";
			this.lbX.Size = new System.Drawing.Size(12, 13);
			this.lbX.TabIndex = 2;
			this.lbX.Text = "x";
			this.lbX.Click += new System.EventHandler(this.label1_Click);
			// 
			// lbY
			// 
			this.lbY.AutoSize = true;
			this.lbY.Location = new System.Drawing.Point(100, 20);
			this.lbY.Name = "lbY";
			this.lbY.Size = new System.Drawing.Size(12, 13);
			this.lbY.TabIndex = 3;
			this.lbY.Text = "y";
			// 
			// tbY
			// 
			this.tbY.Location = new System.Drawing.Point(118, 20);
			this.tbY.Name = "tbY";
			this.tbY.Size = new System.Drawing.Size(55, 20);
			this.tbY.TabIndex = 4;
			// 
			// lbTailleImage
			// 
			this.lbTailleImage.AutoSize = true;
			this.lbTailleImage.Location = new System.Drawing.Point(12, 51);
			this.lbTailleImage.Name = "lbTailleImage";
			this.lbTailleImage.Size = new System.Drawing.Size(35, 13);
			this.lbTailleImage.TabIndex = 5;
			this.lbTailleImage.Text = "label1";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(246, 18);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 6;
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// TestSam
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(463, 565);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.lbTailleImage);
			this.Controls.Add(this.tbY);
			this.Controls.Add(this.lbY);
			this.Controls.Add(this.lbX);
			this.Controls.Add(this.tbX);
			this.Controls.Add(this.pictureBox1);
			this.Name = "TestSam";
			this.Text = "TestSam";
			this.Load += new System.EventHandler(this.TestSam_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.TextBox tbX;
		private System.Windows.Forms.Label lbX;
		private System.Windows.Forms.Label lbY;
		private System.Windows.Forms.TextBox tbY;
		private System.Windows.Forms.Label lbTailleImage;
		private System.Windows.Forms.Button button1;
	}
}