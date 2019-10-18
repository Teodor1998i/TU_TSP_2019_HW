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
    public partial class Task3MainForm : Form
    {
        public Task3MainForm()
        {
            this.InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            var currentDate = new DateTime(int.Parse(this.yearTextBox.Text), int.Parse(this.monthTextBox.Text), 1);
            var isLeapYear = currentDate.Year % 4 == 0 && currentDate.Year % 400 == 0;
            var daysInMonth = DateTime.DaysInMonth(currentDate.Year, currentDate.Month);

            MessageBox.Show($"В месец {currentDate.ToString("MMMM")} има {daysInMonth} дни! Годината {(isLeapYear ? "е" : "не е")} високосна!");
        }
    }
}
