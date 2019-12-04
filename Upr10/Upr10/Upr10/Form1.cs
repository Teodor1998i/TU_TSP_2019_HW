using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace Upr10
{
    public partial class Form1 : Form
    {
        int flag1 = 0;
        int MarioX;
        int LuigiX;
        int marioWins = 0;
        int luigiWins = 0;
        public Form1()
        {
            InitializeComponent();
            Image img = Image.FromFile("Mario.png");
            pictureBox1.Image = img;
            Image img2 = Image.FromFile("Luigi.png");
            pictureBox2.Image = img2;

            MarioX = 1; LuigiX = 1;
            pictureBox1.Left = MarioX;
            pictureBox2.Left = LuigiX;

            label1.Text = marioWins.ToString();
            label2.Text = luigiWins.ToString();


        }

        private void button1_Click(object sender, EventArgs e)
        {

            MarioX = 1; LuigiX = 1;
            pictureBox1.Left = MarioX;
            pictureBox2.Left = LuigiX;
            flag1 = 0;

        }

        private void button2_Click(object sender, EventArgs e)
        {           
            flag1 = 1; 
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random r = new Random();
    
            int rand1 = r.Next(0, 8);
            int rand2 = r.Next(0, 8); 

 
      

                if (flag1 == 1)
            {
                if (pictureBox1.Location.X >= 763) {
                    flag1 = 0;
                    MessageBox.Show("Mario wins!");
                    marioWins++;
                    label1.Text = marioWins.ToString();
                    MarioX = 1; LuigiX = 1;
                    pictureBox1.Left = MarioX;
                    pictureBox2.Left = LuigiX;
                }

                else if (pictureBox2.Location.X >= 763)
                {
                    flag1 = 0;
                    MessageBox.Show("Luigi wins!");
                    luigiWins++;
                    label2.Text = luigiWins.ToString();
                    MarioX = 1; LuigiX = 1;
                    pictureBox1.Left = MarioX;
                    pictureBox2.Left = LuigiX;

                }
                else
                {

                    MarioX = MarioX + rand1;
                    pictureBox1.Left = MarioX;
                    LuigiX = LuigiX + rand2;
                    pictureBox2.Left = LuigiX;
                }


           
            }

        }



   

        
    }
}
