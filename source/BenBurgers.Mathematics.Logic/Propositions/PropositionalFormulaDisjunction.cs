/*
 * Ben Burgers Mathematics
 * © 2022-2023 Ben Burgers and contributors
 * Licensed under AGPL 3.0
 */

using BenBurgers.Mathematics.Logic.Symbols;

namespace BenBurgers.Mathematics.Logic.Propositions;

/// <summary>
/// A disjunctive propositional formula.
/// </summary>
public sealed class PropositionalFormulaDisjunction
    : PropositionalFormula
{
    /// <summary>
    /// Initializes a new instance of <see cref="PropositionalFormulaDisjunction" />.
    /// </summary>
    /// <param name="children">The propositional formula's children.</param>
    public PropositionalFormulaDisjunction(IEnumerable<PropositionalFormula> children)
        : base(children)
    {
    }

    /// <inheritdoc />
    public override string ToString() =>
        string.Join(Symbol.DisjunctionChar, this);
}
