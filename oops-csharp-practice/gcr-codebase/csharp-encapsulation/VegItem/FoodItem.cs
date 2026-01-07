using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.Encapsulation.VegItem
{
    abstract class FoodItem
    {
        public string ItemName { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        public FoodItem(string itemName, double price, int quantity)
        {
            ItemName = itemName;
            Price = price;
            Quantity = quantity;
        }

        public abstract double CalculatingTotalPrice();

        public void GetItemDetails()
        {
            Console.WriteLine("Item Name: " + ItemName + ", Price per unit: " + Price + ", Quantity ordered: " + Quantity);
        }
    }

}
