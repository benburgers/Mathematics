/*
 * Ben Burgers Mathematics
 * © 2022 Ben Burgers and contributors
 * Licensed under AGPL 3.0
 */

using BenBurgers.Mathematics.Numbers.Real.Rational.Integer.Natural.Prime;
using BenBurgers.Mathematics.Numbers.Real.Rational.Integer.Natural;
using BenBurgers.Mathematics.Numbers.Real.Irrational;
using BenBurgers.Mathematics.Numbers.Arithmetic.Sequence;

namespace BenBurgers.Mathematics.Numbers.Real.Rational.Integer;

public readonly partial struct IntegerNumber
{
    /// <inheritdoc/>
    public int CompareTo(object? obj)
    {
        return obj switch
        {
            null => -1,
            PrimeNumber prime => this.CompareTo((IIntegerNumber)prime),
            NaturalNumber natural => this.CompareTo((IIntegerNumber)natural),
            IntegerNumber integer => this.CompareTo((IIntegerNumber)integer),
            _ => -1
        };
    }

    /// <inheritdoc/>
    public int CompareTo(byte other)
    {
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public int CompareTo(sbyte other)
    {
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public int CompareTo(ushort other)
    {
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public int CompareTo(short other)
    {
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public int CompareTo(uint other)
    {
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public int CompareTo(int other)
    {
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public int CompareTo(ulong other)
    {
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
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

    /// <inheritdoc/>
    public int CompareTo(IPrimeNumber? other)
    {
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public int CompareTo(INaturalNumber? other)
    {
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public int CompareTo(IIntegerNumber<IntegerNumber>? other)
    {
        if (other is null)
            return -1;
        return SequenceArithmetic.IntegerCompare(this.sequence.StartNode, this.IsNegative, other.Sequence.StartNode, other.IsNegative);
    }

    /// <inheritdoc/>
    /// <exception cref="NumberTypeNotSupportedException">
    /// A <see cref="NumberTypeNotSupportedException" /> is thrown if the number type is not supported.
    /// </exception>
    public int CompareTo(IIntegerNumber? other)
    {
        if (other is null)
            return -1;
        return SequenceArithmetic.IntegerCompare(this.sequence.StartNode, this.IsNegative, other.Sequence.StartNode, other.IsNegative);
    }

    /// <inheritdoc/>
    public int CompareTo(IRationalNumber? other)
    {
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public int CompareTo(IIrrationalNumber? other)
    {
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public int CompareTo(INumber<IntegerNumber>? other)
    {
        if (other == null)
            return -1;
        return this.CompareTo((IntegerNumber)other);
    }
}
