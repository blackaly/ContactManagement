using Models;

namespace Services.Interfaces;

public interface IParseFromFile
{
    public List<Contact> Parse(string[] content);
}