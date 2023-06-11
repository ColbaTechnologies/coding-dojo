
using BankOCR;

var worker = new OcrWorker();
var decypheredNumber = worker.ReadAccountNumbers();

Console.WriteLine(decypheredNumber);




