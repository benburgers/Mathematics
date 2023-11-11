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

namespace BenBurgers.Mathematics.Logic.Expressions.Abstractions;

/// <summary>
/// A logical binary expression.
/// </summary>
public interface ILogicBinaryExpression
{
    /// <summary>
    /// Gets the left hand side of the expression.
    /// </summary>
    LogicExpression Left { get; }

    /// <summary>
    /// Gets the right hand side of the expression.
    /// </summary>
    LogicExpression Right { get; }
    
    /// <summary>
    /// Gets any other operands in the expression, if it can be chained.
    /// </summary>
    IReadOnlyList<LogicExpression> Others { get; }
}