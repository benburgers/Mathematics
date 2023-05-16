/*
 * Ben Burgers Mathematics
 * © 2022-2023 Ben Burgers and contributors
 * Licensed under AGPL 3.0
 */

using BenBurgers.Mathematics.Numbers.Arithmetics;
using BenBurgers.Mathematics.Numbers.Real.Rational.Integer;
using BenBurgers.Mathematics.Numbers.Real.Rational.Integer.Natural;

namespace BenBurgers.Mathematics.Numbers.Arithmetic.Moduli;

/// <summary>
/// Represents a modulo calculation.
/// </summary>
/// <typeparam name="TDividend">
/// The type of number of the dividend.
/// </typeparam>
/// <typeparam name="TDivisor">
/// The type of number of the divisor.
/// </typeparam>
public interface IModulus<TDividend, TDivisor>
    : IArithmeticOperation<ArithmeticOptions>,
    IComparable<NaturalNumber>,
    IComparable<IntegerNumber>,
    IEquatable<NaturalNumber>,
    IEquatable<IntegerNumber>
    where TDividend : INumber<TDividend>
    where TDivisor : INumber<TDivisor>
{
    /// <summary>
    /// Gets the dividend number.
    /// </summary>
    TDividend Dividend { get; }

    /// <summary>
    /// Gets the divisor number.
    /// </summary>
    TDivisor Divisor { get; }
}