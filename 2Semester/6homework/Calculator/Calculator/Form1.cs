using System;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        private string oldException = "";
        int operation = 0;

        public string OldException { get => oldException; set => oldException = value; }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.button1.Click += new System.EventHandler(this.button1_Click);
            textBox1.Text += "7";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.button11.Click += new System.EventHandler(this.button11_Click);
            textBox1.Text += "2";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.button8.Click += new System.EventHandler(this.button8_Click);
            textBox1.Text += "3";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.button7.Click += new System.EventHandler(this.button7_Click);
            textBox1.Text += "6";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.button4.Click += new System.EventHandler(this.button4_Click);
            textBox1.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.button6.Click += new System.EventHandler(this.button6_Click);
            textBox1.Text += "4";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.button3.Click += new System.EventHandler(this.button3_Click);
            textBox1.Text += "9";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.button5.Click += new System.EventHandler(this.button5_Click);
            textBox1.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.button9.Click += new System.EventHandler(this.button9_Click);
            textBox1.Text += "0";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            this.button16.Click += new System.EventHandler(this.button16_Click);
            string currentException = "";
            currentException = textBox1.Text;
            textBox1.Text = "";
            if (operation == 1)
            {
                textBox1.Text += Convert.ToInt32(OldException) + Convert.ToInt32(currentException);
            }
            if (operation == 2)
            {
                textBox1.Text += Convert.ToInt32(OldException) - Convert.ToInt32(currentException);
            }
            if (operation == 3)
            {
                textBox1.Text += Convert.ToInt32(OldException) * Convert.ToInt32(currentException);
            }
            if (operation == 4)
            {
                if (Convert.ToInt32(OldException) == 0)
                {
                    textBox1.Text = "";
                    return;
                }
                textBox1.Text += Convert.ToInt32(OldException) / Convert.ToInt32(currentException);
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.button13.Click += new System.EventHandler(this.button13_Click);
            OldException += textBox1.Text;
            textBox1.Text = "";
            operation = 1;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.button12.Click += new System.EventHandler(this.button12_Click);
            textBox1.Text += "1";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.button14.Click += new System.EventHandler(this.button14_Click);
            OldException += textBox1.Text;
            textBox1.Text = "";
            operation = 2;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            this.button15.Click += new System.EventHandler(this.button15_Click);
            OldException += textBox1.Text;
            textBox1.Text = "";
            operation = 3;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.button10.Click += new System.EventHandler(this.button10_Click);
            OldException += textBox1.Text;
            textBox1.Text = "";
            operation = 4;
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            this.button11.Click += new System.EventHandler(this.button11_Click);
            textBox1.Text += "2";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            this.button17.Click += new System.EventHandler(this.button17_Click);
            if (textBox1.Text.Length > 0)
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            }
        }
    }
}
