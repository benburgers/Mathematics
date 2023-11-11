﻿/*
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

using BenBurgers.Mathematics.Logic.Symbols.Resources;

namespace BenBurgers.Mathematics.Logic.Symbols;

/// <summary>
/// An exception that is thrown if a letter is invalid as a logic symbol.
/// </summary>
public sealed class LogicSymbolLetterInvalidException
    : LogicSymbolException
{
    /// <summary>
    /// Initializes a new instance of <see cref="LogicSymbolLetterInvalidException" />.
    /// </summary>
    /// <param name="letter">
    /// The invalid letter.
    /// </param>
    public LogicSymbolLetterInvalidException(char letter)
        : base(ExceptionMessages.CharacterIsNotAValidLetter)
    {
        this.Letter = letter;
    }

    /// <summary>
    /// Gets the invalid letter.
    /// </summary>
    public char Letter { get; }
}