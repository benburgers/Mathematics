/*
 * Ben Burgers Mathematics
 * © 2022-2023 Ben Burgers and contributors
 * Licensed under AGPL 3.0
 */

using BenBurgers.Mathematics.Logic.Symbols;

namespace BenBurgers.Mathematics.Logic.Propositions;

/// <summary>
/// A conjunctive propositional formula.
/// </summary>
public sealed class PropositionalFormulaConjunction
    : PropositionalFormula
{
    /// <summary>
    /// Initializes a new instance of <see cref="PropositionalFormulaConjunction" />.
    /// </summary>
    /// <param name="children">The propositional formula's children.</param>
    public PropositionalFormulaConjunction(IEnumerable<PropositionalFormula> children)
        : base(children)
    {
    }

    /// <inheritdoc />
    public override string ToString() =>
        string.Join(Symbol.ConjunctionChar, this);
}
