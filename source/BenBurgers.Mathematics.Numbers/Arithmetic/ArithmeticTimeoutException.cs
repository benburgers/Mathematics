/*
 * Ben Burgers Mathematics
 * © 2022-2023 Ben Burgers and contributors
 * Licensed under AGPL 3.0
 */

using BenBurgers.Mathematics.Numbers.Arithmetic.Resources;

namespace BenBurgers.Mathematics.Numbers.Arithmetic;

/// <summary>
/// An exception that is thrown if a time-out has occurred during the evaluation of an arithmetic operation.
/// </summary>
public class ArithmeticTimeoutException
    : ArithmeticException
{
    /// <summary>
    /// Initializes a new instance of <see cref="ArithmeticTimeoutException" />.
    /// </summary>
    /// <param name="numberType">
    /// The type of the number involved.
    /// </param>
    /// <param name="timeout">
    /// The timeout that was exceeded.
    /// </param>
    public ArithmeticTimeoutException(Type numberType, TimeSpan timeout)
        : base(ExceptionMessages.ArithmeticTimeout, numberType)
    {
        this.Timeout = timeout;
    }

    /// <summary>
    /// Gets the timeout limit that was exceeded.
    /// </summary>
    public TimeSpan Timeout { get; }
}