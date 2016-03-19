using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Assignment_1___Task_2
{
    public partial class Form1 : Form
    {
        int[] l = new int[6];
        int[] m = new int[6];
        string[] k = new string[6];
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            k = Regex.Split(textBox1.Text, "");
            if (k.Length == 6)
            {
                textBox2.Text = "";
                for (int i = 1; i < 5; i++)
                {
                    l[i] = Convert.ToInt32(k[i]);
                    l[i] = (l[i] + l[i] + 7);
                    textBox2.Text += l[i];
                }
                swaping(l, 1, 3);
                swaping(l, 2, 4);
            }
            else
            {
                MessageBox.Show("Data has to be 4 digits");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            swaping(l, 3, 1);
            swaping(l, 4, 2);
            for (int i = 1; i < 5; i++)
            {
                m[i] = Convert.ToInt32(k[i]);
                l[i] = (l[i] - m[i] - 7);
                textBox2.Text += l[i];
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        static void swaping(int[] array, int p1, int p2)
        {
            int temp = array[p1];
            array[p1] = array[p2];
            array[p2] = temp;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
