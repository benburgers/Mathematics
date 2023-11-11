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

public class LogicImplicationExpressionTests
{
    [Fact]
    public void ToStringTestHappy()
    {
        // Arrange
        var trueGetter = new Func<bool>(() => true);
        var falseGetter = new Func<bool>(() => false);
        var antecedent = new LogicPropositionVariableExpression(new PropositionVariableFunc("a", trueGetter));
        var consequent = new LogicPropositionVariableExpression(new PropositionVariableFunc("b", falseGetter));
        var implicationExpression = new LogicImplicationExpression(antecedent, consequent);

        // Act
        var result = implicationExpression.ToString();

        // Assert
        Assert.Equal("a → b", result);
    }
}
