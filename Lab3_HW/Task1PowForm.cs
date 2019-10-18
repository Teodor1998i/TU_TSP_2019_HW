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
    public partial class Task1PowForm : Form
    {
        public Task1PowForm()
        {
            InitializeComponent();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            this.aTextBox.Clear();
            this.nTextBox.Clear();
            this.resultTextBox.Clear();
        }

        private void Calculate()
        {
            try
            {
                this.resultTextBox.Text = Math.Pow(int.Parse(this.aTextBox.Text), int.Parse(this.nTextBox.Text)).ToString();
            }
            catch
            {
            }
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            this.Calculate();
        }
    }
}
