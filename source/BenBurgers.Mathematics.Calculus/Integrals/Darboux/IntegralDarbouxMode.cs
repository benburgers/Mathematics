/*
 * Ben Burgers Mathematics
 * © 2022-2023 Ben Burgers and contributors
 * Licensed under AGPL 3.0
 */

namespace BenBurgers.Mathematics.Calculus.Integrals.Darboux;

/// <summary>
/// The mode of calculating the Darboux sum.
/// </summary>
public enum IntegralDarbouxMode
{
    /// <summary>
    /// Calculate the lower Darboux sum.
    /// </summary>
    Lower,

    /// <summary>
    /// Calculate the upper Darboux sum.
    /// </summary>
    Upper
}
