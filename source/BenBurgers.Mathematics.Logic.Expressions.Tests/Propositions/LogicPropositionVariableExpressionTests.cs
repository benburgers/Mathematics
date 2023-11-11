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