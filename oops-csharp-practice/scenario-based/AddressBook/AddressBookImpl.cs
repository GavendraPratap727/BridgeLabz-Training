using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.AddressBook
{
    internal class AddressBookImpl : IAddressbook
    {
        private Contacts[] contacts = new Contacts[10];
        private int count = 0;

        public void AddContact(Contacts contact)
        {
            if (count < contacts.Length)
            {
                contacts[count] = contact;
                count++;
                Console.WriteLine("Contact added successfully.");
            }
            else
            {
                Console.WriteLine("Address Book is full.");
            }
        }

        public void DisplayAllContacts()
        {
            if (count == 0)
            {
                Console.WriteLine("No contacts found.");
                return;
            }

            for (int i = 0; i < count; i++)
            {
                contacts[i].DisplayContact();
            }
        }

        public void EditContact(string firstName)
        {
            bool found = false;

            for (int i = 0; i < count; i++)
            {
                if (contacts[i].FirstName.Equals(firstName))
                {
                    found = true;

                    Console.Write("New Last Name: ");
                    contacts[i].LastName = Console.ReadLine();

                    Console.Write("New Address: ");
                    contacts[i].Address = Console.ReadLine();

                    Console.Write("New City: ");
                    contacts[i].City = Console.ReadLine();

                    Console.Write("New State: ");
                    contacts[i].State = Console.ReadLine();

                    Console.Write("New Zip: ");
                    contacts[i].Zip = Console.ReadLine();

                    Console.Write("New Phone Number: ");
                    contacts[i].PhoneNumber = Console.ReadLine();

                    Console.Write("New Email: ");
                    contacts[i].Email = Console.ReadLine();

                    Console.WriteLine("Contact updated successfully.");
                    break;
                }
            }

            if (!found)
            {
                Console.WriteLine("Contact not found.");
            }
        }

        // ✅ VERSION 4 FEATURE
        public void DeleteContact(string firstName)
        {
            bool found = false;

            for (int i = 0; i < count; i++)
            {
                if (contacts[i].FirstName.Equals(firstName))
                {
                    found = true;

                    for (int j = i; j < count - 1; j++)
                    {
                        contacts[j] = contacts[j + 1];
                    }

                    contacts[count - 1] = null;
                    count--;

                    Console.WriteLine("Contact deleted successfully.");
                    break;
                }
            }

            if (!found)
            {
                Console.WriteLine("Contact not found.");
            }
        }
    }
}
