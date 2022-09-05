/*
 * Ben Burgers Mathematics
 * © 2022 Ben Burgers and contributors
 * Licensed under AGPL 3.0
 */

using System.Linq.Expressions;

namespace BenBurgers.Mathematics.Logic.Expressions.Abstractions;

/// <summary>
/// A logic binary expression.
/// </summary>
public abstract class LogicBinaryExpression
    : LogicExpression,
    IEquatable<LogicBinaryExpression>,
    ILogicBinaryExpression
{
    /// <summary>
    /// The left hand side of the expression.
    /// </summary>
    protected LogicExpression left;

    /// <summary>
    /// The right hand side of the expression.
    /// </summary>
    protected LogicExpression right;

    /// <summary>
    /// Any other expressions.
    /// </summary>
    protected IReadOnlyList<LogicExpression> others;

    /// <summary>
    /// Initializes a new instance of <see cref="LogicBinaryExpression" />.
    /// </summary>
    /// <param name="left">The left operand of the expression.</param>
    /// <param name="right">The right operand of the expression.</param>
    /// <param name="others">Any additional operands, if the particular expression allows it.</param>
    protected LogicBinaryExpression(
        LogicExpression left,
        LogicExpression right,
        params LogicExpression[] others)
    {
        this.left = left;
        this.right = right;
        this.others = others;
    }

    /// <inheritdoc />
    public override bool CanReduce =>
        this.left.CanReduce
        || this.right.CanReduce
        || this.others.Any(o => o.CanReduce);

    /// <inheritdoc />
    public override bool Equals(object? obj)
    {
        return obj switch
        {
            null => false,
            LogicBinaryExpression binaryExpression => this.Equals(binaryExpression),
            _ => false
        };
    }

    /// <inheritdoc />
    public virtual bool Equals(LogicBinaryExpression? binaryExpression)
    {
        if (binaryExpression is null) return false;
        return
            this.left.Equals(binaryExpression.left)
            && this.right.Equals(binaryExpression.right)
            && this.others.SequenceEqual(binaryExpression.others);
    }


    /// <inheritdoc />
    public override int GetHashCode()
    {
        return HashCode.Combine(base.GetHashCode(), this.left, this.right, this.others);
    }

    /// <inheritdoc />
    /// <remarks>
    /// Implementations should check if the number of operands can be reduced, too.
    /// </remarks>
    public override Expression Reduce()
    {
        if (!this.CanReduce) return this;
        var left = (LogicExpression)this.left.Reduce();
        var right = (LogicExpression)this.right.Reduce();
        var others =
            this
                .others
                .Select(o => (LogicExpression)o.Reduce())
                .ToArray();
        return this.Update(left, right, others);
    }

    /// <inheritdoc />
    public abstract override string ToString();

    /// <summary>
    /// Updates the binary expression with new operands.
    /// </summary>
    /// <param name="left">The left operand.</param>
    /// <param name="right">The right operand.</param>
    /// <param name="others">Any other operands, if allowed by the expression.</param>
    /// <returns>
    /// If changed, a copy of this <see cref="LogicBinaryExpression" /> with the new operands, 
    /// otherwise the identity of this expression.
    /// </returns>
    public virtual LogicBinaryExpression Update(
        LogicExpression left,
        LogicExpression right,
        params LogicExpression[] others)
    {
        if (
            left == this.left
            && right == this.right
            && others.SequenceEqual(this.others))
        {
            return this;
        }
        var clone = (LogicBinaryExpression)this.Clone();
        clone.left = left;
        clone.right = right;
        clone.others = others;
        return clone;
    }

    /// <inheritdoc />
    protected override Expression VisitChildren(ExpressionVisitor visitor)
    {
        var left = (LogicExpression)visitor.Visit(this.left);
        var right = (LogicExpression)visitor.Visit(this.right);
        var others =
            this
                .others
                .Select(o => (LogicExpression)visitor.Visit(o))
                .ToArray();
        return this.Update(left, right, others);
    }

    LogicExpression ILogicBinaryExpression.Left => this.left;

    LogicExpression ILogicBinaryExpression.Right => this.right;

    IReadOnlyList<LogicExpression> ILogicBinaryExpression.Others => this.others;
}