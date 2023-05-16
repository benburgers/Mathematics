/*
 * Ben Burgers Mathematics
 * © 2022-2023 Ben Burgers and contributors
 * Licensed under AGPL 3.0
 */

using BenBurgers.Mathematics.Logic.Symbols;

namespace BenBurgers.Mathematics.Logic.Expressions;

/// <summary>
/// A syntactic consequence expression.
/// </summary>
/// <remarks>
/// Also known as "proves" or "entails".
/// </remarks>
public sealed class LogicSyntacticConsequenceExpression
    : LogicBinaryExpression
{
    /// <summary>
    /// Initializes a new instance of <see cref="LogicSyntacticConsequenceExpression" />.
    /// </summary>
    /// <param name="antecedent">
    /// The antecedent.
    /// </param>
    /// <param name="consequent">
    /// The consequent.
    /// </param>
    public LogicSyntacticConsequenceExpression(
        LogicExpression antecedent,
        LogicExpression consequent)
        : base(antecedent, consequent)
    {
    }

    /// <summary>
    /// Gets the antecedent in the consequence expression.
    /// </summary>
    public LogicExpression Antecedent => this.left;

    /// <summary>
    /// Gets the consequent in the consequence expression.
    /// </summary>
    public LogicExpression Consequent => this.right;

    /// <inheritdoc />
    public override LogicBinaryExpression Clone()
    {
        return new LogicSyntacticConsequenceExpression(this.left, this.right);
    }

    /// <inheritdoc />
    public override string ToString()
    {
        return $"{this.left} {Symbol.SyntacticConsequence()} {this.right}";
    }
}