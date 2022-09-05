/*
 * Ben Burgers Mathematics
 * © 2022 Ben Burgers and contributors
 * Licensed under AGPL 3.0
 */

using BenBurgers.Mathematics.Numbers.Real.Rational.Integer.Natural;
using BenBurgers.Mathematics.Numbers.Sequence;

namespace BenBurgers.Mathematics.Numbers.Tests.Real.Rational.Integer.Natural;

public partial class NaturalNumberTests
{
    private static readonly NaturalNumber[] Numbers = new[]
    {
        new NaturalNumber((NumberSequence)new nuint[] { 2 }),
        new NaturalNumber((NumberSequence)new nuint[] { 3 })
    };

    [Theory]
    [InlineData(0, 0, true)]
    [InlineData(0, 1, false)]
    [InlineData(1, 0, false)]
    [Trait(nameof(Traits.Category), nameof(TraitCategory.Operator))]
    public void OperatorEqualsTest(int leftIndex, int rightIndex, bool equalsExpected)
    {
        // Arrange
        var left = Numbers[leftIndex];
        var right = Numbers[rightIndex];

        // Act
        var equalsActual = left == right;

        // Assert
        Assert.Equal(equalsExpected, equalsActual);
    }

    [Theory]
    [InlineData(0, 0, false)]
    [InlineData(0, 1, true)]
    [InlineData(1, 0, true)]
    [Trait(nameof(Traits.Category), nameof(TraitCategory.Operator))]
    public void OperatorNotEqualsTest(int leftIndex, int rightIndex, bool notEqualsExpected)
    {
        // Arrange
        var left = Numbers[leftIndex];
        var right = Numbers[rightIndex];

        // Act
        var notEqualsActual = left != right;

        // Assert
        Assert.Equal(notEqualsExpected, notEqualsActual);
    }

    [Theory]
    [InlineData(0, 0, false)]
    [InlineData(0, 1, true)]
    [InlineData(1, 0, false)]
    [Trait(nameof(Traits.Category), nameof(TraitCategory.Operator))]
    public void OperatorLessTest(int leftIndex, int rightIndex, bool lessExpected)
    {
        // Arrange
        var left = Numbers[leftIndex];
        var right = Numbers[rightIndex];

        // Act
        var lessActual = left < right;

        // Assert
        Assert.Equal(lessExpected, lessActual);
    }

    [Theory]
    [InlineData(0, 0, true)]
    [InlineData(0, 1, true)]
    [InlineData(1, 0, false)]
    [Trait(nameof(Traits.Category), nameof(TraitCategory.Operator))]
    public void OperatorLessOrEqualTest(int leftIndex, int rightIndex, bool lessOrEqualExpected)
    {
        // Arrange
        var left = Numbers[leftIndex];
        var right = Numbers[rightIndex];

        // Act
        var lessOrEqualActual = left <= right;

        // Assert
        Assert.Equal(lessOrEqualExpected, lessOrEqualActual);
    }

    [Theory]
    [InlineData(0, 0, false)]
    [InlineData(0, 1, false)]
    [InlineData(1, 0, true)]
    [Trait(nameof(Traits.Category), nameof(TraitCategory.Operator))]
    public void OperatorGreaterTest(int leftIndex, int rightIndex, bool greaterExpected)
    {
        // Arrange
        var left = Numbers[leftIndex];
        var right = Numbers[rightIndex];

        // Act
        var greaterActual = left > right;

        // Assert
        Assert.Equal(greaterExpected, greaterActual);
    }

    [Theory]
    [InlineData(0, 0, true)]
    [InlineData(0, 1, false)]
    [InlineData(1, 0, true)]
    [Trait(nameof(Traits.Category), nameof(TraitCategory.Operator))]
    public void OperatorGreaterOrEqualTest(int leftIndex, int rightIndex, bool greaterOrEqualExpected)
    {
        // Arrange
        var left = Numbers[leftIndex];
        var right = Numbers[rightIndex];

        // Act
        var greaterOrEqualActual = left >= right;

        // Assert
        Assert.Equal(greaterOrEqualExpected, greaterOrEqualActual);
    }

