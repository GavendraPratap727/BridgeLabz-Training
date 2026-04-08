//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Review.BankAccountManager
//{
//    //    Methods – Bank Account Manager
//    //1. Scenario: A banking app needs to perform operations like deposit, withdraw, and check balance for a user.
//    //● Problem: Design a BankAccount class with :
//    //● Fields/Properties: AccountNumber, Balance.
//    //● Methods: Deposit(double), Withdraw(double), CheckBalance().
//    //● Include logic to prevent overdraft.
//    class BankAccountManager
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Enter User Name");
//            string name = Console.ReadLine();
//            Console.WriteLine("Enter your Phone Number");
//            long number = long.Parse(Console.ReadLine());
//            Console.Write("Enter Account Number ");
//            string accNo = Console.ReadLine();
//            Console.Write("Enter Initial Balance ");
//            double balance = double.Parse(Console.ReadLine());
//            IBankAccount account = new BankOperationImpl(accNo, balance, name, number);
//            BankMenu menu = new BankMenu(account);
//            menu.ShowMenu();
//        }
//    }

//}
