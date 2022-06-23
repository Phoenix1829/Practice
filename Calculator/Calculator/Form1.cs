using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text != "") && (textBox2.Text != ""))
            {
                double a = Convert.ToDouble(textBox1.Text);
                double b = Convert.ToDouble(textBox2.Text);
                double result = a + b;
                textBox3.Text = result.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text != "") && (textBox2.Text != ""))
            {
                double a = Convert.ToDouble(textBox1.Text);
                double b = Convert.ToDouble(textBox2.Text);
                double result = a - b;
                textBox3.Text = result.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text != "") && (textBox2.Text != ""))
            {
                double a = Convert.ToDouble(textBox1.Text);
                double b = Convert.ToDouble(textBox2.Text);
                double result = a * b;
                textBox3.Text = result.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text != "") && (textBox2.Text != ""))
            {
                double a = Convert.ToDouble(textBox1.Text);
                double b = Convert.ToDouble(textBox2.Text);
                if (b != 0)
                {
                    double result = a / b;
                    textBox3.Text = result.ToString();
                }
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (e.KeyChar.ToString().Equals("-"))
            {
                e.Handled = textBox1.SelectionStart != 0 || textBox1.Text.IndexOf("-") != -1;
                if (!e.Handled)
                {
                    return;
                }
            }
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && e.KeyChar != 44 && e.KeyChar != 45) // цифры, BackSpace, минус и запятая
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (e.KeyChar.ToString().Equals("-"))
            {
                e.Handled = textBox2.SelectionStart != 0 || textBox2.Text.IndexOf("-") != -1;
                if (!e.Handled)
                {
                    return;
                }
            }
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && e.KeyChar != 44 && e.KeyChar != 45) // цифры, BackSpace, минус и запятая
            {
                e.Handled = true;
            }
        }
    }
}
