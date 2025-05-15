using Models;

namespace Repository.Interfaces;

public interface IContactRepository
{
    IEnumerable<Contact> GetAll();
    bool Add(Contact contact);
    bool Add(List<Contact> contacts);
}