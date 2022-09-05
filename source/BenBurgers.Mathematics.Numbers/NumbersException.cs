/*
 * Ben Burgers Mathematics
 * © 2022 Ben Burgers and contributors
 * Licensed under AGPL 3.0
 */

namespace BenBurgers.Mathematics.Numbers;

/// <summary>
/// An exception that is thrown while handling mathematical numbers.
/// </summary>
public class NumbersException
    : Exception
{
    /// <summary>
    /// Initializes a new instance of <see cref="NumbersException" />.
    /// </summary>
    /// <param name="message">
    /// The exception message.
    /// </param>
    public NumbersException(string message)
        : base(message)
    {
    }

    /// <summary>
    /// Initializes a new instance of <see cref="NumbersException" />.
    /// </summary>
    /// <param name="message">
    /// The exception message.
    /// </param>
    /// <param name="innerException">
    /// The inner exception.
    /// </param>
    public NumbersException(string message, Exception innerException)
        : base(message, innerException)
    {
    }
}