/*
 * Ben Burgers Mathematics
 * © 2022 Ben Burgers and contributors
 * Licensed under AGPL 3.0
 */

using BenBurgers.Mathematics.Logic.Symbols;
using System.Text;

namespace BenBurgers.Mathematics.Logic.Expressions;

/// <summary>
/// A negation expression.
/// </summary>
public sealed class LogicNegationExpression : LogicUnaryExpression
{
    /// <summary>
    /// Initializes a new instance of <see cref="LogicNegationExpression" />.
    /// </summary>
    /// <param name="operand">
    /// The operand.
    /// </param>
    public LogicNegationExpression(LogicExpression operand)
        : base(operand)
    {
    }

    /// <inheritdoc />
    public override LogicUnaryExpression Clone()
    {
        return new LogicNegationExpression(this.Operand);
    }

    /// <inheritdoc />
    public override string ToString()
    {
        var stringBuilder = new StringBuilder();
        stringBuilder.Append(Symbol.Negation());
        stringBuilder.Append(this.Operand switch
        {
            LogicBinaryExpression binary => $"({binary})",
            _ => this.Operand.ToString()
        });
        return stringBuilder.ToString();
    }
}