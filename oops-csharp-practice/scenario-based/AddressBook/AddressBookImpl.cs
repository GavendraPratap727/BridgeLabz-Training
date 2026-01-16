using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.AddressBook
{
    internal class AddressBookImpl : IAddressbook
    {
        private List<Contacts> contacts = new List<Contacts>();

        public void AddContact(Contacts contact)
        {
            contacts.Add(contact);
            Console.WriteLine("Contact added successfully.");
        }

        public void DisplayAllContacts()
        {
            if (contacts.Count == 0)
            {
                Console.WriteLine("No contacts available.");
                return;
            }

            foreach (Contacts c in contacts)
            {
                c.DisplayContact();
            }
        }

        public void EditContact(string firstName)
        {
            bool found = false;

            foreach (Contacts c in contacts)
            {
                if (c.FirstName.Equals(firstName))
                {
                    found = true;

                    Console.Write("New Last Name: ");
                    c.LastName = Console.ReadLine();

                    Console.Write("New Address: ");
                    c.Address = Console.ReadLine();

                    Console.Write("New City: ");
                    c.City = Console.ReadLine();

                    Console.Write("New State: ");
                    c.State = Console.ReadLine();

                    Console.Write("New Zip: ");
                    c.Zip = Console.ReadLine();

                    Console.Write("New Phone Number: ");
                    c.PhoneNumber = Console.ReadLine();

                    Console.Write("New Email: ");
                    c.Email = Console.ReadLine();

                    Console.WriteLine("Contact updated successfully.");
                    break;
                }
            }

            if (!found)
            {
                Console.WriteLine("Contact not found.");
            }
        }

        public void DeleteContact(string firstName)
        {
            Contacts deleteContact = null;

            foreach (Contacts c in contacts)
            {
                if (c.FirstName.Equals(firstName))
                {
                    deleteContact = c;
                    break;
                }
            }

            if (deleteContact != null)
            {
                contacts.Remove(deleteContact);
                Console.WriteLine("Contact deleted successfully.");
            }
            else
            {
                Console.WriteLine("Contact not found.");
            }
        }
    }
}
