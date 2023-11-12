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

using BenBurgers.Mathematics.Geometry.Euclidean;
using System.Numerics;

namespace BenBurgers.Mathematics.Geometry.Tests.Euclidean;

public sealed class Point2DTests
{
    public static readonly IEnumerable<object?[]> AddTestCases =
        new[]
        {
            new object?[]
            {
                new Point2D<decimal>(0.5m, 0.7m),
                new Point2D<decimal>(0.2m, 0.8m),
                new Point2D<decimal>(0.7m, 1.5m)
            },
            new object?[]
            {
                new Point2D<int>(-2, 3),
                new Point2D<int>(3, -2),
                new Point2D<int>(1, 1)
            }
        };

    [Theory(DisplayName = "Addition of two Euclidean points should return the expected result.")]
    [MemberData(nameof(AddTestCases))]
    public void AddTests<TNumber>(Point2D<TNumber> one, Point2D<TNumber> other, Point2D<TNumber> expected)
        where TNumber : INumber<TNumber>
    {
        var actual = one + other;
        Assert.Equal(expected, actual);
    }

    public static readonly IEnumerable<object?[]> SubtractTestCases =
        new[]
        {
            new object?[]
            {
                new Point2D<decimal>(2.3m, 3.2m),
                new Point2D<decimal>(1.0m, 2.0m),
                new Point2D<decimal>(1.3m, 1.2m)
            },
            new object?[]
            {
                new Point2D<int>(-2, -3),
                new Point2D<int>(3, -2),
                new Point2D<int>(-5, -1)
            }
        };

    [Theory(DisplayName = "Subtraction of two Euclidean points should return the expected result.")]
    [MemberData(nameof(SubtractTestCases))]
    public void SubtractTests<TNumber>(Point2D<TNumber> one, Point2D<TNumber> other, Point2D<TNumber> expected)
        where TNumber : INumber<TNumber>
    {
        var actual = one - other;
        Assert.Equal(expected, actual);
    }
}
