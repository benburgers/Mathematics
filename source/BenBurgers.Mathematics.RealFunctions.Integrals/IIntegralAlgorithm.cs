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

namespace BenBurgers.Mathematics.RealFunctions.Integrals;

/// <summary>
/// A synchronous implementation of an integral algorithm.
/// </summary>
/// <typeparam name="TNumber">The type of number in the integral function.</typeparam>
/// <typeparam name="TArgsSync">The type of arguments for the synchronous approximation of the integral.</typeparam>
/// <typeparam name="TArgsAsync">The type of arguments for the asynchronous approximation of the integral.</typeparam>
public interface IIntegralAlgorithm<TNumber, TArgsSync, TArgsAsync>
    where TNumber : INumber<TNumber>
{
    /// <summary>
    /// Gets the function that is integrated.
    /// </summary>
    Integral<TNumber>.IntegralFunction Function { get; }

    /// <summary>
    /// Synchronously approximates the integral using the provided arguments.
    /// </summary>
    /// <param name="args">The arguments to use for approximating the integral.</param>
    /// <returns>The result of the approximation.</returns>
    TNumber Approximate(TArgsSync args);

    /// <summary>
    /// Asynchronously approximates the integral using the provided arguments.
    /// </summary>
    /// <param name="args">The arguments to use for approximating the integral.</param>
    /// <param name="cancellationToken">The cancellation token.</param>
    /// <returns>The result of the approximation.</returns>
    Task<TNumber> ApproximateAsync(TArgsAsync args, CancellationToken cancellationToken = default);
}
