using Models;
using Repository.Interfaces;
using Services.Interfaces;
using Validation.Interfaces;

namespace Files;

public class ExcelFile : IContactFile
{
    public string Path { get; set; }
    private IContactRepository _repo;
    private IParseFromFile _parse;
    private IReadFromFile _read;
    private IFileValidation _validation;
    public ExcelFile(IContactRepository repo, IParseFromFile parse,
    IReadFromFile read, IFileValidation validation)
    {
        _repo = repo;
        _parse = parse;
        _read = read;
        _validation = validation;

    }

    public bool AddContactToDatabase()
    {
        if (!_validation.Validate(this.Path)) return false;
        
        List<Contact> c = _parse.Parse(_read.ReadFile(this));
        if (_repo.Add(c)) return true;

        return false;
    }

    public void PrintContacts()
    {
        var data = _repo.GetAll();

        foreach (var i in data)
        {
            Console.WriteLine($"First Name: ${i.FirstName}\n Last Name: {i.LastName}\nPhone Number: {i.PhoneNumber}");
        }
    }

}