namespace BankOCR;

public class OcrWorker
{
    private readonly FileReadingService _fileService;
    private readonly NumberFinder _finder;
    private readonly AccountFixer _fixer;

    public OcrWorker(string name = "MachineInput.txt")
    {
        _fileService = new FileReadingService(name);
        _finder = new NumberFinder();
        _fixer = new AccountFixer();
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
            if (account.FinalNumber.Length > 9)
            {
                account.FinalNumber = _fixer.TryToFixAccountNr(account);
            }
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
        else if (!account.ValidateChecksum())
        {
            account.FinalNumber += " ERR";
        }
    }
}