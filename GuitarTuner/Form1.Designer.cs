namespace GuitarTuner
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
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.radio6 = new System.Windows.Forms.RadioButton();
			this.radio5 = new System.Windows.Forms.RadioButton();
			this.radio4 = new System.Windows.Forms.RadioButton();
			this.radio3 = new System.Windows.Forms.RadioButton();
			this.radio2 = new System.Windows.Forms.RadioButton();
			this.radio1 = new System.Windows.Forms.RadioButton();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(12, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(268, 126);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.radio1);
			this.panel1.Controls.Add(this.radio2);
			this.panel1.Controls.Add(this.radio3);
			this.panel1.Controls.Add(this.radio4);
			this.panel1.Controls.Add(this.radio5);
			this.panel1.Controls.Add(this.radio6);
			this.panel1.Location = new System.Drawing.Point(12, 144);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(268, 143);
			this.panel1.TabIndex = 1;
			// 
			// radio6
			// 
			this.radio6.AutoSize = true;
			this.radio6.Checked = true;
			this.radio6.Location = new System.Drawing.Point(3, 3);
			this.radio6.Name = "radio6";
			this.radio6.Size = new System.Drawing.Size(32, 17);
			this.radio6.TabIndex = 0;
			this.radio6.TabStop = true;
			this.radio6.Text = "E";
			this.radio6.UseVisualStyleBackColor = true;
			// 
			// radio5
			// 
			this.radio5.AutoSize = true;
			this.radio5.Location = new System.Drawing.Point(3, 26);
			this.radio5.Name = "radio5";
			this.radio5.Size = new System.Drawing.Size(32, 17);
			this.radio5.TabIndex = 1;
			this.radio5.Text = "B";
			this.radio5.UseVisualStyleBackColor = true;
			// 
			// radio4
			// 
			this.radio4.AutoSize = true;
			this.radio4.Location = new System.Drawing.Point(3, 49);
			this.radio4.Name = "radio4";
			this.radio4.Size = new System.Drawing.Size(33, 17);
			this.radio4.TabIndex = 2;
			this.radio4.Text = "G";
			this.radio4.UseVisualStyleBackColor = true;
			// 
			// radio3
			// 
			this.radio3.AutoSize = true;
			this.radio3.Location = new System.Drawing.Point(3, 72);
			this.radio3.Name = "radio3";
			this.radio3.Size = new System.Drawing.Size(33, 17);
			this.radio3.TabIndex = 3;
			this.radio3.Text = "D";
			this.radio3.UseVisualStyleBackColor = true;
			// 
			// radio2
			// 
			this.radio2.AutoSize = true;
			this.radio2.Location = new System.Drawing.Point(3, 95);
			this.radio2.Name = "radio2";
			this.radio2.Size = new System.Drawing.Size(32, 17);
			this.radio2.TabIndex = 4;
			this.radio2.Text = "A";
			this.radio2.UseVisualStyleBackColor = true;
			// 
			// radio1
			// 
			this.radio1.AutoSize = true;
			this.radio1.Location = new System.Drawing.Point(3, 118);
			this.radio1.Name = "radio1";
			this.radio1.Size = new System.Drawing.Size(32, 17);
			this.radio1.TabIndex = 5;
			this.radio1.Text = "E";
			this.radio1.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(292, 299);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.pictureBox1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.RadioButton radio1;
		private System.Windows.Forms.RadioButton radio2;
		private System.Windows.Forms.RadioButton radio3;
		private System.Windows.Forms.RadioButton radio4;
		private System.Windows.Forms.RadioButton radio5;
		private System.Windows.Forms.RadioButton radio6;
	}
}

