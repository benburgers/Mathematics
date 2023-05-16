/*
 * Ben Burgers Mathematics
 * © 2022-2023 Ben Burgers and contributors
 * Licensed under AGPL 3.0
 */

using BenBurgers.Mathematics.Logic.Propositions.Variables;

namespace BenBurgers.Mathematics.Logic.Expressions.Tests;

public class LogicSyntacticConsequenceExpressionTests
{
    private static readonly Func<bool> TrueGetter = new(() => true);
    private static readonly Func<bool> FalseGetter = new(() => false);
    private static readonly IReadOnlyList<LogicExpression> TestExpressions =
        new LogicExpression[]
        {
            new LogicPropositionVariableExpression(new PropositionVariableFunc("a", TrueGetter)),
            new LogicPropositionVariableExpression(new PropositionVariableFunc("b", TrueGetter)),
            new LogicConjunctionExpression(
                new LogicPropositionVariableExpression(new PropositionVariableFunc("c", FalseGetter)),
                new LogicPropositionVariableExpression(new PropositionVariableFunc("d", FalseGetter)))
        };

    [Theory]
    [InlineData(0, 1, "a ⊢ b")]
    [InlineData(0, 2, "a ⊢ c ∧ d")]
    [InlineData(1, 2, "b ⊢ c ∧ d")]
    [InlineData(2, 1, "c ∧ d ⊢ b")]
    public void ToStringTest(int antecedentIndex, int consequentIndex, string expected)
    {
        // Arrange
        var antecedent = TestExpressions[antecedentIndex];
        var consequent = TestExpressions[consequentIndex];
        var syntacticConsequenceExpression = new LogicSyntacticConsequenceExpression(antecedent, consequent);

        // Act
        var actual = syntacticConsequenceExpression.ToString();

        // Assert
        Assert.Equal(expected, actual);
    }
}