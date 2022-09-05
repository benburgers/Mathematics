/*
 * Ben Burgers Mathematics
 * © 2022 Ben Burgers and contributors
 * Licensed under AGPL 3.0
 */

namespace BenBurgers.Mathematics.Logic.Sets;

/// <summary>
/// A type of quantifier.
/// </summary>
public enum QuantifierType
{
    /// <summary>
    /// An existential quantifier.
    /// </summary>
    Existential,

    /// <summary>
    /// A uniqueness quantifier.
    /// </summary>
    Uniqueness,

    /// <summary>
    /// A universal quantifier.
    /// </summary>
    Universal
}