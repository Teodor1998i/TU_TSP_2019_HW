using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Upr5_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int month = int.Parse(dateTimePicker1.Value.ToString("MM"));
            int day = int.Parse(dateTimePicker1.Value.ToString("dd"));
            string astro_sign=""; 
          

            if (month == 12)
            {                   
                if (day < 22) 
                astro_sign = "Strelec"; 
                else
                astro_sign ="Kozirog"; 
            }  
        
            else if (month == 1)
            { 
                if (day < 20) 
                astro_sign = "Kozirog"; 
                else
                astro_sign = "Vodolei"; 
            }  
        
            else if (month == 2)
            { 
                if (day < 19) 
                astro_sign = "Vodolei"; 
                else
                astro_sign = "Ribi"; 
            } 
              
            else if(month == 3)
            { 
                if (day < 21)  
                astro_sign = "Ribi"; 
                else
                astro_sign = "Oven"; 
            } 

            else if (month == 4)
            { 
                if (day < 20) 
                astro_sign = "Oven"; 
                else
                astro_sign = "Telec"; 
            } 
              
            else if (month == 5)
            { 
                if (day < 21) 
                astro_sign = "Telec"; 
                else
                astro_sign = "Bliznaci"; 
            } 
              
            else if( month == 6)
            { 
                if (day < 21) 
                astro_sign = "Bliznaci"; 
                else
                astro_sign = "Rak"; 
            } 
              
            else if (month == 7)
            { 
                if (day < 23) 
                astro_sign = "Rak"; 
                else
                astro_sign = "luv"; 
            } 
              
            else if( month == 8)
            { 
                if (day < 23)  
                astro_sign = "Luv"; 
                else
                astro_sign = "Deva"; 
            } 
              
            else if (month == 9)
            { 
                if (day < 23) 
                astro_sign = "Deva"; 
                else
                astro_sign = "Vezni"; 
            } 
              
            else if (month == 10)
            { 
                if (day < 23) 
                astro_sign = "Vezni"; 
                else
                astro_sign = "Scorpion"; 
            } 
              
            else if (month == 11)
            { 
                if (day < 22) 
                astro_sign = "Scorpion"; 
                else
                astro_sign = "Strelec"; 
            }

            listBox1.Items.Add(astro_sign);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
