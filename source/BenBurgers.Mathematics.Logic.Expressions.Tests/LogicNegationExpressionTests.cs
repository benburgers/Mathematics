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

using BenBurgers.Mathematics.Logic.Propositions.Variables;

namespace BenBurgers.Mathematics.Logic.Expressions.Tests;

public class LogicNegationExpressionTests
{
    private static readonly Func<bool> TrueGetter = new(() => true);
    private static readonly Func<bool> FalseGetter = new(() => false);
    private readonly IReadOnlyList<LogicExpression> Expressions =
        new LogicExpression[]
        {
            new LogicPropositionVariableExpression(new PropositionVariableFunc("a", TrueGetter)),
            new LogicConjunctionExpression(
                new LogicPropositionVariableExpression(new PropositionVariableFunc("a", TrueGetter)),
                new LogicPropositionVariableExpression(new PropositionVariableFunc("b", FalseGetter))),
            new LogicDisjunctionExpression(
                new LogicPropositionVariableExpression(new PropositionVariableFunc("c", TrueGetter)),
                new LogicPropositionVariableExpression(new PropositionVariableFunc("d", TrueGetter)),
                new LogicPropositionVariableExpression(new PropositionVariableFunc("e", FalseGetter)))
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