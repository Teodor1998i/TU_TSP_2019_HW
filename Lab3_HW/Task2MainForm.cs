using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3_HW
{
    public partial class Task2MainForm : Form
    {
        private bool isButtonVisible;

        public Task2MainForm()
        {
            this.InitializeComponent();
        }

        private void Calculate()
        {
            try
            {
                double pDDO = 0;
                double pDZPO = 0;
                double salary = double.Parse(this.salaryTextBox.Text);

                if (this.radioButton1.Checked)
                {
                    pDDO = 0.089;
                }

                if (this.radioButton2.Checked)
                {
                    pDDO = 0.067;
                    pDZPO = 0.022;
                }

                double DOO = pDDO * salary;
                double DZPO = pDZPO * salary;
                double health = 0.032 * salary;
                double total = DOO + DZPO + health;

                this.dooTextBox.Text = DOO.ToString("N") + " лв.";
                this.dzpoTextBox.Text = DZPO.ToString("N") + " лв.";
                this.healthTextBox.Text = health.ToString("N") + " лв.";
                this.totalTextBox.Text = total.ToString("N") + " лв.";
            }
            catch
            {
            }
        }

        private void Task2MainForm_Load(object sender, EventArgs e)
        {
            this.radioButton1.Checked = true;

            if (DialogResult.Yes == MessageBox.Show("Work with button?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                this.isButtonVisible = true;
            }

            if (this.isButtonVisible)
            {
                this.calculateButton.Visible = true;
            }
        }

        private void salaryTextBox_KeyPressed(object sender, KeyPressEventArgs e)
        {
            // Допуска се запетая и Backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != ',')
            {
                e.Handled = true;
                this.salaryTextBox.Focus();
            }
        }

        private void salaryTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!this.isButtonVisible)
            {
                this.Calculate();
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (!this.isButtonVisible)
            {
                this.Calculate();
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (!this.isButtonVisible)
            {
                this.Calculate();
            }
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            this.Calculate();
        }
    }
}
