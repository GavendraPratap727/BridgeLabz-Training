namespace bridge.AddressBook
{
    internal interface IAddressbook
    {
        void AddContact(Contacts contact);
        void DisplayAllContacts();
        void EditContact(string firstName);
        void DeleteContact(string firstName);

        Contacts[] GetContacts();
        int GetCount();

        void SortByName();
    }
}
