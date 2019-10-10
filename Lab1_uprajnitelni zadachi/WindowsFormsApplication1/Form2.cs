using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }

        

        Calculator calc = new Calculator();

        private void Operation(object sender, EventArgs e)
        {
            string p = "";
            if (sender is Button)
            {
                p = (sender as Button).Text;
            }
            double val1;
            double val2;

            val1 = Double.Parse(textBox1.Text);
            val2 = Double.Parse(textBox2.Text);

            if (p == "+"){
                textBox3.Text = calc.AddNumbers(val1, val2).ToString();
            }
            else
            {
                textBox3.Text = calc.MulNumbers(val1, val2).ToString();
            }

            MessageBox.Show(p);
            MessageBox.Show(textBox3.Text);

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            Operation(sender,e);
        }



        /*

      
        private void button1_Click(object sender, EventArgs e)
        {
              double val1, val2;
              try
              {
                  val1 = Double.Parse(textBox1.Text);
                  val2 = Double.Parse(textBox2.Text);
                  textBox3.Text = calc.AddNumbers(val1, val2).ToString();
              }
              catch
              {
                  MessageBox.Show("Въведете коректни данни, преди да натиснете бутона!");
                  textBox1.Clear(); textBox2.Clear(); textBox3.Clear();
              }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            double val1, val2;
            try
            {
                val1 = Double.Parse(textBox1.Text);
                val2 = Double.Parse(textBox2.Text);
                textBox3.Text = (val1 - val2).ToString();
            }
            catch
            {
                MessageBox.Show("Въведете коректни данни, преди да натиснете бутона!");
                textBox1.Clear(); textBox2.Clear(); textBox3.Clear();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double val1, val2;
            try
            {
                val1 = Double.Parse(textBox1.Text);
                val2 = Double.Parse(textBox2.Text);
                textBox3.Text = (val1 / val2).ToString();
            }
            catch
            {
                MessageBox.Show("Въведете коректни данни, преди да натиснете бутона!");
                textBox1.Clear(); textBox2.Clear(); textBox3.Clear();
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            double val1, val2;
            try
            {
                val1 = Double.Parse(textBox1.Text);
                val2 = Double.Parse(textBox2.Text);
                textBox3.Text = (val1 * val2).ToString();
            }
            catch
            {
                MessageBox.Show("Въведете коректни данни, преди да натиснете бутона!");
                textBox1.Clear(); textBox2.Clear(); textBox3.Clear();
            }


        }

        private void button5_Click(object sender, EventArgs e)
        {
            double val1 = double.Parse(textBox1.Text);
            double val2 = double.Parse(textBox2.Text);
            if (comboBox1.Text == "ADD")
            {
                textBox3.Text = (val1 + val2).ToString();
            }
            else
            {
                textBox3.Text = (val1 * val2).ToString();
            }

        }
    }*/
    }
}

