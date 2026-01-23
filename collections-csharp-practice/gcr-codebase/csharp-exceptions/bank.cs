using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.Collections.Exceptions
{
    class InsufficientFundsException : Exception
    {
        public InsufficientFundsException()
        {
        }
    }
    class BankAccount
    {
        double balance;

        public BankAccount(double initialBalance)
        {
            balance = initialBalance;
        }

        public void Withdraw(double amount)
        {
            if (amount < 0)
            {
                throw new ArgumentException();
            }

            if (amount > balance)
            {
                throw new InsufficientFundsException();
            }

            balance -= amount;
            Console.WriteLine("Withdrawal successful, new balance: " + balance);
        }
    }
    internal class Bank
    {
        static void Main()
        {
            try
            {
                BankAccount account = new BankAccount(5000);

                Console.Write("Enter withdrawal amount: ");
                double amount = double.Parse(Console.ReadLine());

                account.Withdraw(amount);
            }
            catch (InsufficientFundsException)
            {
                Console.WriteLine("Insufficient balance!");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Invalid amount!");
            }
        }
    }
}
