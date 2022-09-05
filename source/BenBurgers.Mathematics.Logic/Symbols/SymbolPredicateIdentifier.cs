/*
 * Ben Burgers Mathematics
 * © 2022 Ben Burgers and contributors
 * Licensed under AGPL 3.0
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