
using BankOCR;

var worker = new OcrWorker();
var accounts = worker.ReadAccountNumbers();

foreach (var account in accounts)
{
    Console.WriteLine(account.FinalNumber);
}




