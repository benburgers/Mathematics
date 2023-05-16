/*
 * Ben Burgers Mathematics
 * © 2022-2023 Ben Burgers and contributors
 * Licensed under AGPL 3.0
 */

namespace BenBurgers.Mathematics.Logic.Symbols;

/// <summary>
/// Represents a contradiction symbol.
/// </summary>
public sealed class SymbolContradiction
    : Symbol
{
    /// <summary>
    /// The singleton instance of <see cref="SymbolContradiction" />.
    /// </summary>
    public static readonly SymbolContradiction Instance = new();

    private SymbolContradiction()
        : base(ContradictionChar)
    {
    }
}