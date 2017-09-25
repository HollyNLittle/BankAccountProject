using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountProject
{
    abstract class Account
    {
        //FIELDS
        protected string accountType;
        protected int accountNumber;
        protected double balance;
        protected double available;

        //PROPERTIES
        public int AccountNumber
        {
            get { return this.accountNumber; }
            set { accountNumber = value; }
        }
        public string AccountType
        {
            get { return this.accountType; }
            set { accountType = value; }
        }
        public double Balance
        {
            get { return this.balance; }
            set { balance = value; }
        }
        public double Available
        {
            get { return this.available; }
            set { available = value; }
        }

        //METHODS
        abstract public double Withdrawal(double withdrawalAmount);

        public double Deposit(double depositAmount)
        {
            balance += depositAmount;
            return balance;
        }

        //CONSTRUCTORS
        public Account()
        {
        }
    }
}

