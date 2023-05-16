/*
 * Ben Burgers Mathematics
 * © 2022-2023 Ben Burgers and contributors
 * Licensed under AGPL 3.0
 */

namespace BenBurgers.Mathematics.Logic.Symbols;

/// <summary>
/// Represents a tautology.
/// </summary>
public sealed class SymbolTautology
    : Symbol
{
    /// <summary>
    /// A singleton instance of the <see cref="SymbolTautology" />.
    /// </summary>
    public static readonly SymbolTautology Instance = new();

    private SymbolTautology()
        : base(TautologyChar)
    {
    }
}