/*
 * Ben Burgers Mathematics
 * © 2022 Ben Burgers and contributors
 * Licensed under AGPL 3.0
 */

using BenBurgers.Mathematics.Numbers.Arithmetic.Sequence;
using BenBurgers.Mathematics.Numbers.Sequence;

namespace BenBurgers.Mathematics.Numbers.Real.Rational.Integer;

public partial struct IntegerNumber
{
    /// <summary>
    /// Casts a <see cref="byte" /> <paramref name="value" /> to an <see cref="IntegerNumber" />.
    /// </summary>
    /// <param name="value">
    /// The value to cast.
    /// </param>
    public static unsafe explicit operator IntegerNumber(byte value)
    {
        var nodePointer = NumberSequenceNode.AllocateAndInitialize(value);
        var numberSequence = new NumberSequence(nodePointer, nodePointer);

        return new(numberSequence, isNegative: false);
    }

    /// <summary>
    /// Casts a <see cref="sbyte" /> <paramref name="value" /> to an <see cref="IntegerNumber" />.
    /// </summary>
    /// <param name="value">
    /// The value to cast.
    /// </param>
    public static explicit operator IntegerNumber(sbyte value)
    {
        var isNegative = value < 0;
        var nonNegative = isNegative ? -value : value;
        var nodePointer = NumberSequenceNode.AllocateAndInitialize((byte)nonNegative);
        var sequence = new NumberSequence(nodePointer, nodePointer);

        return new(sequence, isNegative);
    }

    /// <summary>
    /// Casts a <see cref="short" /> <paramref name="value" /> to an <see cref="IntegerNumber" />.
    /// </summary>
    /// <param name="value">
    /// The value to cast.
    /// </param>
    public static explicit operator IntegerNumber(short value)
    {
        var isNegative = value < 0;
        var nonNegative = isNegative ? -value : value;
        var nodePointer = NumberSequenceNode.AllocateAndInitialize((ushort)nonNegative);
        var sequence = new NumberSequence(nodePointer, nodePointer);

        return new(sequence, isNegative);
    }

    /// <summary>
    /// Casts a <see cref="ushort" /> <paramref name="value" /> to an <see cref="IntegerNumber" />.
    /// </summary>
    /// <param name="value">
    /// The value to cast.
    /// </param>
    public static explicit operator IntegerNumber(ushort value)
    {
        var nodePointer = NumberSequenceNode.AllocateAndInitialize(value);
        var sequence = new NumberSequence(nodePointer, nodePointer);

        return new(sequence, isNegative: false);
    }

    /// <summary>
    /// Casts a <see cref="int" /> <paramref name="value" /> to an <see cref="IntegerNumber" />.
    /// </summary>
    /// <param name="value">
    /// The value to cast.
    /// </param>
    public static explicit operator IntegerNumber(int value)
    {
        var isNegative = value < 0;
        var nonNegative = isNegative ? -value : value;
        var nodePointer = NumberSequenceNode.AllocateAndInitialize((uint)nonNegative);
        var sequence = new NumberSequence(nodePointer, nodePointer);

        return new(sequence, isNegative);
    }

    /// <summary>
    /// Casts a <see cref="uint" /> <paramref name="value" /> to an <see cref="IntegerNumber" />.
    /// </summary>
    /// <param name="value">
    /// The value to cast.
    /// </param>
    public static explicit operator IntegerNumber(uint value)
    {
        var nodePointer = NumberSequenceNode.AllocateAndInitialize(value);
        var sequence = new NumberSequence(nodePointer, nodePointer);

        return new(sequence, isNegative: false);
    }

    /// <summary>
    /// Casts a <see cref="long" /> <paramref name="number" /> to an <see cref="IntegerNumber" />.
    /// </summary>
    /// <param name="number">
    /// The value to cast.
    /// </param>
    /// <exception cref="NumberBinaryConversionException">
    /// A <see cref="NumberBinaryConversionException" /> is thrown if <paramref name="number" /> could not be converted.
    /// </exception>
    public unsafe static explicit operator IntegerNumber(long number)
        => SequenceArithmetic.ToIntegerNumberFrom(number);

