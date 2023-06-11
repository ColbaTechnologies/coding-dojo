namespace BankOCR;

public class OcrWorker
{
    public string ReadAccountNumbers()
    {
        const int charLimit = 27;

        var fileService = new FileReadingService();
        var linesFromFile = fileService.ReadLinesFromFile(charLimit);

        var converter = new Converter();
        var numbersRead = converter.ConvertIntoNumbers(linesFromFile, charLimit);

        var finder = new NumberFinder();
        var s = finder.FindNumber(numbersRead);
        return s;
    }
}