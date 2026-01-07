using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.Encapsulation.EcommercePlatform
{
    public class EcommercePlatform
    {
        public static void Main(string[] args)
        {
            Product[] products = new Product[3];
            Electronics p1 = new Electronics();
            p1.ProductId = 1;
            p1.Name = "Asus";
            p1.Price = 70000;
            Clothing p2 = new Clothing();
            p2.ProductId = 2;
            p2.Name = "Jeans";
            p2.Price = 1000;
            Groceries p3 = new Groceries();
            p3.ProductId = 3;
            p3.Name = "Paneer";
            p3.Price = 190;
            products[0] = p1;
            products[1] = p2;
            products[2] = p3;
            ProductProcessor processor = new ProductProcessor();
            processor.showFinalPrices(products);
        }
    }
}