    [Theory]
    [InlineData(0, 1)]
    [Trait(nameof(Traits.Category), nameof(TraitCategory.Operator))]
    public void OperatorIncrementTest(int originalIndex, int incrementExpectedIndex)
    {
        // Arrange
        var original = Numbers[originalIndex];
        var incrementExpected = Numbers[incrementExpectedIndex];

        // Act
        var incrementActual = ++original;

        // Assert
        Assert.Equal(incrementExpected, incrementActual);
    }

    [Theory]
    [InlineData(1, 0)]
    [Trait(nameof(Traits.Category), nameof(TraitCategory.Operator))]
    public void OperatorDecrementTest(int originalIndex, int decrementExpectedIndex)
    {
        // Arrange
        var original = Numbers[originalIndex];
        var decrementExpected = Numbers[decrementExpectedIndex];

        // Act
        var decrementActual = --original;

        // Assert
        Assert.Equal(decrementExpected, decrementActual);
    }

    [Theory]
    [InlineData(0, 1)]
    [InlineData(1, 0)]
    [Trait(nameof(Traits.Category), nameof(TraitCategory.Operator))]
    public void OperatorAdditionTest(int leftIndex, int rightIndex)
    {
        // Arrange
        var left = Numbers[leftIndex];
        var right = Numbers[rightIndex];

        // Act
        var addition = left + right;

        // Assert
        Assert.Equal(left, addition.Left);
        Assert.Equal(right, addition.Right);
    }

    [Theory]
    [InlineData(0, 1)]
    [InlineData(1, 0)]
    [Trait(nameof(Traits.Category), nameof(TraitCategory.Operator))]
    public void OperatorSubtractionTest(int leftIndex, int rightIndex)
    {
        // Arrange
        var left = Numbers[leftIndex];
        var right = Numbers[rightIndex];

        // Act
        var subtraction = left - right;

        // Assert
        Assert.Equal(left, subtraction.Left);
        Assert.Equal(right, subtraction.Right);
    }

    [Theory]
    [InlineData(0, 1)]
    [InlineData(1, 0)]
    [Trait(nameof(Traits.Category), nameof(TraitCategory.Operator))]
    public void OperatorMultiplicationTest(int leftIndex, int rightIndex)
    {
        // Arrange
        var left = Numbers[leftIndex];
        var right = Numbers[rightIndex];

        // Act
        var multiplication = left * right;

        // Assert
        Assert.Equal(left, multiplication.Left);
        Assert.Equal(right, multiplication.Right);
    }

    [Theory]
    [InlineData(0, 1)]
    [InlineData(1, 0)]
    [Trait(nameof(Traits.Category), nameof(TraitCategory.Operator))]
    public void OperatorDivisionTest(int numeratorIndex, int denominatorIndex)
    {
        // Arrange
        var numerator = Numbers[numeratorIndex];
        var denominator = Numbers[denominatorIndex];

        // Act
        var division = numerator / denominator;

        // Assert
        Assert.Equal(numerator, division.Numerator);
        Assert.Equal(denominator, division.Denominator);
        Assert.False(division.IsNegative);
    }

    [Theory]
    [InlineData(0, 1)]
    [InlineData(1, 0)]
    [Trait(nameof(Traits.Category), nameof(TraitCategory.Operator))]
    public void OperatorModulusTest(int dividendIndex, int divisorIndex)
    {
        // Arrange
        var dividend = Numbers[dividendIndex];
        var divisor = Numbers[divisorIndex];

        // Act
        var modulus = dividend % divisor;

        // Assert
        Assert.Equal(dividend, modulus.Dividend);
        Assert.Equal(divisor, modulus.Divisor);
    }
}