using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3_HW
{
    public partial class Task1FormulasForm : Form
    {
        public Task1FormulasForm()
        {
            this.InitializeComponent();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            this.aTextBox.Clear();
            this.bTextBox.Clear();
            this.resultTextBox.Clear();
            this.radioButton1.Checked = true;
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                double a = double.Parse(this.aTextBox.Text);
                double b = double.Parse(this.bTextBox.Text);
                double result = 0;

                if (this.radioButton1.Checked)
                {
                    result = Math.Pow(a, 2) + 2 * a * b + Math.Pow(b, 2);
                }

                if (this.radioButton2.Checked)
                {
                    result = Math.Pow(a, 2) - 2 * a * b + Math.Pow(b, 2);
                }

                if (this.radioButton3.Checked)
                {
                    result = Math.Pow(a, 2) - Math.Pow(b, 2);
                }

                if (this.radioButton4.Checked)
                {
                    result = Math.Pow(a, 3) + 3 * Math.Pow(a, 2) * b + 3 * a * Math.Pow(b, 2) + Math.Pow(b, 3);
                }

                if (this.radioButton4.Checked)
                {
                    result = Math.Pow(a, 3) - 3 * Math.Pow(a, 2) * b + 3 * a * Math.Pow(b, 2) - Math.Pow(b, 3);
                }

                if (this.radioButton5.Checked)
                {
                    result = (a + b) * (Math.Pow(a, 2) + a * b + Math.Pow(b, 2));
                }

                if (this.radioButton6.Checked)
                {
                    result = (a + b) * (Math.Pow(a, 2) - a * b + Math.Pow(b, 2));
                }

                this.resultTextBox.Text = result.ToString();
            }
            catch
            {
            }
        }
    }
}
