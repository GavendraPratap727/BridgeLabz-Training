using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace bridge.AddressBook
{
    internal class AddressBookMenu
    {
        private string[] bookNames = new string[10];
        private AddressBookImpl[] books = new AddressBookImpl[10];
        private int bookCount = 0;

        public void ShowMenu()
        {
            while (true)
            {
                Console.WriteLine("\n1. Add Address Book");
                Console.WriteLine("2. Open Address Book");
                Console.WriteLine("3. Exit");

                int choice = int.Parse(Console.ReadLine());

                if (choice == 1)
                {
                    Console.Write("Enter Address Book Name: ");
                    string name = Console.ReadLine();

                    if (FindBook(name) != -1)
                    {
                        Console.WriteLine("Address Book already exists.");
                    }
                    else
                    {
                        bookNames[bookCount] = name;
                        books[bookCount] = new AddressBookImpl();
                        bookCount++;
                        Console.WriteLine("Address Book created.");
                    }
                }
                else if (choice == 2)
                {
                    Console.Write("Enter Address Book Name: ");
                    string name = Console.ReadLine();
                    int index = FindBook(name);

                    if (index == -1)
                    {
                        Console.WriteLine("Address Book not found.");
                    }
                    else
                    {
                        AddressBookOperations(books[index]);
                    }
                }
                else if (choice == 3)
                {
                    return;
                }
                else
                {
                    Console.WriteLine("Invalid choice.");
                }
            }
        }

        private int FindBook(string name)
        {
            for (int i = 0; i < bookCount; i++)
            {
                if (bookNames[i].Equals(name))
                {
                    return i;
                }
            }
            return -1;
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

