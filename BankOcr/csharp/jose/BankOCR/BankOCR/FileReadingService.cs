namespace BankOCR;

public class FileReadingService
{
    public string[] ReadLinesFromFile(int charLimit1)
    {
        var path = Directory.GetCurrentDirectory() + "/MachineInput.txt";
        var inputFromFile = File.ReadLines(path);

        var strings = inputFromFile as string[] ?? inputFromFile.ToArray();
        if (strings.Any(x => x.Length != charLimit1))
        {
            throw new InvalidDataException();
        }

        return strings;
    }
}