using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laborator2
{
    public partial class Form1 : Form
    {
        double a;
        double b;
        String op;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }


        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text += ".";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            a = 0;
            b = 0;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            b = Convert.ToDouble(textBox1.Text);
            if (op == "+")
            {
                a += b;
                textBox1.Text = "";
                textBox1.Text += Convert.ToString(a);
                b *= 0;
            }
            else if (op == "-")
            {
                a -= b;
                textBox1.Text = "";
                textBox1.Text += Convert.ToString(a);
                b *= 0;
            }
            else if (op == "*")
            {
                a *= b;
                textBox1.Text = "";
                textBox1.Text += Convert.ToString(a);
                b *= 0;
            }
            else if (op == "*")
            {
                if (b != 0)
                {
                    a /= b;
                    textBox1.Text = "";
                    textBox1.Text += Convert.ToString(a);
                    b *= 0;
                }
                else
                {
                    textBox1.Text = "ERROR";
                }
            }
            Console.WriteLine(a);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (a != 0)
            {
                b = Convert.ToDouble(textBox1.Text);
                a += b;
                b *= 0;
                textBox1.Text = "";
            }
            if(a == 0d)
            {
                a = Convert.ToDouble(textBox1.Text);
                textBox1.Text = "";
            }
            op = "+";

        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (a != 0)
            {
                b = Convert.ToDouble(textBox1.Text);
                a -= b;
                b *= 0;
                textBox1.Text = "";
            }
            if (a == 0d)
            {
                a = Convert.ToDouble(textBox1.Text);
                textBox1.Text = "";
            }
            op = "-";

        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (a != 0)
            {
                b = Convert.ToDouble(textBox1.Text);
                a *= b;
                b *= 0;
                textBox1.Text = "";
            }
            if (a == 0d)
            {
                a = Convert.ToDouble(textBox1.Text);
                textBox1.Text = "";
            }
            op = "*";

        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (a != 0)
            {
                b = Convert.ToDouble(textBox1.Text);
                if (b != 0)
                {
                    a /= b;
                    b *= 0;
                    textBox1.Text = "";
                }
                else
                {
                    textBox1.Text = "ERROR";
                    a = 0;
                    b = 0;
                }
            }
            if (a == 0d)
            {
                a = Convert.ToDouble(textBox1.Text);
                textBox1.Text = "";
            }
            op = "/";
        }

    }
}
