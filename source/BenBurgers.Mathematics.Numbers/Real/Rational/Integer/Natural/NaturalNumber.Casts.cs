/*
 * Ben Burgers Mathematics
 * © 2022 Ben Burgers and contributors
 * Licensed under AGPL 3.0
 */

using BenBurgers.Mathematics.Numbers.Arithmetic;
using BenBurgers.Mathematics.Numbers.Arithmetic.Sequence;
using BenBurgers.Mathematics.Numbers.Sequence;

namespace BenBurgers.Mathematics.Numbers.Real.Rational.Integer.Natural;

public partial struct NaturalNumber
{
    /// <summary>
    /// Casts a <see cref="NaturalNumber" /> <paramref name="number" /> to a <see cref="byte" />.
    /// </summary>
    /// <param name="number">
    /// The number to cast.
    /// </param>
    /// <exception cref="NumberTooLargeException">
    /// A <see cref="NumberTooLargeException" /> is thrown if the <paramref name="number" /> does not fit in a <see langword="byte" />.
    /// </exception>
    public static explicit operator byte(NaturalNumber number)
    {
        if (!number.sequence.IsSingle || number.sequence.StartNode.Value > byte.MaxValue)
            throw new NumberTooLargeException();
        return (byte)number.sequence.StartNode.Value;
    }

    /// <summary>
    /// Casts a <see cref="NaturalNumber" /> <paramref name="number" /> to a <see cref="sbyte" />.
    /// </summary>
    /// <param name="number">
    /// The number to cast.
    /// </param>
    /// <exception cref="NumberTooLargeException">
    /// A <see cref="NumberTooLargeException" /> is thrown if the <paramref name="number" /> does not fit in an <see langword="sbyte" />.
    /// </exception>
    public static explicit operator sbyte(NaturalNumber number)
    {
        if (!number.sequence.IsSingle || number.sequence.StartNode.Value > (nuint)sbyte.MaxValue)
            throw new NumberTooLargeException();
        return (sbyte)number.sequence.StartNode.Value;
    }

    /// <summary>
    /// Casts a <see cref="NaturalNumber" /> <paramref name="number" /> to a <see cref="short" />.
    /// </summary>
    /// <param name="number">
    /// The number to cast.
    /// </param>
    /// <exception cref="NumberTooLargeException">
    /// A <see cref="NumberTooLargeException" /> is thrown if the <paramref name="number" /> does not fit in an <see langword="short" />.
    /// </exception>
    public static explicit operator short(NaturalNumber number)
    {
        if (!number.sequence.IsSingle || number.sequence.StartNode.Value > (nuint)short.MaxValue)
            throw new NumberTooLargeException();
        return (short)number.sequence.StartNode.Value;
    }

    /// <summary>
    /// Casts a <see cref="NaturalNumber" /> <paramref name="number" /> to a <see cref="ushort" />.
    /// </summary>
    /// <param name="number">
    /// The number to cast.
    /// </param>
    /// <exception cref="NumberTooLargeException">
    /// A <see cref="NumberTooLargeException" /> is thrown if the <paramref name="number" /> does not fit in an <see langword="ushort" />.
    /// </exception>
    public static explicit operator ushort(NaturalNumber number)
    {
        if (!number.sequence.IsSingle || number.sequence.StartNode.Value > ushort.MaxValue)
            throw new NumberTooLargeException();
        return (ushort)number.sequence.StartNode.Value;
    }

    /// <summary>
    /// Casts a <see cref="NaturalNumber" /> <paramref name="number" /> to a <see cref="int" />.
    /// </summary>
    /// <param name="number">
    /// The number to cast.
    /// </param>
    /// <exception cref="NumberTooLargeException">
    /// A <see cref="NumberTooLargeException" /> is thrown if the <paramref name="number" /> does not fit in an <see langword="int" />.
    /// </exception>
    public static explicit operator int(NaturalNumber number)
    {
        if (!number.sequence.IsSingle || number.sequence.StartNode.Value > int.MaxValue)
            throw new NumberTooLargeException();
        return (int)number.sequence.StartNode.Value;
    }

