/*
 * Ben Burgers Mathematics
 * © 2022-2023 Ben Burgers and contributors
 * Licensed under AGPL 3.0
 */

namespace BenBurgers.Mathematics.Logic.Propositions;

/// <summary>
/// A propositional formula.
/// </summary>
public abstract class PropositionalFormula
    : Formula
{
    /// <summary>
    /// Initializes a new instance of <see cref="PropositionalFormula" />.
    /// </summary>
    protected PropositionalFormula()
        : base()
    {
    }

    /// <summary>
    /// Initializes a new instance of <see cref="PropositionalFormula" />.
    /// </summary>
    /// <param name="children">The propositional formula's children.</param>
    protected PropositionalFormula(IEnumerable<PropositionalFormula> children)
        : base(children)
    {
    }

    /// <summary>
    /// Creates a conjunction of the current formula and other formulae.
    /// </summary>
    /// <param name="other">The other formula.</param>
    /// <param name="rest">More formulae, if applicable.</param>
    /// <returns>
    /// A conjunction of propositional formulae.
    /// </returns>
    public PropositionalFormulaConjunction And(PropositionalFormula other, params PropositionalFormula[] rest) =>
        new(rest.Prepend(other).Prepend(this));

    /// <summary>
    /// Creates a disjunction of the current formula and other formulae.
    /// </summary>
    /// <param name="other">The other formula.</param>
    /// <param name="rest">More formulae, if applicable.</param>
    /// <returns>
    /// A disjunction of propositional formulae.
    /// </returns>
    public PropositionalFormulaDisjunction Or(PropositionalFormula other, params PropositionalFormula[] rest) =>
        new(rest.Prepend(other).Prepend(this));
}