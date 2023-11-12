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
/// A point in the two-dimensional Euclidean space.
/// </summary>
/// <typeparam name="TNumber">The type of number in the two-dimensional Euclidean geometric space.</typeparam>
/// <param name="X">The x-coordinate in the two-dimensional Euclidean geometric space.</param>
/// <param name="Y">The y-coordinate in the two-dimensional Euclidean geometric space.</param>
public record struct Point2D<TNumber>(TNumber X, TNumber Y) : IElement
    where TNumber : INumber<TNumber>
{
    /// <summary>
    /// Adds <paramref name="point2" /> to <paramref name="point1" />.
    /// </summary>
    /// <param name="point1">The point to add to.</param>
    /// <param name="point2">The point to add.</param>
    /// <returns>The result of the addition.</returns>
    public static Point2D<TNumber> operator +(Point2D<TNumber> point1, Point2D<TNumber> point2)
    {
        return new Point2D<TNumber>(point1.X + point2.X, point1.Y + point2.Y);
    }

    /// <summary>
    /// Subtracts <paramref name="point2" /> from <paramref name="point1" />.
    /// </summary>
    /// <param name="point1">The point to subtract from.</param>
    /// <param name="point2">The point to subtract.</param>
    /// <returns>The result of the subtraction.</returns>
    public static Point2D<TNumber> operator -(Point2D<TNumber> point1, Point2D<TNumber> point2)
    {
        return new Point2D<TNumber>(point1.X - point2.X, point1.Y - point2.Y);
    }
}
