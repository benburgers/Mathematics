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
/// The proposition variable contains its own value and its value can change.
/// </remarks>
public sealed class PropositionVariableStateful : PropositionVariable
{
    /// <summary>
    /// A method signature for a Value Changed event handler.
    /// </summary>
    /// <param name="oldValue">The old value of the proposition variable.</param>
    /// <param name="newValue">The new value of the proposition variable.</param>
    public delegate void ValueChangedHandler(bool oldValue, bool newValue);

    /// <summary>
    /// An event that is triggered if the proposition variable's value has changed.
    /// </summary>
    public event ValueChangedHandler? ValueChanged;

    private bool value;

    /// <summary>
    /// Initializes a new instance of <see cref="PropositionVariableStateful" />.
    /// </summary>
    /// <param name="identifier"></param>
    /// <param name="initialValue"></param>
    public PropositionVariableStateful(string identifier, bool initialValue = false)
        : base(identifier)
    {
        this.value = initialValue;
    }

    /// <summary>
    /// Sets a new value for the proposition variable.
    /// </summary>
    /// <param name="newValue">The new value for the proposition variable.</param>
    public void SetValue(bool newValue)
    {
        var oldValue = this.value;
        this.value = newValue;
        this.ValueChanged?.Invoke(oldValue, newValue);
    }

    /// <summary>
    /// Gets the value of the proposition variable.
    /// </summary>
    public override bool Value => this.value;
}
