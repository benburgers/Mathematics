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

using System.Linq.Expressions;

namespace BenBurgers.Mathematics.Logic.Expressions.Abstractions;

/// <summary>
/// A base logic expression.
/// </summary>
public abstract class LogicExpression
    : Expression,
    ICloneable
{
    /// <inheritdoc />
    public override ExpressionType NodeType => ExpressionType.Extension;

    /// <summary>
    /// Creates and returns an exact copy of this expression and its relations.
    /// </summary>
    /// <returns>
    /// The copy of this expression and its relations.
    /// </returns>
    public abstract LogicExpression Clone();

    /// <inheritdoc />
    public override abstract string ToString();

    object ICloneable.Clone()
    {
        return this.Clone();
    }
}
