/*
 * Ben Burgers Mathematics
 * © 2022 Ben Burgers and contributors
 * Licensed under AGPL 3.0
 */

using BenBurgers.Mathematics.Numbers.Real.Rational.Integer.Natural;
using BenBurgers.Mathematics.Numbers.Real.Rational.Integer;
using System.Diagnostics.CodeAnalysis;

namespace BenBurgers.Mathematics.Numbers.Arithmetic.Moduli;

public readonly partial struct Modulus<TDividend, TDivisor>
    : IEquatable<Modulus<TDividend, TDivisor>>
{
    /// <summary>
    /// Determines whether the object is equivalent to this modulus.
    /// </summary>
    /// <param name="obj">
    /// The object to compare with.
    /// </param>
    /// <returns>
    /// A value that indicates whether the object is equivalent to this modulus.
    /// </returns>
    public override bool Equals([NotNullWhen(true)] object? obj)
    {
        return obj switch
        {
            null => false,
            byte number => this.CompareTo((NaturalNumber)number) == 0,
            sbyte number => this.CompareTo((IntegerNumber)number) == 0,
            ushort number => this.CompareTo((NaturalNumber)number) == 0,
            short number => this.CompareTo((IntegerNumber)number) == 0,
            uint number => this.CompareTo((NaturalNumber)number) == 0,
            int number => this.CompareTo((IntegerNumber)number) == 0,
            ulong number => this.CompareTo((NaturalNumber)number) == 0,
            long number => this.CompareTo((IntegerNumber)number) == 0,
            NaturalNumber naturalNumber => this.CompareTo(naturalNumber) == 0,
            IntegerNumber integerNumber => this.CompareTo(integerNumber) == 0,
            Modulus<TDividend, TDivisor> modulus => this.CompareTo(modulus) == 0,
            _ => false
        };
    }

    /// <inheritdoc/>
    public bool Equals(NaturalNumber other) => this.CompareTo(other) == 0;

    /// <inheritdoc/>
    public bool Equals(IntegerNumber other) => this.CompareTo(other) == 0;

    /// <inheritdoc/>
    public bool Equals(Modulus<TDividend, TDivisor> other) => this.CompareTo(other) == 0;

    /// <inheritdoc/>
    public override int GetHashCode()
    {
        return HashCode.Combine(this.Dividend.GetHashCode(), this.Divisor.GetHashCode());
    }
}