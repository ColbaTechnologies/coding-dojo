namespace BankOCR;

public class Account
{
    public string[] Lines { get; set; } = new string[4];
    public string[] NumberBlocks { get; set; } = new string[9];
    public string FinalNumber { get; set; } = null!;
}