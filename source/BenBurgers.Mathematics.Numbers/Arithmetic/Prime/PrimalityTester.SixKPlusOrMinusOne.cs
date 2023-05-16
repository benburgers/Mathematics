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
    /// Determines whether <paramref name="number" /> is a prime number, using the 6k±1 algorithm.
    /// </summary>
    /// <param name="number">
    /// The number to test.
    /// </param>
    /// <param name="options">
    /// The arithmetic options.
    /// </param>
    /// <param name="cancellationToken">
    /// The cancellation token.
    /// </param>
    /// <returns>
    /// A <see cref="bool" /> that indicates whether <paramref name="number" /> is a prime number.
    /// </returns>
    /// <remarks>
    /// For the inspiration of this method, check out https://en.wikipedia.org/wiki/Primality_test .
    /// </remarks>
    private static async Task<bool> IsPrimeSixKPlusOrMinusOneAsync(
        NaturalNumber number,
        ArithmeticOptions options,
        CancellationToken cancellationToken = default)
    {
        if (number == 2 || number == 3)
            return true;

        if (number <= 1 || number % 2 == 0 || number % 3 == 0)
            return false;

        var timeout = options.Timeout;
        var stopwatch = new Stopwatch();
        stopwatch.Start();
        return await Task.Run(() =>
        {
            for (var i = 5; i * i <= number; i += 6)
            {
                if (stopwatch.Elapsed > timeout)
                    throw new ArithmeticTimeoutException(typeof(NaturalNumber), timeout);
                if (number % i == 0 || number % (i + 2) == 0)
                    return false;
            }

            stopwatch.Stop();
            return true;
        }, cancellationToken);
    }
}
