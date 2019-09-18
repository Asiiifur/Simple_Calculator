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
    public partial class Calculator : Form
    {

        Double value = 0;
        String operation = "";
        bool operation_pressed = false;

        public Calculator()
        {
            InitializeComponent();
        }



        private void Button_Click(object sender, EventArgs e)
        {
            if ((textBoxResult.Text == "0") || (operation_pressed))
                textBoxResult.Clear();
            operation_pressed = false;

            Button button = (Button)sender;
            textBoxResult.Text = textBoxResult.Text + button.Text;
        }


        private void Operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operation = button.Text;
            value = Double.Parse(textBoxResult.Text);
            operation_pressed = true;
            Equation.Text = value + " " + operation;


        }

  
 
     

        private void button16_Click(object sender, EventArgs e)
        {

            Equation.Text = "";
            switch (operation)
            {

                case "+":
                    textBoxResult.Text = (value + Double.Parse(textBoxResult.Text)).ToString();
                    break;

                case "-":
                    textBoxResult.Text = (value - Double.Parse(textBoxResult.Text)).ToString();
                    break;
                case "*":
                    textBoxResult.Text = (value * Double.Parse(textBoxResult.Text)).ToString();
                    break;
                case "/":
                    textBoxResult.Text = (value / Double.Parse(textBoxResult.Text)).ToString();
                    break;
                default:
                    break;


            }//end switch



        }

        private void button6_Click(object sender, EventArgs e)
        {

            textBoxResult.Clear();
            value = 0;
        }

        private void button5_Click(object sender, EventArgs e)
        {

            textBoxResult.Clear();
            value = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }
    }
 }
