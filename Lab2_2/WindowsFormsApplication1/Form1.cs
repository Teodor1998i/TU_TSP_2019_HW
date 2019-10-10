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
    public partial class Form1 : Form
    {
        double[,] k = new double[4, 4];

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("feet");
            comboBox1.Items.Add("yards");
            comboBox1.Items.Add("inches");
            comboBox1.Items.Add("miles");
            comboBox2.Items.Add("feet");
            comboBox2.Items.Add("yards");
            comboBox2.Items.Add("inches");
            comboBox2.Items.Add("miles");
            comboBox1.SelectedIndex = 0;
            comboBox1.SelectedIndex = 0;
            textBox2.Text = "";
            textBox1.Text = 0.ToString();


            k[0, 0] = 1;
            k[0, 1] = 0.3333;
            k[0, 2] = 1.1989;
            k[0, 3] = 0.0001893;
            k[1, 0] = 3;
            k[1, 1] = 1;
            k[1, 2] = 3.5966;
            k[1, 3] = 0.0005682;
            k[2, 0] = 0.8341;
            k[2, 1] = 0.278;
            k[2, 2] = 1;
            k[2, 3] = 0.0001579;
            k[3, 0] = 5280;
            k[3, 1] = 1760;
            k[3, 2] = 6330;
            k[3, 3] = 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = ((double.Parse(textBox1.Text) * k[comboBox1.SelectedIndex, comboBox2.SelectedIndex])).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            textBox2.Text = "";
            textBox1.Text = 0.ToString();
        }
    }
}
