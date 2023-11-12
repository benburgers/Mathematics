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

public sealed class PythagoreanTheoremTests
{
    public static readonly IEnumerable<object?[]> HypotenuseTestCases =
        new[]
        {
            new object?[]
            {
                3.0d,
                5.0d,
                5.8309518948453007d
            },
            new object?[]
            {
                3.0d,
                2.0d,
                3.6055512754639891d
            }
        };

    [Theory(DisplayName = "Hypotenuse should return the expected result.")]
    [MemberData(nameof(HypotenuseTestCases))]
    public void HypotenuseTests<TNumber>(TNumber a, TNumber b, TNumber expected)
        where TNumber : INumber<TNumber>, IRootFunctions<TNumber>
    {
        var actual = PythagoreanTheorem.Hypotenuse(a, b);
        Assert.Equal(expected, actual);
    }

    public static readonly IEnumerable<object?[]> LegTestCases =
        new[]
        {
            new object?[]
            {
                3.0d,
                5.8309518948453007d,
                5.0d
            },
            new object?[]
            {
                3.0d,
                3.6055512754639891d,
                1.9999999999999996d
            }
        };

    [Theory(DisplayName = "Leg should return the expected value.")]
    [MemberData(nameof(LegTestCases))]
    public void LegTests<TNumber>(TNumber leg, TNumber hypotenuse, TNumber expected)
        where TNumber : INumber<TNumber>, IRootFunctions<TNumber>
    {
        var actual = PythagoreanTheorem.Leg(leg, hypotenuse);
        Assert.Equal(expected, actual);
    }
}
