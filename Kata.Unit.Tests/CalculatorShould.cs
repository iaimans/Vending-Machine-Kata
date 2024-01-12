namespace Kata.Unit.Tests;

public class CalculatorShould
{
    #region Add

    [Fact]
    public void Add_two_numbers()
    {
        // Arrange
        var calculator = new Calculator();
        // Act
        var result = calculator.Add(1, 2);
        // Assert
        result.Should().Be(3);
    }
    
    [Theory]
    [InlineData(1, 2, 3)]
    [InlineData(2, 3, 5)]
    [InlineData(3, 4, 7)]
    public void Add_two_numbers_theory(int a, int b, int expected)
    {
        // Arrange
        var calculator = new Calculator();
        // Act
        var result = calculator.Add(a, b);
        // Assert
        result.Should().Be(expected);
    }

    #endregion
    
    #region Subtract
    
    [Fact]
    public void Subtract_two_numbers()
    {
        // Arrange
        var calculator = new Calculator();
        // Act
        var result = calculator.Subtract(1, 2);
        // Assert
        result.Should().Be(-1);
    }
    
    #endregion
}