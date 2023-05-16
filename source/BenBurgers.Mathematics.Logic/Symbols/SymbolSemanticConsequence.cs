/*
 * Ben Burgers Mathematics
 * © 2022-2023 Ben Burgers and contributors
 * Licensed under AGPL 3.0
 */

namespace BenBurgers.Mathematics.Logic.Symbols;

/// <summary>
/// Represents a semantic consequence.
/// </summary>
public sealed class SymbolSemanticConsequence
    : Symbol
{
    /// <summary>
    /// A singleton instance of the <see cref="SymbolSemanticConsequence" />.
    /// </summary>
    public static readonly SymbolSemanticConsequence Instance = new();

    private SymbolSemanticConsequence()
        : base(TurnstileDouble)
    {
    }
}