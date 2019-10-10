using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace upr4lab3matformuli
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double a;
            double n;
            double rez;
            a = double.Parse(textBox1.Text);
            n = double.Parse(textBox2.Text);

            rez = Math.Pow(a, n);
            textBox3.Text = rez.ToString();
                
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            //label2.ResetText();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
