using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.Seiled_class
{
    public class Item
    {
        public static double offerRate = 10.0;
        public readonly int itemCode;
        public string itemTitle;
        public double itemCost;
        public int itemCount;

        public Item(int code, string title, double cost, int count)
        {
            itemCode = code;
            itemTitle = title;
            itemCost = cost;
            itemCount = count;
        }

        public static void ChangeOffer(double updatedRate)
        {
            offerRate = updatedRate;
            Console.WriteLine("Updated Discount " + offerRate + "%");
        }

        public void ShowItemInfo(object obj)
        {
            if (obj is Item)
            {
                Console.WriteLine("Item Code " + itemCode);
                Console.WriteLine("Item Name " + itemTitle);
                Console.WriteLine("Price " + itemCost);
                Console.WriteLine("Quantity " + itemCount);
                Console.WriteLine("Discount " + offerRate + "%");
            }
            else    Console.WriteLine("Invalid item ");
        }
    }
    class CartManager
    {
        static void Main(string[] args)
        {
            Item firstItem = new Item(1, "Laptop", 60000, 1);
            Item secondItem = new Item(2, "Mouse", 800, 2);
            firstItem.ShowItemInfo(firstItem);
            Console.WriteLine();
            secondItem.ShowItemInfo(secondItem);
            Console.WriteLine();
            Item.ChangeOffer(15.0);
            Console.WriteLine();
            firstItem.ShowItemInfo(firstItem);
        }
    }
}
