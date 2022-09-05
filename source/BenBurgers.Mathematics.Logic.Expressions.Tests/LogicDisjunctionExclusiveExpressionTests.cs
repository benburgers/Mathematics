/*
 * Ben Burgers Mathematics
 * © 2022 Ben Burgers and contributors
 * Licensed under AGPL 3.0
 */

namespace BenBurgers.Mathematics.Logic.Expressions.Tests;

public class LogicDisjunctionExclusiveExpressionTests
{
    [Fact]
    public void ToStringTestBasicHappy()
    {
        // Arrange
        var trueGetter = new Func<bool>(() => true);
        var falseGetter = new Func<bool>(() => false);
        var left = new LogicPropositionVariableExpression(new PropositionVariable("a", trueGetter));
        var right = new LogicPropositionVariableExpression(new PropositionVariable("b", falseGetter));
        var others = new LogicPropositionVariableExpression[]
        {
            new(new PropositionVariable("c", trueGetter)),
            new(new PropositionVariable("d", falseGetter))
        };
        var disjunctionExclusiveExpression = new LogicDisjunctionExclusiveExpression(left, right, others);

        // Act
        var result = disjunctionExclusiveExpression.ToString();

        // Assert
        Assert.Equal("a ⊻ b ⊻ c ⊻ d", result);
    }
}