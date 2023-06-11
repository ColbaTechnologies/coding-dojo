namespace BankOCR;

public class Converter
{
    public string[] ConvertIntoNumbers(string[] accountLines, int i1)
    {
        var numbersRead = new string[9];
        foreach (var line in accountLines)
        {
            var chunkedLine = new string[9];
            for (var i = 0; i < i1 / 3; i++)
            {
                chunkedLine[i] = string.Concat(line.AsSpan(3 * i, 3), "\n");
                numbersRead[i] += chunkedLine[i];
            }
        }

        return numbersRead;
    }
}