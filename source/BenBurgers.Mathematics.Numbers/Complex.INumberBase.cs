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

using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Numerics;

namespace BenBurgers.Mathematics.Numbers;

public readonly partial struct Complex<TComplexComponent>
{
    /// <inheritdoc />
    public static Complex<TComplexComponent> One =>
        new(TComplexComponent.One, TComplexComponent.Zero);

    /// <inheritdoc />
    public static int Radix =>
        TComplexComponent.Radix;

    /// <inheritdoc />
    public static Complex<TComplexComponent> Zero =>
        new(TComplexComponent.Zero, TComplexComponent.Zero);

    /// <inheritdoc />
    public static Complex<TComplexComponent> Abs(Complex<TComplexComponent> value) =>
        new(Hypotenuse(value.Real, value.Imaginary), TComplexComponent.Zero);

    /// <inheritdoc />
    public static bool IsCanonical(Complex<TComplexComponent> value) =>
        true;

    /// <inheritdoc />
    public static bool IsComplexNumber(Complex<TComplexComponent> value) =>
        value.Imaginary != TComplexComponent.Zero && value.Real != TComplexComponent.Zero;

    /// <inheritdoc />
    public static bool IsEvenInteger(Complex<TComplexComponent> value) =>
        value.Imaginary == TComplexComponent.Zero && TComplexComponent.IsEvenInteger(value.Real);

    /// <inheritdoc />
    public static bool IsFinite(Complex<TComplexComponent> value) =>
        TComplexComponent.IsFinite(value.Imaginary) && TComplexComponent.IsFinite(value.Real);

    /// <inheritdoc />
    public static bool IsImaginaryNumber(Complex<TComplexComponent> value) =>
        value.Real == TComplexComponent.Zero;

    /// <inheritdoc />
    public static bool IsInfinity(Complex<TComplexComponent> value) =>
        TComplexComponent.IsInfinity(value.Imaginary) || TComplexComponent.IsInfinity(value.Real);

    /// <inheritdoc />
    public static bool IsInteger(Complex<TComplexComponent> value) =>
        value.Imaginary == TComplexComponent.Zero && TComplexComponent.IsInteger(value.Real);

    /// <inheritdoc />
    public static bool IsNaN(Complex<TComplexComponent> value) =>
        !IsInfinity(value) && !IsFinite(value);

    /// <inheritdoc />
    public static bool IsNegative(Complex<TComplexComponent> value) =>
        value.Imaginary == TComplexComponent.Zero && TComplexComponent.IsNegative(value.Real);

    /// <inheritdoc />
    public static bool IsNegativeInfinity(Complex<TComplexComponent> value) =>
        value.Imaginary == TComplexComponent.Zero && TComplexComponent.IsNegativeInfinity(value.Real);

    /// <inheritdoc />
    public static bool IsNormal(Complex<TComplexComponent> value) =>
        (value.Imaginary == TComplexComponent.Zero || TComplexComponent.IsNormal(value.Imaginary)) && TComplexComponent.IsNormal(value.Real);

    /// <inheritdoc />
    public static bool IsOddInteger(Complex<TComplexComponent> value) =>
        value.Imaginary == TComplexComponent.Zero && TComplexComponent.IsOddInteger(value.Real);

    /// <inheritdoc/>
    public static bool IsPositive(Complex<TComplexComponent> value) =>
        value.Imaginary == TComplexComponent.Zero && TComplexComponent.IsPositive(value.Real);

    /// <inheritdoc />
    public static bool IsPositiveInfinity(Complex<TComplexComponent> value) =>
        value.Imaginary == TComplexComponent.Zero && TComplexComponent.IsPositiveInfinity(value.Real);

    /// <inheritdoc />
    public static bool IsRealNumber(Complex<TComplexComponent> value) =>
        value.Imaginary == TComplexComponent.Zero && TComplexComponent.IsRealNumber(value.Real);

    /// <inheritdoc />
    public static bool IsSubnormal(Complex<TComplexComponent> value) =>
        TComplexComponent.IsSubnormal(value.Imaginary) || TComplexComponent.IsSubnormal(value.Real);

    /// <inheritdoc />
    public static bool IsZero(Complex<TComplexComponent> value) =>
        value.Imaginary == TComplexComponent.Zero && value.Real == TComplexComponent.Zero;

    /// <inheritdoc />
    public static Complex<TComplexComponent> MaxMagnitude(Complex<TComplexComponent> x, Complex<TComplexComponent> y)
    {
        var amplitudeX = Abs(x);
        var amplitudeY = Abs(y);

        if ((amplitudeX > amplitudeY) || IsNaN(amplitudeX))
            return x;

        if (amplitudeX == amplitudeY)
        {
            switch (
                TComplexComponent.IsNegative(x.Real),
                TComplexComponent.IsNegative(x.Imaginary),
                TComplexComponent.IsNegative(y.Real),
                TComplexComponent.IsNegative(y.Imaginary))
            {
                case (_, _, true, true): // y = -a - ib
                    return x;
                case (true, _, true, false): // x = -a + ib or -a - ib and y = -a + ib
                    return y;
                case (false, _, true, false): // x = +a + ib or +a - ib and y = -a + ib
                    return x;
                case (true, _, false, true): // x = -a + ib or -a - ib and y = +a - ib
                    return y;
                case (false, _, false, true): // x = +a + ib or +a - ib and y = +a - ib
                    return x;
            }
        }

        return y;
    }

    /// <inheritdoc />
    public static Complex<TComplexComponent> MaxMagnitudeNumber(Complex<TComplexComponent> x, Complex<TComplexComponent> y)
    {
        throw new NotImplementedException();
    }

    /// <inheritdoc />
    public static Complex<TComplexComponent> MinMagnitude(Complex<TComplexComponent> x, Complex<TComplexComponent> y)
    {
        throw new NotImplementedException();
    }

    /// <inheritdoc />
    public static Complex<TComplexComponent> MinMagnitudeNumber(Complex<TComplexComponent> x, Complex<TComplexComponent> y)
    {
        throw new NotImplementedException();
    }

    /// <inheritdoc />
    public static Complex<TComplexComponent> Parse(ReadOnlySpan<char> s, NumberStyles style, IFormatProvider? provider)
    {
        throw new NotImplementedException();
    }

    /// <inheritdoc />
    public static Complex<TComplexComponent> Parse(string s, NumberStyles style, IFormatProvider? provider)
    {
        throw new NotImplementedException();
    }

    /// <inheritdoc />
    public static bool TryParse(ReadOnlySpan<char> s, NumberStyles style, IFormatProvider? provider, [MaybeNullWhen(false)] out Complex<TComplexComponent> result)
    {
        throw new NotImplementedException();
    }

    /// <inheritdoc />
    public static bool TryParse([NotNullWhen(true)] string? s, NumberStyles style, IFormatProvider? provider, [MaybeNullWhen(false)] out Complex<TComplexComponent> result)
    {
        throw new NotImplementedException();
    }

    static bool INumberBase<Complex<TComplexComponent>>.TryConvertFromChecked<TOther>(TOther value, out Complex<TComplexComponent> result)
    {
        throw new NotImplementedException();
    }

    static bool INumberBase<Complex<TComplexComponent>>.TryConvertFromSaturating<TOther>(TOther value, out Complex<TComplexComponent> result)
    {
        throw new NotImplementedException();
    }

    static bool INumberBase<Complex<TComplexComponent>>.TryConvertFromTruncating<TOther>(TOther value, out Complex<TComplexComponent> result)
    {
        throw new NotImplementedException();
    }

    static bool INumberBase<Complex<TComplexComponent>>.TryConvertToChecked<TOther>(Complex<TComplexComponent> value, out TOther result)
    {
        throw new NotImplementedException();
    }

    static bool INumberBase<Complex<TComplexComponent>>.TryConvertToSaturating<TOther>(Complex<TComplexComponent> value, out TOther result)
    {
        throw new NotImplementedException();
    }

    static bool INumberBase<Complex<TComplexComponent>>.TryConvertToTruncating<TOther>(Complex<TComplexComponent> value, out TOther result)
    {
        throw new NotImplementedException();
    }
}
