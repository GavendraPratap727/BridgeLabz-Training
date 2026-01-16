using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.AddressBook
{
    internal class AddressBookMenu
    {
        public void ShowMenu(AddressBookImpl book)
        {
            while (true)
            {
                Console.WriteLine("1. Add Contact");
                Console.WriteLine("2. Display Contacts");
                Console.WriteLine("3. For Exit");
                int choice = int.Parse(Console.ReadLine());
                if (choice == 1)
                {
                    Console.Write("First Name: ");
                    string fname = Console.ReadLine();
                    Console.Write("Last Name: ");
                    string lname = Console.ReadLine();
                    Console.Write("Address: ");
                    string address = Console.ReadLine();
                    Console.Write("City: ");
                    string city = Console.ReadLine();
                    Console.Write("State: ");
                    string state = Console.ReadLine();
                    Console.Write("Zip: ");
                    string zip = Console.ReadLine();
                    Console.Write("Phone Number: ");
                    string phone = Console.ReadLine();
                    Console.Write("Email: ");
                    string email = Console.ReadLine();
                    Contacts c = new Contacts(fname, lname, address, city, state, zip, phone, email);
                    book.AddContact(c);
                }
                else if (choice == 2)
                {
                    book.DisplayAllContacts();
                }
                else if (choice == 3) return;
                else
                {
                    Console.WriteLine("Invalid choice");
                }
            }
        }
    }
}
