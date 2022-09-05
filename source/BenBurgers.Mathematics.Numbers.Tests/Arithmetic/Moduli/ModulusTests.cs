/*
 * Ben Burgers Mathematics
 * © 2022 Ben Burgers and contributors
 * Licensed under AGPL 3.0
 */

using BenBurgers.Mathematics.Numbers.Arithmetic;
using BenBurgers.Mathematics.Numbers.Real.Rational.Integer.Natural;

namespace BenBurgers.Mathematics.Numbers.Tests.Arithmetic.Moduli;

public class ModulusTests
{
    private static readonly IReadOnlyList<string> Numbers =
        new[]
        {
            "5",
            "3",
            "2",
            "254781365",
            "0",
            "12412512515125251251251252151252",
            "6",
            "15153151134135135369964961939195169396193951959319513959315913593151391519593159132"
        };

    [Theory]
    [InlineData(0, 1, 2)]
    [InlineData(1, 0, 1)]
    [InlineData(3, 0, 4)]
    [InlineData(5, 6, 2)]
    [InlineData(7, 2, 4)]
    public async Task EvaluateIntegerTest(int dividendIndex, int divisorIndex, int expectedIndex)
    {
        // Arrange
        var dividend = await NaturalNumber.ParseAsync(Numbers[dividendIndex], ArithmeticOptions.Default);
        var divisor = await NaturalNumber.ParseAsync(Numbers[divisorIndex], ArithmeticOptions.Default);
        var expected = await NaturalNumber.ParseAsync(Numbers[expectedIndex], ArithmeticOptions.Default);
        var modulus = dividend % divisor;

        // Act
        var actual = await modulus.EvaluateAsync<NaturalNumber>(ArithmeticOptions.Default);

        // Assert
        Assert.Equal(expected, actual);
    }
}