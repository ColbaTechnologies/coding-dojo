namespace BankOCR;

public class Account
{
    public string[] Lines { get; set; } = new string[4];
    public string[] NumberBlocks { get; set; } = new string[9];
    public string FinalNumber { get; set; } = null!;
    
    
    public bool ValidateChecksum()
    {
        var charArray = FinalNumber.Select(x => int.Parse(x.ToString())).ToArray();
        var oneByOne = new[]
            {charArray[8], charArray[7], charArray[6], charArray[5], charArray[4], charArray[3], charArray[2], charArray[1], charArray[0]};
        
        var sum = oneByOne[0] +
                  2 * oneByOne[1] +
                  3 * oneByOne[2] +
                  4 * oneByOne[3] +
                  5 * oneByOne[4] +
                  6 * oneByOne[5] +
                  7 * oneByOne[6] +
                  8 * oneByOne[7] +
                  9 * oneByOne[8];

        var checkSum = sum % 11;
        return checkSum == 0;
    }
}