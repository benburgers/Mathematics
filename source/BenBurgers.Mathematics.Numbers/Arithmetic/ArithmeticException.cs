/*
 * Ben Burgers Mathematics
 * © 2022 Ben Burgers and contributors
 * Licensed under AGPL 3.0
 */

namespace BenBurgers.Mathematics.Numbers.Arithmetic;

/// <summary>
/// An <see cref="ArithmeticException" /> is thrown if an unexpected error occurs during an arithmetic operation.
/// </summary>
public class ArithmeticException
    : NumbersException
{
    /// <summary>
    /// Initializes a new instance of <see cref="ArithmeticException" />.
    /// </summary>
    /// <param name="message">
    /// The exception message.
    /// </param>
    /// <param name="numberType">
    /// The type of the number involved in the exception.
    /// </param>
    public ArithmeticException(string message, Type numberType)
        : base(message)
    {
        this.NumberType = numberType;
    }

    /// <summary>
    /// Initializes a new instance of <see cref="ArithmeticException" />.
    /// </summary>
    /// <param name="message">
    /// The exception message.
    /// </param>
    /// <param name="numberType">
    /// The type of the number involved in the exception.
    /// </param>
    /// <param name="innerException">
    /// An inner exception that caused the <see cref="ArithmeticException" />.
    /// </param>
    public ArithmeticException(string message, Type numberType, Exception innerException)
        : base(message, innerException)
    {
        this.NumberType = numberType;
    }

    /// <summary>
    /// Gets the type of the number involved in the exception.
    /// </summary>
    public Type NumberType { get; }
}
