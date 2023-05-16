/*
 * Ben Burgers Mathematics
 * © 2022-2023 Ben Burgers and contributors
 * Licensed under AGPL 3.0
 */

using BenBurgers.Mathematics.Logic.Symbols.Resources;

namespace BenBurgers.Mathematics.Logic.Symbols;

/// <summary>
/// A logic symbol.
/// </summary>
public abstract partial class Symbol
    : IEquatable<string>
{
    /// <summary>
    /// Initializes a new instance of <see cref="Symbol" />.
    /// </summary>
    /// <param name="literal">
    /// The literal for the symbol.
    /// </param>
    protected Symbol(char literal)
    {
        this.Literal = new string(literal, 1);
    }

    /// <summary>
    /// Initializes a new instance of <see cref="Symbol" />.
    /// </summary>
    /// <param name="literal">
    /// The literal for the symbol.
    /// </param>
    /// <exception cref="ArgumentException">
    /// An <see cref="ArgumentException" /> is thrown if <paramref name="literal" /> is <see langword="null" /> or an empty string.
    /// </exception>
    protected Symbol(string literal)
    {
        if (string.IsNullOrEmpty(literal))
            throw new ArgumentException(ExceptionMessages.LiteralCannotBeNullOrEmpty, nameof(literal));
        this.Literal = literal;
    }

    /// <summary>
    /// Gets the literal for the symbol.
    /// </summary>
    protected string Literal { get; }

    /// <inheritdoc />
    public override sealed bool Equals(object? obj)
    {
        return obj switch
        {
            null => false,
            _ when ReferenceEquals(this, obj) => true,
            string text => this.Equals(text),
            Symbol { Literal: var literal } => this.Equals(literal),
            _ => false
        };
    }

    /// <inheritdoc />
    public bool Equals(string? other)
    {
        return other switch
        {
            null => false,
            { } literal => this.Literal.Equals(literal)
        };
    }

    /// <inheritdoc />
    public override sealed int GetHashCode()
    {
        return this.Literal.GetHashCode();
    }

    /// <summary>
    /// Returns the literal for the symbol.
    /// </summary>
    /// <returns>
    /// The literal for the symbol.
    /// </returns>
    public override sealed string ToString()
    {
        return this.Literal;
    }
}