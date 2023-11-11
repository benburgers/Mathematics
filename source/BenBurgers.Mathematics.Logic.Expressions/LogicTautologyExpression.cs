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
using System.Linq.Expressions;

namespace BenBurgers.Mathematics.Logic.Expressions;

/// <summary>
/// Represents a tautology expression.
/// </summary>
public sealed class LogicTautologyExpression
    : LogicExpression
{
    /// <summary>
    /// The singleton instance of the logical tautology expression.
    /// </summary>
    public static readonly LogicTautologyExpression Instance = new();

    private LogicTautologyExpression()
    {
    }

    /// <inheritdoc />
    public override bool CanReduce => false;

    /// <inheritdoc />
    /// <remarks>
    /// The tautology expression is a singleton, so it always returns itself.
    /// </remarks>
    public override LogicExpression Clone()
    {
        return Instance;
    }

    /// <inheritdoc />
    public override string ToString()
    {
        return $"{Symbol.Tautology()}";
    }

    /// <inheritdoc />
    protected override Expression VisitChildren(ExpressionVisitor visitor)
    {
        return this;
    }
}