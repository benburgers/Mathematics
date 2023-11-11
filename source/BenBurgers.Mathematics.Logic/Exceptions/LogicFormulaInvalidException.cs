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
/// An exception that is thrown if an operation is attempted on an invalid formula.
/// </summary>
public sealed class LogicFormulaInvalidException
    : LogicFormulaException
{
    internal LogicFormulaInvalidException(IEnumerable<int> symbolIndices, string reason)
        : base(ExceptionMessages.FormulaInvalid)
    {
        SymbolIndices = symbolIndices.ToArray();
        Reason = reason;
    }

    /// <summary>
    /// Gets the indices of the symbols that make the formula invalid.
    /// </summary>
    public IReadOnlyList<int> SymbolIndices { get; }

    /// <summary>
    /// Gets the textual reason why the formula is invalid.
    /// </summary>
    public string Reason { get; }
}