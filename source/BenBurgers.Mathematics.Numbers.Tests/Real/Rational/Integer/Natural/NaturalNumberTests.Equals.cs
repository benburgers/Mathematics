/*
 * Ben Burgers Mathematics
 * © 2022-2023 Ben Burgers and contributors
 * Licensed under AGPL 3.0
 */

using BenBurgers.Mathematics.Numbers.Real.Irrational;
using BenBurgers.Mathematics.Numbers.Real.Rational.Integer;
using BenBurgers.Mathematics.Numbers.Real.Rational.Integer.Natural;
using BenBurgers.Mathematics.Numbers.Real.Rational.Integer.Natural.Prime;

namespace BenBurgers.Mathematics.Numbers.Tests.Real.Rational.Integer.Natural;

public partial class NaturalNumberTests
{
    [Fact]
    [Trait(nameof(Traits.Category), nameof(TraitCategory.Equals))]
    public void EqualsTestUInt8Happy()
    {
        // Arrange
        byte primitiveEqual = 2;
        byte primitiveNotEqual = 3;
        NaturalNumber number = (NaturalNumber)2;

        // Act
        var byteEquals = number.Equals(primitiveEqual);
        var byteNotEquals = !number.Equals(primitiveNotEqual);

        // Assert
        Assert.True(byteEquals);
        Assert.True(byteNotEquals);
    }

    [Fact]
    [Trait(nameof(Traits.Category), nameof(TraitCategory.Equals))]
    public void EqualsTestInt8Happy()
    {
        // Arrange
        sbyte primitiveEqual = 2;
        sbyte primitiveNotEqual = 3;
        sbyte primitiveNotEqualNegative = -3;
        NaturalNumber number = (NaturalNumber)2;

        // Act
        var equals = number.Equals(primitiveEqual);
        var notEquals = !number.Equals(primitiveNotEqual);
        var notEqualsNegative = !number.Equals(primitiveNotEqualNegative);

        // Assert
        Assert.True(equals);
        Assert.True(notEquals);
        Assert.True(notEqualsNegative);
    }

    [Fact]
    [Trait(nameof(Traits.Category), nameof(TraitCategory.Equals))]
    public void EqualsTestUInt16Happy()
    {
        // Arrange
        ushort primitiveEqual = 2;
        ushort primitiveNotEqual = 3;
        NaturalNumber number = (NaturalNumber)2;

        // Act
        var equals = number.Equals(primitiveEqual);
        var notEquals = !number.Equals(primitiveNotEqual);

        // Assert
        Assert.True(equals);
        Assert.True(notEquals);
    }

    [Fact]
    [Trait(nameof(Traits.Category), nameof(TraitCategory.Equals))]
    public void EqualsTestInt16Happy()
    {
        // Arrange
        short primitiveEqual = 2;
        short primitiveNotEqual = 3;
        short primitiveNotEqualNegative = -3;
        NaturalNumber number = (NaturalNumber)2;

        // Act
        var equals = number.Equals(primitiveEqual);
        var notEquals = !number.Equals(primitiveNotEqual);
        var notEqualsNegative = !number.Equals(primitiveNotEqualNegative);

        // Assert
        Assert.True(equals);
        Assert.True(notEquals);
        Assert.True(notEqualsNegative);
    }

    [Fact]
    [Trait(nameof(Traits.Category), nameof(TraitCategory.Equals))]
    public void EqualsTestUInt32Happy()
    {
        // Arrange
        uint primitiveEqual = 2U;
        uint primitiveNotEqual = 3U;
        NaturalNumber number = (NaturalNumber)2;

        // Act
        var equals = number.Equals(primitiveEqual);
        var notEquals = !number.Equals(primitiveNotEqual);

        // Assert
        Assert.True(equals);
        Assert.True(notEquals);
    }

    [Fact]
    [Trait(nameof(Traits.Category), nameof(TraitCategory.Equals))]
    public void EqualsTestInt32Happy()
    {
        // Arrange
        int primitiveEqual = 2;
        int primitiveNotEqual = 3;
        int primitiveNotEqualNegative = -3;
        NaturalNumber number = (NaturalNumber)2;

        // Act
        var equals = number.Equals(primitiveEqual);
        var notEquals = !number.Equals(primitiveNotEqual);
        var notEqualsNegative = !number.Equals(primitiveNotEqualNegative);

        // Assert
        Assert.True(equals);
        Assert.True(notEquals);
        Assert.True(notEqualsNegative);
    }

    [Fact]
    [Trait(nameof(Traits.Category), nameof(TraitCategory.Equals))]
    public void EqualsTestUInt64Happy()
    {
        // Arrange
        ulong primitiveEqual = 2UL;
        ulong primitiveNotEqual = 3UL;
        NaturalNumber number = (NaturalNumber)2;

        // Act
        var equals = number.Equals(primitiveEqual);
        var notEquals = !number.Equals(primitiveNotEqual);

        // Assert
        Assert.True(equals);
        Assert.True(notEquals);
    }

    [Fact]
    [Trait(nameof(Traits.Category), nameof(TraitCategory.Equals))]
    public void EqualsTestInt64Happy()
    {
        // Arrange
        long primitiveEqual = 2L;
        long primitiveNotEqual = 3L;
        long primitiveNotEqualNegative = -3L;
        NaturalNumber number = (NaturalNumber)2;

        // Act
        var equals = number.Equals(primitiveEqual);
        var notEquals = !number.Equals(primitiveNotEqual);
        var notEqualsNegative = !number.Equals(primitiveNotEqualNegative);

        // Assert
        Assert.True(equals);
        Assert.True(notEquals);
        Assert.True(notEqualsNegative);
    }

