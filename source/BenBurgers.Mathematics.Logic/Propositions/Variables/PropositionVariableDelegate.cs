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

namespace BenBurgers.Mathematics.Logic.Propositions.Variables;

/// <inheritdoc cref="PropositionVariable" />
/// <remarks>
/// This proposition variable uses a delegate method for determining the current value of the proposition variable.
/// </remarks>
public sealed class PropositionVariableDelegate : PropositionVariable
{
    /// <summary>
    /// The method signature of the value getter.
    /// </summary>
    /// <returns>The value of the proposition value.</returns>
    public delegate bool ValueGetterDelegate();

    private readonly ValueGetterDelegate valueGetter;

    /// <summary>
    /// Initializes a new instance of <see cref="PropositionVariableDelegate" />.
    /// </summary>
    /// <param name="identifier">The identiier of the proposition variable.</param>
    /// <param name="valueGetter">Gets the value of the proposition variable.</param>
    public PropositionVariableDelegate(string identifier, ValueGetterDelegate valueGetter)
        : base(identifier)
    {
        this.valueGetter = valueGetter;
    }

    /// <inheritdoc cref="PropositionVariable.Value" />
    public override bool Value => this.valueGetter();
}
