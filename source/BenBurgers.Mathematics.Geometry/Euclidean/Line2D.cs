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
/// A line in the two-dimensional Euclidean space.
/// </summary>
/// <typeparam name="TNumber">The type of number in the two-dimensional Euclidean geometric space.</typeparam>
public readonly struct Line2D<TNumber> : IElement
    where TNumber : INumber<TNumber>, IRootFunctions<TNumber>
{
    private readonly Lazy<TNumber> length;

    /// <summary>
    /// Initializes a new instance of <see cref="Line2D{TNumber}" />.
    /// </summary>
    /// <param name="start">The start of the line.</param>
    /// <param name="end">The end of the line.</param>
    public Line2D(Point2D<TNumber> start, Point2D<TNumber> end)
    {
        this.Start = start;
        this.End = end;
        this.length = new Lazy<TNumber>(() =>
        {
            var difference = end - start;
            return PythagoreanTheorem.Hypotenuse(difference.X, difference.Y);
        });
    }

    /// <summary>
    /// Gets the start of the line.
    /// </summary>
    public Point2D<TNumber> Start { get; }

    /// <summary>
    /// Gets the end of the line.
    /// </summary>
    public Point2D<TNumber> End { get; }

    /// <summary>
    /// Gets the length of the line.
    /// </summary>
    public TNumber Length => this.length.Value;
}