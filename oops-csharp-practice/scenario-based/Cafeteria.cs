using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace bridge.Opps_senario
{
    class Cafeteria
    {
        //Dish which are available in cafeteria
        static string[] menu = { "Burger", "Pizza", "Pasta", "Salad" };
        //method to display menu
        public static void DisplayMenu()
        {
            Console.WriteLine("Cafeteria Menu:"); 
            for (int i = 0; i < menu.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {menu[i]}"); // Displaying menu items with index starting from 1
            }
            GetItemByIndex(); //calling get item by index method
        }
        public static void GetItemByIndex()
        {
            Console.WriteLine("Enter the index of the item you want to get (1-4):"); 
            int choose = int.Parse(Console.ReadLine()); // User input for index
            if (choose > menu.Length || choose < 1)
            {
                Console.WriteLine("Invalid index. Please try again.");
                return;
            }
            for (int i = 0; i < menu.Length; i++)
            {
                if (choose - 1 == i)
                {
                    Console.WriteLine($"You order  a  {menu[i]}"); // Displaying the selected item
                }
            }
        }
        //Main method
        static void Main(String[] args)
        {
           
            DisplayMenu(); //calling display menu method
        }
    }

}
