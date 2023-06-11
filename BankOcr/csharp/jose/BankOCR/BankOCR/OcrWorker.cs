namespace BankOCR;

public class OcrWorker
{
    private readonly string _fileName;

    public OcrWorker(string name = "MachineInput.txt")
    {
        _fileName = name;
    }
    public string ReadAccountNumbers()
    {
        const int charLimit = 27;

        var fileService = new FileReadingService(_fileName);
        var linesFromFile = fileService.ReadLinesFromFile(charLimit);

        var converter = new Converter();
        var numbersRead = converter.ConvertIntoNumbers(linesFromFile, charLimit);

        var finder = new NumberFinder();
        var s = finder.FindNumber(numbersRead);
        return s;
    }
}