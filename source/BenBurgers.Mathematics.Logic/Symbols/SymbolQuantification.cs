/*
 * Ben Burgers Mathematics
 * © 2022 Ben Burgers and contributors
 * Licensed under AGPL 3.0
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