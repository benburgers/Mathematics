/*
 * Ben Burgers Mathematics
 * © 2022-2023 Ben Burgers and contributors
 * Licensed under AGPL 3.0
 */

using BenBurgers.Mathematics.Numbers.Arithmetic;
using BenBurgers.Mathematics.Numbers.Real.Rational.Integer.Natural;

namespace BenBurgers.Mathematics.Numbers.Tests.Real.Rational.Integer.Natural;

public partial class NaturalNumberTests
{
    [Fact]
    [Trait(nameof(Traits.Category), nameof(TraitCategory.IsZero))]
    public void IsZeroTest()
    {
        // Arrange
        NaturalNumber zero = (NaturalNumber)0;
        NaturalNumber notZero = (NaturalNumber)1;

        // Act
        var isZero = zero.IsZero;
        var isNotZero = notZero.IsZero;

        // Assert
        Assert.True(isZero);
        Assert.False(isNotZero);
    }

    [Fact]
    [Trait(nameof(Traits.Category), nameof(TraitCategory.ToString))]
    public async Task ParseToStringTestAsync()
    {
        // Arrange
        const string NaturalShortString = "2";
        const string NaturalLongString = "148894445742041325547806458472397916603026273992795324185271289425213239361064475310309971132180337174752834401423587560";
        var naturalShort = await NaturalNumber.ParseAsync(NaturalShortString, ArithmeticOptions.Default);
        var naturalLong = await NaturalNumber.ParseAsync(NaturalLongString, ArithmeticOptions.Default);

        // Act
        var naturalShortString = naturalShort.ToString();
        var naturalLongString = naturalLong.ToString();

        // Assert
        Assert.Equal(NaturalShortString, naturalShortString);
        Assert.Equal(NaturalLongString, naturalLongString);
    }
}