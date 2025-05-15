using Services.Interfaces;
using Validation.Interfaces;

namespace Validation;

public class CsvFileValidation : IFileValidation
{
    public bool Validate(string file)
    => !string.IsNullOrEmpty(file) && Path.GetExtension(file).Equals(".csv", StringComparison.OrdinalIgnoreCase);
    
}