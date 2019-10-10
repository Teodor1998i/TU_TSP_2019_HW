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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void stepenuvaneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
            //Math.Pow(b, 2);
            //Math.Sqrt(d); 
        }

        private void formuliSakratenoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3();
            frm.Show();
        }
    }
}
