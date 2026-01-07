using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.Encapsulation.LibraryManagement
{
    internal class LibraryManagement
    {
        static void Main()
        {
            Console.WriteLine("=== LIBRARY MANAGEMENT SYSTEM ===");
            Console.WriteLine();

            List<LibraryItem> items = new List<LibraryItem>();
            items.Add(new Book(1, "C# Programming", "John Smith", 500));
            items.Add(new Magazine(2, "Tech Today", "Editor", "Jan 2024"));
            items.Add(new DVD(3, "Learning OOP", "Director", 120));

            Console.WriteLine("=== LIBRARY ITEMS ===");
            foreach (LibraryItem item in items)
            {
                item.GetItemDetails();

                if (item is IReservable)
                {
                    IReservable reservable = (IReservable)item;
                    bool available = reservable.CheckAvailability();
                    Console.WriteLine("Available: " + available);

                    if (available)
                    {
                        reservable.ReserveItem("Student123");
                    }
                }
            }
        }
    }
}
