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
    public partial class Task1MainForm : Form
    {
        public Task1MainForm()
        {
            this.InitializeComponent();
        }

        private void powMenuItem_Click(object sender, EventArgs e)
        {
            Task1PowForm powForm = new Task1PowForm();
            powForm.Show();
        }

        private void shortFormulasMenuItem_Click(object sender, EventArgs e)
        {
            Task1FormulasForm formulasForm = new Task1FormulasForm();
            formulasForm.Show();
        }

        private void quadricEquationMenuItem_Click(object sender, EventArgs e)
        {
            Task1QuadricEquationForm quadricEquationForm = new Task1QuadricEquationForm();
            quadricEquationForm.Show();
        }
    }
}
