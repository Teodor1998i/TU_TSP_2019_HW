using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int br = 0;

        private void form2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            br++;
            label2.Text = br.ToString();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n, s, r1;
            double r2;
            s = int.Parse(textBox1.Text);
            n = int.Parse(textBox2.Text);
            r1 = n - s;
            label6.Text = r1.ToString();
            if (radioButton1.Checked == true)
             label8.Text =( r1 * double.Parse(radioButton1.Text)).ToString();
            if (radioButton2.Checked == true)
                label8.Text = (r1 * double.Parse(radioButton2.Text)).ToString();
            if (radioButton3.Checked == true)
                label8.Text = (r1 * double.Parse(radioButton3.Text)).ToString();
            
        }
        
    }
}
