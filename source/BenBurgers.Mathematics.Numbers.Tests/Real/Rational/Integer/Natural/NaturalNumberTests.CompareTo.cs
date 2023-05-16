/*
 * Ben Burgers Mathematics
 * © 2022-2023 Ben Burgers and contributors
 * Licensed under AGPL 3.0
 */

using BenBurgers.Mathematics.Numbers.Real.Rational.Integer.Natural;

namespace BenBurgers.Mathematics.Numbers.Tests.Real.Rational.Integer.Natural;

public partial class NaturalNumberTests
{
    [Fact]
    [Trait(nameof(Traits.Category), nameof(TraitCategory.CompareTo))]
    public void CompareToTestUInt8Happy()
    {
        // Arrange
        byte numberLess = 1;
        byte numberEqual = 2;
        byte numberGreater = 3;
        NaturalNumber number = (NaturalNumber)2;

        // Act
        var less = number.CompareTo(numberLess);
        var equal = number.CompareTo(numberEqual);
        var greater = number.CompareTo(numberGreater);

        // Assert
        Assert.Equal(1, less);
        Assert.Equal(0, equal);
        Assert.Equal(-1, greater);
    }

    [Fact]
    [Trait(nameof(Traits.Category), nameof(TraitCategory.CompareTo))]
    public void CompareToTestInt8Happy()
    {
        // Arrange
        sbyte numberLess = 1;
        sbyte numberLessNegative = -1;
        sbyte numberEqual = 2;
        sbyte numberGreater = 3;
        NaturalNumber number = (NaturalNumber)2;

        // Act
        var less = number.CompareTo(numberLess);
        var lessNegative = number.CompareTo(numberLessNegative);
        var equal = number.CompareTo(numberEqual);
        var greater = number.CompareTo(numberGreater);

        // Assert
        Assert.Equal(1, less);
        Assert.Equal(1, lessNegative);
        Assert.Equal(0, equal);
        Assert.Equal(-1, greater);
    }
}
