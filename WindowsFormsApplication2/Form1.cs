using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        string userInput = string.Empty;
        string operand1 = string.Empty;
        string operand2 = string.Empty;
        char operation;
        double numberResult = 0.00;



        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            userInput +="1";
            this.textBox1.Text += userInput;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            userInput += "2";
            this.textBox1.Text += userInput;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            userInput += "3";
            this.textBox1.Text += userInput;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            userInput += "4";
            this.textBox1.Text += userInput;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            userInput += "5";
            this.textBox1.Text += userInput;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            userInput += "6";
            this.textBox1.Text += userInput;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            userInput += "7";
            this.textBox1.Text += userInput;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            userInput += "8";
            this.textBox1.Text += userInput;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            userInput += "9";
            this.textBox1.Text += userInput;
        }

        private void button0_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            userInput += "0";
            this.textBox1.Text += userInput;
        }

        private void plusButton_Click(object sender, EventArgs e)
        {
            operand1 = userInput;
            operation = '+';
            userInput = string.Empty;

        }

        private void minusButton_Click(object sender, EventArgs e)
        {
            operand1 = userInput;
            operation = '-';
            userInput = string.Empty;

        }

        private void multiplicationButton_Click(object sender, EventArgs e)
        {
            operand1 = userInput;
            operation = '*';
            userInput = string.Empty;

        }

        private void divisionButton_Click(object sender, EventArgs e)
        {
            operand1 = userInput;
            operation = '/';
            userInput = string.Empty;

        }

        private void button10_Click(object sender, EventArgs e)
        {
            operand1 = userInput;
            operation = '=';
            userInput = string.Empty;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            this.operand1 = string.Empty;
            this.operand2 = string.Empty;
            this.userInput = string.Empty;
            
        }
    }
}
