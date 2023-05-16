/*
 * Ben Burgers Mathematics
 * © 2022-2023 Ben Burgers and contributors
 * Licensed under AGPL 3.0
 */

namespace BenBurgers.Mathematics.Logic.Symbols;

/// <summary>
/// Represents a logic exclusive conjunction.
/// </summary>
public sealed class SymbolConjunctionNegation
    : Symbol
{
    /// <summary>
    /// A singleton instance of the <see cref="SymbolConjunctionNegation" />.
    /// </summary>
    public static readonly SymbolConjunctionNegation Instance = new();

    private SymbolConjunctionNegation()
        : base(ShefferStrokeChar)
    {
    }
}