using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerAndAccountAppExample1
{
    public class Account
    {
       public string AccountNumber { get; set; }
        public string OpeningDate { get; set; }

        private double balance;

        public double Balance
        {
            get { return balance; }
        }

        public bool Deposit(double amount)
        {
            balance = balance + amount;
            return true;
        }

        public bool Withdraw(double amount)
        {
            balance = balance - amount;
            return true;
        }
    }
}
