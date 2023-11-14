/*
 * This file is part of Ben Burgers Mathematics.
 * 
 * Ben Burgers Mathematics is free software: you can redistribute it and/or modify it under the terms of the GNU General Public License 
 * as published by the Free Software Foundation, either version 3 of the License, or (at your option) any later version.
 * 
 * Ben Burgers Mathematics is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY;
 * without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
 * See the GNU General Public License for more details.
 * 
 * You should have received a copy of the GNU General Public License along with Foobar. If not, see <https://www.gnu.org/licenses/>.
 */

using System.Numerics;

namespace BenBurgers.Mathematics.Calculus.Integrals;

/// <summary>
/// Calculates integrals.
/// </summary>
public abstract class Integral
{
}

/// <summary>
/// Calculates integrals.
/// </summary>
/// <typeparam name="TNumber">The type of number in the function's domain and range.</typeparam>
public abstract class Integral<TNumber> : Integral
    where TNumber : INumberBase<TNumber>
{
    /// <summary>
    /// A partition of an integral's approximation.
    /// </summary>
    /// <remarks>
    /// Initializes a new instance of <see cref="Partition" />.
    /// </remarks>
    /// <param name="start">The start of the partition.</param>
    /// <param name="end">The end of the partition.</param>
    public readonly struct Partition(TNumber start, TNumber end)
    {
        /// <summary>
        /// The start of the partition.
        /// </summary>
        public readonly TNumber start = start;

        /// <summary>
        /// The end of the partition.
        /// </summary>
        public readonly TNumber end = end;
    }

    /// <summary>
    /// A delegate for an integral function.
    /// </summary>
    /// <param name="input">The input of the function.</param>
    /// <returns>The output of the function.</returns>
    public delegate TNumber IntegralFunction(TNumber input);
}


/// <summary>
/// Represents an integral of a function.
/// </summary>
/// <typeparam name="TNumber">The type of number in the function's domain and range.</typeparam>
/// <typeparam name="TArgsSync">The type of arguments for the synchronous approximation of the integral.</typeparam>
/// <typeparam name="TArgsAsync">The type of arguments for the asynchronous approximation of the integral.</typeparam>
/// <remarks>
/// Initializes a new instance of <see cref="Integral" />.
/// </remarks>
/// <param name="algorithm">The algorithm for the approximation of the integral.</param>
public class Integral<TNumber, TArgsSync, TArgsAsync>(IIntegralAlgorithm<TNumber, TArgsSync, TArgsAsync> algorithm) : Integral
    where TNumber : INumber<TNumber>
{
    /// <summary>
    /// The algorithm for approximating the integral.
    /// </summary>
    protected readonly IIntegralAlgorithm<TNumber, TArgsSync, TArgsAsync> algorithm = algorithm;

    /// <summary>
    /// Calculates the approximation of the integral.
    /// </summary>
    /// <param name="args">Arguments for the synchronous approximation of the integral.</param>
    /// <returns>The approximation of the integral.</returns>
    public TNumber Approximate(TArgsSync args)
    {
        return this.algorithm.Approximate(args);
    }

    /// <summary>
    /// Asynchronously calculates the approximation of the integral.
    /// </summary>
    /// <param name="args">Arguments for the asynchronous approximation of the integral.</param>
    /// <param name="cancellationToken">The cancellation token.</param>
    /// <returns>The approximation of the integral.</returns>
    public Task<TNumber> ApproximateAsync(TArgsAsync args, CancellationToken cancellationToken = default)
    {
        return this.algorithm.ApproximateAsync(args, cancellationToken);
    }
}