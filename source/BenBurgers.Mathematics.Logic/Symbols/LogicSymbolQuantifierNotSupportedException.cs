/*
 * Ben Burgers Mathematics
 * © 2022-2023 Ben Burgers and contributors
 * Licensed under AGPL 3.0
 */

using BenBurgers.Mathematics.Logic.Sets;
using BenBurgers.Mathematics.Logic.Symbols.Resources;

namespace BenBurgers.Mathematics.Logic.Symbols;

/// <summary>
/// An exception that is thrown if a quantifier type is not supported for a logic symbol.
/// </summary>
public sealed class LogicSymbolQuantifierNotSupportedException
    : LogicSymbolException
{
    /// <summary>
    /// Initializes a new instance of <see cref="LogicSymbolQuantifierNotSupportedException" />.
    /// </summary>
    /// <param name="type">
    /// The quantifier type.
    /// </param>
    public LogicSymbolQuantifierNotSupportedException(QuantifierType type)
        : base(ExceptionMessages.QuantifierTypeNotSupported)
    {
        this.Type = type;
    }

    /// <summary>
    /// Gets the quantifier type.
    /// </summary>
    public QuantifierType Type { get; }
}