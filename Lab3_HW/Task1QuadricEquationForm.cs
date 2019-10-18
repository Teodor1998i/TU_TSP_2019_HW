using System;
using System.Windows.Forms;

namespace Lab3_HW
{
    public partial class Task1QuadricEquationForm : Form
    {
        private bool isButtonVisible;

        public Task1QuadricEquationForm()
        {
            this.InitializeComponent();
        }

        private void Task1QuadricEquationForm_Load(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Work with button?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                this.isButtonVisible = true;
            }

            if (this.isButtonVisible)
            {
                this.calculateButton.Visible = true;
            }
        }

        private void CalculateQuadraticEquation()
        {
            try
            {
                double a = double.Parse(this.aTextBox.Text);
                double b = double.Parse(this.bTextBox.Text);
                double c = double.Parse(this.cTextBox.Text);
                double D = Math.Pow(b, 2) - 4 * a * c;

                if (D > 0)
                {
                    double x1 = (-b + Math.Sqrt(D)) / (2 * a);
                    double x2 = (-b - Math.Sqrt(D)) / (2 * a);

                    this.x1Label.Text = x1.ToString();
                    this.x2Label.Text = x2.ToString();
                }
                else if (D == 0)
                {
                    double x1 = -b / (2 * a);
                    this.x1Label.Text = x1.ToString();
                    this.x2Label.Text = string.Empty;
                }
                else
                {
                    this.x1Label.Text = "No real roots..";
                    this.x2Label.Text = "No real roots..";
                }
            }
            catch
            {
            }
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            this.CalculateQuadraticEquation();
        }

        private void aTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!this.isButtonVisible)
            {
                this.CalculateQuadraticEquation();
            }
        }

        private void bTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!this.isButtonVisible)
            {
                this.CalculateQuadraticEquation();
            }
        }

        private void cTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!this.isButtonVisible)
            {
                this.CalculateQuadraticEquation();
            }
        }
    }
}
