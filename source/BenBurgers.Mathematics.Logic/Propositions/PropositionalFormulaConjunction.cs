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
 * You should have received a copy of the GNU General Public License along with Ben Burgers Mathematics. If not, see <https://www.gnu.org/licenses/>.
 */

using BenBurgers.Mathematics.Logic.Symbols;
using System.Text;

namespace BenBurgers.Mathematics.Logic.Propositions;

/// <summary>
/// A conjunctive propositional formula.
/// </summary>
/// <remarks>
/// Initializes a new instance of <see cref="PropositionalFormulaConjunction" />.
/// </remarks>
/// <param name="left">The left-hand operand of the conjunction.</param>
/// <param name="right">The right-hand operand of the conjunction.</param>
public sealed class PropositionalFormulaConjunction(PropositionalFormula left, PropositionalFormula? right)
    : PropositionalFormula(right is not null ? [left, right] : [left])
{
    /// <inheritdoc />
    public override string ToString()
    {
        var children = this.ToArray();
        if (children.Length > 0 && children.Any(c => c is PropositionalFormulaDisjunction))
        {
            var stringBuilder = new StringBuilder();
            stringBuilder.Append(children[0].ToString());

            stringBuilder.Append(Symbol.ConjunctionChar);

            var secondIsDisjunction = children[1] is PropositionalFormulaDisjunction;
            if (secondIsDisjunction)
                stringBuilder.Append(Symbol.ParenthesisOpenChar);
            stringBuilder.Append(children[1].ToString());
            if (secondIsDisjunction)
                stringBuilder.Append(Symbol.ParenthesisClosingChar);

            return stringBuilder.ToString();
        }
        return children[0].ToString();
    }
}
