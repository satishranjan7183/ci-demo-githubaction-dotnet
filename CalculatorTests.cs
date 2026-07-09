using Xunit;
using DotNetDemo;

namespace DotNetDemo.Tests;

public class CalculatorTests
{
    private readonly Calculator calculator = new();

    [Fact]
    public void TestAdd()
    {
        Assert.Equal(5, calculator.Add(2,3));
    }

    [Fact]
    public void TestMultiply()
    {
        Assert.Equal(12, calculator.Multiply(3,4));
    }
}