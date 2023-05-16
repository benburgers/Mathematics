/*
 * Ben Burgers Mathematics
 * © 2022-2023 Ben Burgers and contributors
 * Licensed under AGPL 3.0
 */

namespace BenBurgers.Mathematics.Logic;

/// <summary>
/// An exception that is thrown when processing logic.
/// </summary>
public abstract class LogicException
    : Exception
{
    /// <summary>
    /// Initializes a new instance of <see cref="LogicException" />.
    /// </summary>
    /// <param name="message">
    /// The exception message.
    /// </param>
    /// <param name="innerException">
    /// The inner exception.
    /// </param>
    protected LogicException(string message, Exception? innerException)
        : base(message, innerException)
    {
    }

    /// <summary>
    /// Initializes a new instance of <see cref="LogicException" />.
    /// </summary>
    /// <param name="message">
    /// The exception message.
    /// </param>
    protected LogicException(string message)
        : this(message, null)
    {
    }
}