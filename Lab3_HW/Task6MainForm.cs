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
    public partial class Task6MainForm : Form
    {
        private const int TIME_LEFT = 1000;
        private int timeLeft;
        private int randomNumber;
        private bool isTimerStarted;
        public Task6MainForm()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.timeLeft != this.timer1.Interval)
            {
                this.timeLeft++;
                this.timerLabel.Text = $"{this.timeLeft}/{TIME_LEFT}";
            }
            else
            {
                this.timer1.Stop();
                MessageBox.Show($"Time expired my number was {this.randomNumber}");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var number = int.Parse(this.numberTextBox.Text);

                if (!this.isTimerStarted)
                {
                    this.timeLeft = 0;
                    this.timer1.Interval = TIME_LEFT;
                    this.timer1.Start();
                    this.randomNumber = new Random().Next(100) + 1;
                    this.isTimerStarted = true;
                    this.button1_Click(sender, e);
                }
                else
                {
                    if (number > this.randomNumber)
                    {
                        MessageBox.Show($"Your number {number} is bigger than my number!");
                    }
                    else if (number < this.randomNumber)
                    {
                        MessageBox.Show($"Your number {number} is less than my number!");
                    }
                    else
                    {
                        MessageBox.Show($"Your number {number} correct with my number!");
                        this.timeLeft = 0;
                    }
                }
            }
            catch
            {
            }
        }
    }
}
