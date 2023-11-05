/*
 * Ben Burgers Mathematics
 * © 2022-2023 Ben Burgers and contributors
 * Licensed under AGPL 3.0
 */

using BenBurgers.Mathematics.Logic.Symbols;

namespace BenBurgers.Mathematics.Logic.Propositions;

/// <summary>
/// A negation in propositional logic.
/// </summary>
public sealed class PropositionalFormulaNegation
    : PropositionalFormula
{
    /// <summary>
    /// Initializes a new instance of <see cref="PropositionalFormulaNegation" />.
    /// </summary>
    /// <param name="operand">
    /// The formula that is negated.
    /// </param>
    public PropositionalFormulaNegation(PropositionalFormula operand)
        : base(new[] { operand })
    {
    }

    /// <inheritdoc />
    public override string ToString() =>
        $"{Symbol.NegationChar}{this.First()}";
}
