using Models;
using Services.Interfaces;

namespace Services;

public class ParseFromFile : IParseFromFile
{
    public List<Contact> Parse(string[] content)
    {

        if (content.Length == 0) return new List<Contact>();
        List<Contact> contacts = new();

        for (int i = 1; i < content.Length; ++i)
        {
            var columns = content[i].Split(',');
            if (columns.Length > 4) continue;

            Contact c = new()
            {
                FirstName = columns[0].Trim(),
                LastName = columns[1].Trim(),
                PhoneNumber = columns[2].Trim()
            };

            contacts.Add(c);
        }

        return contacts;

    }
}