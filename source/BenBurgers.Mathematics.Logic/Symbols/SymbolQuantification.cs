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

using BenBurgers.Mathematics.Logic.Sets;

namespace BenBurgers.Mathematics.Logic.Symbols;

/// <summary>
/// A quantification symbol.
/// </summary>
public sealed class SymbolQuantification
    : Symbol
{
    private SymbolQuantification(char literal)
        : base(literal)
    {
    }

    private SymbolQuantification(string literal)
        : base(literal)
    {
    }

    /// <summary>
    /// Creates a quantifier logic symbol for the desired quantifier type.
    /// </summary>
    /// <param name="type">
    /// The quantifier type.
    /// </param>
    /// <returns>
    /// The quantifier logic symbol.
    /// </returns>
    /// <exception cref="LogicSymbolQuantifierNotSupportedException">
    /// A <see cref="LogicSymbolQuantifierNotSupportedException" /> is thrown if <paramref name="type" /> is not supported.
    /// </exception>
    public static SymbolQuantification Create(QuantifierType type)
        => type switch
        {
            QuantifierType.Existential => new(QuantificationExistentialChar),
            QuantifierType.Uniqueness => new(QuantificationUniquenessString),
            QuantifierType.Universal => new(QuantificationUniversalChar),
            _ => throw new LogicSymbolQuantifierNotSupportedException(type)
        };
}