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