    /// <summary>
    /// Casts a <see cref="NaturalNumber" /> <paramref name="number" /> to a <see cref="uint" />.
    /// </summary>
    /// <param name="number">
    /// The number to cast.
    /// </param>
    /// <exception cref="NumberTooLargeException">
    /// A <see cref="NumberTooLargeException" /> is thrown if the <paramref name="number" /> does not fit in an <see langword="uint" />.
    /// </exception>
    public static explicit operator uint(NaturalNumber number)
    {
        if (!number.sequence.IsSingle || number.sequence.StartNode.Value > uint.MaxValue)
            throw new NumberTooLargeException();
        return (uint)number.sequence.StartNode.Value;
    }

    /// <summary>
    /// Casts a <see cref="NaturalNumber" /> <paramref name="number" /> to a <see cref="long" />.
    /// </summary>
    /// <param name="number">
    /// The number to cast.
    /// </param>
    /// <exception cref="NumberTooLargeException">
    /// A <see cref="NumberTooLargeException" /> is thrown if the <paramref name="number" /> does not fit in an <see langword="long" />.
    /// </exception>
    public static unsafe explicit operator long(NaturalNumber number)
    {
        return sizeof(nuint) switch
        {
            sizeof(ulong)
                when !number.sequence.IsSingle
                    => throw new NumberTooLargeException(),
            sizeof(ulong)
                when number.sequence.IsSingle && number.sequence.StartNode.Value > long.MaxValue
                    => throw new NumberTooLargeException(),
            sizeof(ulong)
                when number.sequence.IsSingle && number.sequence.StartNode.Value <= long.MaxValue
                    => (long)number.sequence.StartNode.Value,
            sizeof(uint)
                when !number.sequence.IsSingle && number.sequence.StartNode.GetNext()!.Value.Next is not null
                    => throw new NumberTooLargeException(),
            sizeof(uint)
                when !number.sequence.IsSingle && number.sequence.StartNode.GetNext()!.Value.Next is null
                    => (long)number.sequence.StartNode.Value + (long)number.sequence.StartNode.GetNext()!.Value,
            sizeof(uint)
                when number.sequence.IsSingle
                    => (long)number.sequence.StartNode.Value,
            _ => throw new NumberTooLargeException()
        };
    }

    /// <summary>
    /// Casts a <see cref="NaturalNumber" /> <paramref name="number" /> to a <see cref="ulong" />.
    /// </summary>
    /// <param name="number">
    /// The number to cast.
    /// </param>
    /// <exception cref="NumberTooLargeException">
    /// A <see cref="NumberTooLargeException" /> is thrown if the <paramref name="number" /> does not fit in an <see langword="ulong" />.
    /// </exception>
    public static unsafe explicit operator ulong(NaturalNumber number)
    {
        return sizeof(nuint) switch
        {
            sizeof(ulong)
                when !number.sequence.IsSingle
                    => throw new NumberTooLargeException(),
            sizeof(ulong)
                when number.sequence.IsSingle
                    => number.sequence.StartNode.Value,
            sizeof(uint)
                when !number.sequence.IsSingle && number.sequence.StartNode.GetNext()!.Value.Next is not null
                    => throw new NumberTooLargeException(),
            sizeof(uint)
                when !number.sequence.IsSingle && number.sequence.StartNode.GetNext()!.Value.Next is null
                    => number.sequence.StartNode.Value + (ulong)number.sequence.StartNode.GetNext()!.Value,
            sizeof(uint)
                when number.sequence.IsSingle
                    => number.sequence.StartNode.Value,
            _ => throw new NumberTooLargeException()
        };
    }

