namespace Services.Interfaces;

public interface IReadFromFile
{
    public string[] ReadFile(IContactFile file);
}