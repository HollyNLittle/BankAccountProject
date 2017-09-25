using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountProject
{
    class SavingsAccount:Account
    {
        //FIELDS
        protected double minimumBalance;

        //PROPERTIES
        public double MinimumBalance
        {
            get { return this.minimumBalance; }
            set { minimumBalance = value; }
        }

        //METHODS
        //All savings accounts have a minimum balance requirement.  
        //Clients cannot complete withdrawals resulting in a balance that is less than the minimum.
        public override double Withdrawal(double withdrawalAmount)
        {
            this.minimumBalance = 50;
            if (balance - withdrawalAmount < minimumBalance)
            {
                Console.WriteLine("   Sorry, the minimum required limit is $50.00.");
                return 0;
            }
            else
            {
                balance -= withdrawalAmount;
                return balance;
            }
        }

        //CONSTRUCTOR
        public SavingsAccount()
        {
        }
    }
}
