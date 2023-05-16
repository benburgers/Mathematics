/*
 * Ben Burgers Mathematics
 * © 2022-2023 Ben Burgers and contributors
 * Licensed under AGPL 3.0
 */

namespace BenBurgers.Mathematics.Logic.Symbols;

/// <summary>
/// Represents a logic disjunction negation symbol.
/// </summary>
public sealed class SymbolDisjunctionNegation
    : Symbol
{
    /// <summary>
    /// A singleton instance of the <see cref="SymbolDisjunctionNegation" />.
    /// </summary>
    public static readonly SymbolDisjunctionNegation Instance = new();

    private SymbolDisjunctionNegation()
        : base(PeirceArrowChar)
    {
    }
}