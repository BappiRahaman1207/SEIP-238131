using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorAppPractice2
{
    public partial class CalculatorUi : Form
    {

        public CalculatorUi()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Calculator calculatorobj = new Calculator();
            calculatorobj.firstNumber = Convert.ToInt32(firstNumberTextBox.Text);
            calculatorobj.secondNumber = Convert.ToInt32(secondNumberTextBox.Text);
   
            resultTextBox.Text = calculatorobj.GetAdd().ToString();

        }

        private void SubtractButton_Click(object sender, EventArgs e)
        {

            Calculator calculatorobj = new Calculator();
            calculatorobj.firstNumber = Convert.ToInt32(firstNumberTextBox.Text);
            calculatorobj.secondNumber = Convert.ToInt32(secondNumberTextBox.Text);

            resultTextBox.Text = calculatorobj.GetSubtract().ToString();
        }

        private void MultiplyButton_Click(object sender, EventArgs e)
        {
            Calculator calculatorobj = new Calculator();
            calculatorobj.firstNumber = Convert.ToInt32(firstNumberTextBox.Text);
            calculatorobj.secondNumber = Convert.ToInt32(secondNumberTextBox.Text);

            resultTextBox.Text = calculatorobj.GetMultiply().ToString();
        }

        private void DivideButton_Click(object sender, EventArgs e)
        {
            Calculator calculatorobj = new Calculator();
            calculatorobj.firstNumber = Convert.ToInt32(firstNumberTextBox.Text);
            calculatorobj.secondNumber = Convert.ToInt32(secondNumberTextBox.Text);

            resultTextBox.Text = calculatorobj.GetDivide().ToString();
        }
    }
}
