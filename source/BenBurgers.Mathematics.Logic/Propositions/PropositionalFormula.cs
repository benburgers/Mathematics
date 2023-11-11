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

namespace BenBurgers.Mathematics.Logic.Propositions;

/// <summary>
/// A propositional formula.
/// </summary>
public abstract class PropositionalFormula
    : Formula
{
    /// <summary>
    /// Initializes a new instance of <see cref="PropositionalFormula" />.
    /// </summary>
    protected PropositionalFormula()
        : base()
    {
    }

    /// <summary>
    /// Initializes a new instance of <see cref="PropositionalFormula" />.
    /// </summary>
    /// <param name="children">The propositional formula's children.</param>
    protected PropositionalFormula(IEnumerable<PropositionalFormula> children)
        : base(children)
    {
    }

    /// <summary>
    /// Creates a conjunction of the current formula and other formulae.
    /// </summary>
    /// <param name="other">The other formula.</param>
    /// <param name="rest">More formulae, if applicable.</param>
    /// <returns>
    /// A conjunction of propositional formulae.
    /// </returns>
    public PropositionalFormulaConjunction And(PropositionalFormula other, params PropositionalFormula[] rest) =>
        new(rest.Prepend(other).Prepend(this));

    /// <summary>
    /// Creates a disjunction of the current formula and other formulae.
    /// </summary>
    /// <param name="other">The other formula.</param>
    /// <param name="rest">More formulae, if applicable.</param>
    /// <returns>
    /// A disjunction of propositional formulae.
    /// </returns>
    public PropositionalFormulaDisjunction Or(PropositionalFormula other, params PropositionalFormula[] rest) =>
        new(rest.Prepend(other).Prepend(this));
}