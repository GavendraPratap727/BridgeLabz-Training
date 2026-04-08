using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review.BankAccountManager
{
    interface IBankAccount
    {
        void Deposit(double amount);
        void Withdraw(double amount);
        void CheckBalance();
        void DisplayAccountDetails();
    }

}
