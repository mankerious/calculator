using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCalculator
{
    public partial class Form1 : Form
    {
        // Global variables
        private double FirstNumber = 0.0;
        private double SecondNumber = 0.0;
        private string OperatorString = "+";
        private double Result = 0.0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //zero button click event
        private void ZeroButton_Click(object sender, EventArgs e)
        {
            ZeroRemove(0);
        }
        //zero remove function and here other number will add on the texbox
        private void ZeroRemove(int number)
        {
            if (CalcTextBox.Text == "0")
                CalcTextBox.Text =number.ToString();
            else
                CalcTextBox.Text += number.ToString();
        }
        //three button click event
        private void OneButton_Click(object sender, EventArgs e)
        {
            ZeroRemove(1);
        }
        //three button click event
        private void TwoButton_Click(object sender, EventArgs e)
        {
            ZeroRemove(2);
        }
        //three button click event
        private void ThreeButton_Click(object sender, EventArgs e)
        {
            ZeroRemove(3);
        }

        private void FourButton_Click(object sender, EventArgs e)
        {
            ZeroRemove(4);
        }

        private void FiveButton_Click(object sender, EventArgs e)
        {
            ZeroRemove(5);
        }

        private void SixButton_Click(object sender, EventArgs e)
        {
            ZeroRemove(6);
        }

        private void SevenButton_Click(object sender, EventArgs e)
        {
            ZeroRemove(7);
        }

        private void EightButton_Click(object sender, EventArgs e)
        {
            ZeroRemove(8);
        }

        private void NineButton_Click(object sender, EventArgs e)
        {
            ZeroRemove(9);
        }
        //Clear button click event here clear the texbox
        private void ClearButton_Click(object sender, EventArgs e)
        {
            CalcTextBox.Clear();
            CalcTextBox.Text = "0";
            FirstNumber = 0.0;
            SecondNumber = 0.0;
            Result = 0.0;

        }
        //Here put . in the textbox
        private void DoBtutton_Click(object sender, EventArgs e)
        {
            if (!CalcTextBox.Text.Contains("."))
                CalcTextBox.Text += ".";
        }
        //plus button
        private void PlusButton_Click(object sender, EventArgs e)
        {
            SuppliedOperator("+");

        }
        // It is general function which recieve the coming operator
        private void SuppliedOperator(string operatorString)
        {
            OperatorString = operatorString;
            FirstNumber = double.Parse(CalcTextBox.Text);
            CalcTextBox.Text = "0";
        }

        private void MinusButton_Click(object sender, EventArgs e)
        {
            SuppliedOperator("-");
        }

        private void DivisionButton_Click(object sender, EventArgs e)
        {
            SuppliedOperator("/");
        }

        public void MultiplyButton_Click(object sender, EventArgs e)
        {
            SuppliedOperator("*");
        }
        //Equal button
        private void EqualButton_Click(object sender, EventArgs e)
        {
            SecondNumber = double.Parse(CalcTextBox.Text);// here recieve second number from the user.

            switch (OperatorString)// switch
            { 
                case "+":
                    Result = FirstNumber + SecondNumber;
                    break;
                case "-":
                    Result = FirstNumber - SecondNumber;
                    break;
                case "/":
                    Result = FirstNumber / SecondNumber;
                    break;
                case "*":
                    Result = FirstNumber * SecondNumber;
                    break;
                case "%":
                    Result = FirstNumber % SecondNumber;
                    break;
                case "sin":
                    Result = System.Math.Sin(FirstNumber);
                    break;
                case "cos":
                    Result = System.Math.Cos(FirstNumber);
                    break;
                case "tan":
                    Result = System.Math.Tan(FirstNumber);
                    break;
            }
            CalcTextBox.Text = Result.ToString();
        }

        private void MinusPlusButton_Click(object sender, EventArgs e)
        {
            if (!CalcTextBox.Text.Contains("-"))
                CalcTextBox.Text = "-" + CalcTextBox.Text;
            else
                CalcTextBox.Text = CalcTextBox.Text.Trim('-');
        }

        private void PercentageButton_Click(object sender, EventArgs e)
        {
            SuppliedOperator("%");
        }
        //sin button
        private void SinButton_Click(object sender, EventArgs e)
        {
            SuppliedOperator("sin");
        }

        private void CosButton_Click(object sender, EventArgs e)
        {
            SuppliedOperator("cos");
        }
        //cos button
        private void TanButton_Click(object sender, EventArgs e)
        {
            SuppliedOperator("cos");
        }
    }
}
