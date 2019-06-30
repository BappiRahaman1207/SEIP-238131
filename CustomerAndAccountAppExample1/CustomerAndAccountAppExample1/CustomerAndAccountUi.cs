using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerAndAccountAppExample1
{
    public partial class CustomerAndAccountUi : Form
    {
        public CustomerAndAccountUi()
        {
            InitializeComponent();
        }
        private Customer aCustomer;
        private void SaveButton_Click(object sender, EventArgs e)
        {
            aCustomer = new Customer();
           
            aCustomer.CustomerName = customerNameTextBox.Text;
            aCustomer.Email = emailTextBox.Text;

            Account account = new Account();
            account.AccountNumber = accountNumberTextBox.Text;
            account.OpeningDate = openingDateTextBox.Text;

            aCustomer.Account = account;


        }
        private void DepositeButton_Click(object sender, EventArgs e)
        {
            double depositAmount = Convert.ToDouble(amountTextBox.Text);

           
            bool isDeposited = aCustomer.Account.Deposit(depositAmount);
            if (isDeposited)
            {
                amountTextBox.Text = "";
            }
        }
        private void WithdrawButton_Click(object sender, EventArgs e)
        {
            double withdrawAmount = Convert.ToDouble(amountTextBox.Text);
            bool isWithdrawn = aCustomer.Account.Withdraw(withdrawAmount);

            if (isWithdrawn)
            {
                amountTextBox.Text = "";
            }
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            customerName2TextBox.Text = aCustomer.CustomerName;
            email2TextBox.Text = aCustomer.Email;

            accountNumber2TextBox.Text = aCustomer.Account.AccountNumber;
            openingDate2TextBox.Text = aCustomer.Account.OpeningDate;

            BalanceTextBox.Text = aCustomer.Account.Balance.ToString();
        }
    }
}
