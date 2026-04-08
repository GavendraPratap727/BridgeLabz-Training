using System;

namespace bridge.DSA_Senario.FlashDealz
{
    class Menu
    {
        public void Run()
        {
            FlashManagerImpl manager = new FlashManagerImpl();
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("\n--- FlashDealz Menu ---");
                Console.WriteLine("1. Add Product");
                Console.WriteLine("2. Sort Products by Discount");
                Console.WriteLine("3. Display Deals");
                Console.WriteLine("4. Exit");
                Console.Write("Enter choice: ");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter product name: ");
                        string name = Console.ReadLine();

                        Console.Write("Enter discount (%): ");
                        double discount = double.Parse(Console.ReadLine());

                        manager.AddProduct(name, discount);
                        break;

                    case 2:
                        manager.SortProducts();
                        break;

                    case 3:
                        manager.DisplayDeals();
                        break;

                    case 4:
                        exit = true;
                        Console.WriteLine("Exiting FlashDealz...");
                        break;

                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            }
        }
    }
}
