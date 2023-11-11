/*
 * This file is part of Ben Burgers Mathematics.
 * 
 * Ben Burgers Mathematics is free software: you can redistribute it and/or modify it under the terms of the GNU General Public License 
 * as published by the Free Software Foundation, either version 3 of the License, or (at your option) any later version.
 * 
 * Ben Burgers Mathematics is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY;
 * without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
 * See the GNU General Public License for more details.
 * 
 * You should have received a copy of the GNU General Public License along with Foobar. If not, see <https://www.gnu.org/licenses/>.
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