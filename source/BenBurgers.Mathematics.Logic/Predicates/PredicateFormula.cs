/*
 * Ben Burgers Mathematics
 * © 2022-2023 Ben Burgers and contributors
 * Licensed under AGPL 3.0
 */

using BenBurgers.Mathematics.Logic.Symbols;

namespace BenBurgers.Mathematics.Logic.Predicates;

/// <summary>
/// A predicate formula.
/// </summary>
public sealed class PredicateFormula
    : Formula
{
    /// <summary>
    /// Initializes a new instance of <see cref="PredicateFormula" />.
    /// </summary>
    public PredicateFormula()
        : base()
    {
    }

    /// <inheritdoc />
    protected override bool AddGuard(Symbol symbol)
    {
        throw new NotImplementedException();
    }
}