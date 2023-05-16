/*
 * Ben Burgers Mathematics
 * © 2022-2023 Ben Burgers and contributors
 * Licensed under AGPL 3.0
 */

using BenBurgers.Mathematics.Logic.Propositions;
using BenBurgers.Mathematics.Logic.Symbols;

namespace BenBurgers.Mathematics.Logic.Tests.Propositions;

public class PropositionalFormulaTests
{
    public static readonly IEnumerable<object?[]> AddArguments =
        new[]
        {
            new object?[]
            {
                new Symbol[]
                {
                    Symbol.PropositionIdentifier("foo"),
                    Symbol.Disjunction(),
                    Symbol.PropositionIdentifier("bar")
                },
                "foo∨bar",
                null
            },
            new object?[]
            {
                new Symbol[]
                {
                    Symbol.PropositionIdentifier("foo"),
                    Symbol.PropositionIdentifier("bar")
                },
                "foo bar",
                new LogicFormulaInvalidSymbolInCurrentStateException(Symbol.PropositionIdentifier("bar"))
            },
            new object?[]
            {
                new Symbol[]
                {
                    Symbol.Disjunction(),
                    Symbol.Conjunction(),
                    Symbol.PropositionIdentifier("foo")
                },
                "∨∧foo",
                new LogicFormulaInvalidSymbolInCurrentStateException(Symbol.Conjunction())
            },
            new object?[]
            {
                new Symbol[]
                {
                    Symbol.PropositionIdentifier("foo"),
                    Symbol.Disjunction(),
                    Symbol.PropositionIdentifier("bar"),
                    Symbol.Conjunction(),
                    Symbol.PropositionIdentifier("lorem")
                },
                "foo∨bar∧lorem",
                null
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
                    Symbol.Conjunction(),
                    Symbol.PropositionIdentifier("lorem")
                },
                "(foo∨bar)∧lorem",
                null
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
                "(foo∨bar)→lorem",
                null
            }
        };

    [Theory(DisplayName = "Propositional Formula :: Add")]
    [MemberData(nameof(AddArguments))]
    public void AddTests(Symbol[] symbols, string representation, Exception? exception)
    {
        if (exception is { })
        {
            var exceptionType = exception.GetType();
            Assert.Throws(exceptionType, () => new PropositionalFormula(symbols));
            return;
        }

        // Act
        var formula = new PropositionalFormula(symbols);

        // Assert
        var symbolsContained = formula.ToArray();
        Assert.NotEmpty(symbolsContained);
        Assert.Equal(formula.ToString(), representation);
    }
}