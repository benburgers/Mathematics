/*
 * Ben Burgers Mathematics
 * © 2022-2023 Ben Burgers and contributors
 * Licensed under AGPL 3.0
 */

using BenBurgers.Mathematics.Numbers.Arithmetic;
using BenBurgers.Mathematics.Numbers.Arithmetic.Sequence;
using BenBurgers.Mathematics.Numbers.Real.Irrational;
using BenBurgers.Mathematics.Numbers.Real.Rational.Integer.Natural.Prime;
using System.Diagnostics.CodeAnalysis;

namespace BenBurgers.Mathematics.Numbers.Real.Rational.Integer.Natural;

public readonly partial struct NaturalNumber
{
    /// <inheritdoc/>
    public bool Equals(byte other)
    {
        if (!this.sequence.IsSingle)
            return false;
        return this.sequence.StartNode.Value.Equals(other);
    }

    /// <inheritdoc/>
    public bool Equals(sbyte other)
    {
        if (other < 0)
            return false;
        if (!this.sequence.IsSingle)
            return false;
        return this.sequence.StartNode.Value.Equals((nuint)other);
    }

    /// <inheritdoc/>
    public bool Equals(ushort other)
    {
        if (!this.sequence.IsSingle)
            return false;
        return this.sequence.StartNode.Value.Equals(other);
    }

    /// <inheritdoc/>
    public bool Equals(short other)
    {
        if (other < 0)
            return false;
        if (!this.sequence.IsSingle)
            return false;
        return this.sequence.StartNode.Value.Equals((nuint)other);
    }

    /// <inheritdoc/>
    public bool Equals(uint other)
    {
        if (!this.sequence.IsSingle)
            return false;
        return this.sequence.StartNode.Value.Equals(other);
    }

    /// <inheritdoc/>
    public bool Equals(int other)
    {
        if (other < 0)
            return false;
        if (!this.sequence.IsSingle)
            return false;
        return this.sequence.StartNode.Value.Equals((nuint)other);
    }

    /// <inheritdoc/>
    /// <exception cref="NumberBinaryConversionException">
    /// A <see cref="NumberBinaryConversionException" /> is thrown if the number could not be compared.
    /// </exception>
    public bool Equals(ulong other)
        => SequenceArithmetic.IntegerEquals(this.sequence.StartNode, other);

    /// <inheritdoc/>
    /// <exception cref="NumberBinaryConversionException">
    /// A <see cref="NumberBinaryConversionException" /> is thrown if the number could not be compared.
    /// </exception>
    public bool Equals(long other)
        => SequenceArithmetic.IntegerEquals(this.sequence.StartNode, isNegative: false, other);

    /// <inheritdoc/>
    /// <exception cref="NumberBinaryConversionException">
    /// A <see cref="NumberBinaryConversionException" /> is thrown if the number could not be compared.
    /// </exception>
    public bool Equals(float other)
        => SequenceArithmetic.IntegerEquals(this.sequence.StartNode, isNegative: false, other);

    /// <inheritdoc/>
    /// <exception cref="NumberBinaryConversionException">
    /// A <see cref="NumberBinaryConversionException" /> is thrown if the number could not be compared.
    /// </exception>
    public bool Equals(double other)
        => SequenceArithmetic.IntegerEquals(this.sequence.StartNode, isNegative: false, other);

    /// <inheritdoc/>
    /// <exception cref="NumberBinaryConversionException">
    /// A <see cref="NumberBinaryConversionException" /> is thrown if the number could not be compared.
    /// </exception>
    public bool Equals(decimal other)
        => SequenceArithmetic.IntegerEquals(this.sequence.StartNode, isNegative: false, other);

    /// <inheritdoc/>
    public bool Equals([NotNullWhen(true)] IPrimeNumber? other)
    {
        return other switch
        {
            null => false,
            _ => SequenceArithmetic.IntegerEquals(
                    other.GetType(),
                    ArithmeticOptions.Default,
                    this.sequence.StartNode,
                    other.Sequence.StartNode)
        };
    }

    /// <inheritdoc/>
    public bool Equals([NotNullWhen(true)] INaturalNumber? other)
    {
        return other switch
        {
            null => false,
            _ => SequenceArithmetic.IntegerEquals(
                    other.GetType(),
                    ArithmeticOptions.Default,
                    this.sequence.StartNode,
                    other.Sequence.StartNode)
        };
    }

    /// <inheritdoc/>
    public bool Equals([NotNullWhen(true)] IIntegerNumber? other)
    {
        return other switch
        {
            null => false,
            IIntegerNumber number when number.IsNegative => false,
            IIntegerNumber number
                => SequenceArithmetic.IntegerEquals(
                    other.GetType(),
                    ArithmeticOptions.Default,
                    this.sequence.StartNode,
                    number.Sequence.StartNode)
        };
    }

    /// <inheritdoc/>
    public bool Equals([NotNullWhen(true)] IRationalNumber? other)
    {
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public bool Equals([NotNullWhen(true)] IIrrationalNumber? other)
    {
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    /// <exception cref="NumberTypeNotSupportedException">
    /// A <see cref="NumberTypeNotSupportedException" /> is thrown if the number that is being compared is not supported.
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
            IPrimeNumber primeNumber => this.Equals(primeNumber),
            INaturalNumber naturalNumber => this.Equals(naturalNumber),
            IIntegerNumber integerNumber => this.Equals(integerNumber),
            // TODO other number types
            Pi => false,
            _ => throw new NumberTypeNotSupportedException(obj.GetType())
        };
    }
}