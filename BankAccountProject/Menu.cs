using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountProject
{
    class Menu
    {
        //METHODS
        public void Greeting()
        {
            Console.Write("\n\n\n\n\t     ~ * ~ * ~ Welcome to YOUR FAVORITE BANK! ~ * ~ * ~  \n\n\t   Please enter your name for assistance: ");
        }

        //TABLE HEADER for account summary:         
        public void DisplayHeader()
        {
            Console.WriteLine
                ("\n\n\n\n\n\n\t\t ~ * ~ * ~ ACCOUNT SUMMARY~ * ~ * ~ \n\n\n\tACCOUNT\t   ACCOUNT #\t\t\tBALANCE\t\t\n");
        }

        //MENU 
        //  1) DEPOSIT CHECKING 2) DEPOSIT SAVINGS 3) WITHDRAW CHECKING 4) WITHDRAW SAVINGS 5) CLIENT INFO 6) ACCOUNT SUMMARY 7) EXIT
        public void MenuOptions()
        {
            Console.WriteLine
                ("       \n\n       1) Deposit to checking \t\t 2) Deposit to savings \n\n       3) Withdraw from checking \t 4) Withdraw from savings \n\n       5) View customer information      6) View account summary\n\n\n \t\t\t\t7) EXIT\n\n\n");
        }

        public void Salutation()
        {
            Console.WriteLine
                ("\n\n\n\n\n\n\n\n\n\n\n\t\t\t ~ * ~ THANK YOU, GOODBYE! ~ * ~ \n\n\n\n\n\n\n\n\n\n\n\n");
        }
    }
}
