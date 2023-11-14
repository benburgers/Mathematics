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

using BenBurgers.Mathematics.Calculus.Fourier;
using System.Numerics;

namespace BenBurgers.Mathematics.Calculus.Tests.Fourier;

public sealed class FourierTransformTests
{
    public static readonly IEnumerable<object?[]> PerformTestCases =
        new[]
        {
            new object?[]
            {
                new Complex(-100.0d, 0.0d),
                new Complex(100.0d, 0.0d),
                new Func<Complex, Complex>(t => Math.Sin(t.Real)),
                new Complex(2.0d, 0.0d),
                new Complex(5.0d, 0.0d)
            }
        };

    /*
    [Theory(DisplayName = "Fourier transform should return the expected value.")]
    [MemberData(nameof(PerformTestCases))]
    public void PerformTests(Complex start, Complex end, Func<Complex, Complex> f, Complex x, Complex expected)
    {
        var actual = FourierTransform.Perform(start, end, f, x);
        Assert.Equal(expected, actual);
    }
    */
}
