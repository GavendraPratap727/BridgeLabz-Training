using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.AddressBook
{

    internal interface IAddressbook
    {
        void AddContact(Contacts contact);
        void DisplayAllContacts();
        void EditContact(string firstName);
    }
}
