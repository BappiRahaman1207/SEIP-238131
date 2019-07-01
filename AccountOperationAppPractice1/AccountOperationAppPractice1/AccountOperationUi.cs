using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountOperationAppPractice1
{
    public partial class AccountOperationUi : Form
    {
        public AccountOperationUi()
        {
            InitializeComponent();
        }
        Account accountObj = new Account();

        private void CreateButton_Click(object sender, EventArgs e)
        { 

            accountObj.accountNumber = Convert.ToInt32(accountNoTextBox.Text);
            accountObj.customerName = customerNameTextBox.Text;
            
        }

        private void DipositButton_Click(object sender, EventArgs e)
        {
            accountObj.GetDiposit();
            accountObj.amount = Convert.ToInt32(amountTextBox.Text);
          
        }

        private void WithdrawButton_Click(object sender, EventArgs e)
        {
            accountObj.GetWithdraw();
            accountObj.amount = Convert.ToInt32(amountTextBox.Text);
          
        }

        private void ReportButton_Click(object sender, EventArgs e)
        {
            int accountNumber = accountObj.accountNumber;
            string customerName = accountObj.customerName;
            int amount = accountObj.amount;
            MessageBox.Show("Account Number:"+ accountNumber+"\t"+"Customer Name:"+ customerName+"\t"+"Blance:"+ amount+" Taka");
        }
    }
}
