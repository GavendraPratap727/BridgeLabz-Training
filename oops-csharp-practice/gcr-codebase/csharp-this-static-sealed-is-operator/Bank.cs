using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.Seiled_class
{
    //  class BankAccount
    public class BankAccount
    {
        // Static member to hold bank name
        public static string bankName = "PNB Bank";
        private static int totalAccounts = 0;
        public readonly long AccountNumber;
        public string AccountHolderName;
        // Parameterized constructor

        public BankAccount(string AccountHolderName, long AccountNumber)
        {
            this.AccountHolderName = AccountHolderName;
            this.AccountNumber = AccountNumber;
            totalAccounts++;
        }
        public static int TotalAccounts()
        {
            return totalAccounts;
        }
        // Method to display account details
        public void AccountDetails(object account)
        {
            if (account is BankAccount)
            {
                Console.WriteLine("Bank Name " + bankName);
                Console.WriteLine("Account Holder " + AccountHolderName);
                Console.WriteLine("Account Number " + AccountNumber);
            }
            else Console.WriteLine("Invalid account details");
            
        }
    }
    // Main class
    class Bank
    {
        static void Main(string[] args)
        {
            BankAccount acc1 = new BankAccount("Gavendra", 11);
            BankAccount acc2 = new BankAccount("Love", 12);
            acc1.AccountDetails(acc1);
            Console.WriteLine();
            acc2.AccountDetails(acc2);
            Console.WriteLine();
            Console.WriteLine("Total Accounts " + BankAccount.TotalAccounts());

        }
    }
}
