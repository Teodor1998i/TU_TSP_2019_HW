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
    public partial class Task4MainForm : Form
    {
        public Task4MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var year = int.Parse(this.yearTextBox.Text);
                var month = int.Parse(this.monthTextBox.Text);
                var day = int.Parse(this.dayTextBox.Text);

                var years = DateTime.Today.Year - year;
                var months = DateTime.Today.Month - month;
                var days = DateTime.Today.Day - day;

                if (DateTime.Today.Day > day)
                {
                    month--;
                }

                MessageBox.Show($"{years} години и {months} месеца!");
            }
            catch
            {
            }
        }
    }
}
