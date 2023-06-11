// See https://aka.ms/new-console-template for more information

var path = Directory.GetCurrentDirectory() + "/MachineInput.txt";
var inputFromFile = File.ReadLines(path);


foreach (var line in inputFromFile) Console.WriteLine(line);