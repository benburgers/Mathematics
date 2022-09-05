/*
 * Ben Burgers Mathematics
 * © 2022 Ben Burgers and contributors
 * Licensed under AGPL 3.0
 */

using BenBurgers.Mathematics.Numbers.Arithmetics;

namespace BenBurgers.Mathematics.Numbers.Arithmetic.Divisions;

/// <summary>
/// A division arithmetic operation.
/// </summary>
/// <typeparam name="TNumerator">
/// The number type as the numerator in the division.
/// </typeparam>
/// <typeparam name="TDenominator">
/// The number type as the denominator in the division.
/// </typeparam>
public interface IDivision<TNumerator, TDenominator>
    : IArithmeticOperation<ArithmeticOptions>
    where TNumerator : INumber<TNumerator>
    where TDenominator : INumber<TDenominator>
{
    /// <summary>
    /// Gets the numerator.
    /// </summary>
    TNumerator Numerator { get; }

    /// <summary>
    /// Gets the denominator.
    /// </summary>
    TDenominator Denominator { get; }
}