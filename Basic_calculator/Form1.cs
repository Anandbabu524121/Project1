using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Basic_calculator
{
    public partial class Form1 : Form
    {
        double value = 0;
        string operation="";
        bool operation_pressed = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            equation.Text = "";
            switch(operation)
            {
                case "+":
                    result.Text = (value + double.Parse(result.Text)).ToString();
                    break;
                case "-":
                    result.Text = (value - double.Parse(result.Text)).ToString();
                    break;
                case "*":
                    result.Text = (value * double.Parse(result.Text)).ToString();
                    break;
                case "/":
                    result.Text = (value / double.Parse(result.Text)).ToString();
                    break;
                default:
                    break;

            }//switch
            operation_pressed = false;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            result.Clear();
            value = 0;
        }

        private void button_Click(object sender, EventArgs e)
        {
            if (result.Text == "0" || (operation_pressed))
                result.Clear();
            operation_pressed = false;
            Button b = (Button)sender;
            result.Text = result.Text + b.Text;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            result.Text = "0";
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            operation = b.Text;
            value = double.Parse(result.Text);
            operation_pressed = true;
            equation.Text = value + "" + operation;
        }
    }
}
