using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Upr4_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
  

        private void button_pal_Click(object sender, EventArgs e)
        {
            String str = textBox1.Text;
            if (str != "")
            {
                
                str = str.ToUpper();
                char[] arr = str.ToCharArray();
                Array.Reverse(arr);
                string new_str = new string(arr);
                int i = str.CompareTo(new_str);
                if (i == 0)
                {
                    MessageBox.Show("Палиндром е");
                }
                else MessageBox.Show("Не е Палиндром!");
            }
            else {
                    MessageBox.Show("Моля въведете нещо в полето!");
                }
            
        }

        private void button_ascii_Click(object sender, EventArgs e)
        {
            String str = textBox1.Text;
            if (str != "")
            {

                String msg = "";
                foreach (char val in str)
                {
                    msg += val.ToString() + " = " + ((int)val).ToString() + " \n";

                }

                MessageBox.Show(msg);
            }
            else {
                MessageBox.Show("Моля въведете нещо в полето!");
            }

        }
    }
}
