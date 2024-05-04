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
 * You should have received a copy of the GNU General Public License along with Ben Burgers Mathematics. If not, see <https://www.gnu.org/licenses/>.
 */

using System.Numerics;

namespace BenBurgers.Mathematics.Numbers;

public readonly partial struct Complex<TComplexComponent>
{
    /// <inheritdoc />
    public static Complex<TComplexComponent> operator +(Complex<TComplexComponent> left, Complex<TComplexComponent> right)
    {
        return Add(left, right);
    }

    /// <summary>
    /// Adds two complex numbers.
    /// </summary>
    /// <param name="left">The left operand.</param>
    /// <param name="right">The right operand.</param>
    /// <returns>The result of the addition.</returns>
    public static Complex<TComplexComponent> Add(Complex<TComplexComponent> left, Complex<TComplexComponent> right)
    {
        return new Complex<TComplexComponent>(left.Real + right.Real, left.Imaginary + right.Imaginary);
    }

    /// <summary>
    /// Adds two complex numbers.
    /// </summary>
    /// <param name="other">The other number to add.</param>
    /// <returns>The result of the addition.</returns>
    public Complex<TComplexComponent> Add(Complex<TComplexComponent> other)
    {
        return Add(this, other);
    }
}
