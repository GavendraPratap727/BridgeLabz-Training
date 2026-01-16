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
                Console.WriteLine("No contacts available.");
                return;
            }

            for (int i = 0; i < count; i++)
            {
                contacts[i].DisplayContact();
            }
        }
    }
}
