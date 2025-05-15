using DbContext;
using Models;
using Repository.Interfaces;

namespace Repository;

public class ContactRepositroy : IContactRepository
{
    private readonly AppDbContext _context;
    public ContactRepositroy(AppDbContext context) => _context = context;

    public bool Add(Contact contact)
    {
        _context.Contacts.Add(contact);

        return _context.SaveChanges() > 0;
    }

    public bool Add(List<Contact> contacts)
    {
        _context.Contacts.AddRange(contacts);

        return _context.SaveChanges() > 0;
    }

    public IEnumerable<Contact> GetAll()
    {
        return _context.Contacts.ToList();
    }
}