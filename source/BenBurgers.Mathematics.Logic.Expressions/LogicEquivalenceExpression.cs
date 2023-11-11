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

using BenBurgers.Mathematics.Logic.Symbols;

namespace BenBurgers.Mathematics.Logic.Expressions;

/// <summary>
/// A material equivalence expression.
/// </summary>
public sealed class LogicEquivalenceExpression
    : LogicBinaryExpression
{
    /// <summary>
    /// Initializes a new instance of <see cref="LogicEquivalenceExpression" />.
    /// </summary>
    /// <param name="left">The left operand.</param>
    /// <param name="right">The right operand.</param>
    public LogicEquivalenceExpression(
        LogicExpression left,
        LogicExpression right)
        : base(left, right)
    {
    }

    /// <summary>
    /// Gets the left hand side of the expression.
    /// </summary>
    public LogicExpression Left => this.left;

    /// <summary>
    /// Gets the right hand side of the expression.
    /// </summary>
    public LogicExpression Right => this.right;

    /// <inheritdoc />
    public override LogicBinaryExpression Clone()
    {
        return new LogicEquivalenceExpression(this.Left, this.Right);
    }

    /// <inheritdoc />
    public override string ToString()
    {
        return $"{this.Left} {Symbol.Equivalence()} {this.Right}";
    }
}
