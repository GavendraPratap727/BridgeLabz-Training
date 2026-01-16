using System;

namespace bridge.AddressBook
{
    internal class AddressBookImpl : IAddressbook
    {
        private Contacts[] contacts = new Contacts[50];
        private int count = 0;

        public void AddContact(Contacts contact)
        {
            for (int i = 0; i < count; i++)
            {
                if (contacts[i].Equals(contact))
                {
                    Console.WriteLine("Duplicate contact. Not added.");
                    return;
                }
            }

            contacts[count++] = contact;
            Console.WriteLine("Contact added successfully.");
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
            for (int i = 0; i < count; i++)
            {
                if (contacts[i].FirstName.Equals(firstName))
                {
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

                    Console.Write("New Phone: ");
                    contacts[i].PhoneNumber = Console.ReadLine();

                    Console.Write("New Email: ");
                    contacts[i].Email = Console.ReadLine();

                    Console.WriteLine("Contact updated.");
                    return;
                }
            }
            Console.WriteLine("Contact not found.");
        }

        public void DeleteContact(string firstName)
        {
            for (int i = 0; i < count; i++)
            {
                if (contacts[i].FirstName.Equals(firstName))
                {
                    for (int j = i; j < count - 1; j++)
                    {
                        contacts[j] = contacts[j + 1];
                    }
                    count--;
                    Console.WriteLine("Contact deleted.");
                    return;
                }
            }
            Console.WriteLine("Contact not found.");
        }

        public Contacts[] GetContacts()
        {
            return contacts;
        }

        public int GetCount()
        {
            return count;
        }
    }
}
