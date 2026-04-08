using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.Collections.Senario.SmartCheckpointApp
{
    class CheckoutUtility : ICheckoutUtility
    {
        Queue<Customer> queue = new Queue<Customer>();

        Dictionary<string, double> priceMap = new Dictionary<string, double>();
        Dictionary<string, int> stockMap = new Dictionary<string, int>();

        public CheckoutUtility()
        {
            priceMap["Milk"] = 50;
            stockMap["Milk"] = 10;

            priceMap["Bread"] = 40;
            stockMap["Bread"] = 8;

            priceMap["Eggs"] = 6;
            stockMap["Eggs"] = 30;
        }

        public void AddCustomer(string name)
        {
            Console.Write("Enter number of items: ");
            int n = int.Parse(Console.ReadLine());

            List<string> items = new List<string>();
            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter item name: ");
                items.Add(Console.ReadLine());
            }

            queue.Enqueue(new Customer(name, items));
            Console.WriteLine(name + " added to checkout queue.");
        }

        public void RemoveCustomer()
        {
            if (queue.Count == 0)
            {
                Console.WriteLine("Queue is empty.");
                return;
            }

            Customer c = queue.Dequeue();
            Console.WriteLine(c.GetName() + " removed from queue.");
        }

        public void ProcessCheckout()
        {
            if (queue.Count == 0)
            {
                Console.WriteLine("No customers to process.");
                return;
            }

            Customer c = queue.Dequeue();
            double total = 0;

            Console.WriteLine("\nBilling for " + c.GetName());

            foreach (string item in c.GetItems())
            {
                if (!priceMap.ContainsKey(item))
                {
                    Console.WriteLine(item + " not available.");
                    continue;
                }

                if (stockMap[item] <= 0)
                {
                    Console.WriteLine(item + " out of stock.");
                    continue;
                }

                total += priceMap[item];
                stockMap[item]--;

                Console.WriteLine(item + " : " + priceMap[item]);
            }

            Console.WriteLine("Total Bill = " + total);
        }
    }

}
