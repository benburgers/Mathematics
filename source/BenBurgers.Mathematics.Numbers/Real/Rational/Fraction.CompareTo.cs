/*
 * Ben Burgers Mathematics
 * © 2022-2023 Ben Burgers and contributors
 * Licensed under AGPL 3.0
 */

using BenBurgers.Mathematics.Numbers.Real.Irrational;
using BenBurgers.Mathematics.Numbers.Real.Rational.Integer;
using BenBurgers.Mathematics.Numbers.Real.Rational.Integer.Natural.Prime;
using BenBurgers.Mathematics.Numbers.Real.Rational.Integer.Natural;

namespace BenBurgers.Mathematics.Numbers.Real.Rational;

public readonly partial struct Fraction<TNumerator, TDenominator>
{
    /// <inheritdoc />
    public int CompareTo(object? obj)
    {
        return obj switch
        {
            null => -1,
            Fraction<TNumerator, TDenominator> fractionOther => this.CompareTo(fractionOther),
            IFraction fractionOther => this.CompareTo(fractionOther),
            _ => -1
        };
    }

    /// <inheritdoc />
    public int CompareTo(byte other)
    {
        throw new NotImplementedException();
    }

    /// <inheritdoc />
    public int CompareTo(sbyte other)
    {
        throw new NotImplementedException();
    }

    /// <inheritdoc />
    public int CompareTo(ushort other)
    {
        throw new NotImplementedException();
    }

    /// <inheritdoc />
    public int CompareTo(short other)
    {
        throw new NotImplementedException();
    }

    /// <inheritdoc />
    public int CompareTo(uint other)
    {
        throw new NotImplementedException();
    }

    /// <inheritdoc />
    public int CompareTo(int other)
    {
        throw new NotImplementedException();
    }

    /// <inheritdoc />
    public int CompareTo(ulong other)
    {
        throw new NotImplementedException();
    }

    /// <inheritdoc />
    public int CompareTo(long other)
    {
        throw new NotImplementedException();
    }

    /// <inheritdoc />
    public int CompareTo(float other)
    {
        throw new NotImplementedException();
    }

    /// <inheritdoc />
    public int CompareTo(double other)
    {
        throw new NotImplementedException();
    }

    /// <inheritdoc />
    public int CompareTo(decimal other)
    {
        throw new NotImplementedException();
    }

    /// <inheritdoc />
    public int CompareTo(IFraction? other)
    {
        throw new NotImplementedException();
    }

    /// <inheritdoc />
    public int CompareTo(Fraction<TNumerator, TDenominator> other)
    {
        throw new NotImplementedException();
    }

    /// <inheritdoc />
    public int CompareTo(IPrimeNumber? other)
    {
        throw new NotImplementedException();
    }

    /// <inheritdoc />
    public int CompareTo(INaturalNumber? other)
    {
        throw new NotImplementedException();
    }

    /// <inheritdoc />
    public int CompareTo(IIntegerNumber? other)
    {
        throw new NotImplementedException();
    }

    /// <inheritdoc />
    public int CompareTo(IRationalNumber? other)
    {
        throw new NotImplementedException();
    }

    /// <inheritdoc />
    public int CompareTo(IIrrationalNumber? other)
    {
        throw new NotImplementedException();
    }

    /// <inheritdoc />
    public int CompareTo(INumber<Fraction<TNumerator, TDenominator>>? other)
    {
        throw new NotImplementedException();
    }

    /// <inheritdoc />
    public int CompareTo(INumber<IFraction>? other)
    {
        throw new NotImplementedException();
    }
}