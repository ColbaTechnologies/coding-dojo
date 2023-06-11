namespace BankOCR;

public class FileReadingService
{
    private readonly string _fileName;
    public FileReadingService(string name)
    {
        _fileName = name;
    }
    public string[] ReadLinesFromFile(int charLimit1)
    {
        var path = string.Concat(Directory.GetCurrentDirectory(), "/", _fileName);
        var inputFromFile = File.ReadLines(path);

        var strings = inputFromFile as string[] ?? inputFromFile.ToArray();
        if (strings.Any(x => x.Length != charLimit1))
        {
            throw new InvalidDataException();
        }

        return strings;
    }
}