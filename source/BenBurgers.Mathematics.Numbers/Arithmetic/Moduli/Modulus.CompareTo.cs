/*
 * Ben Burgers Mathematics
 * © 2022 Ben Burgers and contributors
 * Licensed under AGPL 3.0
 */

using BenBurgers.Mathematics.Numbers.Real.Rational.Integer.Natural;
using BenBurgers.Mathematics.Numbers.Real.Rational.Integer;

namespace BenBurgers.Mathematics.Numbers.Arithmetic.Moduli;

public readonly partial struct Modulus<TDividend, TDivisor>
    : IComparable<Modulus<TDividend, TDivisor>>
{
    /// <inheritdoc/>
    public int CompareTo(NaturalNumber other)
    {
        var result = this.Evaluate<NaturalNumber>(ArithmeticOptions.Default);
        return result.CompareTo(other);
    }

    /// <inheritdoc/>
    public int CompareTo(IntegerNumber other)
    {
        var result = this.Evaluate<IntegerNumber>(ArithmeticOptions.Default);
        return result.CompareTo(other);
    }

    /// <inheritdoc/>
    public int CompareTo(Modulus<TDividend, TDivisor> other)
    {
        var resultThis = this.Evaluate<TDividend>(ArithmeticOptions.Default);
        var resultOther = other.Evaluate<TDividend>(ArithmeticOptions.Default);
        return resultThis.CompareTo(resultOther);
    }
}