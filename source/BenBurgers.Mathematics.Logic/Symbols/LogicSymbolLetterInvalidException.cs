/*
 * Ben Burgers Mathematics
 * © 2022-2023 Ben Burgers and contributors
 * Licensed under AGPL 3.0
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