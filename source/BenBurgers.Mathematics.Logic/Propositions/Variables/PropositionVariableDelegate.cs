/*
 * Ben Burgers Mathematics
 * © 2022-2023 Ben Burgers and contributors
 * Licensed under AGPL 3.0
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
