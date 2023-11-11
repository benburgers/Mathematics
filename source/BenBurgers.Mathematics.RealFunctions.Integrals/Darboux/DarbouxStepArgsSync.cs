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

namespace BenBurgers.Mathematics.RealFunctions.Integrals.Darboux;

/// <summary>
/// Arguments for a synchronous Riemann-Darboux approximation of an integral.
/// </summary>
/// <typeparam name="TNumber">The type of number in the function's domain and range.</typeparam>
public readonly struct DarbouxStepArgsSync<TNumber> : IDarbouxArgsSync<TNumber>
    where TNumber : INumber<TNumber>
{
    /// <summary>
    /// The start of the integral approximation.
    /// </summary>
    public readonly TNumber start;

    /// <summary>
    /// The end of the integral approximation.
    /// </summary>
    public readonly TNumber end;

    /// <summary>
    /// The step of the integral approximation.
    /// </summary>
    public readonly TNumber step;

    /// <summary>
    /// Initializes a new instance of <see cref="DarbouxStepArgsSync{TNumber}" />.
    /// </summary>
    /// <param name="start">The start of the integral approximation.</param>
    /// <param name="end">The end of the integral approximation.</param>
    /// <param name="step">The step of the integral approximation.</param>
    /// <param name="mode">The mode of the Darboux algorithm.</param>
    public DarbouxStepArgsSync(
        TNumber start,
        TNumber end,
        TNumber step,
        IntegralDarbouxMode mode)
    {
        this.start = start;
        this.end = end;
        this.step = step;
        this.Mode = mode;
    }

    /// <inheritdoc/>
    public IntegralDarbouxMode Mode { get; }
}
