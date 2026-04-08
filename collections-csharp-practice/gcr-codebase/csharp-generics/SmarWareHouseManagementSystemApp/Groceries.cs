using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.Collections.Generics.SmarWareHouseManagementSystemApp
{
    public class Groceries : WareHouseSystem
    {
        public DateTime ExpiryDate { get; set; }

        public Groceries(string name, double price, DateTime expiry) : base(name, price)

        {
            ExpiryDate = expiry;
        }
        public override void Show()
        {
            Console.WriteLine($"Grocery: {Name}, Price: {Price}, Expiry: {ExpiryDate.ToShortDateString()}");
        }
    }
}
