using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.lkfdghkjf
{
    class Product
    {
        public string ItemName { get; set; }
        public double Cost { get; set; }
        public Product(string inputName, double inputPrice)
        {
            ItemName = inputName;
            Cost = inputPrice;
        }
        public void DisplayProduct()
        {
            Console.WriteLine(ItemName + " - " + Cost);
        }
    }

    class Order
    {
        public int OrderNo { get; set; }
        private List<Product> productList = new List<Product>();
        public Order(int inputOrderNo)
        {
            OrderNo = inputOrderNo;
        }
        public void AddItem(Product item)
        {
            productList.Add(item);
        }
        public void ShowOrderDetails()
        {
            Console.WriteLine("Order ID: " + OrderNo);
            Console.WriteLine("Products in this order:");
            double sum = 0;
            foreach (Product p in productList)
            {
                p.DisplayProduct();
                sum += p.Cost;
            }
            Console.WriteLine("Total Amount: " + sum);
            Console.WriteLine();
        }
    }

    class Customer
    {
        public string CustomerName { get; set; }
        public Customer(string inputName)
        {
            CustomerName = inputName;
        }
        public void CreateOrder(Order ord)
        {
            Console.WriteLine(CustomerName + " placed Order ID " + ord.OrderNo);
            ord.ShowOrderDetails();
        }
    }

    class Ecommers
    {
        public static void Main(string[] args)
        {
            Product pro1 = new Product("MAC", 100000);
            Product pro2 = new Product("PC", 50000);
            Product pro3 = new Product("CPU", 3000);
            Customer cust = new Customer("Rishita");
            Order order1 = new Order(99);
            order1.AddItem(pro1);
            order1.AddItem(pro2);
            order1.AddItem(pro3);
            cust.CreateOrder(order1);
        }
    }
}
