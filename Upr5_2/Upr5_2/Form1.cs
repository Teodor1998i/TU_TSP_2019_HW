using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Upr5_2

{
    

    public partial class Form1 : Form
    {
        public static bool add = false;
        public static bool subtract = false;
        public static bool multiply = false;
        public static bool divide = true;
        public static int counter = 60;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {    

            try
            {
                Timer timer1 = new Timer
                {
                    Interval = 1000
                };

                timer1.Enabled = true;
                timer1.Tick += new EventHandler(timer1_Tick);
               
                Random rand = new Random();
                int p;
                var labels = new List<Label> { num1, num2, num3, num4, num5, num6, num7, num8 };

                foreach (var label in labels)
                {
                    p = rand.Next(50) + 1;
                    label.Text = p.ToString();
                }

            }
            catch {
                MessageBox.Show("Nope!");
            }

        }

        public static void OnTimerEvent()
        {
            if (add && subtract && multiply && divide )
            {
                MessageBox.Show("Success!");
            }

            else {

                MessageBox.Show("Wrong!");
                
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            counter--;
            if (counter == 0)
            {
                int x1 = int.Parse(num1.Text);
                int x2 = int.Parse(num2.Text);

                int y1 = int.Parse(num3.Text);
                int y2 = int.Parse(num4.Text);

                int z1 = int.Parse(num5.Text);
                int z2 = int.Parse(num6.Text);

                double t1 = int.Parse(num7.Text);
                double t2 = int.Parse(num8.Text);

                int ans1 = int.Parse(a1.Text);
                int ans2 = int.Parse(a2.Text);
                int ans3 = int.Parse(a3.Text);
                double ans4 = int.Parse(a4.Text); 

                if (x1 + x2 == ans1)
                {
                    add = true;
                }

                if (y1 - y2 == ans2)
                {
                    subtract = true;
                }

                if (z1 * z2 == ans3)
                {
                    multiply = true;
                }

                double ans4_div = t1 / t2;
                if (Math.Round(ans4_div, 2) == Math.Round(ans4, 2))
                {
                    divide = true;
                }
              
                timer1.Enabled = false;
                OnTimerEvent();
            }

            if (counter>=0) {
                label_timer.Text = counter.ToString();
            }
            

        }


    }
}
