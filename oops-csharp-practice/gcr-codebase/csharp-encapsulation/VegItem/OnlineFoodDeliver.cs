using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.Encapsulation.VegItem
{
    internal class OnlineFoodDeliver
    {
        static void Main()
        {
            FoodItem item1 = new VegItem("Hakka Noodle", 100, 2);
            FoodItem item2 = new NonVegItem("Chicken Wings", 250, 1);

            ViewBill(item1);
            ViewBill(item2);
        }

        static void ViewBill(FoodItem food)
        {
            food.GetItemDetails();

            double total = food.CalculatingTotalPrice();
            Console.WriteLine("Total amount to pay: " + total);

            if (food is IDiscountable discount)
            {
                Console.WriteLine("Offer Applied: " + discount.GetDiscountDetails());
                Console.WriteLine("You save: " + discount.ApplyDiscount());
            }

            Console.WriteLine("====================================");
        }
    }

}
