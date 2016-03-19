using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task6_Asg1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //TextBox only accept numbers.
            char a = e.KeyChar;
            if(!char.IsDigit(a) && a!=8){
                e.Handled = true;
                MessageBox.Show("Please enter only digits."); 
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            //TextBox only accept numbers.
            char a = e.KeyChar;
            if (!char.IsDigit(a) && a != 8)
            {
                e.Handled = true;
                MessageBox.Show("Please enter only digits.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a;
            int b;
            int res;
           a = Convert.ToInt32(textBox1.Text);
           b = Convert.ToInt32(textBox2.Text);
           res = product(a,b);
           textBox3.Text += res;

        }
        public int product(int a, int b)
        {
            if (a < b)
            {
                return product(b, a);
            }
            else if (b != 0)
            {
                return (a + product(a, b - 1));
            }
            else
            {
                return 0;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }
    }
}
