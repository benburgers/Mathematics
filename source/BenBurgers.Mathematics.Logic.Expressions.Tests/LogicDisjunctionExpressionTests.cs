/*
 * Ben Burgers Mathematics
 * © 2022-2023 Ben Burgers and contributors
 * Licensed under AGPL 3.0
 */

using BenBurgers.Mathematics.Logic.Propositions.Variables;

namespace BenBurgers.Mathematics.Logic.Expressions.Tests;

public class LogicDisjunctionExpressionTests
{
    [Fact]
    public void ToStringTestBasicHappy()
    {
        // Arrange
        var trueGetter = new Func<bool>(() => true);
        var falseGetter = new Func<bool>(() => false);
        var left = new LogicPropositionVariableExpression(new PropositionVariableFunc("a", trueGetter));
        var right = new LogicPropositionVariableExpression(new PropositionVariableFunc("b", falseGetter));
        var others = new LogicPropositionVariableExpression[]
        {
            new(new PropositionVariableFunc("c", trueGetter)),
            new(new PropositionVariableFunc("d", falseGetter))
        };
        var disjunctionExpression = new LogicDisjunctionExpression(left, right, others);

        // Act
        var result = disjunctionExpression.ToString();

        // Assert
        Assert.Equal("a ∨ b ∨ c ∨ d", result);
    }
}
