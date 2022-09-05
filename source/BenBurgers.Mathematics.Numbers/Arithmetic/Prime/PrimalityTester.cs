/*
 * Ben Burgers Mathematics
 * © 2022 Ben Burgers and contributors
 * Licensed under AGPL 3.0
 */

using BenBurgers.Mathematics.Numbers.Real.Rational.Integer.Natural;

namespace BenBurgers.Mathematics.Numbers.Arithmetic.Prime;

/// <summary>
/// Tests numbers whether they are prime numbers.
/// </summary>
public static partial class PrimalityTester
{
    /// <summary>
    /// The algorithm to apply for testing for primality.
    /// </summary>
    public enum Algorithm
    {
        /// <summary>
        /// Calculate all numbers within the range of 0 to N and stop when a non-prime divisor is found.
        /// </summary>
        BruteForce,

        /// <summary>
        /// Check for first few obvious prime numbers, then check in increments of 6.
        /// </summary>
        SixKPlusOrMinusOne
    }

    /// <summary>
    /// Determines whether the <paramref name="candidate" /> is a prime number.
    /// </summary>
    /// <param name="candidate">
    /// The number to check for primality.
    /// </param>
    /// <param name="algorithm">
    /// The algorithm to apply in checking for primality.
    /// </param>
    /// <param name="arithmeticOptions">
    /// The options for the arithmetic operation.
    /// </param>
    /// <param name="cancellationToken">
    /// The cancellation token.
    /// </param>
    /// <returns>
    /// A <see cref="bool" /> that indicates whether <paramref name="candidate" /> is a prime number.
    /// </returns>
    /// <exception cref="NotSupportedException">
    /// A <see cref="NotSupportedException" /> is thrown if the specified <paramref name="algorithm" /> does not support testing the primality of <paramref name="candidate" />.
    /// </exception>
    public static async Task<bool> IsPrimeAsync(
        NaturalNumber candidate,
        Algorithm algorithm,
        ArithmeticOptions arithmeticOptions,
        CancellationToken cancellationToken = default)
    {
        return algorithm switch
        {
            Algorithm.BruteForce => await IsPrimeBruteForceAsync(candidate, arithmeticOptions, cancellationToken),
            Algorithm.SixKPlusOrMinusOne => await IsPrimeSixKPlusOrMinusOneAsync(candidate, arithmeticOptions, cancellationToken),
            _ => throw new NotSupportedException()
        };
    }
}
