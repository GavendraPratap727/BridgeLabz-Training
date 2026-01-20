using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.Collections.Generics.SmarWareHouseManagementSystemApp
{
    public class Furniture : WareHouseSystem
    {
        public string Material { get; set; }
        public Furniture(string name, double price, string material) : base(name, price)
        {
            Material = material;
        }
        public override void Show()
        {
            Console.WriteLine($"Furniture: {Name}, Price: {Price}, Material: {Material}");
        }
    }
}
