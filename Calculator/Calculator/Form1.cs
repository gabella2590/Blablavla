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
            Calculate(sender);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Calculate(sender);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Calculate(sender);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Calculate(sender);
        }
        void Calculate(object sender)
        {
            double firstvalue = double.Parse(textBox1.Text);
            double secondvalue = double.Parse(textBox2.Text);
            double result;
            switch (((Button)sender).Name)
            {
                case "button1":
                    result = firstvalue + secondvalue;
                    textBox3.Text = result.ToString();
                    break;
                case "button2":
                    result = firstvalue - secondvalue;
                    textBox3.Text = result.ToString();
                    break;
                case "button3":
                    result = firstvalue * secondvalue;
                    textBox3.Text = result.ToString();
                    break;
                case "button4":
                    result = firstvalue / secondvalue;
                    textBox3.Text = result.ToString();
                    break;
                default:
                    throw new Exception("Неизвестная операция");
            }
            textBox3.Text = result.ToString();
        }
    }
}
