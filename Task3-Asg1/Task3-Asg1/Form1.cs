using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task3_Asg1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        int [,] temp = new int [4, 7];


        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label3.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int a;
            for (int i = 0; i < temp.GetLength(0); i++)
            {
                MessageBox.Show("Enter The Tempture " + i + " Province.");
                for (int j = 0; j < temp.GetLength(1); j++)
                {
                     a = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Enter The Tempture of  " + i + " Week."));
                    temp[i, j] += a;
                }

                string h;
               
            }
            textBox1.Text = "";
            for (int i = 0; i < temp.GetLength(0); i++)
            {

                for (int j = 0; j < temp.GetLength(1); j++)
                {
                    textBox1.Text += temp[i, j] + "\t";
                }
                textBox1.Text += Environment.NewLine;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double d = 0;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 1; j < 7; j++)
                {
                    d += temp[i, j];
                }
                d /= 28;
                Math.Round(d);
                label3.Text = "-The Average Tempture is " + d;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
