/*
 * Ben Burgers Mathematics
 * © 2022-2023 Ben Burgers and contributors
 * Licensed under AGPL 3.0
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
