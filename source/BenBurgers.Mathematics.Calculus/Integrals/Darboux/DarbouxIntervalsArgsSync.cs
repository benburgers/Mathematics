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

namespace BenBurgers.Mathematics.Calculus.Integrals.Darboux;

/// <summary>
/// Arguments for synchronously approximating an integral using the Riemann-Darboux algorithm, with specified intervals.
/// </summary>
/// <typeparam name="TNumber">The type of number in the integral's number space.</typeparam>
/// <remarks>
/// Initializes a new instance of <see cref="DarbouxIntervalsArgsSync{TNumber}" />.
/// </remarks>
/// <param name="mode">The mode of the Riemann-Darboux algorithm.</param>
/// <param name="intervals">The intervals for which to approximate the integral.</param>
public readonly struct DarbouxIntervalsArgsSync<TNumber>(IntegralDarbouxMode mode, Memory<TNumber> intervals) : IDarbouxArgsSync<TNumber>
    where TNumber : INumberBase<TNumber>
{
    /// <summary>
    /// The intervals to use for synchronously approximating an integral using the Riemann-Darboux algorithm.
    /// </summary>
    public readonly Memory<TNumber> Intervals = intervals;

    /// <inheritdoc/>
    public readonly IntegralDarbouxMode Mode { get; } = mode;
}
