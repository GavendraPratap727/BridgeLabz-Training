using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.Encapsulation.VegItem
{
    class NonVegItem : FoodItem, IDiscountable
    {
        private const double ExtraCharge = 50;

        public NonVegItem(string name, double price, int quantity)
            : base(name, price, quantity) { }

        public override double CalculatingTotalPrice()
        {
            return (Price * Quantity) + ExtraCharge;
        }

        public double ApplyDiscount()
        {
            return CalculatingTotalPrice() * 0.05;
        }

        public string GetDiscountDetails()
        {
            return "5% discount available on non-vegetarian items";
        }
    }

}
