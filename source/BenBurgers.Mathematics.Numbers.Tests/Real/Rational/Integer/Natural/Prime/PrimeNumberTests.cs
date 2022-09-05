/*
 * Ben Burgers Mathematics
 * © 2022 Ben Burgers and contributors
 * Licensed under AGPL 3.0
 */

using BenBurgers.Mathematics.Numbers.Arithmetic;
using BenBurgers.Mathematics.Numbers.Real.Rational.Integer.Natural.Prime;

namespace BenBurgers.Mathematics.Numbers.Tests.Real.Rational.Integer.Natural.Prime;

public class PrimeNumberTests
{
    [Fact]
    [Trait(nameof(Traits.Category), nameof(TraitCategory.IsEven))]
    public void IsEvenTest()
    {
        // Arrange
        var primeEven = (PrimeNumber)2;
        var primeOdd = (PrimeNumber)3;

        // Act
        var actualEven = primeEven.IsEven;
        var actualOdd = primeOdd.IsEven;

        // Assert
        Assert.True(actualEven);
        Assert.False(actualOdd);
    }

    [Fact]
    [Trait(nameof(Traits.Category), nameof(TraitCategory.ToString))]
    public async Task ParseToStringTestAsync()
    {
        // Arrange
        const string PrimeShortString = "3";
        const string PrimeLongString = "148894445742041325547806458472397916603026273992795324185271289425213239361064475310309971132180337174752834401423587560";
        var primeShort = await PrimeNumber.ParseAsync(PrimeShortString, ArithmeticOptions.Default);
        var primeLong = await PrimeNumber.ParseAsync(PrimeLongString, ArithmeticOptions.Default);

        // Act
        var primeShortString = primeShort.ToString();
        var primeLongString = primeLong.ToString();

        // Assert
        Assert.Equal(PrimeShortString, primeShortString);
        Assert.Equal(PrimeLongString, primeLongString);
    }
}