/*
 * Ben Burgers Mathematics
 * © 2022-2023 Ben Burgers and contributors
 * Licensed under AGPL 3.0
 */

using BenBurgers.Mathematics.Logic.Propositions.Variables;

namespace BenBurgers.Mathematics.Logic.Expressions.Tests;

public class LogicImplicationExpressionTests
{
    [Fact]
    public void ToStringTestHappy()
    {
        // Arrange
        var trueGetter = new Func<bool>(() => true);
        var falseGetter = new Func<bool>(() => false);
        var antecedent = new LogicPropositionVariableExpression(new PropositionVariableFunc("a", trueGetter));
        var consequent = new LogicPropositionVariableExpression(new PropositionVariableFunc("b", falseGetter));
        var implicationExpression = new LogicImplicationExpression(antecedent, consequent);

        // Act
        var result = implicationExpression.ToString();

        // Assert
        Assert.Equal("a → b", result);
    }
}
