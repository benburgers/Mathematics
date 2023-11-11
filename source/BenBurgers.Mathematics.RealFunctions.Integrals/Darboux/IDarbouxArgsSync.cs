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
/// Arguments for a synchronous approximation of an integral using the Riemann-Darboux algorithm.
/// </summary>
/// <typeparam name="TNumber">The type of number.</typeparam>
public interface IDarbouxArgsSync<TNumber>
    where TNumber : INumber<TNumber>
{
    /// <summary>
    /// The mode of Riemann-Darboux algorithm.
    /// </summary>
    public IntegralDarbouxMode Mode { get; }
}
