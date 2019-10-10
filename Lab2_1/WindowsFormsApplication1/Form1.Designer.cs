namespace WindowsFormsApplication1
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.a = new System.Windows.Forms.TextBox();
			this.b = new System.Windows.Forms.TextBox();
			this.c = new System.Windows.Forms.TextBox();
			this.x1 = new System.Windows.Forms.TextBox();
			this.x2 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(69, 83);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(22, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "a =";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(69, 132);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(25, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "b = ";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(69, 167);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(25, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "c = ";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(65, 383);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(30, 13);
			this.label4.TabIndex = 3;
			this.label4.Text = "x1 = ";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(65, 424);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(30, 13);
			this.label5.TabIndex = 4;
			this.label5.Text = "x2 = ";
			// 
			// a
			// 
			this.a.Location = new System.Drawing.Point(121, 80);
			this.a.Name = "a";
			this.a.Size = new System.Drawing.Size(85, 20);
			this.a.TabIndex = 5;
			this.a.TextChanged += new System.EventHandler(this.a_TextChanged);
			// 
			// b
			// 
			this.b.Location = new System.Drawing.Point(121, 129);
			this.b.Name = "b";
			this.b.Size = new System.Drawing.Size(89, 20);
			this.b.TabIndex = 6;
			this.b.TextChanged += new System.EventHandler(this.b_TextChanged);
			// 
			// c
			// 
			this.c.Location = new System.Drawing.Point(119, 169);
			this.c.Name = "c";
			this.c.Size = new System.Drawing.Size(90, 20);
			this.c.TabIndex = 7;
			this.c.TextChanged += new System.EventHandler(this.c_TextChanged);
			// 
			// x1
			// 
			this.x1.Location = new System.Drawing.Point(125, 384);
			this.x1.Name = "x1";
			this.x1.Size = new System.Drawing.Size(83, 20);
			this.x1.TabIndex = 8;
			// 
			// x2
			// 
			this.x2.Location = new System.Drawing.Point(126, 424);
			this.x2.Name = "x2";
			this.x2.Size = new System.Drawing.Size(84, 20);
			this.x2.TabIndex = 9;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(294, 264);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(139, 61);
			this.button1.TabIndex = 10;
			this.button1.Text = "Calc";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(725, 533);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.x2);
			this.Controls.Add(this.x1);
			this.Controls.Add(this.c);
			this.Controls.Add(this.b);
			this.Controls.Add(this.a);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox a;
		private System.Windows.Forms.TextBox b;
		private System.Windows.Forms.TextBox c;
		private System.Windows.Forms.TextBox x1;
		private System.Windows.Forms.TextBox x2;
		private System.Windows.Forms.Button button1;
	}
}