    /// <summary>
    /// Casts a <see cref="NaturalNumber" /> <paramref name="number" /> to a <see cref="float" />.
    /// </summary>
    /// <param name="number">
    /// The number to cast.
    /// </param>
    /// <exception cref="NumberTooLargeException">
    /// A <see cref="NumberTooLargeException" /> is thrown if the number is less than <see cref="float.NegativeInfinity" /> or more than <see cref="float.PositiveInfinity" />.
    /// </exception>
    public static explicit operator float(NaturalNumber number)
        => SequenceArithmetic.ToSingleFrom(number.sequence.StartNode, isNegative: false);

    /// <summary>
    /// Casts a <see cref="NaturalNumber" /> <paramref name="number" /> to a <see cref="double" />.
    /// </summary>
    /// <param name="number">
    /// The number to cast.
    /// </param>
    /// <exception cref="NumberTooLargeException">
    /// A <see cref="NumberTooLargeException" /> is thrown if the number is less than <see cref="double.NegativeInfinity" /> or more than <see cref="double.PositiveInfinity" />.
    /// </exception>
    public static explicit operator double(NaturalNumber number)
        => SequenceArithmetic.ToDoubleFrom(number.sequence.StartNode, isNegative: false);

    /// <summary>
    /// Casts a <see cref="NaturalNumber" /> <paramref name="number" /> to a <see cref="decimal" />.
    /// </summary>
    /// <param name="number">
    /// The number to cast.
    /// </param>
    /// <exception cref="NumberTooLargeException">
    /// A <see cref="NumberTooLargeException" /> is thrown if the number is less than <see cref="decimal.MinValue" /> or more than <see cref="decimal.MaxValue" />.
    /// </exception>
    public static explicit operator decimal(NaturalNumber number)
        => SequenceArithmetic.ToDecimalFrom(number.sequence.StartNode, isNegative: false);

    /// <summary>
    /// Casts a <see cref="NaturalNumber" /> <paramref name="number" /> to a <see cref="string" /> representation.
    /// </summary>
    /// <param name="number">
    /// The number to cast.
    /// </param>
    public static explicit operator string(NaturalNumber number)
        => number.ToString();

    /// <summary>
    /// Casts a <see cref="byte" /> <paramref name="number" /> to a <see cref="NaturalNumber" />.
    /// </summary>
    /// <param name="number">
    /// The number to cast.
    /// </param>
    public static explicit operator NaturalNumber(byte number)
    {
        var nodePointer = NumberSequenceNode.AllocateAndInitialize(number);
        var sequence = new NumberSequence(nodePointer, nodePointer);
        return new(sequence);
    }

    /// <summary>
    /// Casts a <see cref="sbyte" /> <paramref name="number" /> to a <see cref="NaturalNumber" />.
    /// </summary>
    /// <param name="number">
    /// The number to cast.
    /// </param>
    /// <exception cref="NumberNotNaturalException">
    /// A <see cref="NumberNotNaturalException" /> is thrown if <paramref name="number" /> is not a natural number.
    /// </exception>
    public static explicit operator NaturalNumber(sbyte number)
    {
        if (number < 0)
            throw new NumberNotNaturalException();
        var nodePointer = NumberSequenceNode.AllocateAndInitialize((byte)number);
        var sequence = new NumberSequence(nodePointer, nodePointer);
        return new(sequence);
    }

    /// <summary>
    /// Casts a <see cref="short" /> <paramref name="number" /> to a <see cref="NaturalNumber" />.
    /// </summary>
    /// <param name="number">
    /// The number to cast.
    /// </param>
    /// <exception cref="NumberNotNaturalException">
    /// A <see cref="NumberNotNaturalException" /> is thrown if the <paramref name="number" /> is not a natural number.
    /// </exception>
    public static explicit operator NaturalNumber(short number)
    {
        if (number < 0)
            throw new NumberNotNaturalException();
        var nodePointer = NumberSequenceNode.AllocateAndInitialize((ushort)number);
        var sequence = new NumberSequence(nodePointer, nodePointer);
        return new(sequence);
    }

