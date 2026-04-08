using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.Collections.Generics.SmarWareHouseManagementSystemApp
{
    public class Electronics : WareHouseSystem
    {
        public int WarrantyYears { get; set; }
        public Electronics(string name, double price, int warranty) : base(name, price)
        {
            WarrantyYears = warranty;
        }
        public override void Show()
        {
            Console.WriteLine($"Electronics: {Name}, Price: {Price}, Warranty: {WarrantyYears} years");
        }
    }
}
