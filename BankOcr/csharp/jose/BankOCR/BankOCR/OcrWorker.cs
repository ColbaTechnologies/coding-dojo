namespace BankOCR;

public class OcrWorker
{
    private readonly FileReadingService _fileService;
    private readonly Converter _converter;
    private readonly NumberFinder _finder;

    public OcrWorker(string name = "MachineInput.txt")
    {
        _fileService = new FileReadingService(name);
        _converter = new Converter();
        _finder = new NumberFinder();
    }
    
    public IEnumerable<Account> ReadAccountNumbers()
    {
        const int charLimit = 27;
        var accountsFromFile = _fileService.ReadLinesFromFile(charLimit);

        var accounts = accountsFromFile as Account[] ?? accountsFromFile.ToArray();
        foreach (var account in accounts)
        {
            account.NumberBlocks = Converter.ConvertIntoNumbers(account.Lines, charLimit);
            SetFinalNumberWithErrorMessages(account);
        }

        return accounts;
    }
    
    private void SetFinalNumberWithErrorMessages(Account account)
    {
        account.FinalNumber = _finder.FindNumber(account.NumberBlocks);
        if (account.FinalNumber.Contains('?'))
        {
            account.FinalNumber += " ILL";
        }
        else if (!account.ValidateNumber())
        {
            account.FinalNumber += " ERR";
        }
    }
}