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

namespace BenBurgers.Mathematics.Logic.Expressions.Tests;

public class LogicValueExpressionTests
{
    private static readonly IReadOnlyList<LogicValueExpression> Expressions =
        new LogicValueExpression[]
        {
            new(true),
            new(false),
            new(null)
        };

    [Theory]
    [InlineData(0)]
    [InlineData(1)]
    [InlineData(2)]
    public void CloneTest(int expressionIndex)
    {
        // Arrange
        var expression = Expressions[expressionIndex];

        // Act
        var clone = expression.Clone();

        // Assert
        Assert.False(ReferenceEquals(clone, expression));
        Assert.Equal(clone.Value, expression.Value);
    }

    [Theory]
    [InlineData(0, "1")]
    [InlineData(1, "0")]
    [InlineData(2, "?")]
    public void ToStringTest(int expressionIndex, string expected)
    {
        // Arrange
        var expression = Expressions[expressionIndex];

        // Act
        var actual = expression.ToString();

        // Assert
        Assert.Equal(expected, actual);
    }
}