    [Fact]
    [Trait(nameof(Traits.Category), nameof(TraitCategory.Equals))]
    public void EqualsTestSingleHappy()
    {
        // Arrange
        float primitiveEqual = 2.0F;
        float primitiveNotEqual = 3.0F;
        float primitiveNotEqualNegative = -3.0F;
        float primitiveNotEqualNotInteger = 2.5F;
        NaturalNumber number = (NaturalNumber)2;

        // Act
        var equals = number.Equals(primitiveEqual);
        var notEquals = !number.Equals(primitiveNotEqual);
        var notEqualsNegative = !number.Equals(primitiveNotEqualNegative);
        var notEqualsNotInteger = !number.Equals(primitiveNotEqualNotInteger);

        // Assert
        Assert.True(equals);
        Assert.True(notEquals);
        Assert.True(notEqualsNegative);
        Assert.True(notEqualsNotInteger);
    }

    [Fact]
    [Trait(nameof(Traits.Category), nameof(TraitCategory.Equals))]
    public void EqualsTestDoubleHappy()
    {
        // Arrange
        double primitiveEqual = 2.0D;
        double primitiveNotEqual = 3.0D;
        double primitiveNotEqualNegative = -3.0D;
        double primitiveNotEqualNotInteger = 2.5D;
        NaturalNumber number = (NaturalNumber)2;

        // Act
        var equals = number.Equals(primitiveEqual);
        var notEquals = !number.Equals(primitiveNotEqual);
        var notEqualsNegative = !number.Equals(primitiveNotEqualNegative);
        var notEqualsNotInteger = !number.Equals(primitiveNotEqualNotInteger);

        // Assert
        Assert.True(equals);
        Assert.True(notEquals);
        Assert.True(notEqualsNegative);
        Assert.True(notEqualsNotInteger);
    }

    [Fact]
    [Trait(nameof(Traits.Category), nameof(TraitCategory.Equals))]
    public void EqualsTestDecimalHappy()
    {
        // Arrange
        decimal primitiveEqual = 2.0M;
        decimal primitiveNotEqual = 3.0M;
        decimal primitiveNotEqualNegative = -3.0M;
        decimal primitiveNotEqualNotInteger = 2.5M;
        NaturalNumber number = (NaturalNumber)2;

        // Act
        var equals = number.Equals(primitiveEqual);
        var notEquals = !number.Equals(primitiveNotEqual);
        var notEqualsNegative = !number.Equals(primitiveNotEqualNegative);
        var notEqualsNotInteger = !number.Equals(primitiveNotEqualNotInteger);

        // Assert
        Assert.True(equals);
        Assert.True(notEquals);
        Assert.True(notEqualsNegative);
        Assert.True(notEqualsNotInteger);
    }

    [Fact]
    [Trait(nameof(Traits.Category), nameof(TraitCategory.Equals))]
    public void EqualsTestPrimeNumberHappy()
    {
        // Arrange
        NaturalNumber numberNatural = (NaturalNumber)3;
        PrimeNumber numberPrimeEqual = (PrimeNumber)3;
        PrimeNumber numberPrimeNotEqual = (PrimeNumber)5;

        // Act
        var equals = numberNatural.Equals(numberPrimeEqual);
        var notEquals = !numberNatural.Equals(numberPrimeNotEqual);

        // Assert
        Assert.True(equals);
        Assert.True(notEquals);
    }

    [Fact]
    [Trait(nameof(Traits.Category), nameof(TraitCategory.Equals))]
    public void EqualsTestNaturalNumberHappy()
    {
        // Arrange
        NaturalNumber number1 = (NaturalNumber)2;
        NaturalNumber number2 = (NaturalNumber)2;
        NaturalNumber number3 = (NaturalNumber)3;

        // Act
        var equals = number1.Equals(number2);
        var notEquals = !number2.Equals(number3);

        // Assert
        Assert.True(equals);
        Assert.True(notEquals);
    }

    [Fact]
    [Trait(nameof(Traits.Category), nameof(TraitCategory.Equals))]
    public void EqualsTestIntegerNumberHappy()
    {
        // Arrange
        NaturalNumber numberNatural = (NaturalNumber)2;
        IntegerNumber numberIntegerEqual = (IntegerNumber)2;
        IntegerNumber numberIntegerNotEqual = (IntegerNumber)3;
        IntegerNumber numberIntegerNotEqualNegative = (IntegerNumber)(-3);

        // Act
        var equals = numberNatural.Equals(numberIntegerEqual);
        var notEquals = !numberNatural.Equals(numberIntegerNotEqual);
        var notEqualsNegative = !numberNatural.Equals(numberIntegerNotEqualNegative);

        // Assert
        Assert.True(equals);
        Assert.True(notEquals);
        Assert.True(notEqualsNegative);
    }

    // TODO Rational Number
    // TODO Irrational Number

    [Fact]
    [Trait(nameof(Traits.Category), nameof(TraitCategory.Equals))]
    public void EqualsTestPiHappy()
    {
        // Arrange
        Pi pi = Pi.Instance;
        NaturalNumber number = (NaturalNumber)2;

        // Act
        var notEquals = !number.Equals(pi);

        // Assert
        Assert.True(notEquals);
    }
}