using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalaryCalculatorAppPractice3
{
    public partial class SalaryCalculatorUi : Form
    {
        public SalaryCalculatorUi()
        {
            InitializeComponent();
        }

        private void ShowMeSalaryButton_Click(object sender, EventArgs e)
        {
            Salary salaryobj = new Salary();
            salaryobj.employeeName = employeeNameTextBox.Text;
            salaryobj.basicAmount =Convert.ToInt32( basicAmountTextBox.Text);
            salaryobj.homeRent = Convert.ToInt32(homeRentTextBox.Text);
            salaryobj.medicalAllowance = Convert.ToInt32(medicalAllowanceTextBox.Text);

        
           string Show=salaryobj.GetFullSalary().ToString();
            MessageBox.Show(salaryobj.employeeName +" " + "your salary is:" + Show);

        }
    }
}
