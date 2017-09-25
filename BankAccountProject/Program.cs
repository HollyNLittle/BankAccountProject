using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //OPENING GREETING DISPLAY
            Menu display = new Menu();
            display.Greeting();

            Client clientInfo = new Client();
            clientInfo.ClientName = Console.ReadLine();
            clientInfo.ClientID = 14253;
            clientInfo.ClientPhone = "(440)246-2323";

            CheckingAccount checking = new CheckingAccount();
            checking.AccountNumber = 156746;
            checking.AccountType = "Checking";
            checking.Balance = 100.87;

            SavingsAccount savings = new SavingsAccount();
            savings.AccountNumber = 156749;
            savings.AccountType = "Savings";
            savings.Balance = 200.00;

            int usersChoice = 0;
            double amount;
            //while (usersChoice != 6)
            //{
            //MENU DISPLAY 
            display.DisplayHeader();
            Console.WriteLine("\t{0}   {1}\t\t\t{2}\t\t\n", checking.AccountType,
            checking.AccountNumber, checking.Balance);
            Console.WriteLine("\t{0}    {1}\t\t\t{2}\t\t\n\n", savings.AccountType,
            savings.AccountNumber, savings.Balance);

            //usersChoice = Convert.ToInt32(Console.ReadLine());
            //if (usersChoice == 6)
            //{
            //    Console.WriteLine
            //        ("\n\n\n\n\n\n\n\n\n\n\n\t\t\t ~ * ~ THANK YOU, GOODBYE! ~ * ~ \n\n\n\n\n\n\n\n\n\n\n\n", usersChoice);
            //}
            //else if (usersChoice == 5)
            //{
            //    clientInfo.DisplayClient(clientInfo.ClientName);

            //{ Console.Write("   Please enter the number of your choice: "); }
            //Console.Write("   Please enter the number of your choosing: ");
            //usersChoice = Convert.ToInt32(Console.ReadLine());
            //while (usersChoice != 6)
            //do
            //{

            do
            {
                display.MenuOptions();
                Console.Write("   Please enter the number of your choosing: ");
                usersChoice = Convert.ToInt32(Console.ReadLine());
                switch (usersChoice)
                {
                    case 1:
                        Console.Write("   Enter the amount you would like to deposit: ");
                        amount = Convert.ToDouble(Console.ReadLine());
                        checking.Deposit(amount);
                        Console.WriteLine("   Balance is now {0}\n", checking.Balance);
                        break;
                    case 2:
                        Console.Write("   Enter the amount you would like to deposit: ");
                        amount = Convert.ToDouble(Console.ReadLine());
                        savings.Deposit(amount);
                        Console.WriteLine("   Balance is now {0}\n", savings.Balance);
                        break;
                    case 3:
                        Console.Write("   Enter the amount you would like to withdraw: ");
                        amount = Convert.ToDouble(Console.ReadLine());
                        checking.Withdrawal(amount);
                        Console.WriteLine("   Balance is now {0}\n", checking.Balance);
                        break;
                    case 4:
                        Console.Write("   Enter the amount you would like to withdraw: ");
                        amount = Convert.ToDouble(Console.ReadLine());
                        savings.Withdrawal(amount);
                        Console.WriteLine("   Balance is {0}\n", savings.Balance);
                        break;
                    case 5:
                        clientInfo.DisplayClient(clientInfo.ClientName);
                        break;
                    case 6:
                        display.DisplayHeader();
                        Console.WriteLine("\t{0}   {1}\t\t\t{2}\t\t\n", checking.AccountType,
                        checking.AccountNumber, checking.Balance);
                        Console.WriteLine("\t{0}    {1}\t\t\t{2}\t\t\n\n", savings.AccountType,
                        savings.AccountNumber, savings.Balance);
                        break;

                }
            } while (usersChoice != 7);
                Console.WriteLine
                   ("\n\n\n\n\n\n\n\n\n\n\n\t\t\t ~ * ~ THANK YOU, GOODBYE! ~ * ~ \n\n\n\n\n\n\n\n\n\n\n\n", usersChoice);

        }
    }
}