    /// <summary>
    /// Casts a <see cref="ulong" /> <paramref name="number" /> to an <see cref="IntegerNumber" />.
    /// </summary>
    /// <param name="number">
    /// The value to cast.
    /// </param>
    /// <exception cref="NumberBinaryConversionException">
    /// A <see cref="NumberBinaryConversionException" /> is thrown if <paramref name="number" /> could not be converted.
    /// </exception>
    public static explicit operator IntegerNumber(ulong number)
        => SequenceArithmetic.ToIntegerNumberFrom(number, false);

    /// <summary>
    /// Casts a <see cref="float" /> <paramref name="number" /> to an <see cref="IntegerNumber" />.
    /// </summary>
    /// <param name="number">
    /// The number to cast.
    /// </param>
    /// <exception cref="NumberNotIntegerException">
    /// A <see cref="NumberNotIntegerException" /> is thrown if <paramref name="number" /> is not an integer.
    /// </exception>
    /// <exception cref="NumberTooLargeException">
    /// A <see cref="NumberTooLargeException" /> is thrown if <paramref name="number" /> has an infinite value.
    /// </exception>
    /// <exception cref="NotSupportedException">
    /// A <see cref="NotSupportedException" /> is thrown if the number is larger than the system-specific integer number.
    /// </exception>
    public unsafe static explicit operator IntegerNumber(float number)
        => SequenceArithmetic.ToIntegerNumberFrom(number);

    /// <summary>
    /// Casts a <see cref="double" /> <paramref name="number" /> to an <see cref="IntegerNumber" />.
    /// </summary>
    /// <param name="number">
    /// The value to cast.
    /// </param>
    /// <exception cref="NumberNotIntegerException">
    /// A <see cref="NumberNotIntegerException" /> is thrown if <paramref name="number" /> is not an integer.
    /// </exception>
    /// <exception cref="NumberTooLargeException">
    /// A <see cref="NumberTooLargeException" /> is thrown if <paramref name="number" /> has an infinite value.
    /// </exception>
    public static explicit operator IntegerNumber(double number)
        => SequenceArithmetic.ToIntegerNumberFrom(number);

    /// <summary>
    /// Casts a <see cref="decimal" /> <paramref name="number" /> to an <see cref="IntegerNumber" />.
    /// </summary>
    /// <param name="number">
    /// The value to cast.
    /// </param>
    /// <exception cref="NumberNotIntegerException">
    /// A <see cref="NumberNotIntegerException" /> is thrown if <paramref name="number" /> is not an integer.
    /// </exception>
    /// <exception cref="NumberTooLargeException">
    /// A <see cref="NumberTooLargeException" /> is thrown if <paramref name="number" /> contains the minimum or maximum <see cref="decimal" /> value.
    /// </exception>
    public unsafe static explicit operator IntegerNumber(decimal number)
        => SequenceArithmetic.ToIntegerNumberFrom(number);

    /// <summary>
    /// Casts an <see cref="IntegerNumber" /> to a <see cref="byte" />.
    /// </summary>
    /// <param name="number">
    /// The number to cast.
    /// </param>
    /// <exception cref="NumberNegativeException">
    /// A <see cref="NumberNegativeException" /> is thrown if the <paramref name="number" /> has a negative sign.
    /// </exception>
    /// <exception cref="NumberTooLargeException">
    /// A <see cref="NumberTooLargeException" /> is thrown if the <paramref name="number" /> is too large to fit in a <see cref="byte" />.
    /// </exception>
    public static explicit operator byte(IntegerNumber number)
    {
        if (number.IsNegative)
            throw new NumberNegativeException();
        if (number.sequence.StartNode.Value > byte.MaxValue
            || !number.sequence.IsSingle)
            throw new NumberTooLargeException();
        return (byte)number.sequence.StartNode.Value;
    }

    /// <summary>
    /// Casts an <see cref="IntegerNumber" /> to a <see cref="sbyte" />.
    /// </summary>
    /// <param name="number">
    /// The number to cast.
    /// </param>
    /// <exception cref="NumberTooLargeException">
    /// A <see cref="NumberTooLargeException" /> is thrown if the <paramref name="number" /> is too large to fit in a <see cref="sbyte" />.
    /// </exception>
    public static explicit operator sbyte(IntegerNumber number)
    {
        if (number.sequence.StartNode.Value > (nuint)sbyte.MaxValue
            || !number.sequence.IsSingle)
            throw new NumberTooLargeException();
        return number.IsNegative
            ? (sbyte)-(sbyte)number.sequence.StartNode.Value
            : (sbyte)number.sequence.StartNode.Value;
    }

