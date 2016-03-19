using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task1_Asg1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int accNumber;
        int startBal;
        int charges;
        int creditLimit;
        int credit;
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            accNumber = Convert.ToInt32(textBox1.Text);
            startBal = Convert.ToInt32(textBox2.Text);
            charges = Convert.ToInt32(textBox3.Text);
            credit = Convert.ToInt32(textBox4.Text);
            creditLimit = Convert.ToInt32(textBox5.Text);
            //startingbal+charges-credits
            int remaining;
            remaining = startBal + charges - credit;
            textBox6.Text = "" + remaining;
            int a;
            a = creditLimit - remaining;
            textBox7.Text = "" + a;
            if (a > remaining)
            {
                MessageBox.Show("Your Limit is excced.");
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
           
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //TextBox only accept numbers.
            char a = e.KeyChar;
            if (!char.IsDigit(a) && a != 8)
            {
                e.Handled = true;
                MessageBox.Show("Please enter only digits.");
            }

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char a = e.KeyChar;
            if (!char.IsDigit(a) && a != 8)
            {
                e.Handled = true;
                MessageBox.Show("Please enter only digits.");
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char a = e.KeyChar;
            if (!char.IsDigit(a) && a != 8)
            {
                e.Handled = true;
                MessageBox.Show("Please enter only digits.");
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            char a = e.KeyChar;
            if (!char.IsDigit(a) && a != 8)
            {
                e.Handled = true;
                MessageBox.Show("Please enter only digits.");
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            char a = e.KeyChar;
            if (!char.IsDigit(a) && a != 8)
            {
                e.Handled = true;
                MessageBox.Show("Please enter only digits.");
            }
        }
    }
}
