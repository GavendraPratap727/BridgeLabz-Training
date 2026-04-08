//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace bridge.Senario
//{
//    class BankApplication
//    {
//        // --------- Global variables to store single user account data ---------
//        static long accountNumber; // Stores 10-digit account number
//        static string userName; // Stores account holder name
//        static double balance; // Stores account balance
//        static int pin; // Stores user PIN
//        static bool accountCreated = false; // Checks if account exists
//        static bool pinCreated = false; // Checks if PIN is created
//        // Method to choose role (User / Manager)
//        static void ChooseRole()
//        {
//            while (true)
//            {
//                Console.WriteLine();
//                Console.WriteLine("WELCOME TO OUR BANK");
//                Console.WriteLine("PLEASE CHOOSE YOUR ROLE:");
//                Console.WriteLine("PRESS 1: IF  U ARE A USER");
//                Console.WriteLine("PRESS 2: IF U ARE AN MANAGER");
//                Console.WriteLine("PRESS 3: FOR EXIT");
//                int role = int.Parse(Console.ReadLine());
//                switch (role)
//                {
//                    case 1:
//                        UserMenu();
//                        break;
//                    case 2:
//                        ManagerLogin();
//                        break;
//                    case 3:
//                        Console.WriteLine("THANK YOU FOR VISITING");
//                        break;
//                }

//            }
//        }
//        //-------------------MANAGER MENU-----------------
//        public static void ManagerLogin()
//        {
//            int password = 8085;
//            Console.WriteLine("ENTER YOUR LOGIN PASSWORD");
//            int inputPas = int.Parse(Console.ReadLine());
//            if (inputPas != password)
//            {
//                Console.WriteLine("WRONG PASSWORD");
//                return;
//            }
//            while (true)
//            {
//                Console.WriteLine();
//                Console.WriteLine("WELCOME TO MANAGER MENU");
//                Console.WriteLine("PRESS 1 : CREATE ACCOUNT");
//                Console.WriteLine("PRESS 2 : FOR VIEW ACCOUNT DETAILS");
//                Console.WriteLine("PRESS 3: FOR DELETE THE ACCOUNT");
//                Console.WriteLine("PRESS 4: FOR BACK");
//                int choose = int.Parse(Console.ReadLine());
//                switch (choose)
//                {
//                    case 1:
//                        CreateAccount();
//                        break;
//                    case 2:
//                        ViewAccountDetails();
//                        break;
//                    case 3:
//                        DeleteAccount();
//                        break;
//                    case 4:
//                        return;
//                }
//            }
//        }
//        // Method to create account (Manager only)
//        static void CreateAccount()
//        {
//            Random r = new Random();
//            accountNumber = r.NextInt64(1000000000L, 10000000000L);
//            Console.WriteLine("THE ACCOUNT NUMBER IS :" + accountNumber);
//            Console.WriteLine(" ENTER ACCOUNT HOLDER NAME ");
//            userName = Console.ReadLine();
//            Console.WriteLine("ENTER INITIAL BALANCE ");
//            balance = double.Parse(Console.ReadLine());
//            accountCreated = true;
//            Console.WriteLine("ACCOUNT CREATED SUCCESSFULLY");
//        }
//        // Method to view account details
//        static void ViewAccountDetails()
//        {
//            if (!accountCreated)
//            {
//                Console.WriteLine("NO ACCOUNT FOUND.PLEASE CREATE AN ACCOUNT FIRST.");
//                return;
//            }
//            Console.WriteLine("ACCOUNT NUMBER      " + accountNumber);
//            Console.WriteLine("ACCOUNT HOLDER NAME " + userName);
//            Console.WriteLine("ACCOUNT BALANCE     " + balance);

//        }
//        //Method to delete account  
//        static void DeleteAccount()
//        {
//            if (!accountCreated)
//            {
//                Console.WriteLine("NO ACCOUNT FOUND.PLEASE CREATE AN ACCOUNT FIRST.");
//                return;
//            }
//            accountNumber = 0;
//            userName = null;
//            balance = 0;
//            pin = 0;
//            accountCreated = false;
//            pinCreated = false;
//            Console.WriteLine("ACCOUNT DELETED ");
//        }
//        //--------------------------//
//        //=========USER MENU=============//
//        static void UserMenu()
//        {
//            if (!accountCreated)
//            {
//                Console.WriteLine("NO ACCOUNT FOUND");
//                return;
//            }
//            if (!pinCreated)
//            {
//                Console.WriteLine("YOU CANT ACCESS YOUR ACCOUNT BECAUSE PIN IS NOT CREATED CREATE IT FIRST");
//                CreatePin();
//                return;
//            }
//            Console.WriteLine("WELCOME CUSTOMER");
//            while (true)
//            {
//                Console.WriteLine();

//                Console.WriteLine("PRESS 1: FOR DEPOSIT MONEY");
//                Console.WriteLine("PRESS 2: FOR WITHDRAW MONEY ");
//                Console.WriteLine("PRESS 3: CHECK BALANCE");
//                Console.WriteLine("PRESS 4: FOR BACK");
//                int choose = int.Parse(Console.ReadLine());
//                Console.WriteLine("ENTER  YOUR PIN NUMBER");
//                int checkpin = int.Parse(Console.ReadLine());
//                if (checkpin != pin)
//                {
//                    Console.WriteLine("WRONG PIN NUMBER");
//                    return;
//                }
//                Console.WriteLine();

//                if (choose == 1) Deposit();
//                else if (choose == 2) Withdraw();
//                else if (choose == 3) CheckBalance();
//                else if (choose == 4) return;
//                else Console.WriteLine("Invalid option");

//            }

//        }
//        // Method to create PIN
//        static void CreatePin()
//        {
//            Console.WriteLine("CREATE YOUR 4 DIGIT PIN NUMBER");
//            pin = int.Parse(Console.ReadLine());
//            Console.WriteLine("PIN CREATED");
//            pinCreated = true;
//        }
//        // Deposit money

//        static void Deposit()
//        {
//            Console.WriteLine("ENTER AMOUNT U WANT TO DEPOSIT");
//            double amount = double.Parse(Console.ReadLine());
//            if (amount < 0) Console.WriteLine("INVALID AMOUNT");
//            else balance += amount;
//        }
//        //Withdraw money
//        static void Withdraw()
//        {
//            Console.WriteLine("ENTER AMOUNT YOU WANT TO WITHDRAW");
//            double amount = double.Parse(Console.ReadLine());
//            if (amount < 0) Console.WriteLine("INVALID AMOUNT");
//            else
//            {
//                if (amount > balance) Console.WriteLine("INSUFFICIENT BALANCE");
//                else
//                {
//                    balance -= amount;
//                    Console.WriteLine("TAKE YOUR AMOUNT");
//                }
//            }
//        }
//        //Check account balance
//        static void CheckBalance()
//        {
//            Console.WriteLine("YOUR ACCOUNT BALANCE IS -:" + balance);
//        }
//        static void Main(string[] args)
//        {
//            ChooseRole();

//        }
//    }
//}
