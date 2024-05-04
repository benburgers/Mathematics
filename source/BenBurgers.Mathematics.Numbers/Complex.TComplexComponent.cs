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
    /// <summary>
    /// Implicitly casts the real component of a complex number to a full complex number.
    /// </summary>
    /// <param name="real">The real component of the complex number.</param>
    public static implicit operator Complex<TComplexComponent>(TComplexComponent real)
    {
        return new Complex<TComplexComponent>(real, TComplexComponent.Zero);
    }
}
