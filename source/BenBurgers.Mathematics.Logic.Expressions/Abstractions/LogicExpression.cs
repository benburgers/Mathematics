/*
 * Ben Burgers Mathematics
 * © 2022 Ben Burgers and contributors
 * Licensed under AGPL 3.0
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
