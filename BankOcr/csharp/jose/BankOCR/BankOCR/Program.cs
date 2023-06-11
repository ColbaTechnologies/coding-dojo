
using BankOCR;

const int charLimit = 27;

var fileService = new FileReadingService();
var linesFromFile = fileService.ReadLinesFromFile(charLimit);

var converter = new Converter();
var numbersRead = converter.ConvertIntoNumbers(linesFromFile, charLimit);


foreach (var line in numbersRead)
{
    Console.WriteLine(line);
}