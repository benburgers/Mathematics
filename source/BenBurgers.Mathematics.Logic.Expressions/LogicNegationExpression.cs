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