    /// <summary>
    /// Casts a <see cref="ushort" /> <paramref name="number" /> to a <see cref="NaturalNumber" />.
    /// </summary>
    /// <param name="number">
    /// The number to cast.
    /// </param>
    public static explicit operator NaturalNumber(ushort number)
    {
        var nodePointer = NumberSequenceNode.AllocateAndInitialize(number);
        var sequence = new NumberSequence(nodePointer, nodePointer);
        return new(sequence);
    }

    /// <summary>
    /// Casts a <see cref="int" /> <paramref name="number" /> to a <see cref="NaturalNumber" />.
    /// </summary>
    /// <param name="number">
    /// The number to cast.
    /// </param>
    /// <exception cref="NumberNotNaturalException">
    /// A <see cref="NumberNotNaturalException" /> is thrown if the <paramref name="number" /> is not a natural number.
    /// </exception>
    public static explicit operator NaturalNumber(int number)
    {
        if (number < 0)
            throw new NumberNotNaturalException();
        var nodePointer = NumberSequenceNode.AllocateAndInitialize((uint)number);
        var sequence = new NumberSequence(nodePointer, nodePointer);
        return new(sequence);
    }

    /// <summary>
    /// Casts a <see cref="uint" /> <paramref name="number" /> to a <see cref="NaturalNumber" />.
    /// </summary>
    /// <param name="number">
    /// The number to cast.
    /// </param>
    public static explicit operator NaturalNumber(uint number)
    {
        var nodePointer = NumberSequenceNode.AllocateAndInitialize(number);
        var sequence = new NumberSequence(nodePointer, nodePointer);
        return new(sequence);
    }

    /// <summary>
    /// Casts a <see cref="long" /> <paramref name="number" /> to a <see cref="NaturalNumber" />.
    /// </summary>
    /// <param name="number">
    /// The number to cast.
    /// </param>
    /// <exception cref="NumberNotNaturalException">
    /// A <see cref="NumberNotNaturalException" /> is thrown if the <paramref name="number" /> is not a natural number.
    /// </exception>
    /// <exception cref="NumberBinaryConversionException">
    /// A <see cref="NumberBinaryConversionException" /> is thrown if the <paramref name="number" /> could not be converted.
    /// </exception>
    public static explicit operator NaturalNumber(long number)
    {
        if (number < 0L)
            throw new NumberNotNaturalException();
        return new(SequenceArithmetic.ToIntegerNumberFrom(number).sequence);
    }

    /// <summary>
    /// Casts a <see cref="ulong" /> <paramref name="number" /> to a <see cref="NaturalNumber" />.
    /// </summary>
    /// <param name="number">
    /// The number to cast.
    /// </param>
    /// <exception cref="NumberBinaryConversionException">
    /// A <see cref="NumberBinaryConversionException" /> is thrown if the number could not be converted.
    /// </exception>
    public static explicit operator NaturalNumber(ulong number)
        => new(SequenceArithmetic.ToIntegerNumberFrom(number, false).sequence);

    /// <summary>
    /// Casts a <see cref="float" /> <paramref name="number" /> to a <see cref="NaturalNumber" />.
    /// </summary>
    /// <param name="number">
    /// The number to cast.
    /// </param>
    /// <exception cref="NumberNotNaturalException">
    /// A <see cref="NumberNotNaturalException" /> is thrown if <paramref name="number" /> is not a natural number.
    /// </exception>
    /// <exception cref="NumberNotIntegerException">
    /// A <see cref="NumberNotIntegerException" /> is thrown if <paramref name="number" /> is not an integer number.
    /// </exception>
    /// <exception cref="NumberTooLargeException">
    /// A <see cref="NumberTooLargeException" /> is thrown if <paramref name="number" /> has an infinite value.
    /// </exception>
    /// <exception cref="NotSupportedException">
    /// A <see cref="NotSupportedException" /> is thrown if the number is larger than the system-specific integer number.
    /// </exception>
    public static explicit operator NaturalNumber(float number)
    {
        if (number < 0.0F)
            throw new NumberNotNaturalException();
        return new(SequenceArithmetic.ToIntegerNumberFrom(number).sequence);
    }

