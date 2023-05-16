/*
 * Ben Burgers Mathematics
 * © 2022-2023 Ben Burgers and contributors
 * Licensed under AGPL 3.0
 */

using BenBurgers.Mathematics.Logic.Symbols;
using System.Text;

namespace BenBurgers.Mathematics.Logic.Expressions.Predicates;

/// <summary>
/// A logical expression that involves a quantifier.
/// </summary>
public sealed class LogicQuantifierExpression
    : LogicUnaryExpression
{
    /// <summary>
    /// Initializes a new instance of <see cref="LogicQuantifierExpression" />.
    /// </summary>
    /// <param name="quantifier">
    /// The quantifier of the expression.
    /// </param>
    /// <param name="operand">
    /// The operand.
    /// </param>
    public LogicQuantifierExpression(QuantifierType quantifier, LogicExpression operand)
        : base(operand)
    {
        this.Quantifier = quantifier;
    }
    
    /// <summary>
    /// Gets the quantifier of the expression.
    /// </summary>
    public QuantifierType Quantifier { get; }

    /// <inheritdoc />
    public override LogicUnaryExpression Clone()
    {
        throw new NotImplementedException();
    }

    /// <inheritdoc />
    public override string ToString()
    {
        var stringBuilder = new StringBuilder();
        stringBuilder.Append(this.Quantifier switch
        {
            QuantifierType.Existential => Symbol.Quantification(QuantifierType.Existential),
            QuantifierType.Uniqueness => Symbol.Quantification(QuantifierType.Uniqueness),
            QuantifierType.Universal => Symbol.Quantification(QuantifierType.Universal),
            _ => throw new IndexOutOfRangeException()
        });
        stringBuilder.Append(this.Operand.ToString());
        return stringBuilder.ToString();
    }
}