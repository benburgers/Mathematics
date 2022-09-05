/*
 * Ben Burgers Mathematics
 * © 2022 Ben Burgers and contributors
 * Licensed under AGPL 3.0
 */

using BenBurgers.Mathematics.Numbers.Arithmetic;
using BenBurgers.Mathematics.Numbers.Arithmetic.Prime;
using BenBurgers.Mathematics.Numbers.Real.Rational.Integer.Natural;

namespace BenBurgers.Mathematics.Numbers.Tests.Arithmetic.Prime;

public class PrimalityTesterTests
{
    private static readonly int[] PrimeNumbers =
        new[] { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97, 101, 103, 107, 109, 113, 127, 131, 137, 139, 149, 151, 157, 163, 167, 173, 179, 181, 191, 193, 197, 199, 211, 223, 227, 229, 233, 239, 241, 251, 257, 263, 269, 271 };

    [Fact]
    public async Task BruteForceTestAsync()
    {
        for (var i = 0; i < PrimeNumbers.Length; i++)
        {
            // Arrange
            var number = (NaturalNumber)PrimeNumbers[i];

            // Act
            var isPrime = await PrimalityTester.IsPrimeAsync(
                                                    number,
                                                    PrimalityTester.Algorithm.BruteForce,
                                                    ArithmeticOptions.Default);

            // Assert
            Assert.True(isPrime);
        }
    }

    [Fact]
    public async Task SixKPlusOrMinusOneTestAsync()
    {
        for (var i = 0; i < PrimeNumbers.Length; i++)
        {
            // Arrange
            var number = (NaturalNumber)PrimeNumbers[i];

            // Act
            var isPrime = await PrimalityTester.IsPrimeAsync(
                                                    number,
                                                    PrimalityTester.Algorithm.SixKPlusOrMinusOne,
                                                    ArithmeticOptions.Default);

            // Assert
            Assert.True(isPrime);
        }
    }
}