/*
 * Ben Burgers Mathematics
 * © 2022-2023 Ben Burgers and contributors
 * Licensed under AGPL 3.0
 */

using BenBurgers.Mathematics.Logic.Symbols;

namespace BenBurgers.Mathematics.Logic.Expressions;

/// <summary>
/// A logical semantic consequence expression.
/// </summary>
public sealed class LogicSemanticConsequenceExpression
    : LogicBinaryExpression
{
    /// <summary>
    /// Initializes a new instance of <see cref="LogicSemanticConsequenceExpression" />.
    /// </summary>
    /// <param name="antecedent">
    /// The antecedent.
    /// </param>
    /// <param name="consequent">
    /// The consequent.
    /// </param>
    public LogicSemanticConsequenceExpression(
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
        return new LogicSemanticConsequenceExpression(this.left, this.right);
    }

    /// <inheritdoc />
    public override string ToString()
    {
        return $"{this.left} {Symbol.SemanticConsequence()} {this.right}";
    }
}