/*
 * Ben Burgers Mathematics
 * © 2022-2023 Ben Burgers and contributors
 * Licensed under AGPL 3.0
 */

using BenBurgers.Mathematics.Logic.Symbols;

namespace BenBurgers.Mathematics.Logic.Expressions;

/// <summary>
/// Represents an exclusive disjunction expression.
/// </summary>
public sealed class LogicDisjunctionExclusiveExpression
    : LogicBinaryExpression
{
    /// <summary>
    /// Initializes a new instance of <see cref="LogicDisjunctionExclusiveExpression" />.
    /// </summary>
    /// <param name="left">The left hand side of the expression.</param>
    /// <param name="right">The right hand side of the expression.</param>
    /// <param name="others">Any other operands.</param>
    public LogicDisjunctionExclusiveExpression(
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
    /// Gets any other operands in the expression.
    /// </summary>
    public IReadOnlyList<LogicExpression> Others => this.others;

    /// <inheritdoc />
    public override LogicBinaryExpression Clone()
    {
        return new LogicDisjunctionExclusiveExpression(this.Left, this.Right, this.Others.ToArray());
    }

    /// <inheritdoc />
    public override string ToString()
    {
        return
            string.Join(
                $" {Symbol.DisjunctionExclusive()} ",
                new LogicExpression[]
                {
                    this.Left,
                    this.Right
                }.Concat(this.Others));
    }
}