    /// <summary>
    /// Casts an <see cref="IntegerNumber" /> to a <see cref="short" />.
    /// </summary>
    /// <param name="number">
    /// The number to cast.
    /// </param>
    /// <exception cref="NumberTooLargeException">
    /// A <see cref="NumberTooLargeException" /> is thrown if the <paramref name="number" /> is too large to fit in a <see cref="short" />.
    /// </exception>
    public static explicit operator short(IntegerNumber number)
    {
        if (number.sequence.StartNode.Value > (nuint)short.MaxValue
            || !number.sequence.IsSingle)
            throw new NumberTooLargeException();
        return number.IsNegative
            ? (short)-(short)number.sequence.StartNode.Value
            : (short)number.sequence.StartNode.Value;
    }

    /// <summary>
    /// Casts an <see cref="IntegerNumber" /> to a <see cref="ushort" />.
    /// </summary>
    /// <param name="number">
    /// The number to cast.
    /// </param>
    /// <exception cref="NumberNegativeException">
    /// A <see cref="NumberNegativeException" /> is thrown if the <paramref name="number" /> has a negative sign.
    /// </exception>
    /// <exception cref="NumberTooLargeException">
    /// A <see cref="NumberTooLargeException" /> is thrown if the <paramref name="number" /> is too large to fit in a <see cref="ushort" />.
    /// </exception>
    public static explicit operator ushort(IntegerNumber number)
    {
        if (number.IsNegative)
            throw new NumberNegativeException();
        if (number.sequence.StartNode.Value > ushort.MaxValue
            || !number.sequence.IsSingle)
            throw new NumberTooLargeException();
        return (ushort)number.sequence.StartNode.Value;
    }

    /// <summary>
    /// Casts an <see cref="IntegerNumber" /> to an <see cref="int" />.
    /// </summary>
    /// <param name="number">
    /// The number to cast.
    /// </param>
    /// <exception cref="NumberTooLargeException">
    /// A <see cref="NumberTooLargeException" /> is thrown if the <paramref name="number" /> is too large to fit in a <see cref="int" />.
    /// </exception>
    public static explicit operator int(IntegerNumber number)
    {
        if (number.sequence.StartNode.Value > int.MaxValue
            || !number.sequence.IsSingle)
            throw new NumberTooLargeException();
        return number.IsNegative
            ? -(int)number.sequence.StartNode.Value
            : (int)number.sequence.StartNode.Value;
    }

    /// <summary>
    /// Casts an <see cref="IntegerNumber" /> to a <see cref="uint" />.
    /// </summary>
    /// <param name="number">
    /// The number to cast.
    /// </param>
    /// <returns>
    /// A <see cref="uint" /> that represents the <paramref name="number" />.
    /// </returns>
    /// <exception cref="NumberNegativeException">
    /// A <see cref="NumberNegativeException" /> is thrown if the <paramref name="number" /> has a negative sign.
    /// </exception>
    /// <exception cref="NumberTooLargeException">
    /// A <see cref="NumberTooLargeException" /> is thrown if the <paramref name="number" /> is too large to fit in a <see cref="uint" />.
    /// </exception>
    public static explicit operator uint(IntegerNumber number)
    {
        if (number.IsNegative)
            throw new NumberNegativeException();
        if (number.sequence.StartNode.Value > uint.MaxValue
            || !number.sequence.IsSingle)
            throw new NumberTooLargeException();
        return (uint)number.sequence.StartNode.Value;
    }

