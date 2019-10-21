using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Upr4_2
{
    public partial class Form1 : Form
    {
        ListBox listBox1 = new ListBox();
        ListBox listBox2 = new ListBox();
        Button button1 = new Button();
        Button button2 = new Button();
        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CreateButton();
        }

        private void CreateButton()
        {

             
            button1.Size = new System.Drawing.Size(120, 30);
            button1.Location = new System.Drawing.Point(350, 10);

            
            button1.Text = "Create ListBox1";
            
            this.Controls.Add(button1);
            
            button1.Click += new EventHandler(this.button1_Click);
           
            button2.Size = new System.Drawing.Size(120, 30);
            button2.Location = new System.Drawing.Point(350, 110);


            button2.Text = "Create ListBox2";
            
            this.Controls.Add(button2);
           
            button2.Click += new EventHandler(this.button2_Click);
        }


       
        protected void button1_Click(object sender, EventArgs e)
        {
            CreateListBox(); 
            string[] lines = System.IO.File.ReadAllLines("..\\..\\zaplata.txt");
            foreach (string str in lines)
            {
                listBox1.Items.Add(str);
            }
        }


       
        protected void button2_Click(object sender, EventArgs e)
        {
            try
            {
                double salary = Double.Parse(Interaction.InputBox("Въведете заплата: "));
                listBox2.Items.Add(salary);
            }
            catch {
                MessageBox.Show("Въведете коректни данни!");
            }
   
        }

        private void CreateListBox()
        {  
            
            listBox1.Size = new System.Drawing.Size(100, 100);
            listBox1.Location = new System.Drawing.Point(110, 10);
            this.Controls.Add(listBox1);
            listBox1.MultiColumn = true;
            listBox1.SelectionMode = SelectionMode.MultiExtended;

            listBox2.Size = new System.Drawing.Size(100, 100);
            listBox2.Location = new System.Drawing.Point(110, 110);
            this.Controls.Add(listBox2);
            listBox2.MultiColumn = true;
            listBox2.SelectionMode = SelectionMode.MultiExtended;

        }

    }
}
