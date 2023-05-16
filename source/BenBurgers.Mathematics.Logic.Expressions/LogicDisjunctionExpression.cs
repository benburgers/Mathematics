/*
 * Ben Burgers Mathematics
 * © 2022-2023 Ben Burgers and contributors
 * Licensed under AGPL 3.0
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
