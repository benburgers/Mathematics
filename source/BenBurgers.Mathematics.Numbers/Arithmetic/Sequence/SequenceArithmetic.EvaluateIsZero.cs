/*
 * Ben Burgers Mathematics
 * © 2022-2023 Ben Burgers and contributors
 * Licensed under AGPL 3.0
 */

using BenBurgers.Mathematics.Numbers.Real.Irrational;
using BenBurgers.Mathematics.Numbers.Real.Rational;
using BenBurgers.Mathematics.Numbers.Real.Rational.Integer;
using BenBurgers.Mathematics.Numbers.Real.Rational.Integer.Natural;
using BenBurgers.Mathematics.Numbers.Real.Rational.Integer.Natural.Prime;
using BenBurgers.Mathematics.Numbers.Sequence;
using System.Diagnostics;

namespace BenBurgers.Mathematics.Numbers.Arithmetic.Sequence;

internal static partial class SequenceArithmetic
{
    /// <summary>
    /// Evaluates a binary representation of a number to determine whether it is zero.
    /// </summary>
    /// <param name="numberType">The type of the number.</param>
    /// <param name="sequence">The binary representation of the number.</param>
    /// <param name="arithmeticOptions">The options for the arithmetic operation.</param>
    /// <returns>A <see cref="bool" /> value that indicates whether the number is zero.</returns>
    /// <exception cref="ArithmeticTimeoutException">
    /// An <see cref="ArithmeticTimeoutException" /> is thrown if the arithmetic operation has exceeded the time-out.
    /// </exception>
    internal static bool EvaluateIsZero(
        Type numberType,
        NumberSequence sequence,
        ArithmeticOptions arithmeticOptions)
        => EvaluateIsZeroAsync(numberType, sequence, arithmeticOptions)
            .ConfigureAwait(false)
            .GetAwaiter()
            .GetResult();

    /// <summary>
    /// Evaluates a binary representation of a number to determine whether it is zero.
    /// </summary>
    /// <param name="numberType">The type of the number.</param>
    /// <param name="sequence">The binary representation of the number.</param>
    /// <param name="arithmeticOptions">The options for the arithmetic operation.</param>
    /// <param name="cancellationToken">The cancellation token.</param>
    /// <returns>A <see cref="bool" /> value that indicates whether the number is zero.</returns>
    /// <exception cref="ArithmeticTimeoutException">
    /// An <see cref="ArithmeticTimeoutException" /> is thrown if the arithmetic operation has exceeded the time-out.
    /// </exception>
    /// <exception cref="ArithmeticCancelledException">
    /// An <see cref="ArithmeticCancelledException" /> is thrown if the arithmetic operation has been cancelled.
    /// </exception>
    internal static async Task<bool> EvaluateIsZeroAsync(
        Type numberType,
        NumberSequence sequence,
        ArithmeticOptions arithmeticOptions,
        CancellationToken cancellationToken = default)
    {
        try
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            unsafe
            {
                IntPtr? current = sequence.Start;
                while (current is { } currentBinaryPointer)
                {
                    // Check cancellation.
                    cancellationToken.ThrowIfCancellationRequested();
                    // Check time-out.
                    if (stopwatch.Elapsed > arithmeticOptions.Timeout)
                        throw new ArithmeticTimeoutException(numberType, arithmeticOptions.Timeout);

                    // Evaluate current item.
                    var currentBinary = *(NumberSequenceNode*)currentBinaryPointer.ToPointer();
                    if (currentBinary.Value != 0)
                        return false;

                    // Move to next item.
                    current = currentBinary.Next;
                };
            }
            stopwatch.Stop();
            return await Task.FromResult(true);
        }
        catch (ObjectDisposedException ex)
        {
            throw new ArithmeticCancelledException(numberType, ex);
        }
        catch (OperationCanceledException ex)
        {
            throw new ArithmeticCancelledException(numberType, ex);
        }
    }

    /// <summary>
    /// Evaluates an integer number to determine whether it is zero.
    /// </summary>
    /// <typeparam name="TIntegerNumber">The type of integer number to evaluate.</typeparam>
    /// <param name="integerNumber">The number to evaluate.</param>
    /// <param name="arithmeticOptions">The options for the arithmetic operation.</param>
    /// <param name="cancellationToken">The cancellation token.</param>
    /// <returns>A <see cref="bool" /> value that indicates whether the number is zero.</returns>
    /// <exception cref="ArithmeticCancelledException">
    /// An <see cref="ArithmeticCancelledException" /> is thrown if the arithmetic operation is cancelled.
    /// </exception>
    /// <exception cref="NumberTypeNotSupportedException">
    /// An <see cref="NumberTypeNotSupportedException" /> is thrown if the number type is not supported for evaluating to zero.
    /// </exception>
    /// <exception cref="ArithmeticTimeoutException">
    /// An <see cref="ArithmeticTimeoutException" /> is thrown if the arithmetic operation has exceeded the default time-out.
    /// </exception>
    internal static async Task<bool> EvaluateIsZeroAsync<TIntegerNumber>(
        IIntegerNumber<TIntegerNumber> integerNumber,
        ArithmeticOptions arithmeticOptions,
        CancellationToken cancellationToken = default)
        where TIntegerNumber : IIntegerNumber<TIntegerNumber>
    {
        var sequence = integerNumber.Sequence;
        return await EvaluateIsZeroAsync(typeof(TIntegerNumber), sequence, arithmeticOptions, cancellationToken);
    }

    /// <summary>
    /// Evaluates a number to determine whether it is zero.
    /// </summary>
    /// <typeparam name="TNumber">The type of number to evaluate.</typeparam>
    /// <param name="number">The number to evaluate.</param>
    /// <param name="arithmeticOptions">The options for the arithmetic operation.</param>
    /// <param name="cancellationToken">The cancellation token.</param>
    /// <returns>A <see cref="bool" /> that indicates whether the number is zero or not.</returns>
    /// <exception cref="ArithmeticCancelledException">
    /// An <see cref="ArithmeticCancelledException" /> is thrown if the arithmetic operation is cancelled.
    /// </exception>
    /// <exception cref="NumberTypeNotSupportedException">
    /// An <see cref="NumberTypeNotSupportedException" /> is thrown if the number type is not supported for evaluating to zero.
    /// </exception>
    /// <exception cref="ArithmeticTimeoutException">
    /// An <see cref="ArithmeticTimeoutException" /> is thrown if the arithmetic operation has exceeded the default time-out.
    /// </exception>
    internal static async Task<bool> EvaluateIsZeroAsync<TNumber>(
        TNumber number,
        ArithmeticOptions arithmeticOptions,
        CancellationToken cancellationToken = default)
        where TNumber : INumber<TNumber>
    {
        return number switch
        {
            PrimeNumber => false, // Prime numbers are never zero.
            NaturalNumber naturalNumber
                => await EvaluateIsZeroAsync((IIntegerNumber<NaturalNumber>)naturalNumber, arithmeticOptions, cancellationToken),
            IntegerNumber integerNumber
                => await EvaluateIsZeroAsync((IIntegerNumber<IntegerNumber>)integerNumber, arithmeticOptions, cancellationToken),
            Pi => false, // Pi is a non-zero constant.
            _ => throw new NumberTypeNotSupportedException(typeof(TNumber))
        };
    }
}
