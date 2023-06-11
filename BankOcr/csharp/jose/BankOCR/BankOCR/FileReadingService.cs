namespace BankOCR;

public class FileReadingService
{
    private readonly string _fileName;
    public FileReadingService(string name)
    {
        _fileName = name;
    }
    public IEnumerable<Account> ReadLinesFromFile(int charLimit)
    {
        var path = string.Concat(Directory.GetCurrentDirectory(), "/", _fileName);
        var inputFromFile = File.ReadLines(path);

        var linesFromFile = inputFromFile as string[] ?? inputFromFile.ToArray();
        
        // TODO: extract this to a function
        var accounts = SeparateIntoAccounts(linesFromFile, charLimit);

        return accounts;
    }
    private static IEnumerable<Account> SeparateIntoAccounts(IReadOnlyList<string> linesFromFile, int charLimit)
    {
        var howManyAccounts = linesFromFile.Count / 4;
        var accounts = new List<Account>();
        for (int i = 0; i < howManyAccounts; i++)
        {
            var currentAccount = new Account
            {
                Lines = new[]
                {
                    linesFromFile[4 * i][..charLimit],
                    linesFromFile[4 * i + 1][..charLimit],
                    linesFromFile[4 * i + 2][..charLimit],
                }
            };
            accounts.Add(currentAccount);
        }

        return accounts;
    }
}