using System;
using System.Collections.Generic;

namespace bridge.AddressBook
{
    internal class AddressBookMenu
    {
        private Dictionary<string, AddressBookImpl> books =
            new Dictionary<string, AddressBookImpl>();

        public void ShowMenu()
        {
            while (true)
            {
                Console.WriteLine("\n1. Add Address Book");
                Console.WriteLine("2. Open Address Book");
                Console.WriteLine("3. Search Person");
                Console.WriteLine("4. Exit");

                int choice = int.Parse(Console.ReadLine());

                if (choice == 1)
                {
                    Console.Write("Enter Address Book Name: ");
                    string name = Console.ReadLine();

                    if (!books.ContainsKey(name))
                    {
                        books[name] = new AddressBookImpl();
                        Console.WriteLine("Address Book created.");
                    }
                    else
                    {
                        Console.WriteLine("Address Book already exists.");
                    }
                }
                else if (choice == 2)
                {
                    Console.Write("Enter Address Book Name: ");
                    string name = Console.ReadLine();

                    if (books.ContainsKey(name))
                    {
                        AddressBookOperations(books[name]);
                    }
                    else
                    {
                        Console.WriteLine("Address Book not found.");
                    }
                }
                else if (choice == 3)
                {
                    SearchAcrossAllBooks();
                }
                else if (choice == 4)
                {
                    return;
                }
            }
        }

        private void SearchAcrossAllBooks()
        {
            Console.WriteLine("1. Search by City");
            Console.WriteLine("2. Search by State");
            int choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                Console.Write("Enter City: ");
                string city = Console.ReadLine();

                foreach (var book in books.Values)
                {
                    book.SearchByCity(city);
                }
            }
            else if (choice == 2)
            {
                Console.Write("Enter State: ");
                string state = Console.ReadLine();

                foreach (var book in books.Values)
                {
                    book.SearchByState(state);
                }
            }
        }

        private void AddressBookOperations(AddressBookImpl book)
        {
            while (true)
            {
                Console.WriteLine("\n1. Add Contact");
                Console.WriteLine("2. Display Contacts");
                Console.WriteLine("3. Edit Contact");
                Console.WriteLine("4. Delete Contact");
                Console.WriteLine("5. Back");

                int choice = int.Parse(Console.ReadLine());

                if (choice == 1)
                {
                    Console.Write("First Name: ");
                    string fn = Console.ReadLine();
                    Console.Write("Last Name: ");
                    string ln = Console.ReadLine();
                    Console.Write("Address: ");
                    string ad = Console.ReadLine();
                    Console.Write("City: ");
                    string city = Console.ReadLine();
                    Console.Write("State: ");
                    string state = Console.ReadLine();
                    Console.Write("Zip: ");
                    string zip = Console.ReadLine();
                    Console.Write("Phone: ");
                    string phone = Console.ReadLine();
                    Console.Write("Email: ");
                    string email = Console.ReadLine();

                    book.AddContact(new Contacts(fn, ln, ad, city, state, zip, phone, email));
                }
                else if (choice == 2)
                {
                    book.DisplayAllContacts();
                }
                else if (choice == 3)
                {
                    Console.Write("Enter First Name: ");
                    book.EditContact(Console.ReadLine());
                }
                else if (choice == 4)
                {
                    Console.Write("Enter First Name: ");
                    book.DeleteContact(Console.ReadLine());
                }
                else if (choice == 5)
                {
                    return;
                }
            }
        }
    }
}
