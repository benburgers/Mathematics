/*
 * Ben Burgers Mathematics
 * © 2022-2023 Ben Burgers and contributors
 * Licensed under AGPL 3.0
 */

using BenBurgers.Mathematics.Logic.Propositions.Variables;

namespace BenBurgers.Mathematics.Logic.Expressions.Tests;

public class LogicEquivalenceExpressionTests
{
    [Fact]
    public void ToStringTestBasicHappy()
    {
        // Arrange
        var trueGetter = new Func<bool>(() => true);
        var falseGetter = new Func<bool>(() => false);
        var left = new LogicPropositionVariableExpression(new PropositionVariableFunc("a", trueGetter));
        var right = new LogicPropositionVariableExpression(new PropositionVariableFunc("b", falseGetter));
        var expression = new LogicEquivalenceExpression(left, right);

        // Act
        var result = expression.ToString();

        // Assert
        Assert.Equal("a ↔ b", result);
    }
}