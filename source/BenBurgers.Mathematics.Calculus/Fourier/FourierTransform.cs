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

using BenBurgers.Mathematics.Calculus.Integrals.Darboux;
using BenBurgers.Mathematics.Numbers;
using System.Numerics;

namespace BenBurgers.Mathematics.Calculus.Fourier;

/// <summary>
/// Fourier transform methods.
/// </summary>
public static class FourierTransform
{
    /*
    /// <summary>
    /// Performs a Fourier transform.
    /// </summary>
    /// <param name="start">The start of the transform on the time domain.</param>
    /// <param name="end">The end of the transform on the time domain.</param>
    /// <param name="f">The periodic function.</param>
    /// <param name="x">The desired transform on the frequency domain.</param>
    /// <returns>The Fourier transform for the desired frequency domain.</returns>
    public static Complex<TComplexComponent> Perform<TComplexComponent>(
        Complex<TComplexComponent> start,
        Complex<TComplexComponent> end,
        Complex<TComplexComponent> e,
        Complex<TComplexComponent> pi, 
        Func<Complex<TComplexComponent>, Complex<TComplexComponent>> f,
        Complex<TComplexComponent> x)
        where TComplexComponent
        : IComparisonOperators<TComplexComponent, TComplexComponent, bool>,
        IRootFunctions<TComplexComponent>
    {
        var integral = new IntegralDarboux<Complex<TComplexComponent>>(k =>
        {
            return f(x) * Complex<TComplexComponent>.Pow(e, -(TComplexComponent.One + TComplexComponent.One) * pi * k.Real);
        });
        var args = new DarbouxStepArgsSync<Complex<TComplexComponent>>(start, end, new Complex<TComplexComponent>(0.01d, 0.0d), IntegralDarbouxMode.Lower);
        return integral.Approximate(args);
    }
    */
}
