/*
 * Ben Burgers Mathematics
 * © 2022-2023 Ben Burgers and contributors
 * Licensed under AGPL 3.0
 */

using BenBurgers.Mathematics.Logic.Propositions;
using BenBurgers.Mathematics.Logic.Propositions.Variables;
using BenBurgers.Mathematics.Logic.Symbols;

namespace BenBurgers.Mathematics.Logic.Tests.Propositions;

public class PropositionalFormulaTests
{
    public static readonly IEnumerable<object?[]> ToStringArguments =
        new[]
        {
            new object?[]
            {
                new PropositionVariableStatic("foo", false).Or(new PropositionVariableStatic("bar", true)),
                "foo∨bar"
            },
            new object?[]
            {
                new PropositionVariableStatic("foo", false).Or(new PropositionVariableStatic("bar", true).And(new PropositionVariableStatic("lorem", false))),
                "foo∨bar∧lorem"
            },
            new object?[]
            {
                new PropositionVariableStatic("foo", false).Or(new PropositionVariableStatic("bar", true)).And(new PropositionVariableStatic("lorem", false)),
                "(foo∨bar)∧lorem"
            },
            new object?[]
            {
                new Symbol[]
                {
                    Symbol.ParenthesisOpen(),
                    Symbol.PropositionIdentifier("foo"),
                    Symbol.Disjunction(),
                    Symbol.PropositionIdentifier("bar"),
                    Symbol.ParenthesisClose(),
                    Symbol.Implication(),
                    Symbol.PropositionIdentifier("lorem")
                },
                "(foo∨bar)→lorem"
            }
        };

    [Theory(DisplayName = $"{nameof(PropositionalFormula)} :: {nameof(ToString)}")]
    [MemberData(nameof(ToStringArguments))]
    public void ToStringTests(PropositionalFormula formula, string expected)
    {
        // Act
        var actual = formula.ToString();

        // Assert
        Assert.Equal(expected, actual);
    }
}