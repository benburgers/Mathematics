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

using System.Runtime.CompilerServices;

namespace BenBurgers.Mathematics.Numbers;

public readonly partial struct Complex<TComplexComponent>
{
    /// <inheritdoc/>
    public string ToString(string? format, IFormatProvider? formatProvider)
    {
        var handler = new DefaultInterpolatedStringHandler(4, 2, formatProvider, stackalloc char[512]);
        handler.AppendLiteral("<");
        handler.AppendFormatted(this.Real, format);
        handler.AppendLiteral("; ");
        handler.AppendFormatted(this.Imaginary, format);
        handler.AppendLiteral(">");
        return handler.ToStringAndClear();
    }
}
