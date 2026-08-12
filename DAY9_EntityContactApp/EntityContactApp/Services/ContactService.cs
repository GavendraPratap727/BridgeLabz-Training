using EntityContactApp.Models;
using EntityContactApp.Repositories;

namespace EntityContactApp.Services;

public class ContactService : IContactService
{
    private readonly IContactRepository _repository;

    public ContactService(IContactRepository repository)
    {
        _repository = repository;
    }

    public async Task<IEnumerable<Contact>> GetAllContactsAsync()
    {
        return await _repository.GetAllAsync();
    }

    public async Task<Contact?> GetContactAsync(int id)
    {
        return await _repository.GetByIdAsync(id);
    }

    public async Task<Contact> CreateContactAsync(Contact contact)
    {
        return await _repository.AddAsync(contact);
    }

    public async Task<bool> UpdateContactAsync(int id, Contact contact)
    {
        contact.Id = id;

        return await _repository.UpdateAsync(contact);
    }

    public async Task<bool> DeleteContactAsync(int id)
    {
        return await _repository.DeleteAsync(id);
    }
}