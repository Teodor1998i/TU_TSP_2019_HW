﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace upr4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "Width = " + vScrollBar1.Value + "\n Height = " + hScrollBar1.Value + "\n AREA = " + hScrollBar1.Value * vScrollBar1.Value;
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            label1.Text = "Width = " + vScrollBar1.Value + "\n Height = " + hScrollBar1.Value + "\n AREA = " + hScrollBar1.Value * vScrollBar1.Value;
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            label1.Text = "Width = " + vScrollBar1.Value + "\n Height = " + hScrollBar1.Value + "\n AREA = " + hScrollBar1.Value * vScrollBar1.Value;
        }
    }
}
