/*
 * Ben Burgers Mathematics
 * © 2022-2023 Ben Burgers and contributors
 * Licensed under AGPL 3.0
 */

using BenBurgers.Mathematics.Numbers.Real.Rational.Integer.Natural;
using System.Diagnostics;

namespace BenBurgers.Mathematics.Numbers.Arithmetic.Prime;

public static partial class PrimalityTester
{
    /// <summary>
    /// Tests whether <paramref name="number" /> is a prime number through brute force.
    /// </summary>
    /// <param name="number">
    /// The number to test.
    /// </param>
    /// <param name="cancellationToken">
    /// The cancellation token.
    /// </param>
    /// <returns>
    /// A <see cref="bool" /> that indicates whether the <paramref name="number" /> is a prime number.
    /// </returns>
    /// <exception cref="ArithmeticCancelledException">
    /// An <see cref="ArithmeticCancelledException" /> is thrown if cancellation has been requested.
    /// </exception>
    private static async Task<bool> IsPrimeBruteForceAsync(
        nuint number,
        CancellationToken cancellationToken = default)
    {
        return await Task.Run(() =>
        {
            if (number == 2 || number == 3)
                return true;
            if (number <= 1 || number % 2 == 0 || number % 3 == 0)
                return false;
            try
            {
                var squareRoot = (nuint)Math.Ceiling(Math.Pow(Math.E, Math.Log(number) / 2));
                for (nuint i = 3; i < squareRoot; i++)
                {
                    cancellationToken.ThrowIfCancellationRequested();
                    if (number % i == 0)
                        return false;
                }
                return true;
            }
            catch (ObjectDisposedException ex)
            {
                throw new ArithmeticCancelledException(typeof(NaturalNumber), ex);
            }
            catch (OperationCanceledException ex)
            {
                throw new ArithmeticCancelledException(typeof(NaturalNumber), ex);
            }
        }, cancellationToken);
    }

    /// <summary>
    /// Tests whether <paramref name="number" /> is a prime number through brute force.
    /// </summary>
    /// <param name="number">
    /// The number to test.
    /// </param>
    /// <param name="arithmeticOptions">
    /// The options for the arithmetic operation.
    /// </param>
    /// <param name="cancellationToken">
    /// The cancellation token.
    /// </param>
    /// <returns>
    /// A <see cref="bool" /> that indicates whether the <paramref name="number" /> is a prime number.
    /// </returns>
    /// <exception cref="ArithmeticCancelledException">
    /// An <see cref="ArithmeticCancelledException" /> is thrown if cancellation has been requested.
    /// </exception>
    /// <exception cref="ArithmeticTimeoutException">
    /// An <see cref="ArithmeticTimeoutException" /> is thrown if the arithmetic operation reached a time-out.
    /// </exception>
    private static async Task<bool> IsPrimeBruteForceAsync(
        NaturalNumber number,
        ArithmeticOptions arithmeticOptions,
        CancellationToken cancellationToken = default)
    {
        // Check whether number has exactly one item, so we know it is sufficiently small to perform the quick primality tests.
        if (number.sequence.IsSingle)
            return await IsPrimeBruteForceAsync(number.sequence.StartNode.Value, cancellationToken);

        // The long road.
        var stopwatch = new Stopwatch();
        stopwatch.Start();
        var isPrime = await Task.Run(() =>
        {
            // TODO implement
            // TODO fail on cancellation
            if (stopwatch.Elapsed > arithmeticOptions.Timeout)
                throw new ArithmeticTimeoutException(typeof(NaturalNumber), arithmeticOptions.Timeout);

            return false;
        }, cancellationToken);
        stopwatch.Stop();
        return isPrime;
    }
}