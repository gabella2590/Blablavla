using Calculator.OneArgumentCalc;
using System;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        void OneArgCalc(object sender, EventArgs e)
        {
            double Value = double.Parse(textBox1.Text);
            double result;
            IOneArgumentCalculator calculator = OneArgumentFactory.CreateCalculator(((Button)sender).Name);
            result = calculator.Calculate(Value);
            textBox3.Text = result.ToString();
        }

        private void Calculate(object sender, EventArgs e)
        {
            double firstValue = double.Parse(textBox1.Text);
            double secondValue = double.Parse(textBox2.Text);
            double result;
            ITwoArgumentsCalculator calculator = TwoArgumentsFactory.CreateCalculator(((Button)sender).Name);
            result = calculator.Calculate(firstValue, secondValue);

            textBox3.Text = result.ToString();
        }
    }
}
