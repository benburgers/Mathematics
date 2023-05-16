/*
 * Ben Burgers Mathematics
 * © 2022-2023 Ben Burgers and contributors
 * Licensed under AGPL 3.0
 */

using BenBurgers.Mathematics.Numbers.Arithmetic;
using BenBurgers.Mathematics.Numbers.Real.Rational.Integer;
using BenBurgers.Mathematics.Numbers.Real.Rational.Integer.Natural;

namespace BenBurgers.Mathematics.Numbers.Tests.Arithmetic.Additions;

public class AdditionTests
{
    [Fact]
    public async Task EvaluateNaturalNaturalToNaturalTestAsync()
    {
        // Arrange
        var number1 = (NaturalNumber)20u;
        var number2 = (NaturalNumber)30u;

        // Act
        var result = (uint)await (number1 + number2).EvaluateAsync<NaturalNumber>(ArithmeticOptions.Default);

        // Assert
        Assert.Equal(50u, result);
    }

    [Fact]
    public async Task EvaluateNaturalNaturalToNaturalOverflowTestAsync()
    {
        // Arrange
        var number1 = (NaturalNumber)nuint.MaxValue;
        var number2 = (NaturalNumber)20u;

        // Act
        var result = await (number1 + number2).EvaluateAsync<NaturalNumber>(ArithmeticOptions.Default);

        // Assert
        Assert.NotNull(result.sequence.StartNode.Next);
        var next = result.sequence.StartNode.GetNext()!;
        Assert.NotEqual((nuint)0, next.Value.Value);
        Assert.Null(next.Value.Next);
    }

    [Fact]
    public async Task EvaluateIntegerIntegerToIntegerTestAsync()
    {
        // Arrange
        var number1 = (IntegerNumber)20;
        var number2 = (IntegerNumber)30;

        // Act
        var result = (int)await (number1 + number2).EvaluateAsync<IntegerNumber>(ArithmeticOptions.Default);

        // Assert
        Assert.Equal(50, result);
    }
}
