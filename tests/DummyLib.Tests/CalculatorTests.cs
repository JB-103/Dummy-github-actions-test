using NUnit.Framework;
using DummyLib;

namespace DummyLib.Tests;

[TestFixture]
public class CalculatorTests
{
    [Test]
    public void Add_TwoPositiveNumbers_ReturnsSum()
    {
        // Arrange
        int a = 2;
        int b = 3;

        // Act
        int result = Calculator.Add(a, b);

        // Assert
        Assert.That(result, Is.EqualTo(5));
    }

    [Test]
    public void Add_NegativeAndPositive_ReturnsCorrectSum()
    {
        // Arrange
        int a = -5;
        int b = 3;

        // Act
        int result = Calculator.Add(a, b);

        // Assert
        Assert.That(result, Is.EqualTo(-2));
    }

    [Test]
    public void Multiply_TwoNumbers_ReturnsProduct()
    {
        // Arrange
        int a = 4;
        int b = 5;

        // Act
        int result = Calculator.Multiply(a, b);

        // Assert
        Assert.That(result, Is.EqualTo(20));
    }
}
