using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountOperationAppPractice1
{
    class Account
    {

        public int accountNumber;
        public string customerName;
        public int amount;
        public int diposit;
        public int withdraw;




        public int GetAmount()
        {
            int amount = 0;
            return amount;

        }

        public int GetDiposit()
        {

       
            diposit = amount + diposit;
            return diposit;

        }

        public int GetWithdraw()
        {
            withdraw = amount - withdraw;
            return withdraw;

        }

     


    }
}
