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
/// A Riemann-Darboux integral.
/// </summary>
/// <typeparam name="TNumber">The type of number in the domain and range of the integral's function.</typeparam>
/// <remarks>
///     <a href="https://en.wikipedia.org/wiki/Darboux_integral">Darboux integral (Wikipedia)</a>
///     <br />
///     <a href="https://en.wikipedia.org/wiki/Riemann_integral">Riemann integral (Wikipedia)</a>
/// </remarks>
/// <remarks>
/// Initializes a new instance of <see cref="IntegralDarboux{TNumber}" />.
/// </remarks>
/// <param name="function">The function that is integrated.</param>
public sealed partial class IntegralDarboux<TNumber>(
    Integral<TNumber>.IntegralFunction function) : Integral<TNumber, IDarbouxArgsSync<TNumber>, DarbouxArgsAsync<TNumber>>(
        new IntegralAlgorithmDarboux<TNumber>(function))
    where TNumber : INumber<TNumber>
{
}
