using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_MACHINE
{
    internal class Program
    {
        public delegate void MenuOperation(BankAccount account1, BankAccount account2);        
        static void Main(string[] args)
        {
            //Create some bank accounts
            BankAccount account1 = new BankAccount("123456", "Mark", 1000);
            BankAccount account2 = new BankAccount("654321", "Bob", 2000);

            //Create Delegate Instance
            MenuOperation menuOperation = HandleMenuOperation;

            //Display the menu and handler user choices
            while(true)
            {
                Console.WriteLine("Welcome to Mark's Bank Plc");
                Console.WriteLine("\nATM Menu:");
                Console.WriteLine("1. Check Balance");
                Console.WriteLine("2. Deposit");
                Console.WriteLine("3. Withdraw");
                Console.WriteLine("4. Transfer");
                Console.WriteLine("5. Exit");

                Console.Write("Enter your choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                         account1.CheckBalance();
                         break;
                    case 2:
                        Console.Write("Enter deposit amount: $");
                        double depositAmount = Convert.ToDouble(Console.ReadLine());
                        account1.Deposit(depositAmount);
                        break;
                    case 3:
                        Console.Write("Enter withdrawal amount: $");
                        double withdrawAmount = Convert.ToDouble(Console.ReadLine());
                        account1.Withdraw(withdrawAmount);
                        break;
                    case 4:
                        Console.Write("Enter transfer amount: $");
                        double transferAmount = Convert.ToDouble(Console.ReadLine());
                        account1.Transfer(account2, transferAmount);
                        break;
                    case 5:
                        Console.WriteLine("Exiting ATM. Goodbye!");
                        return;
                    default:
                        Console.WriteLine("Inavlid choice. Please try again.");
                        break;
                }
            }
        }
        // Menu operation method to check balance
        static void HandleMenuOperation(BankAccount account1, BankAccount account2)
        {
            account1.CheckBalance();
        }
    }
}
