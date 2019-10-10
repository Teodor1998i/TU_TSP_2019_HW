namespace upr4lab3matformuli
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.matFormuliToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.algebraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.klasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stepenuvaneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.klasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.klasToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formuliSakratenoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.matFormuliToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(890, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // matFormuliToolStripMenuItem
            // 
            this.matFormuliToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.algebraToolStripMenuItem});
            this.matFormuliToolStripMenuItem.Name = "matFormuliToolStripMenuItem";
            this.matFormuliToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.matFormuliToolStripMenuItem.Text = "MatFormuli";
            // 
            // algebraToolStripMenuItem
            // 
            this.algebraToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.klasToolStripMenuItem,
            this.klasToolStripMenuItem1,
            this.klasToolStripMenuItem2,
            this.exitToolStripMenuItem});
            this.algebraToolStripMenuItem.Name = "algebraToolStripMenuItem";
            this.algebraToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.algebraToolStripMenuItem.Text = "Algebra";
            // 
            // klasToolStripMenuItem
            // 
            this.klasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stepenuvaneToolStripMenuItem});
            this.klasToolStripMenuItem.Name = "klasToolStripMenuItem";
            this.klasToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.klasToolStripMenuItem.Text = "6klas";
            // 
            // stepenuvaneToolStripMenuItem
            // 
            this.stepenuvaneToolStripMenuItem.Name = "stepenuvaneToolStripMenuItem";
            this.stepenuvaneToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.stepenuvaneToolStripMenuItem.Text = "Stepenuvane";
            this.stepenuvaneToolStripMenuItem.Click += new System.EventHandler(this.stepenuvaneToolStripMenuItem_Click);
            // 
            // klasToolStripMenuItem1
            // 
            this.klasToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formuliSakratenoToolStripMenuItem});
            this.klasToolStripMenuItem1.Name = "klasToolStripMenuItem1";
            this.klasToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.klasToolStripMenuItem1.Text = "7klas";
            // 
            // klasToolStripMenuItem2
            // 
            this.klasToolStripMenuItem2.Name = "klasToolStripMenuItem2";
            this.klasToolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.klasToolStripMenuItem2.Text = "8klas";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // formuliSakratenoToolStripMenuItem
            // 
            this.formuliSakratenoToolStripMenuItem.Name = "formuliSakratenoToolStripMenuItem";
            this.formuliSakratenoToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.formuliSakratenoToolStripMenuItem.Text = "FormuliSakrateno";
            this.formuliSakratenoToolStripMenuItem.Click += new System.EventHandler(this.formuliSakratenoToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 597);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem matFormuliToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem algebraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem klasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stepenuvaneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem klasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem klasToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formuliSakratenoToolStripMenuItem;
    }
}

