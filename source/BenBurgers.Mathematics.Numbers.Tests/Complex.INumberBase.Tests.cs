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
    public static readonly IEnumerable<object?[]> OneTestCases =
        new object?[][]
        {
            [new Complex<double>(1.0d, 0.0d)],
            [new Complex<float>(1.0f, 0.0f)]
        };

    [Theory(DisplayName = "One should return the expected value.")]
    [MemberData(nameof(OneTestCases))]
    public void OneTest<TComplexComponent>(Complex<TComplexComponent> expected)
        where TComplexComponent
        : IComparisonOperators<TComplexComponent, TComplexComponent, bool>,
        IRootFunctions<TComplexComponent>
    {
        var actual = Complex<TComplexComponent>.One;
        Assert.Equal(expected, actual);
    }

    public static readonly IEnumerable<object?[]> RadixTestCases =
        new object?[][]
        {
            [new Complex<double>(0.0d, 0.0d), 2],
            [new Complex<float>(0.0f, 0.0f), 2]
        };

    [Theory(DisplayName = "Radix should return the expected value.")]
    [MemberData(nameof(RadixTestCases))]
    public void RadixTests<TComplexComponent>(Complex<TComplexComponent> z, int expected)
        where TComplexComponent
        : IComparisonOperators<TComplexComponent, TComplexComponent, bool>,
        IRootFunctions<TComplexComponent>
    {
        var actual = Complex<TComplexComponent>.Radix;
        Assert.Equal(expected, actual);
    }

    public static readonly IEnumerable<object?[]> ZeroTestCases =
        new object?[][]
        {
            [new Complex<double>(0.0d, 0.0d)],
            [new Complex<float>(0.0f, 0.0f)]
        };

    [Theory(DisplayName = "Zero should return the expected value.")]
    [MemberData(nameof(ZeroTestCases))]
    public void ZeroTests<TComplexComponent>(Complex<TComplexComponent> expected)
        where TComplexComponent
        : IComparisonOperators<TComplexComponent, TComplexComponent, bool>,
        IRootFunctions<TComplexComponent>
    {
        var actual = Complex<TComplexComponent>.Zero;
        Assert.Equal(expected, actual);
    }

    public static readonly IEnumerable<object?[]> AbsoluteTestCases =
        new object?[][]
        {
            [new Complex<double>(1.0d, 2.0d), new Complex<double>(2.23606797749979d, 0.0d)],
            [new Complex<float>(2.0f, 3.0f), new Complex<float>(3.6055512f, 0.0f)]
        };

    [Theory(DisplayName = "Abs should return the expected value.")]
    [MemberData(nameof(AbsoluteTestCases))]
    public void AbsoluteTests<TComplexComponent>(Complex<TComplexComponent> z, Complex<TComplexComponent> expected)
        where TComplexComponent
        : IComparisonOperators<TComplexComponent, TComplexComponent, bool>,
        IRootFunctions<TComplexComponent>
    {
        var actual = Complex<TComplexComponent>.Abs(z);
        Assert.Equal(expected, actual);
    }

    public static readonly IEnumerable<object?[]> IsComplexNumberTestCases =
        new object?[][]
        {
            [new Complex<double>(1.0d, 2.0d), true],
            [new Complex<double>(2.0d, 0.0d), false],
            [new Complex<float>(3.0f, -1.5f), true],
            [new Complex<float>(2.5f, 0.0f), false]
        };

    [Theory(DisplayName = "IsComplexNumber should return the expected value.")]
    [MemberData(nameof(IsComplexNumberTestCases))]
    public void IsComplexNumberTests<TComplexComponent>(Complex<TComplexComponent> z, bool expected)
        where TComplexComponent
        : IComparisonOperators<TComplexComponent, TComplexComponent, bool>,
        IRootFunctions<TComplexComponent>
    {
        var actual = Complex<TComplexComponent>.IsComplexNumber(z);
        Assert.Equal(expected, actual);
    }
}
