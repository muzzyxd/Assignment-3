using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Program
    {
        public class BankAccount
        {
            
            private string accountNumber;
            private double balance;

          
            public BankAccount(string accNumber, double initialBalance)
            {
                accountNumber = accNumber;
                balance = initialBalance;
            }

            public void Deposit(double amount)
            {
                if (amount > 0)
                {
                    balance += amount;
                    Console.WriteLine($"Deposited {amount}. New balance: {balance}");
                }
                else
                {
                    Console.WriteLine("Deposit amount.");
                }
            }

            public void Withdraw(double amount)
            {
                if (amount > 0 && amount <= balance)
                {
                    balance -= amount;
                    Console.WriteLine($"Withdrew {amount}. New balance: {balance}");
                }
                else if (amount > balance)
                {
                    Console.WriteLine("Insufficient balance for this withdrawal.");
                }
                else
                {
                    Console.WriteLine("Withdrawal amount.");
                }
            }

          
            public double GetBalance()
            {
                return balance;
            }

           
            public void DisplayAccountInfo()
            {
                Console.WriteLine($"Account Number: {accountNumber}, Balance: {balance}");
            }
        }

        static void Main(string[] args)
        {
            BankAccount account1 = new BankAccount("123456789", 1000.0);

            
            account1.DisplayAccountInfo();

            
            account1.Deposit(500.0);
            account1.Withdraw(200.0);
            account1.Withdraw(1500.0); 
            account1.Deposit(-100.0);  

            
            Console.WriteLine($"Final Balance: {account1.GetBalance()}");

            Console.ReadLine();
        }
    }
}
