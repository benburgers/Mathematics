/*
 * Ben Burgers Mathematics
 * © 2022 Ben Burgers and contributors
 * Licensed under AGPL 3.0
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