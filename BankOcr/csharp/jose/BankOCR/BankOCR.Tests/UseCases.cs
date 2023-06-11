namespace BankOCR.Tests;

public class UseCases
{
    [Fact]
    public void UseCase1And2()
    {
        // Arrange
        var worker = new OcrWorker("TestCases/useCase1.txt");
        
        // Act
        var numbers = worker.ReadAccountNumbers().ToArray();
        
        // Assert
        Assert.Equal("000000000", numbers[0].FinalNumber);
        Assert.Equal("111111111 ERR", numbers[1].FinalNumber);
        Assert.Equal("222222222 ERR", numbers[2].FinalNumber);
        Assert.Equal("333333333 ERR", numbers[3].FinalNumber);
        Assert.Equal("444444444 ERR", numbers[4].FinalNumber);
        Assert.Equal("555555555 ERR", numbers[5].FinalNumber);
        Assert.Equal("666666666 ERR", numbers[6].FinalNumber);
        Assert.Equal("777777777 ERR", numbers[7].FinalNumber);
        Assert.Equal("888888888 ERR", numbers[8].FinalNumber);
        Assert.Equal("999999999 ERR", numbers[9].FinalNumber);
        Assert.Equal("123456789", numbers[10].FinalNumber);
    }
    
    [Fact]
    public void UseCase2And3()
    {
        // Arrange
        var worker = new OcrWorker("TestCases/useCase2.txt");
        
        // Act
        var numbers = worker.ReadAccountNumbers().ToArray();
        
        // Assert
        Assert.Equal("000000051", numbers[0].FinalNumber);
        Assert.Equal("49006771? ILL", numbers[1].FinalNumber);
        Assert.Equal("1234?678? ILL", numbers[2].FinalNumber);
    }
}