using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.Collections.Generics.SmarWareHouseManagementSystemApp
{
    public abstract class WareHouseSystem
    {
        public string Name { get; set; }
        public double Price { get; set; }
        protected WareHouseSystem(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public abstract void Show();
    }
}
