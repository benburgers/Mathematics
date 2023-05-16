/*
 * Ben Burgers Mathematics
 * © 2022-2023 Ben Burgers and contributors
 * Licensed under AGPL 3.0
 */

namespace BenBurgers.Mathematics.Numbers.Real.Irrational;

/// <summary>
/// Represents an irrational number.
/// </summary>
public interface IIrrationalNumber
    : IRealNumber
{
}

/// <summary>
/// Represents an irrational number.
/// </summary>
/// <typeparam name="TNumber">The type of number.</typeparam>
public interface IIrrationalNumber<TNumber>
    : IRealNumber<TNumber>
    where TNumber : IRealNumber<TNumber>
{
}