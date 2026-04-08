using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.lkfdghkjf
{
    class User
    {
        public string name;
        public double amount;

        // creates a new user
        public User(string name)
        {
            this.name = name;
            amount = 0;
        }

        // shows current balance
        public void showBal()
        {
            System.Console.WriteLine(name + " Balance: " + amount);
        }
    }

    // represents bank entity
    class BankUnit
    {
        public string bank;
        public List<User> users;

        // sets bank name
        public BankUnit(string bank)
        {
            this.bank = bank;
            users = new List<User>();
        }

        // opens account and assigns money
        public void openAcc(User u, double money)
        {
            u.amount = money;
            users.Add(u);

            System.Console.WriteLine("Account opened for " + u.name +
                                     " in " + bank);
        }
    }

    // program execution class
    class DemoApp
    {
        // starting point
        static void Main(string[] args)
        {
            BankUnit b = new BankUnit("Punjab National Bank");

            User u1 = new User("Rishita");
            User u2 = new User("Monty");

            b.openAcc(u1, 15000);
            b.openAcc(u2, 8000);

            u1.showBal();
            u2.showBal();
        }
    }

}
