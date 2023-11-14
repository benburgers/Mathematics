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

namespace BenBurgers.Mathematics.Numbers;

/// <summary>
/// A complex number.
/// </summary>
/// <remarks>
/// Adaptation from System.Runtime.Numerics' <see cref="Complex" />, but with a type argument instead of a fixed <see cref="double" /> type as Real and Imaginary components.
/// See <a href="https://github.com/dotnet/runtime/blob/main/src/libraries/System.Runtime.Numerics/src/System/Numerics/Complex.cs">GitHub</a> for the implementation of <see cref="Complex" />.
/// </remarks>
public readonly partial struct Complex<TComplexComponent>(TComplexComponent real, TComplexComponent imaginary)
    : ISignedNumber<Complex<TComplexComponent>>,
    IUtf8SpanFormattable
    where TComplexComponent
    : IComparisonOperators<TComplexComponent, TComplexComponent, bool>,
    IRootFunctions<TComplexComponent>
{
    /// <summary>
    /// Gets the real component of the complex number.
    /// </summary>
    public TComplexComponent Real { get; } = real;

    /// <summary>
    /// Gets the imaginary component of the complex number.
    /// </summary>
    public TComplexComponent Imaginary { get; } = imaginary;

    /// <summary>
    /// Gets the magnitude of the complex number.
    /// </summary>
    public TComplexComponent Magnitude => Abs(this).Real;

    private static TComplexComponent Hypotenuse(TComplexComponent a, TComplexComponent b)
    {
        a = TComplexComponent.Abs(a);
        b = TComplexComponent.Abs(b);

        TComplexComponent small, large;
        if (a < b)
        {
            small = a;
            large = b;
        }
        else
        {
            small = b;
            large = a;
        }

        if (small == TComplexComponent.Zero)
            return large;
        else if (TComplexComponent.IsPositiveInfinity(large) && !TComplexComponent.IsNaN(small))
            return TComplexComponent.One / TComplexComponent.Zero;
        else
        {
            var ratio = small / large;
            return large * TComplexComponent.Sqrt(TComplexComponent.One + ratio * ratio);
        }
    }

    /// <inheritdoc/>
    public override bool Equals(object? obj)
    {
        if (obj is null) return false;
        if (obj is Complex<TComplexComponent> other) return Equals(other);
        return false;
    }

    /// <inheritdoc/>
    public override int GetHashCode() =>
        HashCode.Combine(this.Real, this.Imaginary);

    /// <inheritdoc/>
    public override string ToString() =>
        this.ToString(null, null);
}
