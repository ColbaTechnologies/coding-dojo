namespace BankOCR;

public class Converter
{
    public string[] ConvertIntoNumbers(string[] linesFromFile1, int i1)
    {
        var numbersRead1 = new string[9];
        foreach (var line in linesFromFile1.Take(3))
        {
            var chunkedLine = new string[9];
            for (var i = 0; i < i1 / 3; i++)
            {
                chunkedLine[i] = string.Concat(line.AsSpan(3 * i, 3), "\n");
                numbersRead1[i] += chunkedLine[i];
            }
        }

        return numbersRead1;
    }
}