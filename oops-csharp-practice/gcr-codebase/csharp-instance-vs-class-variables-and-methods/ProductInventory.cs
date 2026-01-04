using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.Instance
{
    // Instance class Product
    class Product
    {
        // Static variable to keep track of total products created
        private static int totalProducts = 0;
        private string productName;
        private double price;
        internal Product(string productName, double price)
        {
            this.productName = productName;
            this.price = price;
            totalProducts++;
        }
        // Method to display product details
        public void ProductDetails()
        {
            Console.WriteLine();
            Console.WriteLine("        Product details               ");
            Console.WriteLine();

            Console.WriteLine("        Product Name " + productName);
            Console.WriteLine("        Product " + price);
            Console.WriteLine();

        }
        // Static method to display total products created
        public static void TotalProducts()
        {
            Console.WriteLine();
            Console.WriteLine("Total Number of products created so far: " + totalProducts);
        }
    }
    // Main class
    class ProductInventory
    {
        //  Main method
        public static void Main(String[] args)
        {
            Product pro1 = new Product("Iphone ", 100000);
            Product pro2 = new Product("Asus Pc", 60000);
            pro1.ProductDetails(); // Display product 1 details
            pro2.ProductDetails();//    Display product 2 details
            Product.TotalProducts();// Display total products created
        }
    }
}
