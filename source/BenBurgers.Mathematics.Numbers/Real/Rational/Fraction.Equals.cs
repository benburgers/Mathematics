/*
 * Ben Burgers Mathematics
 * © 2022-2023 Ben Burgers and contributors
 * Licensed under AGPL 3.0
 */

using BenBurgers.Mathematics.Numbers.Real.Irrational;
using BenBurgers.Mathematics.Numbers.Real.Rational.Integer.Natural.Prime;
using BenBurgers.Mathematics.Numbers.Real.Rational.Integer.Natural;
using BenBurgers.Mathematics.Numbers.Real.Rational.Integer;
using System.Diagnostics.CodeAnalysis;

namespace BenBurgers.Mathematics.Numbers.Real.Rational;

public readonly partial struct Fraction<TNumerator, TDenominator>
{
    /// <inheritdoc />
    public bool Equals(byte other)
    {
        throw new NotImplementedException();
    }

    /// <inheritdoc />
    public bool Equals(sbyte other)
    {
        throw new NotImplementedException();
    }

    /// <inheritdoc />
    public bool Equals(ushort other)
    {
        throw new NotImplementedException();
    }

    /// <inheritdoc />
    public bool Equals(short other)
    {
        throw new NotImplementedException();
    }

    /// <inheritdoc />
    public bool Equals(uint other)
    {
        throw new NotImplementedException();
    }

    /// <inheritdoc />
    public bool Equals(int other)
    {
        throw new NotImplementedException();
    }

    /// <inheritdoc />
    public bool Equals(ulong other)
    {
        throw new NotImplementedException();
    }

    /// <inheritdoc />
    public bool Equals(long other)
    {
        throw new NotImplementedException();
    }

    /// <inheritdoc />
    public bool Equals(float other)
    {
        throw new NotImplementedException();
    }

    /// <inheritdoc />
    public bool Equals(double other)
    {
        throw new NotImplementedException();
    }

    /// <inheritdoc />
    public bool Equals(decimal other)
    {
        throw new NotImplementedException();
    }

    /// <inheritdoc />
    public bool Equals(Fraction<TNumerator, TDenominator> other)
        => this.Numerator.Equals(other.Numerator) && this.Denominator.Equals(other.Denominator); // TODO equality of evaluation?

    /// <inheritdoc />
    public override bool Equals([NotNullWhen(true)] object? obj)
    {
        return obj switch
        {
            null => false,
            Fraction<TNumerator, TDenominator> fractionOther => this.Equals(fractionOther),
            IFraction fractionOther => this.Equals(fractionOther),
            // TODO equality of evaluation?
            _ => false
        };
    }

    /// <inheritdoc />
    public bool Equals([NotNullWhen(true)] IFraction? other)
    {
        return other switch
        {
            null => false,
            Fraction<TNumerator, TDenominator> fractionOther => this.Equals(fractionOther),
            // TODO equality of evaluation?
            _ => false
        };
    }

    /// <inheritdoc />
    public bool Equals([NotNullWhen(true)] IPrimeNumber? other)
    {
        throw new NotImplementedException();
    }

    /// <inheritdoc />
    public bool Equals([NotNullWhen(true)] INaturalNumber? other)
    {
        throw new NotImplementedException();
    }

    /// <inheritdoc />
    public bool Equals([NotNullWhen(true)] IIntegerNumber? other)
    {
        throw new NotImplementedException();
    }

    /// <inheritdoc />
    public bool Equals([NotNullWhen(true)] IRationalNumber? other)
    {
        throw new NotImplementedException();
    }

    /// <inheritdoc />
    public bool Equals([NotNullWhen(true)] IIrrationalNumber? other)
    {
        throw new NotImplementedException();
    }
}