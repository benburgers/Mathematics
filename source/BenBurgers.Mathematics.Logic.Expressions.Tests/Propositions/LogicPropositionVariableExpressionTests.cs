﻿/*
 * Ben Burgers Mathematics
 * © 2022-2023 Ben Burgers and contributors
 * Licensed under AGPL 3.0
 */

using BenBurgers.Mathematics.Logic.Propositions.Variables;

namespace BenBurgers.Mathematics.Logic.Expressions.Tests.Propositions;

public class LogicPropositionVariableExpressionTests
{
    private static readonly Func<bool> TrueGetter = new(() => true);
    private static readonly Func<bool> FalseGetter = new(() => false);
    private static readonly IReadOnlyList<PropositionVariable> Variables =
        new PropositionVariable[]
        {
            new PropositionVariableFunc("a", TrueGetter),
            new PropositionVariableFunc("b", FalseGetter),
            new PropositionVariableFunc("foo", TrueGetter),
            new PropositionVariableFunc("bar", FalseGetter)
        };

    [Theory]
    [InlineData(0, "a")]
    [InlineData(1, "b")]
    [InlineData(2, "foo")]
    [InlineData(3, "bar")]
    public void ToStringTest(int variableIndex, string expected)
    {
        // Arrange
        var variable = Variables[variableIndex];
        var variableExpression = new LogicPropositionVariableExpression(variable);

        // Act
        var actual = variableExpression.ToString();

        // Assert
        Assert.Equal(expected, actual);
    }
}