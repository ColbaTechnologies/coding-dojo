
using BankOCR;

const int charLimit = 27;

var fileService = new FileReadingService();
var linesFromFile = fileService.ReadLinesFromFile(charLimit);

var converter = new Converter();
var numbersRead = converter.ConvertIntoNumbers(linesFromFile, charLimit);

var finder = new NumberFinder();
var decypheredNumber = finder.FindNumber(numbersRead);

Console.WriteLine(decypheredNumber);


