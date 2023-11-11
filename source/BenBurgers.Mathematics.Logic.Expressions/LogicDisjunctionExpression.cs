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
/// Represents a logical (inclusive) disjunction.
/// </summary>
public sealed class LogicDisjunctionExpression
    : LogicBinaryExpression
{
    /// <summary>
    /// Initializes a new instance of <see cref="LogicDisjunctionExpression" />.
    /// </summary>
    /// <param name="left">
    /// The left hand side of the expression.
    /// </param>
    /// <param name="right">
    /// The right hand side of the expression.
    /// </param>
    /// <param name="others">
    /// Any other operands in the expression.
    /// </param>
    public LogicDisjunctionExpression(
        LogicExpression left,
        LogicExpression right,
        params LogicExpression[] others)
        : base(left, right, others)
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

    /// <summary>
    /// Any other operands in the expression.
    /// </summary>
    public IReadOnlyList<LogicExpression> Others => this.others;

    /// <inheritdoc />
    public override LogicBinaryExpression Clone()
    {
        throw new NotImplementedException();
    }

    /// <inheritdoc />
    public override string ToString()
    {
        return
            string.Join(
                $" {Symbol.Disjunction()} ",
                new LogicExpression[]
                {
                    this.Left,
                    this.Right
                }.Concat(this.Others));
    }
}
