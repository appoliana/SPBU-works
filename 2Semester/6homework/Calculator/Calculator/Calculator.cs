using System;
using System.Windows.Forms;

namespace Calculator
{
    public partial class CalculatorForm : Form
    {
        Double value = 0;
        String operation = "";
        bool operationPressed = false;
        bool error = false;

        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0") || (operationPressed) || (error))
            {
                textBox1.Clear();
            }

            error = false;
            operationPressed = false;
            Button b = (Button)sender;
            textBox1.Text = textBox1.Text + b.Text;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void operator_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            operation = b.Text;
            value = Double.Parse(textBox1.Text);
            operationPressed = true;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            switch(operation)
            {
                case "+":
                    {
                        textBox1.Text = (value + Double.Parse(textBox1.Text)).ToString();
                        break;
                    }
                case "-":
                    {
                        textBox1.Text = (value - Double.Parse(textBox1.Text)).ToString();
                        break;
                    }
                case "*":
                    {
                        textBox1.Text = (value * Double.Parse(textBox1.Text)).ToString();
                        break;
                    }
                case "/":
                    {
                        if (Double.Parse(textBox1.Text) == 0)
                        {
                            textBox1.Text = "error";
                            error = true;
                            return;
                        }
                        textBox1.Text = (value / Double.Parse(textBox1.Text)).ToString();
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
            operationPressed = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            value = 0;
        }
    }
}
