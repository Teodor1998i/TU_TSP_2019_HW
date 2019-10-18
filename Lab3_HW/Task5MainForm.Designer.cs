namespace Lab3_HW
{
    partial class Task5MainForm
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
            this.luckyNumber1Label = new System.Windows.Forms.Label();
            this.luckyNumber4Label = new System.Windows.Forms.Label();
            this.luckyNumber2Label = new System.Windows.Forms.Label();
            this.luckyNumber3Label = new System.Windows.Forms.Label();
            this.generateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // luckyNumber1Label
            // 
            this.luckyNumber1Label.AutoSize = true;
            this.luckyNumber1Label.Location = new System.Drawing.Point(13, 13);
            this.luckyNumber1Label.Name = "luckyNumber1Label";
            this.luckyNumber1Label.Size = new System.Drawing.Size(0, 17);
            this.luckyNumber1Label.TabIndex = 0;
            // 
            // luckyNumber4Label
            // 
            this.luckyNumber4Label.AutoSize = true;
            this.luckyNumber4Label.Location = new System.Drawing.Point(445, 13);
            this.luckyNumber4Label.Name = "luckyNumber4Label";
            this.luckyNumber4Label.Size = new System.Drawing.Size(0, 17);
            this.luckyNumber4Label.TabIndex = 1;
            // 
            // luckyNumber2Label
            // 
            this.luckyNumber2Label.AutoSize = true;
            this.luckyNumber2Label.Location = new System.Drawing.Point(157, 13);
            this.luckyNumber2Label.Name = "luckyNumber2Label";
            this.luckyNumber2Label.Size = new System.Drawing.Size(0, 17);
            this.luckyNumber2Label.TabIndex = 2;
            // 
            // luckyNumber3Label
            // 
            this.luckyNumber3Label.AutoSize = true;
            this.luckyNumber3Label.Location = new System.Drawing.Point(301, 13);
            this.luckyNumber3Label.Name = "luckyNumber3Label";
            this.luckyNumber3Label.Size = new System.Drawing.Size(0, 17);
            this.luckyNumber3Label.TabIndex = 3;
            // 
            // generateButton
            // 
            this.generateButton.Location = new System.Drawing.Point(13, 62);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(480, 23);
            this.generateButton.TabIndex = 4;
            this.generateButton.Text = "Генерирай щастливи числа";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // Task5MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 93);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.luckyNumber3Label);
            this.Controls.Add(this.luckyNumber2Label);
            this.Controls.Add(this.luckyNumber4Label);
            this.Controls.Add(this.luckyNumber1Label);
            this.Name = "Task5MainForm";
            this.Text = "Task5MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label luckyNumber1Label;
        private System.Windows.Forms.Label luckyNumber4Label;
        private System.Windows.Forms.Label luckyNumber2Label;
        private System.Windows.Forms.Label luckyNumber3Label;
        private System.Windows.Forms.Button generateButton;
    }
}