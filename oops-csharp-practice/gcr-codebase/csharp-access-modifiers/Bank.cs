using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.Access_modifiers
{
    public class Bank
    {
        static void Main(string[] args)
        {
            SavingsAccount sa = new SavingsAccount(4512654800, "Love", 11000);
            sa.Details();
        }
    }
    public class BankAccount
    {
        public double accountNumber;
        protected string user;
        private double balance;
        public BankAccount(double accountNumber, string user, double balance)
        {
            this.accountNumber = accountNumber;
            this.user = user;
            this.balance = balance;
        }
        public double AccessBalance()
        {
            return balance;
        }
        public void SetBalance(double balanceAmount)
        {
            balance = balanceAmount;
        }

    }
    public class SavingsAccount : BankAccount
    {
        public SavingsAccount(double accountNumber, string accountHolder, double balance) : base(accountNumber, accountHolder, balance) { }
        public void Details()
        {
            Console.WriteLine("Account Holder Details");
            Console.WriteLine("Account number " + accountNumber);
            Console.WriteLine("Account Holder " + user);
        }
    }
}
