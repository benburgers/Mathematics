/*
 * Ben Burgers Mathematics
 * © 2022 Ben Burgers and contributors
 * Licensed under AGPL 3.0
 */

using BenBurgers.Mathematics.Numbers.Sequence;

namespace BenBurgers.Mathematics.Numbers.Real.Rational;

/// <summary>
/// An approximation of a real number.
/// </summary>
public interface IApproximation
    : IRationalNumber
{
    /// <summary>
    /// Gets the mantissa of the approximation.
    /// </summary>
    internal NumberSequence Mantissa { get; }

    /// <summary>
    /// The scale of the approximation.
    /// </summary>
    internal NumberSequence Scale { get; }
}

/// <summary>
/// An approximation of a real number.
/// </summary>
/// <typeparam name="TNumber">
/// The type of number.
/// </typeparam>
public interface IApproximation<TNumber>
    : IApproximation, IRationalNumber<TNumber>
    where TNumber : IApproximation<TNumber>
{
}