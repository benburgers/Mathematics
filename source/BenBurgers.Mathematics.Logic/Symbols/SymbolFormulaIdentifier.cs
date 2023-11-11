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
/// Represents a logic formula identifier.
/// </summary>
public sealed class SymbolFormulaIdentifier
    : Symbol
{
    private SymbolFormulaIdentifier(string identifier)
        : base(identifier)
    {
    }

    /// <summary>
    /// Creates a <see cref="SymbolFormulaIdentifier" /> from <paramref name="identifier" />.
    /// </summary>
    /// <param name="identifier">
    /// The character from which to create the <see cref="SymbolFormulaIdentifier" />.
    /// </param>
    /// <returns>
    /// The <see cref="SymbolFormulaIdentifier" />.
    /// </returns>
    /// <exception cref="LogicSymbolLetterInvalidException">
    /// A <see cref="LogicSymbolLetterInvalidException" /> is thrown if <paramref name="identifier" /> is not a valid predicate letter symbol.
    /// </exception>
    public static SymbolFormulaIdentifier From(char identifier)
    {
        if (!FormulaLetters.Contains(identifier))
            throw new LogicSymbolLetterInvalidException(identifier);
        return new(new string(identifier, 1));
    }

    /// <summary>
    /// Creates a <see cref="SymbolFormulaIdentifier" /> from <paramref name="identifier" />.
    /// </summary>
    /// <param name="identifier">
    /// The formula identifier.
    /// </param>
    /// <returns>
    /// The <see cref="SymbolFormulaIdentifier" />.
    /// </returns>
    /// <exception cref="AggregateException">
    /// An <see cref="AggregateException" /> is thrown if one or more letters in <paramref name="identifier" /> are invalid.
    /// </exception>
    public static SymbolFormulaIdentifier From(string identifier)
    {
        var lettersInvalid =
            identifier
                .Where(c => !FormulaLetters.Contains(c))
                .Select(c => new LogicSymbolLetterInvalidException(c))
                .ToArray();
        if (lettersInvalid.Any())
            throw new AggregateException(lettersInvalid);
        return new(identifier);
    }
}