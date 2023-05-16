/*
 * Ben Burgers Mathematics
 * © 2022-2023 Ben Burgers and contributors
 * Licensed under AGPL 3.0
 */

using BenBurgers.Mathematics.Numbers.Arithmetic.Sequence;
using BenBurgers.Mathematics.Numbers.Real.Irrational;

namespace BenBurgers.Mathematics.Numbers.Real.Rational.Integer.Natural.Prime;

public readonly partial struct PrimeNumber
{
    /// <inheritdoc />
    public int CompareTo(byte other)
    {
        if (!this.sequence.IsSingle)
            return 1;
        return this.sequence.StartNode.Value.CompareTo(other);
    }

    /// <inheritdoc />
    public int CompareTo(sbyte other)
    {
        if (!this.sequence.IsSingle)
            return 1;
        if (other < 0)
            return 1;
        return this.sequence.StartNode.Value.CompareTo(other);
    }

    /// <inheritdoc />
    public int CompareTo(ushort other)
    {
        if (!this.sequence.IsSingle)
            return 1;
        return this.sequence.StartNode.Value.CompareTo(other);
    }

    /// <inheritdoc />
    public int CompareTo(short other)
    {
        if (!this.sequence.IsSingle)
            return 1;
        if (other < 0)
            return 1;
        return this.sequence.StartNode.Value.CompareTo((nuint)other);
    }

    /// <inheritdoc />
    public int CompareTo(uint other)
    {
        if (!this.sequence.IsSingle)
            return 1;
        return this.sequence.StartNode.Value.CompareTo(other);
    }

    /// <inheritdoc />
    public int CompareTo(int other)
    {
        if (!this.sequence.IsSingle)
            return 1;
        if (other < 0)
            return 1;
        return this.sequence.StartNode.Value.CompareTo((nuint)other);
    }

    /// <inheritdoc />
    public int CompareTo(ulong other)
    {
        if (!this.sequence.IsSingle)
            return 1;
        return this.sequence.StartNode.Value.CompareTo(other);
    }

    /// <inheritdoc />
    public int CompareTo(long other)
    {
        if (!this.sequence.IsSingle)
            return 1;
        if (other < 0L)
            return 1;
        return this.sequence.StartNode.Value.CompareTo((nuint)other);
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
    public int CompareTo(IPrimeNumber? other)
    {
        if (other is null)
            return -1;
        return SequenceArithmetic.IntegerCompare(this.sequence.StartNode, this.IsNegative, other.Sequence.StartNode, other.IsNegative);
    }

    /// <inheritdoc />
    public int CompareTo(INaturalNumber? other)
    {
        if (other is null)
            return -1;
        return SequenceArithmetic.IntegerCompare(this.sequence.StartNode, this.IsNegative, other.Sequence.StartNode, other.IsNegative);
    }

    /// <inheritdoc />
    public int CompareTo(IIntegerNumber? other)
    {
        if (other is null)
            return -1;
        return SequenceArithmetic.IntegerCompare(this.sequence.StartNode, this.IsNegative, other.Sequence.StartNode, other.IsNegative);
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
    /// <exception cref="NumberTypeNotSupportedException">
    /// A <see cref="NumberTypeNotSupportedException" /> is thrown if the number type is not supported.
    /// </exception>
    public int CompareTo(object? obj)
    {
        return obj switch
        {
            null => -1,
            byte uint8 => this.CompareTo(uint8),
            sbyte int8 => this.CompareTo(int8),
            ushort uint16 => this.CompareTo(uint16),
            short int16 => this.CompareTo(int16),
            uint uint32 => this.CompareTo(uint32),
            int int32 => this.CompareTo(int32),
            ulong uint64 => this.CompareTo(uint64),
            long int64 => this.CompareTo(int64),
            float float32 => this.CompareTo(float32),
            double double64 => this.CompareTo(double64),
            decimal decimal128 => this.CompareTo(decimal128),
            IPrimeNumber prime => this.CompareTo(prime),
            INaturalNumber natural => this.CompareTo(natural),
            IIntegerNumber integer => this.CompareTo(integer),
            // TODO other number types
            _ => throw new NumberTypeNotSupportedException(obj.GetType())
        };
    }
}