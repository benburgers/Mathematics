/*
 * Ben Burgers Mathematics
 * © 2022 Ben Burgers and contributors
 * Licensed under AGPL 3.0
 */

namespace BenBurgers.Mathematics.Logic.Symbols;

/// <summary>
/// Represents a disjunction symbol.
/// </summary>
public sealed class SymbolDisjunction
    : Symbol
{
    /// <summary>
    /// The singleton instance of the <see cref="SymbolDisjunction" />.
    /// </summary>
    public static readonly SymbolDisjunction Instance = new();

    private SymbolDisjunction()
        : base(DisjunctionChar)
    {
    }
}