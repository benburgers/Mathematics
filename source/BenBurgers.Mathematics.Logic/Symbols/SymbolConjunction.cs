/*
 * Ben Burgers Mathematics
 * © 2022 Ben Burgers and contributors
 * Licensed under AGPL 3.0
 */

namespace BenBurgers.Mathematics.Logic.Symbols;

/// <summary>
/// Represents a conjunction symbol.
/// </summary>
public sealed class SymbolConjunction
    : Symbol
{
    /// <summary>
    /// The singleton instance of the <see cref="SymbolConjunction" />.
    /// </summary>
    public static readonly SymbolConjunction Instance = new();

    private SymbolConjunction()
        : base(ConjunctionChar)
    {
    }
}