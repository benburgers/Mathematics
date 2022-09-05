/*
 * Ben Burgers Mathematics
 * © 2022 Ben Burgers and contributors
 * Licensed under AGPL 3.0
 */

using BenBurgers.Mathematics.Logic.Symbols;

namespace BenBurgers.Mathematics.Logic.Expressions;

/// <summary>
/// A logical disjunction negation expression.
/// </summary>
/// <remarks>
/// Also known as "NOR".
/// </remarks>
public sealed class LogicDisjunctionNegationExpression
    : LogicBinaryExpression
{
    /// <summary>
    /// Initializes a new instance of <see cref="LogicDisjunctionNegationExpression" />.
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
    public LogicDisjunctionNegationExpression(
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
        return new LogicDisjunctionNegationExpression(this.Left, this.Right, this.Others.ToArray());
    }

    /// <inheritdoc />
    public override string ToString()
    {
        return string.Join($" {Symbol.DisjunctionNegation()} ",
            new LogicExpression[]
            {
                this.Left,
                this.Right
            }.Concat(this.Others));
    }
}