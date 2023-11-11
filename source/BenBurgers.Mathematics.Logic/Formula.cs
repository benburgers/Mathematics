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

using System.Collections;
using System.Diagnostics;
using System.Text;

namespace BenBurgers.Mathematics.Logic;

/// <summary>
/// A logical formula.
/// </summary>
[DebuggerDisplay("{DebuggerDisplay,nq}")]
public abstract class Formula
    : IEnumerable<Formula>
{
    private readonly List<Formula> children;

    /// <summary>
    /// Initializes a new instance of <see cref="Formula" />
    /// </summary>
    protected internal Formula()
    {
        this.children = new List<Formula>();
    }

    /// <summary>
    /// Initializes a new instance of <see cref="Formula" />.
    /// </summary>
    /// <param name="children">The formula's children.</param>
    protected internal Formula(IEnumerable<Formula> children)
    {
        this.children = children.ToList();
    }

    private string DebuggerDisplay => this.ToString();

    /// <inheritdoc />
    public IEnumerator<Formula> GetEnumerator()
    {
        return this.children.GetEnumerator();
    }

    /// <summary>
    /// Returns a string representation of the <see cref="Formula" />.
    /// </summary>
    /// <returns>
    /// The string representation of the <see cref="Formula" />.
    /// </returns>
    public override string ToString()
    {
        var stringBuilder = new StringBuilder();
        foreach (var formula in this.children)
        {
            stringBuilder.Append(formula.ToString());
        }
        return stringBuilder.ToString();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.GetEnumerator();
    }
}