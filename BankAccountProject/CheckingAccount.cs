using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountProject
{
    class CheckingAccount:Account
    {
        //METHODS
        public override double Withdrawal(double withdrawalAmount)
        {
            if (balance - withdrawalAmount > 0)
            {
                return balance -= withdrawalAmount;
            }
            else
            {
                return balance;
            }
        }

        //CONSTRUCTOR
        public CheckingAccount()
        {
        }
    }
}
