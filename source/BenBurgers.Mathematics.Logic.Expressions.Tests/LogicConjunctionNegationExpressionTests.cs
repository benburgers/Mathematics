/*
 * Ben Burgers Mathematics
 * © 2022 Ben Burgers and contributors
 * Licensed under AGPL 3.0
 */

namespace BenBurgers.Mathematics.Logic.Expressions.Tests;

public class LogicConjunctionNegationExpressionTests
{
    private static readonly Func<bool> TrueGetter = new(() => true);
    private static readonly Func<bool> FalseGetter = new(() => false);
    private static readonly int[][] ExpressionIndices =
        new int[][]
        {
            new[] { 0, 1 },
            new[] { 0, 1, 2 },
            new[] { 2, 0, 1 }
        };
    private static readonly IReadOnlyList<LogicExpression> Expressions =
        new LogicExpression[]
        {
            new LogicPropositionVariableExpression(new PropositionVariable("a", TrueGetter)),
            new LogicPropositionVariableExpression(new PropositionVariable("b", TrueGetter)),
            new LogicPropositionVariableExpression(new PropositionVariable("c", FalseGetter))
        };

    [Theory]
    [InlineData(0, "a ↑ b")]
    [InlineData(1, "a ↑ b ↑ c")]
    [InlineData(2, "c ↑ a ↑ b")]
    public void ToStringTest(int expressionIndicesIndex, string expected)
    {
        // Arrange
        var expressionIndices = ExpressionIndices[expressionIndicesIndex];
        var leftIndex = expressionIndices[0];
        var rightIndex = expressionIndices[1];
        var otherIndices = expressionIndices.Skip(2);
        var left = Expressions[leftIndex];
        var right = Expressions[rightIndex];
        var others = otherIndices.Select(i => Expressions[i]).ToArray();
        var conjunctionNegationExpression = new LogicConjunctionNegationExpression(left, right, others);

        // Act
        var actual = conjunctionNegationExpression.ToString();

        // Assert
        Assert.Equal(expected, actual);
    }
}