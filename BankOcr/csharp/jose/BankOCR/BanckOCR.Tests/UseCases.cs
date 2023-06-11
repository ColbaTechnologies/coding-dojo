using BankOCR;

namespace BanckOCR.Tests;

public class UseCases
{
    [Fact]
    public void UseCase1()
    {
        // Arrange
        var worker = new OcrWorker("TestCases1/useCase1.txt");
        
        // Act
        var numbers = worker.ReadAccountNumbers().ToArray();
        
        // Assert
        Assert.Equal("000000000", numbers[0].FinalNumber);
        Assert.Equal("111111111", numbers[1].FinalNumber);
        Assert.Equal("222222222", numbers[2].FinalNumber);
        Assert.Equal("333333333", numbers[3].FinalNumber);
        Assert.Equal("444444444", numbers[4].FinalNumber);
        Assert.Equal("555555555", numbers[5].FinalNumber);
        Assert.Equal("666666666", numbers[6].FinalNumber);
        Assert.Equal("777777777", numbers[7].FinalNumber);
        Assert.Equal("888888888", numbers[8].FinalNumber);
        Assert.Equal("999999999", numbers[9].FinalNumber);
        Assert.Equal("123456789", numbers[10].FinalNumber);
    }
}