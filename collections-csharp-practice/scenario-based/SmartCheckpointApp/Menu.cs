using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.Collections.Senario.SmartCheckpointApp
{
    class Menu
    {
        public static void Start()
        {
            ICheckoutUtility checkout = new CheckoutUtility();
            int choice;

            do
            {
                Console.WriteLine("\n--- Smart Checkout Menu ---");
                Console.WriteLine("1. Add Customer");
                Console.WriteLine("2. Remove Customer");
                Console.WriteLine("3. Process Checkout");
                Console.WriteLine("4. Exit");
                Console.Write("Enter choice: ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter customer name: ");
                        checkout.AddCustomer(Console.ReadLine());
                        break;

                    case 2:
                        checkout.RemoveCustomer();
                        break;

                    case 3:
                        checkout.ProcessCheckout();
                        break;
                }

            } while (choice != 4);
        }
    }
}
