/*
 * Ben Burgers Mathematics
 * © 2022 Ben Burgers and contributors
 * Licensed under AGPL 3.0
 */

namespace BenBurgers.Mathematics.Logic;

/// <summary>
/// An exception that is thrown by a logic formula.
/// </summary>
public abstract class LogicFormulaException
    : LogicException
{
    /// <summary>
    /// Initializes a new instance of <see cref="LogicFormulaException" />.
    /// </summary>
    /// <param name="message">
    /// The exception message.
    /// </param>
    /// <param name="innerException">
    /// The inner exception.
    /// </param>
    public LogicFormulaException(string message, Exception? innerException)
        : base(message, innerException)
    {
    }

    /// <summary>
    /// Initializes a new instance of <see cref="LogicFormulaException" />.
    /// </summary>
    /// <param name="message">
    /// The exception message.
    /// </param>
    public LogicFormulaException(string message)
        : this(message, null)
    {
    }
}