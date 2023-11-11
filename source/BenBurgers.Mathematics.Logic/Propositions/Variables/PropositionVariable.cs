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

namespace BenBurgers.Mathematics.Logic.Propositions.Variables;

/// <summary>
/// Represents a proposition variable.
/// </summary>
/// <example>
///     <list type="bullet">
///         <item>a</item>
///         <item>p</item>
///     </list>
/// </example>
/// <remarks>
/// A variable in a propositional formula.
/// </remarks>
public abstract class PropositionVariable
    : PropositionalFormula
{
    /// <summary>
    /// Initializes a new instance of <see cref="PropositionVariable" />.
    /// </summary>
    /// <param name="identifier">
    /// The identifier of the proposition variable.
    /// </param>
    protected PropositionVariable(string identifier)
        : base()
    {
        this.Identifier = identifier;
    }

    /// <summary>
    /// Gets the identifier of the proposition variable.
    /// </summary>
    public string Identifier { get; }

    /// <summary>
    /// Gets the formulaic symbol that represents the proposition variable.
    /// </summary>
    public SymbolPropositionIdentifier Symbol => Symbols.Symbol.PropositionIdentifier(this.Identifier);

    /// <summary>
    /// Gets the value of the proposition value.
    /// </summary>
    public abstract bool Value { get; }
}
