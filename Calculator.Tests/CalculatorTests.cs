using Xunit;

public class CalculatorTests
{
    [Fact]
    public void Add_ReturnsSumOfTwoNumbers()
    {
        var calculator = new Calculator();
        double result = calculator.Add(5, 7);
        Assert.Equal(12, result);
    }

    [Fact]
    public void Subtract_ReturnsDifferenceOfTwoNumbers()
    {
        var calculator = new Calculator();
        double result = calculator.Subtract(10, 3);
        Assert.Equal(7, result);
    }

    [Fact]
    public void Multiply_ReturnsProductOfTwoNumbers()
    {
        var calculator = new Calculator();
        double result = calculator.Multiply(4, 6);
        Assert.Equal(24, result);
    }
}
