using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.LinkedListttt
{
    internal class InventaryManagementSystem
    {
        static LinkedList<(int id, string name, int qty, double price)> items= new LinkedList<(int, string, int, double)>();
        static void Main(string[] args)
        {
            AddFirst(1, "Pen", 40, 10);
            AddLast(2, "Book", 20, 80);
            AddLast(3, "Pencil", 100, 5);
            Console.WriteLine("All Items:");
            ShowAll();
            Console.WriteLine("Update Quantity:");
            UpdateQty(1, 60);
            Console.WriteLine("Search by Name:");
            SearchByName("Book");
            Console.WriteLine("Total Inventory Value:");
            TotalValue();
            Console.WriteLine("Sort by Price (Ascending):");
            SortByPrice(true);
            ShowAll();
            Console.WriteLine("Remove Item ID 2:");
            RemoveById(2);
            ShowAll();
        }
        static void AddFirst(int id, string name, int qty, double price)
        {
            items.AddFirst((id, name, qty, price));
        }
        static void AddLast(int id, string name, int qty, double price)
        {
            items.AddLast((id, name, qty, price));
        }
        static void RemoveById(int id)
        {
            var node = items.First;
            while (node != null)
            {
                if (node.Value.id == id)
                {
                    items.Remove(node);
                    Console.WriteLine("Item removed");
                    return;
                }
                node = node.Next;
            }
            Console.WriteLine("Item not found");
        }
        static void UpdateQty(int id, int newQty)
        {
            var node = items.First;

            while (node != null)
            {
                if (node.Value.id == id)
                {
                    node.Value = (node.Value.id, node.Value.name, newQty, node.Value.price);
                    Console.WriteLine("Quantity updated");
                    return;
                }
                node = node.Next;
            }

            Console.WriteLine("Item not found");
        }
        static void SearchByName(string name)
        {
            bool found = false;

            foreach (var x in items)
            {
                if (x.name.ToLower() == name.ToLower())
                {
                    Print(x);
                    found = true;
                }
            }
            if (!found)
                Console.WriteLine("Item not found");
        }
        static void TotalValue()
        {
            double sum = 0;

            foreach (var x in items)
            {
                sum += x.qty * x.price;
            }

            Console.WriteLine(sum);
        }
        static void SortByPrice(bool asc)
        {
            for (var i = items.First; i != null; i = i.Next)
            {
                for (var j = i.Next; j != null; j = j.Next)
                {
                    if ((asc && i.Value.price > j.Value.price) ||
                        (!asc && i.Value.price < j.Value.price))
                    {
                        var temp = i.Value;
                        i.Value = j.Value;
                        j.Value = temp;
                    }
                }
            }
        }
        static void ShowAll()
        {
            if (items.Count == 0)
            {
                Console.WriteLine("Inventory empty");
                return;
            }

            foreach (var x in items)
            {
                Print(x);
            }
        }
        static void Print((int id, string name, int qty, double price) x)
        {
            Console.WriteLine("ID: " + x.id + ", Name: " + x.name + ", Qty: " + x.qty + ", Price: " + x.price);
        }
    }
}
