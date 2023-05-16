/*
 * Ben Burgers Mathematics
 * © 2022-2023 Ben Burgers and contributors
 * Licensed under AGPL 3.0
 */

namespace BenBurgers.Mathematics.Logic.Symbols;

/// <summary>
/// Represents an implication.
/// </summary>
public sealed class SymbolImplication
    : Symbol
{
    /// <summary>
    /// A singleton instance of the <see cref="SymbolImplication" />.
    /// </summary>
    public static readonly SymbolImplication Instance = new();

    private SymbolImplication()
        : base(ImplicationChar)
    {
    }
}