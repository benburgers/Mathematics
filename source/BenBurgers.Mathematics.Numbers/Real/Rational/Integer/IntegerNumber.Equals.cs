/*
 * Ben Burgers Mathematics
 * © 2022 Ben Burgers and contributors
 * Licensed under AGPL 3.0
 */

using BenBurgers.Mathematics.Numbers.Arithmetic;
using BenBurgers.Mathematics.Numbers.Arithmetic.Sequence;
using BenBurgers.Mathematics.Numbers.Real.Irrational;
using BenBurgers.Mathematics.Numbers.Real.Rational.Integer.Natural;
using BenBurgers.Mathematics.Numbers.Real.Rational.Integer.Natural.Prime;
using System.Diagnostics.CodeAnalysis;

namespace BenBurgers.Mathematics.Numbers.Real.Rational.Integer;

public readonly partial struct IntegerNumber
{
    /// <inheritdoc />
    public bool Equals(byte other)
    {
        if (!this.sequence.IsSingle)
            return false;
        return this.sequence.StartNode.Value.Equals(other);
    }

    /// <inheritdoc />
    public bool Equals(sbyte other)
    {
        if (!this.sequence.IsSingle)
            return false;
        return this.sequence.StartNode.Value.Equals(other);
    }

    /// <inheritdoc />
    public bool Equals(ushort other)
    {
        if (!this.sequence.IsSingle)
            return false;
        return this.sequence.StartNode.Value.Equals(other);
    }

    /// <inheritdoc />
    public bool Equals(short other)
    {
        if (!this.sequence.IsSingle)
            return false;
        return this.sequence.StartNode.Value.Equals(other);
    }

    /// <inheritdoc />
    public bool Equals(uint other)
    {
        if (!this.sequence.IsSingle)
            return false;
        return this.sequence.StartNode.Value.Equals(other);
    }

    /// <inheritdoc />
    public bool Equals(int other)
    {
        if (!this.sequence.IsSingle)
            return false;
        return this.sequence.StartNode.Value.Equals(other);
    }

    /// <inheritdoc />
    /// <exception cref="NumberBinaryConversionException">
    /// A <see cref="NumberBinaryConversionException" /> is thrown if the number could not be compared.
    /// </exception>
    public bool Equals(ulong other)
        => !this.IsNegative && SequenceArithmetic.IntegerEquals(this.sequence.StartNode, other);

    /// <inheritdoc />
    /// <exception cref="NumberBinaryConversionException">
    /// A <see cref="NumberBinaryConversionException" /> is thrown if the number could not be compared.
    /// </exception>
    public bool Equals(long other)
        => SequenceArithmetic.IntegerEquals(this.sequence.StartNode, this.IsNegative, other);

    /// <inheritdoc />
    public bool Equals(float other)
        => SequenceArithmetic.IntegerEquals(this.sequence.StartNode, this.IsNegative, other);

    /// <inheritdoc />
    public bool Equals(double other)
        => SequenceArithmetic.IntegerEquals(this.sequence.StartNode, this.IsNegative, other);

    /// <inheritdoc />
    public bool Equals(decimal other)
        => SequenceArithmetic.IntegerEquals(this.sequence.StartNode, this.isNegative, other);

    /// <inheritdoc/>
    /// <exception cref="ArithmeticTimeoutException">
    /// An <see cref="ArithmeticTimeoutException" /> is thrown if the comparison exceeded the timeout.
    /// </exception>
    public bool Equals(IPrimeNumber? other)
    {
        return other switch
        {
            null => false,
            IPrimeNumber number
                => SequenceArithmetic.IntegerEquals(
                    number.GetType(),
                    ArithmeticOptions.Default,
                    this.sequence.StartNode,
                    number.Sequence.StartNode,
                    this.isNegative,
                    number.IsNegative)
        };
    }

    /// <inheritdoc/>
    /// <exception cref="ArithmeticTimeoutException">
    /// An <see cref="ArithmeticTimeoutException" /> is thrown if the comparison exceeded the timeout.
    /// </exception>
    public bool Equals(INaturalNumber? other)
    {
        return other switch
        {
            null => false,
            INaturalNumber number
                => SequenceArithmetic.IntegerEquals(
                    number.GetType(),
                    ArithmeticOptions.Default,
                    this.sequence.StartNode,
                    number.Sequence.StartNode,
                    this.isNegative,
                    number.IsNegative)
        };
    }

    /// <inheritdoc />
    /// <exception cref="ArithmeticTimeoutException">
    /// An <see cref="ArithmeticTimeoutException" /> is thrown if the comparison exceeded the timeout.
    /// </exception>
    public bool Equals(IIntegerNumber? other)
    {
        return other switch
        {
            null => false,
            IIntegerNumber number
                => SequenceArithmetic.IntegerEquals(
                    number.GetType(),
                    ArithmeticOptions.Default,
                    this.sequence.StartNode,
                    number.Sequence.StartNode,
                    this.isNegative,
                    number.IsNegative)
        };
    }

    /// <inheritdoc/>
    public bool Equals(IRationalNumber? other)
    {
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public bool Equals(IIrrationalNumber? other)
    {
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    /// <exception cref="ArithmeticTimeoutException">
    /// An <see cref="ArithmeticTimeoutException" /> is thrown if a comparison exceeded a timeout.
    /// </exception>
    public override bool Equals([NotNullWhen(true)] object? obj)
    {
        return obj switch
        {
            null => false,
            byte uint8 => this.Equals(uint8),
            sbyte int8 => this.Equals(int8),
            ushort uint16 => this.Equals(uint16),
            short int16 => this.Equals(int16),
            uint uint32 => this.Equals(uint32),
            int int32 => this.Equals(int32),
            ulong uint64 => this.Equals(uint64),
            long int64 => this.Equals(int64),
            float single32 => this.Equals(single32),
            double double64 => this.Equals(double64),
            decimal decimal128 => this.Equals(decimal128),
            IPrimeNumber prime => this.Equals(prime),
            INaturalNumber natural => this.Equals(natural),
            IIntegerNumber integer => this.Equals(integer),
            Pi => false,
            _ => false
        };
    }
}