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
/// A base unary expression.
/// </summary>
public abstract class LogicUnaryExpression
    : LogicExpression,
    IEquatable<LogicUnaryExpression>
{
    /// <summary>
    /// Initializes a new instance of <see cref="LogicUnaryExpression" />.
    /// </summary>
    /// <param name="operand">
    /// The operand.
    /// </param>
    protected LogicUnaryExpression(LogicExpression operand)
    {
        this.Operand = operand;
    }

    /// <inheritdoc />
    public override bool CanReduce => this.Operand.CanReduce;

    /// <summary>
    /// Gets the operand.
    /// </summary>
    public virtual LogicExpression Operand { get; private set; }

    /// <inheritdoc />
    public override bool Equals(object? obj)
    {
        return obj switch
        {
            null => false,
            LogicUnaryExpression unaryExpression => this.Equals(unaryExpression),
            _ => false
        };
    }

    /// <inheritdoc />
    public virtual bool Equals(LogicUnaryExpression? unaryExpression)
    {
        if (unaryExpression is null) return false;
        return this.Operand.Equals(unaryExpression.Operand);
    }

    /// <inheritdoc />
    public override int GetHashCode()
    {
        return HashCode.Combine(base.GetHashCode(), this.Operand.GetHashCode());
    }

    /// <inheritdoc />
    public override Expression Reduce()
    {
        return this.Update((LogicUnaryExpression)this.Operand.Reduce());
    }

    /// <inheritdoc />
    public override abstract string ToString();

    /// <summary>
    /// Updates the unary expression with a new operand.
    /// </summary>
    /// <param name="operand">The new operand.</param>
    /// <returns>
    /// If changed, a copy of this <see cref="LogicUnaryExpression" /> with the new operand, 
    /// otherwise the identity of this expression.
    /// </returns>
    public virtual LogicUnaryExpression Update(LogicExpression operand)
    {
        if (this.Operand == operand)
            return this;
        var clone = (LogicUnaryExpression)this.Clone();
        clone.Operand = operand;
        return clone;
    }

    /// <inheritdoc />
    protected override Expression VisitChildren(ExpressionVisitor visitor)
    {
        return this.Update((LogicExpression)visitor.Visit(this.Operand));
    }
}