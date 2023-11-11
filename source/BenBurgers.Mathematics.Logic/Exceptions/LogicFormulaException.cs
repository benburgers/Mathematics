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

namespace BenBurgers.Mathematics.Logic.Exceptions;

/// <summary>
/// An exception that is thrown by a logic formula.
/// </summary>
public abstract class LogicFormulaException
    : LogicException
{
    /// <summary>
    /// Initializes a new instance of <see cref="LogicFormulaException" />.
    /// </summary>
    /// <param name="message">
    /// The exception message.
    /// </param>
    /// <param name="innerException">
    /// The inner exception.
    /// </param>
    public LogicFormulaException(string message, Exception? innerException)
        : base(message, innerException)
    {
    }

    /// <summary>
    /// Initializes a new instance of <see cref="LogicFormulaException" />.
    /// </summary>
    /// <param name="message">
    /// The exception message.
    /// </param>
    public LogicFormulaException(string message)
        : this(message, null)
    {
    }
}