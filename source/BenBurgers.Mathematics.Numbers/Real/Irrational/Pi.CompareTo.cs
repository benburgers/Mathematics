/*
 * Ben Burgers Mathematics
 * © 2022 Ben Burgers and contributors
 * Licensed under AGPL 3.0
 */

using BenBurgers.Mathematics.Numbers.Real.Rational.Integer;
using BenBurgers.Mathematics.Numbers.Real.Rational;
using BenBurgers.Mathematics.Numbers.Real.Rational.Integer.Natural;
using BenBurgers.Mathematics.Numbers.Real.Rational.Integer.Natural.Prime;

namespace BenBurgers.Mathematics.Numbers.Real.Irrational;

public readonly partial struct Pi
{
    /// <inheritdoc />
    public int CompareTo(byte other) => 3 < other ? -1 : 1;

    /// <inheritdoc />
    public int CompareTo(sbyte other) => 3 < other ? -1 : 1;

    /// <inheritdoc />
    public int CompareTo(ushort other) => 3U < other ? -1 : 1;

    /// <inheritdoc />
    public int CompareTo(short other) => 3 < other ? -1 : 1;

    /// <inheritdoc />
    public int CompareTo(uint other) => 3U < other ? -1 : 1;

    /// <inheritdoc />
    public int CompareTo(int other) => 3 < other ? -1 : 1;

    /// <inheritdoc />
    public int CompareTo(ulong other) => 3UL < other ? -1 : 1;

    /// <inheritdoc />
    public int CompareTo(long other) => 3L < other ? -1 : 1;

    /// <inheritdoc />
    public int CompareTo(float other) => PiFloat.CompareTo(other);

    /// <inheritdoc />
    public int CompareTo(double other) => PiDouble.CompareTo(other);

    /// <inheritdoc />
    public int CompareTo(decimal other) => PiDecimal.CompareTo(other);

    /// <inheritdoc/>
    /// <exception cref="NumberTypeNotSupportedException">
    /// A <see cref="NumberTypeNotSupportedException" /> is thrown if the object to compare is of an unsupported type.
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
            NaturalNumber natural => this.CompareTo(natural),
            IntegerNumber integer => this.CompareTo(integer),
            // TODO other types
            Pi => 0,
            _ => throw new NumberTypeNotSupportedException(obj.GetType())
        };
    }

    /// <inheritdoc/>
    public int CompareTo(Pi _) => 0; // Pi is always equal to Pi 😅

    /// <inheritdoc />
    public int CompareTo(INumber<Pi>? other)
    {
        if (other is null)
            return -1;
        return this.CompareTo((Pi)other);
    }

    /// <inheritdoc />
    public int CompareTo(IPrimeNumber? other)
    {
        if (other is null)
            return -1;
        if (!other.Sequence.IsSingle)
            return -1;
        return 3U < other.Sequence.StartNode.Value ? -1 : 1;
    }

    /// <inheritdoc />
    public int CompareTo(INaturalNumber? other)
    {
        if (other is null)
            return -1;
        if (!other.Sequence.IsSingle)
            return -1;
        return 3U < other.Sequence.StartNode.Value ? -1 : 1;
    }

    /// <inheritdoc />
    public int CompareTo(IIntegerNumber? other)
    {
        if (other is null)
            return -1;
        if (other.IsNegative)
            return 1;
        if (!other.Sequence.IsSingle)
            return -1;
        return 3U < other.Sequence.StartNode.Value ? -1 : 1;
    }

    /// <inheritdoc />
    public int CompareTo(IIrrationalNumber? other)
    {
        throw new NotImplementedException();
    }

    /// <inheritdoc />
    public int CompareTo(IRationalNumber? other)
    {
        throw new NotImplementedException();
    }
}