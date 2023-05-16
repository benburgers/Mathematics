/*
 * Ben Burgers Mathematics
 * © 2022-2023 Ben Burgers and contributors
 * Licensed under AGPL 3.0
 */

namespace BenBurgers.Mathematics.Logic.Propositions.Variables;

/// <inheritdoc cref="PropositionVariable" />
/// <remarks>
/// The proposition variable reads its value from a <see cref="Func{Boolean}" />.
/// </remarks>
public sealed class PropositionVariableFunc : PropositionVariable
{
    private readonly Func<bool> valueGetter;

    /// <summary>
    /// Initializes a new instance of <see cref="PropositionVariableFunc" />.
    /// </summary>
    /// <param name="identifier">The identifier of the proposition variable.</param>
    /// <param name="valueGetter">Gets the value of the proposition variable.</param>
    public PropositionVariableFunc(string identifier, Func<bool> valueGetter)
        : base(identifier)
    {
        this.valueGetter = valueGetter;
    }

    /// <inheritdoc cref="PropositionVariable.Value" />
    public override bool Value => this.valueGetter();
}
