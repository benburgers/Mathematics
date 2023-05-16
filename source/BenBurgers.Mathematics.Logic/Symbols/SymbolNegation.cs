/*
 * Ben Burgers Mathematics
 * © 2022-2023 Ben Burgers and contributors
 * Licensed under AGPL 3.0
 */

namespace BenBurgers.Mathematics.Logic.Symbols;

/// <summary>
/// Represents a logic negation symbol.
/// </summary>
public sealed class SymbolNegation
    : Symbol
{
    /// <summary>
    /// A singleton instance of the <see cref="SymbolNegation" />.
    /// </summary>
    public static readonly SymbolNegation Instance = new();

    private SymbolNegation()
        : base(NegationChar)
    {
    }
}