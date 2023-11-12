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

namespace BenBurgers.Mathematics.Geometry.Euclidean;

/// <summary>
/// Implementation of the Pythagorean Theorem (51M04).
/// </summary>
/// <remarks>
/// See 51M04: Elementary problems in Euclidean geometries (MSC2020).
/// </remarks>
public static class PythagoreanTheorem
{
    /// <summary>
    /// Calculates the hypotenuse of a two-dimensional Euclidean triangle from the straight sides of the triangle.
    /// </summary>
    /// <typeparam name="TNumber">The type of number in the two-dimensional Euclidean geometric space.</typeparam>
    /// <param name="a">One of two straight sides of the Euclidean triangle.</param>
    /// <param name="b">The other of the two straight sides of the Euclidean triangle.</param>
    /// <returns>The length of the hypotenuse of the two-dimensional Euclidean triangle.</returns>
    public static TNumber Hypotenuse<TNumber>(TNumber a, TNumber b)
        where TNumber : INumber<TNumber>, IRootFunctions<TNumber>
    {
        return TNumber.Sqrt(a * a + b * b);
    }

    /// <summary>
    /// Calculates the leg of a two-dimensional Euclidean triangle from the other leg and the hypotenuse of the triangle.
    /// </summary>
    /// <typeparam name="TNumber">The type of number in the two-dimensional Euclidean geometric space.</typeparam>
    /// <param name="leg">One of two straight sides of the Euclidean triangle.</param>
    /// <param name="hypotenuse">The hypotenuse of the Euclidean triangle.</param>
    /// <returns>The length of the hypotenuse of the two-dimensional Euclidean triangle.</returns>
    public static TNumber Leg<TNumber>(TNumber leg, TNumber hypotenuse)
        where TNumber : INumber<TNumber>, IRootFunctions<TNumber>
    {
        return TNumber.Sqrt(-leg * leg + hypotenuse * hypotenuse);
    }
}
