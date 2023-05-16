/*
 * Ben Burgers Mathematics
 * © 2022-2023 Ben Burgers and contributors
 * Licensed under AGPL 3.0
 */

namespace BenBurgers.Mathematics.Logic.Symbols;

/// <summary>
/// Represents a logic formula set identifier.
/// </summary>
public sealed class SymbolFormulaSetIdentifier
    : Symbol
{
    private SymbolFormulaSetIdentifier(string identifier)
        : base(identifier)
    {
    }

    /// <summary>
    /// Creates a <see cref="SymbolFormulaSetIdentifier" /> from <paramref name="identifier" />.
    /// </summary>
    /// <param name="identifier">
    /// The character from which to create the <see cref="SymbolFormulaSetIdentifier" />.
    /// </param>
    /// <returns>
    /// The <see cref="SymbolFormulaSetIdentifier" />.
    /// </returns>
    /// <exception cref="LogicSymbolLetterInvalidException">
    /// A <see cref="LogicSymbolLetterInvalidException" /> is thrown if <paramref name="identifier" /> is not a valid predicate letter symbol.
    /// </exception>
    public static SymbolFormulaSetIdentifier From(char identifier)
    {
        if (!FormulaSetLetters.Contains(identifier))
            throw new LogicSymbolLetterInvalidException(identifier);
        return new(new string(identifier, 1));
    }

    /// <summary>
    /// Creates a <see cref="SymbolFormulaSetIdentifier" /> from <paramref name="identifier" />.
    /// </summary>
    /// <param name="identifier">
    /// The formula identifier.
    /// </param>
    /// <returns>
    /// The <see cref="SymbolFormulaSetIdentifier" />.
    /// </returns>
    /// <exception cref="AggregateException">
    /// An <see cref="AggregateException" /> is thrown if one or more letters in <paramref name="identifier" /> are invalid.
    /// </exception>
    public static SymbolFormulaSetIdentifier From(string identifier)
    {
        var lettersInvalid =
            identifier
                .Where(c => !FormulaSetLetters.Contains(c))
                .Select(c => new LogicSymbolLetterInvalidException(c))
                .ToArray();
        if (lettersInvalid.Any())
            throw new AggregateException(lettersInvalid);
        return new(identifier);
    }
}