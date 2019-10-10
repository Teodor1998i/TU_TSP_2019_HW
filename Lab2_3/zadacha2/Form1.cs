using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zadacha2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
        void Calc()
        {


            double F, C, R;
            if (comboBox1.Text == "F")
            {

                try
                {
                    F = double.Parse(Convert.Text);
                    R = (F - 32) * 5 / 9;
                    Result.Text = R.ToString();
                }
                catch { }

            }
            else if (comboBox1.Text == "C")
            {
                try
                {

                    C = double.Parse(Convert.Text);
                    R = (C * 9 / 5) + 32;
                    Result.Text = R.ToString();
                }
                catch { }
            }
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("F");
            comboBox1.Items.Add("C");
            comboBox1.SelectedIndex = 0;
        }

        private void Convert_TextChanged(object sender, EventArgs e)
        { 
            
           if (Convert.Text != "")
                Calc();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           if (Convert.Text != "")
                Calc();
        }

        
        
    }
}
