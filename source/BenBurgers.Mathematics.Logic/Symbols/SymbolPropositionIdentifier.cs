/*
 * Ben Burgers Mathematics
 * © 2022 Ben Burgers and contributors
 * Licensed under AGPL 3.0
 */

namespace BenBurgers.Mathematics.Logic.Symbols;

/// <summary>
/// Represents a proposition identifier.
/// </summary>
public sealed class SymbolPropositionIdentifier
    : Symbol
{
    private SymbolPropositionIdentifier(string identifier)
        : base(identifier)
    {
    }

    /// <summary>
    /// Creates a <see cref="SymbolPropositionIdentifier" /> from <paramref name="identifier" />.
    /// </summary>
    /// <param name="identifier">
    /// The character from which to create a <see cref="SymbolPropositionIdentifier" />.
    /// </param>
    /// <returns>
    /// The <see cref="SymbolPropositionIdentifier" />.
    /// </returns>
    /// <exception cref="LogicSymbolLetterInvalidException">
    /// A <see cref="LogicSymbolLetterInvalidException" /> is thrown if <paramref name="identifier" /> is not a valid proposition letter symbol.
    /// </exception>
    public static SymbolPropositionIdentifier From(char identifier)
    {
        if (!PropositionLetters.Contains(identifier))
            throw new LogicSymbolLetterInvalidException(identifier);
        return new(new string(identifier, 1));
    }

    /// <summary>
    /// Creates a <see cref="SymbolPropositionIdentifier" /> from <paramref name="identifier" />.
    /// </summary>
    /// <param name="identifier">
    /// The proposition identifier.
    /// </param>
    /// <returns>
    /// The <see cref="SymbolPropositionIdentifier" />.
    /// </returns>
    /// <exception cref="AggregateException">
    /// An <see cref="AggregateException" /> is thrown if one or more letters in <paramref name="identifier" /> are invalid.
    /// </exception>
    public static SymbolPropositionIdentifier From(string identifier)
    {
        var lettersInvalid =
            identifier
                .Where(c => !PropositionLetters.Contains(c))
                .Select(c => new LogicSymbolLetterInvalidException(c))
                .ToArray();
        if (lettersInvalid.Any())
            throw new AggregateException(lettersInvalid);
        return new(identifier);
    }
}