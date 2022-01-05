using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator2
{
    public partial class Form1 : Form
    {
        
       decimal  resultValue = 0;
        string operators = string.Empty;
        bool IsOperator = false;
        

        public Form1()
        {
            InitializeComponent();
        }
      

        private void button_click(object sender, EventArgs e)
        {
            if(textBox_Result.Text == "0" || IsOperator)
            {
                textBox_Result.Clear();
            }
            IsOperator = false;
            Button button = (Button)sender;

            if (button.Text == ".")
            {
                if (!textBox_Result.Text.Contains("."))
                {
                    textBox_Result.Text = textBox_Result.Text + button.Text;
                }
            }
            else
            {
                textBox_Result.Text = textBox_Result.Text + button.Text;
            }
            
            
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (resultValue != 0)
            {
                button4.PerformClick();
                operators = button.Text;               
                currentLabel.Text = resultValue + " " + operators;
                IsOperator = true;

            }
            else
            {
                operators = button.Text;
                resultValue = decimal.Parse(textBox_Result.Text);
                currentLabel.Text = resultValue + " " + operators;
                IsOperator = true;
            }
            
                     
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox_Result.Text = "0";
            currentLabel.Text = string.Empty;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox_Result.Text = "0";
            resultValue = 0;
            currentLabel.Text = string.Empty;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            decimal resultText = decimal.Parse(textBox_Result.Text);

            switch (operators)
            {
                case "+": 
                    textBox_Result.Text = (resultValue + resultText).ToString();
                    break;
                case "-":
                    textBox_Result.Text = (resultValue - resultText).ToString();
                    break;
                case "*":
                    textBox_Result.Text = (resultValue * resultText).ToString();
                    break;
                case "/":
                    textBox_Result.Text = (resultValue / resultText).ToString();
                    break;

                default:
                    break;
            }

            resultValue = decimal.Parse(textBox_Result.Text);
            currentLabel.Text = string.Empty;

        }
    }
}
