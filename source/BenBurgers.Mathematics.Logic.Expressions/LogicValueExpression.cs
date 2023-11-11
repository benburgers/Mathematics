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

namespace BenBurgers.Mathematics.Logic.Expressions;

/// <summary>
/// A logical value.
/// </summary>
/// <remarks>
/// True, false or undetermined.
/// </remarks>
/// <example>
/// <list type="bullet">
/// <item>1</item>
/// <item>0</item>
/// <item>?</item>
/// </list>
/// </example>
public class LogicValueExpression
    : LogicExpression
{
    /// <summary>
    /// Initializes a new instance of <see cref="LogicValueExpression" />.
    /// </summary>
    /// <param name="value">
    /// The value.
    /// </param>
    public LogicValueExpression(bool? value)
    {
        this.Value = value;
    }

    /// <summary>
    /// Gets the value.
    /// </summary>
    public bool? Value { get; }

    /// <inheritdoc />
    public override LogicValueExpression Clone()
    {
        return new LogicValueExpression(this.Value);
    }

    /// <inheritdoc />
    public override string ToString()
    {
        return this.Value switch
        {
            null => "?",
            true => "1",
            false => "0"
        };
    }
}