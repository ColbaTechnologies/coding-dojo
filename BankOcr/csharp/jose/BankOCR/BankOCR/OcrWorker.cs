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

        foreach (var account in accountsFromFile)
        {
            account.NumberBlocks = _converter.ConvertIntoNumbers(account.Lines, charLimit);
            account.FinalNumber = _finder.FindNumber(account.NumberBlocks);
        }

        return accountsFromFile;
    }
}