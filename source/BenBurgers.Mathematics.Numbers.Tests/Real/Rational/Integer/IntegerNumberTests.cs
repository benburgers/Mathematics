/*
 * Ben Burgers Mathematics
 * © 2022-2023 Ben Burgers and contributors
 * Licensed under AGPL 3.0
 */

using BenBurgers.Mathematics.Numbers.Real.Rational.Integer;

namespace BenBurgers.Mathematics.Numbers.Tests.Real.Rational.Integer;

public partial class IntegerNumberTests
{
    [Fact]
    [Trait(nameof(Traits.Category), nameof(TraitCategory.IsZero))]
    public void IsZeroTest()
    {
        // Arrange
        IntegerNumber zero = (IntegerNumber)0;
        IntegerNumber one = (IntegerNumber)1;
        IntegerNumber oneNegative = (IntegerNumber)(-1);

        // Act
        var isZero = zero.IsZero;
        var oneIsNotZero = one.IsZero;
        var oneNegativeIsNotZero = oneNegative.IsZero;

        // Assert
        Assert.True(isZero);
        Assert.False(oneIsNotZero);
        Assert.False(oneNegativeIsNotZero);
    }
}
