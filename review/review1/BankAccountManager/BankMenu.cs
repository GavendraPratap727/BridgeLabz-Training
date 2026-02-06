using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Review.BankAccountManager
{
    class BankMenu
    {
        private IBankAccount account;
        public BankMenu(IBankAccount account)
        {
            this.account = account;
        }
        public void ShowMenu()
        {
            while (true)
            {
                Console.WriteLine("PRESS 1 : Deposit");
                Console.WriteLine("PRESS 2 : Withdraw");
                Console.WriteLine("PRESS 3 : Check Balance");
                Console.WriteLine("PRESS 4 : DISPLAY ALL DETAILS ABOUT USER ");
                Console.WriteLine("PRESS 5 : Exit");
                int choice =int.Parse(Console.ReadLine());
                switch (choice) {
                    case 1:
                        Console.Write("Enter deposit amount: ");
                        double amt = double.Parse(Console.ReadLine());
                        account.Deposit(amt);
                        break;
                    case 2:
                        Console.Write("Enter withdrawal amount: ");
                        double wamt = double.Parse(Console.ReadLine());
                        account.Withdraw(wamt);
                        break;
                    case 3:
                        account.CheckBalance();
                        break;
                    case 4:
                        account.DisplayAccountDetails();
                        
                        break;
                    case 5:
                        Console.WriteLine("Thankyou For Visiting Ou Bank");
                        return;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;

                }
               
            }
        }
    }

}
