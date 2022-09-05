/*
 * Ben Burgers Mathematics
 * © 2022 Ben Burgers and contributors
 * Licensed under AGPL 3.0
 */

using BenBurgers.Mathematics.Numbers.Arithmetic;

namespace BenBurgers.Mathematics.Numbers.Arithmetics;

/// <summary>
/// An arithmetic operation.
/// </summary>
/// <typeparam name="TOptions">
/// The options for the evaluation.
/// </typeparam>
public interface IArithmeticOperation<TOptions>
{
    /// <summary>
    /// Evaluates the arithmetic operation.
    /// </summary>
    /// <typeparam name="TResult">
    /// The type of number requested as a result.
    /// </typeparam>
    /// <param name="options">
    /// The options for the evaluation.
    /// </param>
    /// <returns>
    /// The result of the evaluation.
    /// </returns>
    /// <exception cref="ArithmeticEvaluationFailedException">
    /// An <see cref="ArithmeticEvaluationFailedException" /> is thrown if the evaluation has failed.
    /// </exception>
    /// <exception cref="ArithmeticTimeoutException">
    /// An <see cref="ArithmeticTimeoutException" /> is thrown if the evaluation has exceeded its time-out limit.
    /// </exception>
    /// <exception cref="NumberTypeNotSupportedException">
    /// An <see cref="NumberTypeNotSupportedException" /> is thrown if the arithmetic operation is evaluated to an unsupported number type.
    /// </exception>
    TResult Evaluate<TResult>(TOptions options);

    /// <summary>
    /// Evaluates the arithmetic operation.
    /// </summary>
    /// <typeparam name="TResult">
    /// The type of number requested as a result.
    /// </typeparam>
    /// <param name="options">
    /// The options for the evaluation.
    /// </param>
    /// <param name="cancellationToken">
    /// The cancellation token.
    /// </param>
    /// <returns>
    /// The result of the evaluation.
    /// </returns>
    /// <exception cref="ArithmeticEvaluationFailedException">
    /// An <see cref="ArithmeticEvaluationFailedException" /> is thrown if the evaluation has failed.
    /// </exception>
    /// <exception cref="ArithmeticTimeoutException">
    /// An <see cref="ArithmeticTimeoutException" /> is thrown if the evaluation has exceeded its time-out limit.
    /// </exception>
    /// <exception cref="NumberTypeNotSupportedException">
    /// An <see cref="NumberTypeNotSupportedException" /> is thrown if the arithmetic operation is evaluated to an unsupported number type.
    /// </exception>
    Task<TResult> EvaluateAsync<TResult>(TOptions options, CancellationToken cancellationToken = default);
}
