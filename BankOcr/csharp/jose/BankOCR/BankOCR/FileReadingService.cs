using System.Security.Principal;

namespace BankOCR;

public class AccountNr
{
    public string[] Lines { get; set; }
}

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

        var linesFromFile = inputFromFile as string[] ?? inputFromFile.ToArray();
        
        // TODO: extract this to a function
        var howManyAccounts = linesFromFile.Length/4;
        var accounts = new List<AccountNr>();
        for (int i = 0; i < howManyAccounts; i++)
        {
            var currentAccount = new AccountNr
            {
                Lines = new[]
                {
                    linesFromFile[4 * i],
                    linesFromFile[4 * i + 1],
                    linesFromFile[4 * i + 2],
                    linesFromFile[4 * i + 3]
                }
            };
            accounts.Add(currentAccount);
        }
        
        // TODO: cleanup extra spaces, trim or something like that
        
        
        if (linesFromFile.Any(x => x.Length != charLimit1))
        {
            throw new InvalidDataException();
        }

        // TODO: return accounts, not this
        return linesFromFile;
    }
}