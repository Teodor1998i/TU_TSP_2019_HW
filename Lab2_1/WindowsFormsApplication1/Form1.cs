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


		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			double val1 = 0.0;
			double val2 = 0.0;
			double val3 = 0.0;
			double d = 0.0;
			double val4=0.0;
			double val5=0.0;

			val1 = Double.Parse(a.Text);
			val2 = Double.Parse(b.Text);
			val3 = Double.Parse(c.Text);

			d = val2 * val2 - (4 * val1 * val3);
			
			if (d < 0)
				MessageBox.Show("Diskriminantata e otricatelna", "Problem");
			else
			{
				if (val1 != 0)
				{
					val4 = (-val2 + Math.Sqrt(d)) / (2 * val1);
					val5 = (-val2 - Math.Sqrt(d)) / (2 * val1);
				}
				else
					MessageBox.Show(" 'a' e sys stoinost nula, ne se deli na nula", "Problem");
			}

			if (val1 != 0)
			{
				x1.Text = val4.ToString();
				x2.Text = val5.ToString();
			}
			else
			{
				x1.Text = "";
				x2.Text = "";
			}
	

		}

		void calc()
		{
			double val1 = 0;
			double val2 = 0;
			double val3 = 0;
			double d = 0;
			double val4 = 0.0;
			double val5 = 0.0;


			if (a.Text != "" && b.Text != "" && c.Text != "")
			{
				val1 = double.Parse(a.Text);
				val2 = double.Parse(b.Text);
				val3 = double.Parse(c.Text);
				d = val1 + val2 + val3;
				x1.Text = d.ToString();
				//	d = val2 * val2 - (4 * val1 * val3);

				//	if (d < 0)
				//		MessageBox.Show("Diskriminantata e otricatelna", "Problem");
				//	else
				//	{
				//		if (val1 != 0)
				//		{
				//			val4 = (-val2 + Math.Sqrt(d)) / (2 * val1);
				//			val5 = (-val2 - Math.Sqrt(d)) / (2 * val1);
				//		}
				//		else
				//			MessageBox.Show(" 'a' e sys stoinost nula, ne se deli na nula", "Problem");
				//	}
				//	if (val1 != 0)
				//	{
				//		x1.Text = val4.ToString();
				//		x2.Text = val5.ToString();
				//	}
				//	else
				//	{
				//		x1.Text = "";
				//		x2.Text = "";
				//	}
				//}
				//else
				//	MessageBox.Show(" .....");

			}
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void a_TextChanged(object sender, EventArgs e)
		{
			calc();
		

		}

		private void b_TextChanged(object sender, EventArgs e)
		{
			calc();
		}

		private void c_TextChanged(object sender, EventArgs e)
		{
			calc();
		}
		 
	}
}
