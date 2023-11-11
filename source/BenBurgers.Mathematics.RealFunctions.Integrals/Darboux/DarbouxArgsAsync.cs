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
/// Arguments for an asynchronous Riemann-Darboux approximation of an integral.
/// </summary>
/// <typeparam name="TNumber">The type of number in the domain and range of the integral's function.</typeparam>
public readonly struct DarbouxArgsAsync<TNumber>
    where TNumber : INumber<TNumber>
{
    /// <summary>
    /// The partitions of the integral to divide among threads.
    /// </summary>
    public readonly ReadOnlyMemory<Integral<TNumber>.Partition> partitions;

    /// <summary>
    /// The step of the Darboux integral.
    /// </summary>
    public readonly TNumber step;

    /// <summary>
    /// The mode of the Riemann-Darboux integral approximation algorithm.
    /// </summary>
    public readonly IntegralDarbouxMode mode;

    /// <summary>
    /// Initializes a new instance of <see cref="DarbouxArgsAsync{TNumber}" />.
    /// </summary>
    /// <param name="partitions">The partitions of the integral to divide among threads.</param>
    /// <param name="step">The step of the Darboux integral.</param>
    /// <param name="mode">The mode of the Darboux integral approximation algorithm.</param>
    public DarbouxArgsAsync(
        ReadOnlyMemory<Integral<TNumber>.Partition> partitions,
        TNumber step,
        IntegralDarbouxMode mode)
    {
        this.partitions = partitions;
        this.step = step;
        this.mode = mode;
    }
}
