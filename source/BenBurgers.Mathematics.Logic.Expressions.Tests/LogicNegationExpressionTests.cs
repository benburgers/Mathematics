/*
 * Ben Burgers Mathematics
 * © 2022 Ben Burgers and contributors
 * Licensed under AGPL 3.0
 */

namespace BenBurgers.Mathematics.Logic.Expressions.Tests;

public class LogicNegationExpressionTests
{
    private static readonly Func<bool> TrueGetter = new(() => true);
    private static readonly Func<bool> FalseGetter = new(() => false);
    private readonly IReadOnlyList<LogicExpression> Expressions =
        new LogicExpression[]
        {
            new LogicPropositionVariableExpression(new PropositionVariable("a", TrueGetter)),
            new LogicConjunctionExpression(
                new LogicPropositionVariableExpression(new PropositionVariable("a", TrueGetter)),
                new LogicPropositionVariableExpression(new PropositionVariable("b", FalseGetter))),
            new LogicDisjunctionExpression(
                new LogicPropositionVariableExpression(new PropositionVariable("c", TrueGetter)),
                new LogicPropositionVariableExpression(new PropositionVariable("d", TrueGetter)),
                new LogicPropositionVariableExpression(new PropositionVariable("e", FalseGetter)))
        };

    [Theory]
    [InlineData(0, "¬a")]
    [InlineData(1, "¬(a ∧ b)")]
    [InlineData(2, "¬(c ∨ d ∨ e)")]
    public void ToStringTest(int expressionIndex, string expected)
    {
        // Arrange
        var operand = Expressions[expressionIndex];
        var negationExpression = new LogicNegationExpression(operand);

        // Act
        var actual = negationExpression.ToString();

        // Assert
        Assert.Equal(expected, actual);
    }
}