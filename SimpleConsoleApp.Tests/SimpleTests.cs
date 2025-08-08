namespace SimpleConsoleApp.Tests;

public class SimpleTests
{
    [Theory]
    [InlineData(4,5, 9)]
    [InlineData(16,4, 20)]
    public void Maths_AddingTwoNumbers_ShouldReturnCorrectValue(int number1, int number2, int expectedResult)
    {
        // Act
        int result = Maths.Add(number1, number2);
        
        // Assert
        Assert.Equal(expectedResult, result);
    }
}
