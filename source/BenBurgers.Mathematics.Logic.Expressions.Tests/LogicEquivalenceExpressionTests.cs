/*
 * Ben Burgers Mathematics
 * © 2022 Ben Burgers and contributors
 * Licensed under AGPL 3.0
 */

namespace BenBurgers.Mathematics.Logic.Expressions.Tests;

public class LogicEquivalenceExpressionTests
{
    [Fact]
    public void ToStringTestBasicHappy()
    {
        // Arrange
        var trueGetter = new Func<bool>(() => true);
        var falseGetter = new Func<bool>(() => false);
        var left = new LogicPropositionVariableExpression(new PropositionVariable("a", trueGetter));
        var right = new LogicPropositionVariableExpression(new PropositionVariable("b", falseGetter));
        var expression = new LogicEquivalenceExpression(left, right);

        // Act
        var result = expression.ToString();

        // Assert
        Assert.Equal("a ↔ b", result);
    }
}