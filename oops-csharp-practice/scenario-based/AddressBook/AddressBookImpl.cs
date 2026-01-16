using System;
using System.Collections.Generic;

namespace bridge.AddressBook
{
    internal class AddressBookImpl : IAddressbook
    {
        private List<Contacts> contacts = new List<Contacts>();

        public void AddContact(Contacts contact)
        {
            if (contacts.Contains(contact))
            {
                Console.WriteLine("Duplicate contact found. Entry not allowed.");
                return;
            }

            contacts.Add(contact);
            Console.WriteLine("Contact added successfully.");
        }

        public void DisplayAllContacts()
        {
            if (contacts.Count == 0)
            {
                Console.WriteLine("No contacts found.");
                return;
            }

            foreach (Contacts c in contacts)
            {
                c.DisplayContact();
            }
        }

        public void EditContact(string firstName)
        {
            foreach (Contacts c in contacts)
            {
                if (c.FirstName.Equals(firstName))
                {
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

                    Console.Write("New Phone: ");
                    c.PhoneNumber = Console.ReadLine();

                    Console.Write("New Email: ");
                    c.Email = Console.ReadLine();

                    Console.WriteLine("Contact updated.");
                    return;
                }
            }
            Console.WriteLine("Contact not found.");
        }

        public void DeleteContact(string firstName)
        {
            Contacts removeContact = null;

            foreach (Contacts c in contacts)
            {
                if (c.FirstName.Equals(firstName))
                {
                    removeContact = c;
                    break;
                }
            }

            if (removeContact != null)
            {
                contacts.Remove(removeContact);
                Console.WriteLine("Contact deleted.");
            }
            else
            {
                Console.WriteLine("Contact not found.");
            }
        }

        // ✅ UC-8 METHODS
        public void SearchByCity(string city)
        {
            foreach (Contacts c in contacts)
            {
                if (c.City.Equals(city))
                {
                    c.DisplayContact();
                }
            }
        }

        public void SearchByState(string state)
        {
            foreach (Contacts c in contacts)
            {
                if (c.State.Equals(state))
                {
                    c.DisplayContact();
                }
            }
        }
    }
}
