using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.Collections.Collection
{
    internal class ShoppingCart
    {
        static Dictionary<string, double> prices = new Dictionary<string, double>();

        // Maintains insertion order (LinkedDictionary behavior)
        static List<string> order = new List<string>();

        static void Main()
        {
            Console.Write("Enter number of products: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter product name: ");
                string name = Console.ReadLine();

                Console.Write("Enter product price: ");
                double price = double.Parse(Console.ReadLine());

                AddItem(name, price);
                Console.WriteLine();
            }

            // Display in insertion order
            Console.WriteLine("Shopping Cart (Insertion Order):");
            foreach (string item in order)
            {
                Console.WriteLine(item + " : " + prices[item]);
            }

            // Display sorted by price
            Console.WriteLine("\nShopping Cart (Sorted by Price):");
            DisplaySortedByPrice();
        }

        static void AddItem(string product, double price)
        {
            if (!prices.ContainsKey(product))
            {
                prices[product] = price;
                order.Add(product);
            }
            else
            {
                Console.WriteLine("Duplicate product ignored: " + product);
            }
        }

        static void DisplaySortedByPrice()
        {
            SortedDictionary<double, List<string>> sorted =
                new SortedDictionary<double, List<string>>();

            foreach (string product in prices.Keys)
            {
                double price = prices[product];

                if (!sorted.ContainsKey(price))
                    sorted[price] = new List<string>();

                sorted[price].Add(product);
            }

            foreach (var entry in sorted)
            {
                foreach (string product in entry.Value)
                {
                    Console.WriteLine(product + " : " + entry.Key);
                }
            }
        }
    }
}
