/*
 * Ben Burgers Mathematics
 * © 2022 Ben Burgers and contributors
 * Licensed under AGPL 3.0
 */

using BenBurgers.Mathematics.Numbers.Real.Rational.Integer;

namespace BenBurgers.Mathematics.Numbers.Tests.Real.Rational.Integer;

public partial class IntegerNumberTests
{
    [Fact]
    [Trait(nameof(Traits.Category), nameof(TraitCategory.Cast))]
    public void CastTestHappy()
    {
        // Arrange
        byte b = 1;
        sbyte sb = -1;
        short s = -1;
        ushort us = 1;
        int i = -1;
        uint ui = 1U;
        long l = -1L;
        ulong ul = 1UL;
        float f = -1.0F;
        double d = -1.0D;
        decimal m = -1.0M;

        // Act
        var bin = (IntegerNumber)b;
        var sbin = (IntegerNumber)sb;
        var sin = (IntegerNumber)s;
        var usin = (IntegerNumber)us;
        var iin = (IntegerNumber)i;
        var uiin = (IntegerNumber)ui;
        var lin = (IntegerNumber)l;
        var ulin = (IntegerNumber)ul;
        var fin = (IntegerNumber)f;
        var din = (IntegerNumber)d;
        var min = (IntegerNumber)m;

        // Assert
        Assert.Equal(b, (byte)bin);
        Assert.Equal(sb, (sbyte)sbin);
        Assert.Equal(s, (short)sin);
        Assert.Equal(us, (ushort)usin);
        Assert.Equal(i, (int)iin);
        Assert.Equal(ui, (uint)uiin);
        Assert.Equal(l, (long)lin);
        Assert.Equal(ul, (ulong)ulin);
        Assert.Equal(f, (float)fin);
        Assert.Equal(d, (double)din);
        Assert.Equal(m, (decimal)min);
    }

    [Fact]
    [Trait(nameof(Traits.Category), nameof(TraitCategory.Cast))]
    public void CastTestFloatNotInteger()
    {
        // Arrange
        float f1 = 2.5F;
        float f2 = -3.5F;

        // Act / Assert
        Assert.Throws<NumberNotIntegerException>(() => (IntegerNumber)f1);
        Assert.Throws<NumberNotIntegerException>(() => (IntegerNumber)f2);
    }

    [Fact]
    [Trait(nameof(Traits.Category), nameof(TraitCategory.Cast))]
    public void CastTestFloatIsInfinity()
    {
        // Arrange
        float f1 = float.PositiveInfinity;
        float f2 = float.NegativeInfinity;

        // Act / Assert
        Assert.Throws<NumberTooLargeException>(() => (IntegerNumber)f1);
        Assert.Throws<NumberTooLargeException>(() => (IntegerNumber)f2);
    }

    [Fact(Skip = "Not yet implemented")] // TODO implement.
    [Trait(nameof(Traits.Category), nameof(TraitCategory.Cast))]
    public void CastTestFloatLargerThanInt()
    {
        // Arrange
        float numberPositive = float.MaxValue - 1000.0F;
        float numberNegative = float.MinValue + 1000.0F;

        // Act
        var integerPositive = (IntegerNumber)numberPositive;
        var integerNegative = (IntegerNumber)numberNegative;

        // Assert
        Assert.NotNull(integerPositive.sequence.StartNode.Next);
        Assert.NotNull(integerNegative.sequence.StartNode.Next);
    }

    [Fact]
    [Trait(nameof(Traits.Category), nameof(TraitCategory.Cast))]
    public void CastTestDoubleNotInteger()
    {
        // Arrange
        double d1 = 2.5D;
        double d2 = -3.5D;

        // Act / Assert
        Assert.Throws<NumberNotIntegerException>(() => (IntegerNumber)d1);
        Assert.Throws<NumberNotIntegerException>(() => (IntegerNumber)d2);
    }

    [Fact]
    [Trait(nameof(Traits.Category), nameof(TraitCategory.Cast))]
    public void CastTestDoubleIsInfinity()
    {
        // Arrange
        double d1 = double.PositiveInfinity;
        double d2 = double.NegativeInfinity;

        // Act / Assert
        Assert.Throws<NumberTooLargeException>(() => (IntegerNumber)d1);
        Assert.Throws<NumberTooLargeException>(() => (IntegerNumber)d2);
    }

    [Fact(Skip = "Not yet implemented")] // TODO implement.
    [Trait(nameof(Traits.Category), nameof(TraitCategory.Cast))]
    public void CastTestDoubleLargerThanInt()
    {
        // Arrange
        double numberPositive = double.MaxValue - 1000.0D;
        double numberNegative = double.MinValue + 1000.0D;

        // Act
        var integerPositive = (IntegerNumber)numberPositive;
        var integerNegative = (IntegerNumber)numberNegative;

        // Assert
        Assert.NotNull(integerPositive.sequence.StartNode.Next);
        Assert.NotNull(integerNegative.sequence.StartNode.Next);
    }

    [Fact]
    [Trait(nameof(Traits.Category), nameof(TraitCategory.Cast))]
    public void CastTestDecimalIsNotInteger()
    {
        // Arrange
        decimal d1 = 2.5M;
        decimal d2 = -3.5M;

        // Act / Assert
        Assert.Throws<NumberNotIntegerException>(() => (IntegerNumber)d1);
        Assert.Throws<NumberNotIntegerException>(() => (IntegerNumber)d2);
    }

    [Fact]
    [Trait(nameof(Traits.Category), nameof(TraitCategory.Cast))]
    public void CastTestDecimalIsMinimumOrMaximumValue()
    {
        // Arrange
        decimal d1 = decimal.MinValue;
        decimal d2 = decimal.MaxValue;

        // Act / Assert
        Assert.Throws<NumberTooLargeException>(() => (IntegerNumber)d1);
        Assert.Throws<NumberTooLargeException>(() => (IntegerNumber)d2);
    }
}