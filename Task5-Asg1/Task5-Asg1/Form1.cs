using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task5_Asg1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double x1,x2;
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b, c,result,result1;
            a = Convert.ToDouble(textBox1.Text);
            b = Convert.ToDouble(textBox2.Text);
            c = Convert.ToDouble(textBox3.Text);
            result = solve(a,b,c);
            textBox4.Text += result;
            result1 = solve2(a, b, c);
            textBox5.Text += result1;
        }

       
        public double solve(double a, double b, double c)
        {
            //The Formula Of Quadratic Formula: x = (-b +- sqrt(b^2 - 4ac)) / 2a

            //For inside the root we use:
      
            double ir = (b * b - 4 * a * c);
            if (ir < 0)
            {
                x1 = double.NaN;
            }
            else
            {
                //compute the value of x
                double sqt = Math.Sqrt(ir);
                x1 = Math.Round((-b + sqt) / (2 * a));
            }
            return x1;
        }//function end

        public double solve2(double a, double b, double c)
        {
            //The Formula Of Quadratic Formula: x = (-b +- sqrt(b^2 - 4ac)) / 2a

            //For inside the root we use:
            double ir = (b * b - 4 * a * c);
       
            if (ir < 0)
            {
                x2 = double.NaN;
            }
            else
            {
                //compute the value of x
                double sqt = Math.Sqrt(ir);
                x2 = Math.Round((-b - sqt) / (2 * a));
            }

            return x2;
        }//function end
        

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            this.Series1.Series["xy"].Points.AddXY(2, 8);
            this.Series1.Series["xy"].Points.AddXY(x1, x2);
        }
    }
}
