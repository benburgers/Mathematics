/*
 * Ben Burgers Mathematics
 * © 2022 Ben Burgers and contributors
 * Licensed under AGPL 3.0
 */

namespace BenBurgers.Mathematics.Logic.Symbols;

/// <summary>
/// An exception that is thrown when processing logic symbols.
/// </summary>
public abstract class LogicSymbolException
    : LogicException
{
    /// <summary>
    /// Initializes a new instance of <see cref="LogicSymbolException" />.
    /// </summary>
    /// <param name="message">
    /// The exception message.
    /// </param>
    protected LogicSymbolException(string message)
        : base(message)
    {
    }
}