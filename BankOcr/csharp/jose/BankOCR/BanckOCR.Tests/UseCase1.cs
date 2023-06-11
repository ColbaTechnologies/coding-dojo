using BankOCR;

namespace BanckOCR.Tests;

public class UseCase1
{
    
    [Fact]
    public void Test1()
    {
        Console.WriteLine(Directory.GetCurrentDirectory());
        // Arrange
        var worker = new OcrWorker("TestCases1/useCase1.txt");
        
        // Act
        var numbers = worker.ReadAccountNumbers();
        
        // Assert
        Assert.Equal("000000000", numbers);
    }
}