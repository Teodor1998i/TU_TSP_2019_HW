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
    public partial class Task5MainForm : Form
    {
        public Task5MainForm()
        {
            InitializeComponent();
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            luckyNumber1Label.Text = (rand.Next(49) + 1).ToString();
            luckyNumber2Label.Text = (rand.Next(49) + 1).ToString();
            luckyNumber3Label.Text = (rand.Next(49) + 1).ToString();
            luckyNumber4Label.Text = (rand.Next(49) + 1).ToString();
        }
    }
}
