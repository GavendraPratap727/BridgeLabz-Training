using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.Encapsulation.EcommercePlatform
{
    public abstract class Product
    {
        private int productId;
        private string name;
        private double price;
        public int ProductId
        {
            get { return productId; }
            set { productId = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public double Price
        {
            get { return price; }
            set { price = value; }
        }
        public abstract double CalculateDiscount();
    }
}
