namespace ContactsApp.Core;

public class ContactService
{
    private readonly List<Contact> _contacts = new();
    private int _nextId = 1;

    public Contact AddContact(Contact contact)
    {
        contact.Id = _nextId++;
        _contacts.Add(contact);
        return contact;
    }

    public List<Contact> GetAllContacts() => _contacts;

    public Contact? GetContactById(int id)
        => _contacts.FirstOrDefault(c => c.Id == id);

    public List<Contact> SearchByName(string name)
        => _contacts.Where(c => c.Name.Contains(name, StringComparison.OrdinalIgnoreCase)).ToList();

    public bool UpdateContact(int id, Contact updated)
    {
        var contact = GetContactById(id);
        if (contact is null) return false;

        contact.Name = updated.Name;
        contact.PhoneNumber = updated.PhoneNumber;
        contact.Email = updated.Email;
        contact.Address = updated.Address;
        return true;
    }

    public bool DeleteContact(int id)
    {
        var contact = GetContactById(id);
        if (contact is null) return false;

        _contacts.Remove(contact);
        return true;
    }
}