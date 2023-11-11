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
