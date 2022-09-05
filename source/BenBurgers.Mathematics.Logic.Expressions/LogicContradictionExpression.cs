/*
 * Ben Burgers Mathematics
 * © 2022 Ben Burgers and contributors
 * Licensed under AGPL 3.0
 */

using BenBurgers.Mathematics.Logic.Symbols;
using System.Linq.Expressions;

namespace BenBurgers.Mathematics.Logic.Expressions;

/// <summary>
/// Represents a contradiction expression.
/// </summary>
public sealed class LogicContradictionExpression
    : LogicExpression
{
    /// <summary>
    /// The singleton instance of the contradiction expression.
    /// </summary>
    public static readonly LogicContradictionExpression Instance = new();

    private LogicContradictionExpression()
    {
    }

    /// <inheritdoc />
    public override bool CanReduce => false;

    /// <inheritdoc />
    /// <remarks>
    /// The contradiction expression is a singleton, so it always returns itself.
    /// </remarks>
    public override LogicExpression Clone()
    {
        return Instance;
    }

    /// <inheritdoc />
    public override string ToString()
    {
        return $"{Symbol.Contradiction()}";
    }

    /// <inheritdoc />
    protected override Expression VisitChildren(ExpressionVisitor visitor)
    {
        return this;
    }
}