/*
 * Ben Burgers Mathematics
 * © 2022-2023 Ben Burgers and contributors
 * Licensed under AGPL 3.0
 */

using BenBurgers.Mathematics.Numbers.Real.Rational.Integer;

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
public partial struct Modulus<TDividend, TDivisor>
    : IModulus<TDividend, TDivisor>

    where TDividend : struct, IIntegerNumber<TDividend>
    where TDivisor : struct, IIntegerNumber<TDivisor>
{
    internal Modulus(TDividend dividend, TDivisor divisor)
    {
        this.Dividend = dividend;
        this.Divisor = divisor;
    }

    /// <inheritdoc/>
    public TDividend Dividend { get; init; }

    /// <inheritdoc/>
    public TDivisor Divisor { get; init; }

    /// <summary>
    /// Retuns the string representation of the modulus.
    /// </summary>
    /// <returns>
    /// The string representation of the modulus.
    /// </returns>
    public override string ToString()
    {
        return $"{this.Dividend} % {this.Divisor}";
    }
}