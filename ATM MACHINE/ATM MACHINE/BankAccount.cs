using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_MACHINE
{
    internal class BankAccount
    {
        //Properties 
        public string AccountNumber { get; }
        public string OwnerName { get; }
        public double Balance { get;private set; }

        //Constructor
        public BankAccount(string accountNumber, string ownerName, double initialBalance)
        {
            AccountNumber = accountNumber;
            OwnerName = ownerName;
            Balance = initialBalance;
        }

        //Method to deposit money into account
        public void Deposit(double amount)
        {
            Balance += amount;
            Console.WriteLine($"Deposited ${amount}. New Balance:${Balance}");
        }

        //Method to withdraw money from the account
        public void Withdraw(double amount)
        {
            if (Balance >= amount)
            {
                Balance -= amount;
                Console.WriteLine($"Withdrawn ${amount}. New balance: ${Balance}");
            }
            else
            {
                Console.WriteLine("Insuffficient Funds.");
            }
        }

        //Method to transfer money to another account
        public void Transfer(BankAccount recipientAccount, double amount)
        {
            if (Balance >= amount)
            {
                Balance -= amount;
                recipientAccount.Deposit(amount);
                Console.WriteLine($"Transferred ${amount} to account number {recipientAccount.AccountNumber}. New balance: ${Balance}");
            }
            else
            {
                Console.WriteLine("Insufficient funds.");
            }
        }

        //Method to check the account balance
        public void CheckBalance()
        {
            Console.WriteLine($"Account balance for {OwnerName} (Account Number: {AccountNumber}): ${Balance}");
        }

    }
}
