/*
 * Ben Burgers Mathematics
 * © 2022 Ben Burgers and contributors
 * Licensed under AGPL 3.0
 */

namespace BenBurgers.Mathematics.Logic.Expressions.Tests;

public class LogicValueExpressionTests
{
    private static readonly IReadOnlyList<LogicValueExpression> Expressions =
        new LogicValueExpression[]
        {
            new(true),
            new(false),
            new(null)
        };

    [Theory]
    [InlineData(0)]
    [InlineData(1)]
    [InlineData(2)]
    public void CloneTest(int expressionIndex)
    {
        // Arrange
        var expression = Expressions[expressionIndex];

        // Act
        var clone = expression.Clone();

        // Assert
        Assert.False(ReferenceEquals(clone, expression));
        Assert.Equal(clone.Value, expression.Value);
    }

    [Theory]
    [InlineData(0, "1")]
    [InlineData(1, "0")]
    [InlineData(2, "?")]
    public void ToStringTest(int expressionIndex, string expected)
    {
        // Arrange
        var expression = Expressions[expressionIndex];

        // Act
        var actual = expression.ToString();

        // Assert
        Assert.Equal(expected, actual);
    }
}