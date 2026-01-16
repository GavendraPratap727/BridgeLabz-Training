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
                Console.WriteLine("3. View Persons by City");
                Console.WriteLine("4. View Persons by State");
                Console.WriteLine("5. Exit");

                int choice = int.Parse(Console.ReadLine());

                if (choice == 1)
                {
                    Console.Write("Enter Address Book Name: ");
                    bookNames[bookCount] = Console.ReadLine();
                    books[bookCount] = new AddressBookImpl();
                    bookCount++;
                    Console.WriteLine("Address Book created.");
                }
                else if (choice == 2)
                {
                    Console.Write("Enter Address Book Name: ");
                    string name = Console.ReadLine();
                    int index = FindBook(name);

                    if (index != -1)
                        AddressBookOperations(books[index]);
                    else
                        Console.WriteLine("Address Book not found.");
                }
                else if (choice == 3)
                {
                    ViewByCity();
                }
                else if (choice == 4)
                {
                    ViewByState();
                }
                else if (choice == 5)
                {
                    return;
                }
            }
        }

        private int FindBook(string name)
        {
            for (int i = 0; i < bookCount; i++)
            {
                if (bookNames[i].Equals(name))
                    return i;
            }
            return -1;
        }

        // UC-9 City View
        private void ViewByCity()
        {
            Console.Write("Enter City: ");
            string city = Console.ReadLine();

            for (int i = 0; i < bookCount; i++)
            {
                Contacts[] contacts = books[i].GetContacts();
                int count = books[i].GetCount();

                for (int j = 0; j < count; j++)
                {
                    if (contacts[j].City.Equals(city))
                    {
                        contacts[j].DisplayContact();
                    }
                }
            }
        }

        // UC-9 State View
        private void ViewByState()
        {
            Console.Write("Enter State: ");
            string state = Console.ReadLine();

            for (int i = 0; i < bookCount; i++)
            {
                Contacts[] contacts = books[i].GetContacts();
                int count = books[i].GetCount();

                for (int j = 0; j < count; j++)
                {
                    if (contacts[j].State.Equals(state))
                    {
                        contacts[j].DisplayContact();
                    }
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
