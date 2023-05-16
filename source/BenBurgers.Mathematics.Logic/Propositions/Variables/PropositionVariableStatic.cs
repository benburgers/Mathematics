/*
 * Ben Burgers Mathematics
 * © 2022-2023 Ben Burgers and contributors
 * Licensed under AGPL 3.0
 */

namespace BenBurgers.Mathematics.Logic.Propositions.Variables;

/// <inheritdoc cref="PropositionVariable" />
/// <remarks>
/// This proposition variable contains a static value that does not change.
/// </remarks>
public sealed class PropositionVariableStatic : PropositionVariable
{
    /// <summary>
    /// Initializes a new instance of <see cref="PropositionVariableStatic" />.
    /// </summary>
    /// <param name="identifier">The identifier of the proposition variable.</param>
    /// <param name="value">The value of the proposition value.</param>
    public PropositionVariableStatic(string identifier, bool value)
        : base(identifier)
    {
        this.Value = value;
    }

    /// <inheritdoc />
    public override bool Value { get; }
}