    /// <summary>
    /// Casts an <see cref="IntegerNumber" /> to a <see cref="long" />.
    /// </summary>
    /// <param name="number">
    /// The number to cast.
    /// </param>
    /// <returns>
    /// A <see cref="long" /> that represents the <paramref name="number" />.
    /// </returns>
    /// <exception cref="NumberBinaryConversionException">
    /// A <see cref="NumberBinaryConversionException" /> is thrown if the binary conversion of the <paramref name="number" /> failed.
    /// </exception>
    /// <exception cref="NumberTooLargeException">
    /// A <see cref="NumberTooLargeException" /> is thrown if the <paramref name="number" /> is too large.
    /// </exception>
    public static unsafe explicit operator long(IntegerNumber number)
    {
        return sizeof(nuint) switch
        {
            sizeof(ulong)
                when number.sequence.StartNode.Value > long.MaxValue
                || !number.sequence.IsSingle
                    => throw new NumberTooLargeException(),
            sizeof(ulong)
                when number.IsNegative
                    => -(long)number.sequence.StartNode.Value,
            sizeof(ulong)
                when !number.IsNegative
                    => (long)number.sequence.StartNode.Value,
            sizeof(uint)
                when !number.sequence.IsSingle
                && number.IsNegative
                    => -(long)(number.sequence.StartNode.Value
                    + (number.sequence.StartNode.GetNext()!.Value.Value << sizeof(uint) * 8)),
            sizeof(uint)
                when !number.sequence.IsSingle
                && !number.IsNegative
                    => (long)(number.sequence.StartNode.Value
                    + (number.sequence.StartNode.GetNext()!.Value.Value << sizeof(uint) * 8)),
            sizeof(uint)
                when number.sequence.IsSingle
                && number.IsNegative
                    => -(long)number.sequence.StartNode.Value,
            sizeof(uint)
                when number.sequence.IsSingle
                && !number.IsNegative
                    => (long)number.sequence.StartNode.Value,
            _ => throw new NumberBinaryConversionException()
        };
    }

    /// <summary>
    /// Casts an <see cref="IntegerNumber" /> to a <see cref="ulong" />.
    /// </summary>
    /// <param name="number">
    /// The number to cast.
    /// </param>
    /// <returns>
    /// A <see cref="ulong" /> that represents the <paramref name="number" />.
    /// </returns>
    /// <exception cref="NumberBinaryConversionException">
    /// A <see cref="NumberBinaryConversionException" /> is thrown if the binary conversion of the <paramref name="number" /> failed.
    /// </exception>
    /// <exception cref="NumberNegativeException">
    /// A <see cref="NumberNegativeException" /> is thrown if the <paramref name="number" /> has a negative sign.
    /// </exception>
    /// <exception cref="NumberTooLargeException">
    /// A <see cref="NumberTooLargeException" /> is thrown if the <paramref name="number" /> is too large.
    /// </exception>
    public static explicit operator ulong(IntegerNumber number)
    {
        if (number.IsNegative)
            throw new NumberNegativeException();
        return (ulong)number.sequence.StartNode;
    }

    /// <summary>
    /// Casts an <see cref="IntegerNumber" /> to a <see cref="float" />.
    /// </summary>
    /// <param name="number">
    /// The number to cast.
    /// </param>
    /// <returns>
    /// A <see cref="float" /> that represents the value of <paramref name="number" />.
    /// </returns>
    /// <exception cref="NumberTooLargeException">
    /// A <see cref="NumberTooLargeException" /> is thrown if the number is less than <see cref="float.NegativeInfinity" /> or more than <see cref="float.PositiveInfinity" />.
    /// </exception>
    public static explicit operator float(IntegerNumber number)
        => SequenceArithmetic.ToSingleFrom(number.sequence.StartNode, number.IsNegative);

    /// <summary>
    /// Casts an <see cref="IntegerNumber" /> to a <see cref="double" />.
    /// </summary>
    /// <param name="number">
    /// The number to cast.
    /// </param>
    /// <returns>
    /// A <see cref="double" /> that represents the value of <paramref name="number" />.
    /// </returns>
    /// <exception cref="NumberTooLargeException">
    /// A <see cref="NumberTooLargeException" /> is thrown if the number is less than <see cref="double.NegativeInfinity" /> or more than <see cref="double.PositiveInfinity" />.
    /// </exception>
    public static explicit operator double(IntegerNumber number)
        => SequenceArithmetic.ToDoubleFrom(number.sequence.StartNode, number.IsNegative);


    /// <summary>
    /// Casts an <see cref="IntegerNumber" /> to a <see cref="decimal" />.
    /// </summary>
    /// <param name="number">
    /// The number to cast.
    /// </param>
    /// <returns>
    /// A <see cref="decimal" /> that represents the value of <paramref name="number" />.
    /// </returns>
    /// <exception cref="NumberTooLargeException">
    /// A <see cref="NumberTooLargeException" /> is thrown if the <paramref name="number" /> is less than <see cref="decimal.MinValue" /> or more than <see cref="decimal.MaxValue" />.
    /// </exception>
    public static explicit operator decimal(IntegerNumber number)
        => SequenceArithmetic.ToDecimalFrom(number.sequence.StartNode, number.IsNegative);
}