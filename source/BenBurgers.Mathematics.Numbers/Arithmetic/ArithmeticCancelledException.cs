/*
 * Ben Burgers Mathematics
 * © 2022-2023 Ben Burgers and contributors
 * Licensed under AGPL 3.0
 */

using BenBurgers.Mathematics.Numbers.Arithmetic.Resources;

namespace BenBurgers.Mathematics.Numbers.Arithmetic;

/// <summary>
/// An exception that is thrown if an arithmetic operation has been cancelled.
/// </summary>
public class ArithmeticCancelledException
    : ArithmeticException
{
    /// <summary>
    /// Initializes a new instance of <see cref="ArithmeticCancelledException" />.
    /// </summary>
    /// <param name="numberType">
    /// The type of number involved in the arithmetic operation.
    /// </param>
    /// <param name="innerException">
    /// The <see cref="OperationCanceledException" /> that was involved in the cancellation.
    /// </param>
    public ArithmeticCancelledException(Type numberType, OperationCanceledException innerException)
        : base(ExceptionMessages.ArithmeticCancelled, numberType, innerException)
    {
    }

    /// <summary>
    /// Initializes a new instance of <see cref="ArithmeticCancelledException" />.
    /// </summary>
    /// <param name="numberType">
    /// The type of number involved in the arithmetic operation.
    /// </param>
    /// <param name="innerException">
    /// The <see cref="ObjectDisposedException" /> that was involved in the cancellation.
    /// </param>
    public ArithmeticCancelledException(Type numberType, ObjectDisposedException innerException)
        : base(ExceptionMessages.ArithmeticCancelled, numberType, innerException)
    {
    }
}
