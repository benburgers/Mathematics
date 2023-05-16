/*
 * Ben Burgers Mathematics
 * © 2022-2023 Ben Burgers and contributors
 * Licensed under AGPL 3.0
 */

using System.Buffers.Binary;

namespace BenBurgers.Mathematics.Numbers.Sequence;

internal readonly partial struct NumberSequenceNode
{
    /// <summary>
    /// Casts a <see cref="byte" /> <paramref name="value" /> to a <see cref="NumberSequenceNode" />.
    /// </summary>
    /// <param name="value">The value to cast.</param>
    public static implicit operator NumberSequenceNode(byte value)
        => new(value);

    /// <summary>
    /// Casts a <see cref="ushort" /> <paramref name="value" /> to a <see cref="NumberSequenceNode" />.
    /// </summary>
    /// <param name="value">The value to cast.</param>
    public static implicit operator NumberSequenceNode(ushort value)
        => new(value);

    /// <summary>
    /// Casts a <see cref="uint" /> <paramref name="value" /> to a <see cref="NumberSequenceNode" />.
    /// </summary>
    /// <param name="value">The value to cast.</param>
    public static implicit operator NumberSequenceNode(uint value)
        => new(value);

    /// <summary>
    /// Casts a <see cref="ulong" /> <paramref name="value" /> to a <see cref="NumberSequenceNode" />.
    /// </summary>
    /// <param name="value">The value to cast.</param>
    public static unsafe implicit operator NumberSequenceNode(ulong value)
    {
        if (sizeof(nuint) == sizeof(ulong))
            return new((nuint)value);
        var number = BitConverter.IsLittleEndian ? value : BinaryPrimitives.ReverseEndianness(value);
        nuint lowerBound = (nuint)number;
        nuint upperBound = (nuint)(number << sizeof(uint) * 8);
        var upperBoundBinary = new NumberSequenceNode(upperBound);
        var lowerBoundBinary = new NumberSequenceNode(lowerBound, new IntPtr(&upperBoundBinary));
        return lowerBoundBinary;
    }

    /// <summary>
    /// Converts a <see cref="NumberSequenceNode" /> <paramref name="value" /> to a <see cref="byte" />.
    /// </summary>
    /// <param name="value">The value to convert.</param>
    public static explicit operator byte(NumberSequenceNode value)
    {
        if (value.Value > byte.MaxValue || value.Next is not null)
            throw new NumberTooLargeException();
        return (byte)value.Value;
    }

    /// <summary>
    /// Converts a <see cref="NumberSequenceNode" /> <paramref name="value" /> to a <see cref="ushort" />.
    /// </summary>
    /// <param name="value">The value to convert.</param>
    public static explicit operator ushort(NumberSequenceNode value)
    {
        if (value.Value > ushort.MaxValue || value.Next is not null)
            throw new NumberTooLargeException();
        return
            (ushort)(BitConverter.IsLittleEndian
                ? value.Value
                : BinaryPrimitives.ReverseEndianness(value.Value));
    }

    /// <summary>
    /// Converts a <see cref="NumberSequenceNode" /> <paramref name="value" /> to a <see cref="uint" />.
    /// </summary>
    /// <param name="value">The value to convert.</param>
    public static explicit operator uint(NumberSequenceNode value)
    {
        if (value.Value > uint.MaxValue || value.Next is not null)
            throw new NumberTooLargeException();
        return (uint)value.Value;
    }

    /// <summary>
    /// Converts a <see cref="NumberSequenceNode" /> <paramref name="value" /> to a <see cref="ulong" />.
    /// </summary>
    /// <param name="value">The value to convert.</param>
    public static unsafe explicit operator ulong(NumberSequenceNode value)
    {
        if (sizeof(nuint) == sizeof(ulong))
        {
            if (value.Next is not null)
                throw new NumberTooLargeException();
            return value.Value;
        }
        else
        {
            if (value.Next is not null && (*(NumberSequenceNode*)value.Next).Next is not null)
                throw new NumberTooLargeException();
            var lowerBound = (ulong)value.Value;
            var upperBound = value.Next is null ? 0ul : (*(NumberSequenceNode*)value.Next).Value;
            return
                BitConverter.IsLittleEndian
                    ? (upperBound << sizeof(uint)) + lowerBound
                    : upperBound + (lowerBound << sizeof(uint));
        }
    }
}