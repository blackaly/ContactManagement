using Services.Interfaces;

namespace Validation.Interfaces;

public interface IFileValidation
{
    public bool Validate(string file);
}