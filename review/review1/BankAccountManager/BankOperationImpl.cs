using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review.BankAccountManager
{
    class BankOperationImpl : IBankAccount
    {
        private string accountNumber;
        private double balance;
        private string User;
        private long number;
        public BankOperationImpl(string accNo, double initialBalance,string name ,long  number)
        {
            accountNumber = accNo;
            balance = initialBalance;
            this.User= name;
            this.number = number;
        }
        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                balance = balance + amount;
                Console.WriteLine("Deposit successful");
            }
            else
            {
                Console.WriteLine("Invalid amount");
            }
        }
        public void Withdraw(double amount)
        {
            if (amount <= balance)
            {
                balance = balance - amount;
                Console.WriteLine(amount + "Withdraw");
            }
            else
            {
                Console.WriteLine("Insufficient bank balance");
            }
        }
        public void CheckBalance()
        {
            Console.WriteLine("Current Balance  " + balance);
        }
        public void DisplayAccountDetails()
        {
            Console.WriteLine("User Name -: " + User);
            Console.WriteLine("Account number -: " + accountNumber);
            Console.WriteLine("Balance -: " + balance);
            Console.WriteLine("Phone Number -: " + number);
        }
    }

}
