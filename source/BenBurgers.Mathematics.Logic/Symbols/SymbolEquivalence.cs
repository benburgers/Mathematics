/*
 * Ben Burgers Mathematics
 * © 2022-2023 Ben Burgers and contributors
 * Licensed under AGPL 3.0
 */

namespace BenBurgers.Mathematics.Logic.Symbols;

/// <summary>
/// Represents an equivalence symbol.
/// </summary>
public sealed class SymbolEquivalence
    : Symbol
{
    /// <summary>
    /// The singleton instance of the <see cref="SymbolEquivalence" />.
    /// </summary>
    public static readonly SymbolEquivalence Instance = new();

    private SymbolEquivalence()
        : base(EquivalenceChar)
    {
    }
}