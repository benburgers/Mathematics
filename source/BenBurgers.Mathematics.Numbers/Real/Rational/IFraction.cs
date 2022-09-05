/*
 * Ben Burgers Mathematics
 * © 2022 Ben Burgers and contributors
 * Licensed under AGPL 3.0
 */

namespace BenBurgers.Mathematics.Numbers.Real.Rational;

/// <summary>
/// Represents a fraction.
/// </summary>
public interface IFraction
    : INumber<IFraction>
{
    /// <summary>
    /// Gets the numerator of the fraction.
    /// </summary>
    INumber Numerator { get; }

    /// <summary>
    /// Gets the denominator of the fraction.
    /// </summary>
    INumber Denominator { get; }
}

/// <summary>
/// Represents a fraction.
/// </summary>
/// <typeparam name="TNumerator">The number type of the numerator.</typeparam>
/// <typeparam name="TDenominator">The number type of the denominator.</typeparam>
public interface IFraction<TNumerator, TDenominator> :
    IFraction
    where TNumerator : INumber<TNumerator>
    where TDenominator : INumber<TDenominator>
{
    /// <summary>
    /// Gets the numerator of the fraction.
    /// </summary>
    new TNumerator Numerator { get; }

    /// <summary>
    /// Gets the denominator of the fraction.
    /// </summary>
    new TDenominator Denominator { get; }
}