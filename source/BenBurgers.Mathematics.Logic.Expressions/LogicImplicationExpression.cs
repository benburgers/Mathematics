/*
 * Ben Burgers Mathematics
 * © 2022 Ben Burgers and contributors
 * Licensed under AGPL 3.0
 */

using BenBurgers.Mathematics.Logic.Symbols;

namespace BenBurgers.Mathematics.Logic.Expressions;

/// <summary>
/// A material implication expression.
/// </summary>
public sealed class LogicImplicationExpression : LogicBinaryExpression
{
    /// <summary>
    /// Initializes a new instance of <see cref="LogicImplicationExpression" />.
    /// </summary>
    /// <param name="antecedent">The antecedent.</param>
    /// <param name="consequent">The consequent.</param>
    public LogicImplicationExpression(
        LogicExpression antecedent,
        LogicExpression consequent)
        : base(antecedent, consequent)
    {
    }

    /// <summary>
    /// Gets the antecedent.
    /// </summary>
    public LogicExpression Antecedent => this.left;

    /// <summary>
    /// Gets the consequent.
    /// </summary>
    public LogicExpression Consequent => this.right;
    
    /// <inheritdoc />
    public override LogicBinaryExpression Clone()
    {
        return new LogicImplicationExpression(this.left, this.right);
    }

    /// <inheritdoc />
    public override string ToString()
    {
        return $"{this.left} {Symbol.Implication()} {this.right}";
    }
}
