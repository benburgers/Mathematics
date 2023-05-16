/*
 * Ben Burgers Mathematics
 * © 2022-2023 Ben Burgers and contributors
 * Licensed under AGPL 3.0
 */

namespace BenBurgers.Mathematics.Numbers.Real.Rational.Integer.Natural;

/// <summary>
/// Represents a natural number.
/// </summary>
public interface INaturalNumber
    : IIntegerNumber
{
}

/// <summary>
/// Represents a natural number.
/// </summary>
/// <typeparam name="TNaturalNumber">The type of natural number.</typeparam>
public interface INaturalNumber<TNaturalNumber>
    : INaturalNumber,
    IIntegerNumber<TNaturalNumber>
    where TNaturalNumber : INaturalNumber<TNaturalNumber>
{
}