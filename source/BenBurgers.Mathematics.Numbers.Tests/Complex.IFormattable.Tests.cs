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

namespace BenBurgers.Mathematics.Numbers.Tests;

public sealed partial class Complex
{
    public static readonly IEnumerable<object?[]> ToStringTestCases =
        new object?[][]
        {
            [new Complex<double>(0.0d, 0.0d), "<0; 0>"],
            [new Complex<float>(0.0f, 0.0f), "<0; 0>"],
            [new Complex<double>(1.0d, 0.0d), "<1; 0>"],
            [new Complex<double>(0.0d, 1.0d), "<0; 1>"],
            [new Complex<float>(1.1f, 2.2f), "<1.1; 2.2>"]
        };

    [Theory(DisplayName = "ToString should return the expected string representation.")]
    [MemberData(nameof(ToStringTestCases))]
    public void ToStringTests<TComplexComponent>(Complex<TComplexComponent> z, string expected)
        where TComplexComponent
        : IComparisonOperators<TComplexComponent, TComplexComponent, bool>,
        IRootFunctions<TComplexComponent>
    {
        var actual = z.ToString();
        Assert.Equal(expected, actual);
    }
}
