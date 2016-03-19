using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task4_Asg1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation=@"C:\Users\Hussain Ali Arif\Documents\Visual Studio 2013\Projects\Task4-Asg1\s.jpg";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Sindh")
            {
                comboBox1.Items.Remove("Sindh");
                listBox1.Items.Add("Sindh");
                textBox1.Text = "Sindh";
                pictureBox1.ImageLocation = @"C:\Users\Hussain Ali Arif\Documents\Visual Studio 2013\Projects\Task4-Asg1\s.jpg";
                
            }
             if (comboBox1.Text == "Punjab")
            {
                comboBox1.Items.Remove("Punjab");
                listBox1.Items.Add("Punjab");
                textBox1.Text = "Punjab";
                pictureBox1.ImageLocation = @"C:\Users\Hussain Ali Arif\Documents\Visual Studio 2013\Projects\Task4-Asg1\1.jpg";
            }
             if (comboBox1.Text == "Balochistan")
            {
                comboBox1.Items.Remove("Balochistan");
                listBox1.Items.Add("Balochistan");
                textBox1.Text = "Balochistan";
                pictureBox1.ImageLocation = @"C:\Users\Hussain Ali Arif\Documents\Visual Studio 2013\Projects\Task4-Asg1\bol.jpg";
            }
             if (comboBox1.Text == "Azad Kashmir")
            {
                comboBox1.Items.Remove("Azad Kashmir");
                listBox1.Items.Add("Azad Kashmir");
                textBox1.Text = "Azad Kashmir";
                pictureBox1.ImageLocation = @"C:\Users\Hussain Ali Arif\Documents\Visual Studio 2013\Projects\Task4-Asg1\az.jpg";
            }
            if (comboBox1.Text == "Islamabad")
            {
                comboBox1.Items.Remove("Islamabad");
                listBox1.Items.Add("Islamabad");
                textBox1.Text = "Islamabad";
                pictureBox1.ImageLocation = @"C:\Users\Hussain Ali Arif\Documents\Visual Studio 2013\Projects\Task4-Asg1\i.jpg";
            }
            if (comboBox1.Items.Count == 0)
            {
                MessageBox.Show("The List Is Empty");
                Application.Exit();
            }        
        }
    }
}
