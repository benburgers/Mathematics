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

using System.Text;

namespace BenBurgers.Mathematics.Logic.TruthTables;

/// <summary>
/// Represents a logic truth table.
/// </summary>
public class TruthTable
{
    private readonly IList<Formula> formulae;

    /// <summary>
    /// Initializes a new instance of <see cref="TruthTable" />.
    /// </summary>
    /// <param name="formulae">
    /// The logic formulae for the truth table.
    /// </param>
    public TruthTable(IEnumerable<Formula> formulae)
    {
        this.formulae = formulae.ToList();
    }

    /// <summary>
    /// Gets the components for the columns of the table.
    /// </summary>
    public IEnumerable<Formula> Columns => this.formulae;

    /// <summary>
    /// Returns a string representation of the truth table.
    /// </summary>
    /// <returns>
    /// A string representation of the truth table.
    /// </returns>
    public override string ToString()
    {
        var stringBuilder = new StringBuilder();
        foreach (var column in this.Columns)
        {
            stringBuilder.Append(column.ToString());
        }
        return stringBuilder.ToString();
    }
}