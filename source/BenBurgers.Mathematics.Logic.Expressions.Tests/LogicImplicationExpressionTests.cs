/*
 * Ben Burgers Mathematics
 * © 2022 Ben Burgers and contributors
 * Licensed under AGPL 3.0
 */

namespace BenBurgers.Mathematics.Logic.Expressions.Tests;

public class LogicImplicationExpressionTests
{
    [Fact]
    public void ToStringTestHappy()
    {
        // Arrange
        var trueGetter = new Func<bool>(() => true);
        var falseGetter = new Func<bool>(() => false);
        var antecedent = new LogicPropositionVariableExpression(new PropositionVariable("a", trueGetter));
        var consequent = new LogicPropositionVariableExpression(new PropositionVariable("b", falseGetter));
        var implicationExpression = new LogicImplicationExpression(antecedent, consequent);

        // Act
        var result = implicationExpression.ToString();

        // Assert
        Assert.Equal("a → b", result);
    }
}
