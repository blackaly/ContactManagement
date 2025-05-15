using Services.Interfaces;
using Validation;
using Validation.Interfaces;

namespace Services;

public class ReadFromFile : IReadFromFile
{
    private readonly IFileValidation _validation;

    public ReadFromFile(IFileValidation validation)
    {
        this._validation = validation;
    }
    public string[] ReadFile(IContactFile file)
    {

        if (_validation.Validate(file.Path))
        {
            return File.ReadAllLines(file.Path);
        }

        return [];
    }
}