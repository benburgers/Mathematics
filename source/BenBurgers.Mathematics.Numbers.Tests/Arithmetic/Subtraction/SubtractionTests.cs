/*
 * Ben Burgers Mathematics
 * © 2022 Ben Burgers and contributors
 * Licensed under AGPL 3.0
 */

using BenBurgers.Mathematics.Numbers.Arithmetic;
using BenBurgers.Mathematics.Numbers.Arithmetic.Subtractions;
using BenBurgers.Mathematics.Numbers.Real.Rational.Integer.Natural;

namespace BenBurgers.Mathematics.Numbers.Tests.Arithmetic.Subtraction;

public class SubtractionTests
{
    private static readonly Type SubtractionGenericTypeDefinition = typeof(Subtraction<,>);
    private static readonly IReadOnlyList<INumber> Numbers =
        new INumber[]
        {
            (NaturalNumber)23,
            (NaturalNumber)12,
            (NaturalNumber)11
        };

    [Theory]
    [InlineData(0, 1, 2)]
    public void SubtractTest(int leftIndex, int rightIndex, int resultExpectedIndex)
    {
        // Arrange
        var left = Numbers[leftIndex];
        var right = Numbers[rightIndex];
        var resultExpected = Numbers[resultExpectedIndex];

        var leftType = left.GetType();
        var rightType = right.GetType();
        var resultType = resultExpected.GetType();
        var subtractionType = SubtractionGenericTypeDefinition.MakeGenericType(leftType, rightType);
        var subtractionConstructor = subtractionType.GetConstructor(new[] { leftType, rightType })!;
        var subtractionEvaluateMethodInfoGeneric = subtractionType.GetMethod("Evaluate")!;
        var subtractionEvaluateMethodInfo = subtractionEvaluateMethodInfoGeneric.MakeGenericMethod(resultType);

        // Act
        var subtraction = subtractionConstructor.Invoke(new object?[] { left, right });
        var resultActual = subtractionEvaluateMethodInfo.Invoke(subtraction, new object?[] { ArithmeticOptions.Default });

        // Assert
        Assert.Equal(resultExpected, resultActual);
    }
}