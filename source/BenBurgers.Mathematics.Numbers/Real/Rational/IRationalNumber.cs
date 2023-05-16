/*
 * Ben Burgers Mathematics
 * © 2022-2023 Ben Burgers and contributors
 * Licensed under AGPL 3.0
 */

namespace BenBurgers.Mathematics.Numbers.Real.Rational;

/// <summary>
/// Represents a rational number.
/// </summary>
public interface IRationalNumber
    : IRealNumber
{
}

/// <summary>
/// Represents a rational number.
/// </summary>
/// <typeparam name="TNumber">The type of number.</typeparam>
public interface IRationalNumber<TNumber>
    : IRationalNumber, IRealNumber<TNumber>
    where TNumber : IRationalNumber<TNumber>
{
}