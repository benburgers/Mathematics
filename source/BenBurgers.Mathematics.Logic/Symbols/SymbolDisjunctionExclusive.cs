/*
 * Ben Burgers Mathematics
 * © 2022 Ben Burgers and contributors
 * Licensed under AGPL 3.0
 */

namespace BenBurgers.Mathematics.Logic.Symbols;

/// <summary>
/// Represents an exclusive disjunction symbol.
/// </summary>
public sealed class SymbolDisjunctionExclusive
    : Symbol
{
    /// <summary>
    /// The singleton instance of the <see cref="SymbolDisjunctionExclusive" />.
    /// </summary>
    public static readonly SymbolDisjunctionExclusive Instance = new();

    private SymbolDisjunctionExclusive()
        : base(DisjunctionExclusiveChar)
    {
    }
}