/*
 * Ben Burgers Mathematics
 * © 2022 Ben Burgers and contributors
 * Licensed under AGPL 3.0
 */

using BenBurgers.Mathematics.Logic.Symbols;

namespace BenBurgers.Mathematics.Logic.Expressions;

/// <summary>
/// A material equivalence expression.
/// </summary>
public sealed class LogicEquivalenceExpression
    : LogicBinaryExpression
{
    /// <summary>
    /// Initializes a new instance of <see cref="LogicEquivalenceExpression" />.
    /// </summary>
    /// <param name="left">The left operand.</param>
    /// <param name="right">The right operand.</param>
    public LogicEquivalenceExpression(
        LogicExpression left,
        LogicExpression right)
        : base(left, right)
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

    /// <inheritdoc />
    public override LogicBinaryExpression Clone()
    {
        return new LogicEquivalenceExpression(this.Left, this.Right);
    }

    /// <inheritdoc />
    public override string ToString()
    {
        return $"{this.Left} {Symbol.Equivalence()} {this.Right}";
    }
}
