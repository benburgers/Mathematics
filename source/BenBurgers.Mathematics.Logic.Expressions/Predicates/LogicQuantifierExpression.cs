/*
 * This file is part of Ben Burgers Mathematics.
 * 
 * Ben Burgers Mathematics is free software: you can redistribute it and/or modify it under the terms of the GNU General Public License 
 * as published by the Free Software Foundation, either version 3 of the License, or (at your option) any later version.
 * 
 * Ben Burgers Mathematics is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY;
 * without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
 * See the GNU General Public License for more details.
 * 
 * You should have received a copy of the GNU General Public License along with Foobar. If not, see <https://www.gnu.org/licenses/>.
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