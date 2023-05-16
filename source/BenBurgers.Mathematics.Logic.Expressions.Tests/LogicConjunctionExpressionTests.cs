/*
 * Ben Burgers Mathematics
 * © 2022-2023 Ben Burgers and contributors
 * Licensed under AGPL 3.0
 */

using BenBurgers.Mathematics.Logic.Propositions.Variables;

namespace BenBurgers.Mathematics.Logic.Expressions.Tests;

public class LogicConjunctionExpressionTests
{
    [Fact]
    public void ToStringTestBasicHappy()
    {
        // Arrange
        var leftGetter = new Func<bool>(() => true);
        var left = new LogicPropositionVariableExpression(new PropositionVariableFunc("a", leftGetter));
        var rightGetter = new Func<bool>(() => false);
        var right = new LogicPropositionVariableExpression(new PropositionVariableFunc("b", rightGetter));
        var others = new LogicPropositionVariableExpression[]
        {
            new(new PropositionVariableFunc("c", leftGetter)),
            new(new PropositionVariableFunc("d", rightGetter))
        };
        var conjunctionExpression = new LogicConjunctionExpression(left, right, others);

        // Act
        var result = conjunctionExpression.ToString();

        // Assert
        Assert.Equal("a ∧ b ∧ c ∧ d", result);
    }
}
