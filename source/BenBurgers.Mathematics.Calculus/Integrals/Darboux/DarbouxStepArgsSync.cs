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
/// Arguments for a synchronous Riemann-Darboux approximation of an integral.
/// </summary>
/// <typeparam name="TNumber">The type of number in the function's domain and range.</typeparam>
/// <remarks>
/// Initializes a new instance of <see cref="DarbouxStepArgsSync{TNumber}" />.
/// </remarks>
/// <param name="start">The start of the integral approximation.</param>
/// <param name="end">The end of the integral approximation.</param>
/// <param name="step">The step of the integral approximation.</param>
/// <param name="mode">The mode of the Darboux algorithm.</param>
public readonly struct DarbouxStepArgsSync<TNumber>(
    TNumber start,
    TNumber end,
    TNumber step,
    IntegralDarbouxMode mode) : IDarbouxArgsSync<TNumber>
    where TNumber : INumberBase<TNumber>
{
    /// <summary>
    /// The start of the integral approximation.
    /// </summary>
    public readonly TNumber start = start;

    /// <summary>
    /// The end of the integral approximation.
    /// </summary>
    public readonly TNumber end = end;

    /// <summary>
    /// The step of the integral approximation.
    /// </summary>
    public readonly TNumber step = step;

    /// <inheritdoc/>
    public IntegralDarbouxMode Mode { get; } = mode;
}
