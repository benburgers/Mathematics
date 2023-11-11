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

public class LogicDisjunctionNegationExpressionTests
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
            new LogicPropositionVariableExpression(new PropositionVariableFunc("a", TrueGetter)),
            new LogicPropositionVariableExpression(new PropositionVariableFunc("b", FalseGetter)),
            new LogicPropositionVariableExpression(new PropositionVariableFunc("c", TrueGetter))
        };

    [Theory]
    [InlineData(0, "a ↓ b")]
    [InlineData(1, "a ↓ b ↓ c")]
    [InlineData(2, "c ↓ a ↓ b")]
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
        var disjunctionNegationExpression = new LogicDisjunctionNegationExpression(left, right, others);

        // Act
        var actual = disjunctionNegationExpression.ToString();

        // Assert
        Assert.Equal(expected, actual);
    }
}