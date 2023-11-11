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

namespace BenBurgers.Mathematics.Logic.Symbols;

/// <summary>
/// Represents a logic predicate identifier.
/// </summary>
public sealed class SymbolPredicateIdentifier
    : Symbol
{
    private SymbolPredicateIdentifier(string identifier)
        : base(identifier)
    {
    }

    /// <summary>
    /// Creates a <see cref="SymbolPredicateIdentifier" /> from <paramref name="identifier" />.
    /// </summary>
    /// <param name="identifier">
    /// The character from which to create the <see cref="SymbolPredicateIdentifier" />.
    /// </param>
    /// <returns>
    /// The <see cref="SymbolPredicateIdentifier" />.
    /// </returns>
    /// <exception cref="LogicSymbolLetterInvalidException">
    /// A <see cref="LogicSymbolLetterInvalidException" /> is thrown if <paramref name="identifier" /> is not a valid predicate letter symbol.
    /// </exception>
    public static SymbolPredicateIdentifier From(char identifier)
    {
        if (!PredicateLetters.Contains(identifier))
            throw new LogicSymbolLetterInvalidException(identifier);
        return new(new string(identifier, 1));
    }

    /// <summary>
    /// Creates a <see cref="SymbolPredicateIdentifier" /> from <paramref name="identifier" />.
    /// </summary>
    /// <param name="identifier">
    /// The predicate identifier.
    /// </param>
    /// <returns>
    /// The <see cref="SymbolPredicateIdentifier" />.
    /// </returns>
    /// <exception cref="AggregateException">
    /// An <see cref="AggregateException" /> is thrown if one or more letters in <paramref name="identifier" /> are invalid.
    /// </exception>
    public static SymbolPredicateIdentifier From(string identifier)
    {
        var lettersInvalid =
            identifier
                .Where(c => !PredicateLetters.Contains(c))
                .Select(c => new LogicSymbolLetterInvalidException(c))
                .ToArray();
        if (lettersInvalid.Any())
            throw new AggregateException(lettersInvalid);
        return new(identifier);
    }
}