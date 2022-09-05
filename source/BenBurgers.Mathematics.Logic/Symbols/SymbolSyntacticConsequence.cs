/*
 * Ben Burgers Mathematics
 * © 2022 Ben Burgers and contributors
 * Licensed under AGPL 3.0
 */

namespace BenBurgers.Mathematics.Logic.Symbols;

/// <summary>
/// Represents a syntactic consequence.
/// </summary>
public sealed class SymbolSyntacticConsequence
    : Symbol
{
    /// <summary>
    /// A singleton instance of the <see cref="SymbolSyntacticConsequence" />.
    /// </summary>
    public static readonly SymbolSyntacticConsequence Instance = new();

    private SymbolSyntacticConsequence()
        : base(Turnstile)
    {
    }
}