/*
 * Ben Burgers Mathematics
 * © 2022-2023 Ben Burgers and contributors
 * Licensed under AGPL 3.0
 */

namespace BenBurgers.Mathematics.Logic.Symbols;

/// <summary>
/// Represents a definition symbol.
/// </summary>
public sealed class SymbolDefinition
    : Symbol
{
    /// <summary>
    /// The singleton instance of the <see cref="SymbolDefinition" />.
    /// </summary>
    public static readonly SymbolDefinition Instance = new();

    private SymbolDefinition()
        : base(DefinitionChar)
    {
    }
}