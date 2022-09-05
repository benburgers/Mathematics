/*
 * Ben Burgers Mathematics
 * © 2022 Ben Burgers and contributors
 * Licensed under AGPL 3.0
 */

namespace BenBurgers.Mathematics.Logic.Expressions.Tests;

public class LogicConjunctionExpressionTests
{
    [Fact]
    public void ToStringTestBasicHappy()
    {
        // Arrange
        var leftGetter = new Func<bool>(() => true);
        var left = new LogicPropositionVariableExpression(new PropositionVariable("a", leftGetter));
        var rightGetter = new Func<bool>(() => false);
        var right = new LogicPropositionVariableExpression(new PropositionVariable("b", rightGetter));
        var others = new LogicPropositionVariableExpression[]
        {
            new(new PropositionVariable("c", leftGetter)),
            new(new PropositionVariable("d", rightGetter))
        };
        var conjunctionExpression = new LogicConjunctionExpression(left, right, others);

        // Act
        var result = conjunctionExpression.ToString();

        // Assert
        Assert.Equal("a ∧ b ∧ c ∧ d", result);
    }
}
