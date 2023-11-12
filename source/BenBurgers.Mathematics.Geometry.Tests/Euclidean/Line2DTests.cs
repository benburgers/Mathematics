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

public sealed class Line2DTests
{
    public static readonly IEnumerable<object?[]> LengthTestCases =
        new[]
        {
            new object?[]
            {
                new Line2D<double>(new Point2D<double>(1.0d, 2.0d), new Point2D<double>(2.0d, 3.0d)),
                1.4142135623730951d
            },
            new object?[]
            {
                new Line2D<double>(new Point2D<double>(2.0d, 1.0d), new Point2D<double>(3.0d, 2.0d)),
                1.4142135623730951d
            },
            new object?[]
            {
                new Line2D<float>(new Point2D<float>(1.0f, 1.0f), new Point2D<float>(2.0f, 1.0f)),
                1.0f
            }
        };

    [Theory(DisplayName = "Length returns the expected value.")]
    [MemberData(nameof(LengthTestCases))]
    public void LengthTests<TNumber>(Line2D<TNumber> line, TNumber expected)
        where TNumber : INumber<TNumber>, IRootFunctions<TNumber>
    {
        var actual = line.Length;
        Assert.Equal(expected, actual);
    }
}
