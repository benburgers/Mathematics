/*
 * Ben Burgers Mathematics
 * © 2022-2023 Ben Burgers and contributors
 * Licensed under AGPL 3.0
 */

namespace BenBurgers.Mathematics.Logic.Symbols;

/// <summary>
/// An opening parenthesis symbol.
/// </summary>
public sealed class SymbolParenthesisOpening
    : Symbol
{
    /// <summary>
    /// A singleton instance of the <see cref="SymbolParenthesisOpening" />.
    /// </summary>
    public static readonly SymbolParenthesisOpening Instance = new();

    private SymbolParenthesisOpening()
        : base(ParenthesisOpenChar)
    {
    }
}