    /// <summary>
    /// Casts a <see cref="double" /> <paramref name="number" /> to a <see cref="NaturalNumber" />.
    /// </summary>
    /// <param name="number">
    /// The number to cast.
    /// </param>
    /// <exception cref="NumberNotNaturalException">
    /// A <see cref="NumberNotNaturalException" /> is thrown if <paramref name="number" /> is not a natural number.
    /// </exception>
    /// <exception cref="NumberNotIntegerException">
    /// A <see cref="NumberNotIntegerException" /> is thrown if <paramref name="number" /> is not an integer number.
    /// </exception>
    /// <exception cref="NumberTooLargeException">
    /// A <see cref="NumberTooLargeException" /> is thrown if <paramref name="number" /> has an infinite value.
    /// </exception>
    /// <exception cref="NotSupportedException">
    /// A <see cref="NotSupportedException" /> is thrown if the number is larger than the system-specific integer number.
    /// </exception>
    public static explicit operator NaturalNumber(double number)
    {
        if (number < 0.0D)
            throw new NumberNotNaturalException();
        return new(SequenceArithmetic.ToIntegerNumberFrom(number).sequence);
    }

    /// <summary>
    /// Casts a <see cref="decimal" /> <paramref name="number" /> to a <see cref="NaturalNumber" />.
    /// </summary>
    /// <param name="number">
    /// The number to cast.
    /// </param>
    /// <exception cref="NumberNotNaturalException">
    /// A <see cref="NumberNotNaturalException" /> is thrown if <paramref name="number" /> is not a natural number.
    /// </exception>
    /// <exception cref="NumberNotIntegerException">
    /// A <see cref="NumberNotIntegerException" /> is thrown if <paramref name="number" /> is not an integer number.
    /// </exception>
    /// <exception cref="NumberTooLargeException">
    /// A <see cref="NumberTooLargeException" /> is thrown if <paramref name="number" /> has an infinite value.
    /// </exception>
    /// <exception cref="NotSupportedException">
    /// A <see cref="NotSupportedException" /> is thrown if the number is larger than the system-specific integer number.
    /// </exception>
    public static explicit operator NaturalNumber(decimal number)
    {
        if (number < 0.0M)
            throw new NumberNotNaturalException();
        return new(SequenceArithmetic.ToIntegerNumberFrom(number).sequence);
    }

    /// <summary>
    /// Casts a <see cref="string" /> <paramref name="number" /> to a <see cref="NaturalNumber" />.
    /// </summary>
    /// <param name="number">
    /// The number to cast.
    /// </param>
    /// <exception cref="ArithmeticTimeoutException">
    /// An <see cref="ArithmeticTimeoutException" /> is thrown if the operation exceeded the timeout.
    /// </exception>
    public static explicit operator NaturalNumber(string number)
        => Parse(number, ArithmeticOptions.Default);

    /// <summary>
    /// Casts a <see cref="IntegerNumber" /> <paramref name="integer" /> to a <see cref="NaturalNumber" />.
    /// </summary>
    /// <param name="integer">
    /// The <see cref="IntegerNumber" /> to cast.
    /// </param>
    public static explicit operator NaturalNumber(IntegerNumber integer)
    {
        if (integer.IsNegative)
            throw new NumberNegativeException();
        return new NaturalNumber(integer.sequence);
    }

    /// <summary>
    /// Casts a <see cref="IntegerNumber" /> <paramref name="natural" /> to an <see cref="IntegerNumber" />.
    /// </summary>
    /// <param name="natural">
    /// The <see cref="NaturalNumber" /> to cast.
    /// </param>
    public static explicit operator IntegerNumber(NaturalNumber natural)
        => new(natural.sequence, false);
}