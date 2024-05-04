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

namespace BenBurgers.Mathematics.Numbers;

public readonly partial struct Complex<TComplexComponent>
{
    /// <inheritdoc/>
    public int CompareTo(object? obj)
    {
        return obj switch
        {
            null => throw new ArgumentNullException(nameof(obj)),
            Complex<TComplexComponent> other => this.CompareTo(other),
            _ => throw new NotSupportedException($"Comparing to type {obj.GetType().Name} not supported.") // TODO localize
        };
    }

    /// <inheritdoc/>
    public int CompareTo(Complex<TComplexComponent> other)
    {
        return Hypotenuse(this.Real, this.Imaginary).CompareTo(Hypotenuse(other.Real, other.Imaginary));
    }
}
