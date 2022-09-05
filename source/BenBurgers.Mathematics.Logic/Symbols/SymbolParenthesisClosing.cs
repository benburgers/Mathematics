/*
 * Ben Burgers Mathematics
 * © 2022 Ben Burgers and contributors
 * Licensed under AGPL 3.0
 */

namespace BenBurgers.Mathematics.Logic.Symbols;

/// <summary>
/// A closing parenthesis symbol.
/// </summary>
public sealed class SymbolParenthesisClosing
    : Symbol
{
    /// <summary>
    /// A singleton instance of the <see cref="SymbolParenthesisClosing" />.
    /// </summary>
    public static readonly SymbolParenthesisClosing Instance = new();

    private SymbolParenthesisClosing()
        : base(ParenthesisClosingChar)
    {
    }
}