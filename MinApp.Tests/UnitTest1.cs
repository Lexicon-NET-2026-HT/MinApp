//using MinApp;
//using Xunit;

namespace MinApp.Tests;

public class CalculatorTests
{
    [Fact] // Talar om för xUnit att detta är ett test
    public void Add_TwoPositiveNumbers_ReturnsSum()
    {
        // Arrange – förbered testet
        var calculator = new Calculator();
        int a = 2;
        int b = 3;
        int expected = 5;

        // Act – kör koden som ska testas
        int actual = calculator.Add(a, b);

        // Assert – kontrollera resultatet
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(2, 3, 5)]
    [InlineData(0, 0, 0)]
    [InlineData(-2, 5, 3)]
    [InlineData(-2, -3, -5)]
    public void Add_ReturnsCorrectSum(int a, int b, int expected)
    {
        // Arrange
        var calculator = new Calculator();

        // Act
        int actual = calculator.Add(a, b);

        // Assert
        Assert.Equal(expected, actual);
    }
}
