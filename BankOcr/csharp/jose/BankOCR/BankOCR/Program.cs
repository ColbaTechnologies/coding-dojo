// See https://aka.ms/new-console-template for more information

const int charLimit = 27;
var path = Directory.GetCurrentDirectory() + "/MachineInput.txt";
var inputFromFile = File.ReadLines(path);

if (inputFromFile.Any(x => x.Length != charLimit))
{
    throw new InvalidDataException();
}

var numbersRead = new string[9];
foreach (var line in inputFromFile.Take(3))
{
    var chunkedLine = new string[9];
    for (var i = 0; i < charLimit/3; i++)
    {
        chunkedLine[i] = line.Substring(3*i, 3) + "\n";
        numbersRead[i] += chunkedLine[i];
    }
}


foreach (var line in numbersRead)
{
    Console.WriteLine(line);
};