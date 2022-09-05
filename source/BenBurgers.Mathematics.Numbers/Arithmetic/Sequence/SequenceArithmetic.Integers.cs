/*
 * Ben Burgers Mathematics
 * © 2022 Ben Burgers and contributors
 * Licensed under AGPL 3.0
 */

using BenBurgers.Mathematics.Numbers.Real.Rational.Integer;
using BenBurgers.Mathematics.Numbers.Real.Rational.Integer.Natural;
using BenBurgers.Mathematics.Numbers.Sequence;

namespace BenBurgers.Mathematics.Numbers.Arithmetic.Sequence;

/// <summary>
/// Arithmetic operations on primitives and sequences.
/// </summary>
internal static partial class SequenceArithmetic
{
    /// <summary>
    /// Gets the binary representation of <paramref name="number" />.
    /// </summary>
    /// <param name="number">
    /// The number for which to get a binary representation.
    /// </param>
    /// <param name="isNegative">
    /// A value that indicates whether the number is negative.
    /// </param>
    /// <returns>
    /// An integer number that is converted from <paramref name="number" />.
    /// </returns>
    /// <exception cref="NumberBinaryConversionException">
    /// A <see cref="NumberBinaryConversionException" /> is thrown if the number could not be converted.
    /// </exception>
    internal static unsafe IntegerNumber ToIntegerNumberFrom(ulong number, bool isNegative)
    {
        var nodePointer = NumberSequenceNode.AllocateAndInitialize(number);
        var node = *(NumberSequenceNode*)nodePointer.ToPointer();
        var sequence = node.Next is null
            ? new NumberSequence(nodePointer, nodePointer)
            : new NumberSequence(nodePointer, node.Next.Value);
        return new(sequence, isNegative);
    }

    /// <summary>
    /// Gets the binary representation of <paramref name="number" />.
    /// </summary>
    /// <param name="number">The number for which to get a binary representation.</param>
    /// <returns>An integer number that is converted from <paramref name="number" />.</returns>
    /// <exception cref="NumberBinaryConversionException">
    /// A <see cref="NumberBinaryConversionException" /> is thrown if the number could not be converted.
    /// </exception>
    internal static IntegerNumber ToIntegerNumberFrom(long number)
    {
        var isNegative = number < 0L;
        var nonNegative = isNegative ? -number : number;
        return ToIntegerNumberFrom((ulong)nonNegative, isNegative);
    }

    /// <summary>
    /// Converts a <see cref="float" /> to an <see cref="IntegerNumber" />.
    /// </summary>
    /// <param name="number">
    /// The number to convert.
    /// </param>
    /// <returns>
    /// The converted <see cref="IntegerNumber" />.
    /// </returns>
    /// <exception cref="NumberNotIntegerException">
    /// A <see cref="NumberNotIntegerException" /> is thrown if <paramref name="number" /> is not an integer.
    /// </exception>
    /// <exception cref="NumberTooLargeException">
    /// A <see cref="NumberTooLargeException" /> is thrown if <paramref name="number" /> has an infinite value.
    /// </exception>
    /// <exception cref="NotSupportedException">
    /// A <see cref="NotSupportedException" /> is thrown if the number is larger than the system-specific integer number.
    /// </exception>
    internal static IntegerNumber ToIntegerNumberFrom(float number)
    {
        var isNegative = number < 0.0F;
        if (!isNegative && number - Math.Truncate(number) > 0.0F || -number + Math.Truncate(number) > 0.0F)
            throw new NumberNotIntegerException();
        if (float.IsInfinity(number))
            throw new NumberTooLargeException();
        var nonNegative = isNegative ? -number : number;

        if (nonNegative > nuint.MaxValue)
        {
            // TODO implement
            throw new NotSupportedException("Single floating point numbers that are larger than the maximum value of an integer are not yet supported.");
        }

        var nodePointer = NumberSequenceNode.AllocateAndInitialize((nuint)nonNegative);
        var sequence = new NumberSequence(nodePointer, nodePointer);
        return new(sequence, isNegative);
    }

    /// <summary>
    /// Converts a <see cref="double" /> to an <see cref="IntegerNumber" />.
    /// </summary>
    /// <param name="number">
    /// The number to convert.
    /// </param>
    /// <returns>
    /// The converted <see cref="IntegerNumber" />.
    /// </returns>
    /// <exception cref="NumberNotIntegerException">
    /// A <see cref="NumberNotIntegerException" /> is thrown if <paramref name="number" /> is not an integer.
    /// </exception>
    /// <exception cref="NumberTooLargeException">
    /// A <see cref="NumberTooLargeException" /> is thrown if <paramref name="number" /> has an infinite value.
    /// </exception>
    /// <exception cref="NotSupportedException">
    /// A <see cref="NotSupportedException" /> is thrown if the number is larger than the system-specific integer number.
    /// </exception>
    internal static IntegerNumber ToIntegerNumberFrom(double number)
    {
        var isNegative = number < 0.0D;
        if (!isNegative && number - Math.Truncate(number) > 0.0D || -number + Math.Truncate(number) > 0.0D)
            throw new NumberNotIntegerException();
        if (double.IsInfinity(number))
            throw new NumberTooLargeException();
        var nonNegative = isNegative ? -number : number;

        if (nonNegative > nuint.MaxValue)
        {
            // TODO implement
            throw new NotSupportedException("Double floating point numbers that are larger than the maximum value of an integer are not yet supported.");
        }

        var nodePointer = NumberSequenceNode.AllocateAndInitialize((nuint)nonNegative);
        var sequence = new NumberSequence(nodePointer, nodePointer);
        return new(sequence, isNegative);
    }

    /// <summary>
    /// Converts a <see cref="decimal" /> <paramref name="number" /> to a <see cref="NaturalNumber" />.
    /// </summary>
    /// <param name="number">
    /// The number to convert.
    /// </param>
    /// <exception cref="NumberNotIntegerException">
    /// A <see cref="NumberNotIntegerException" /> is thrown if <paramref name="number" /> is not an integer number.
    /// </exception>
    /// <exception cref="NumberTooLargeException">
    /// A <see cref="NumberTooLargeException" /> is thrown if <paramref name="number" /> has an infinite value.
    /// </exception>
    /// <exception cref="NotSupportedException">
    /// A <see cref="NotSupportedException" /> is thrown if the number is larger than the system-specific integer number.
    /// </exception>
    internal static unsafe IntegerNumber ToIntegerNumberFrom(decimal number)
    {
        // Validity checks.
        if (number is decimal.MinValue or decimal.MaxValue)
            throw new NumberTooLargeException();
        var binary128 = decimal.GetBits(number);
        var isNegative = (binary128[3] & 0x80000000) != 0;
        if (!isNegative && number - Math.Truncate(number) > 0.0M || -number + Math.Truncate(number) > 0.0M)
            throw new NumberNotIntegerException();

        // Conversion.
        var scale = (byte)((binary128[3] >> 16) & 0x7F);
        var partsInt32 = new int[3];
        Buffer.BlockCopy(binary128, 0, partsInt32, 0, 3);
        // TODO scale
        var parts = partsInt32.Reverse().Select(i => (nuint)(i / Math.Pow(10, scale))).ToArray();

        var sequence = (NumberSequence)parts;
        return new(sequence, isNegative);
    }

    /// <summary>
    /// Converts a number sequence to a <see cref="float" />.
    /// </summary>
    /// <param name="node">
    /// The number sequence to convert.
    /// </param>
    /// <param name="isNegative">
    /// A value that indicates whether the number is negative.
    /// </param>
    /// <returns>
    /// The converted <see cref="float" />.
    /// </returns>
    /// <exception cref="NumberTooLargeException">
    /// A <see cref="NumberTooLargeException" /> is thrown if the number is less than <see cref="float.NegativeInfinity" /> or more than <see cref="float.PositiveInfinity" />.
    /// </exception>
    internal static float ToSingleFrom(NumberSequenceNode node, bool isNegative)
    {
        float sum = 0.0F;

        NumberSequenceNode? current = node;
        while (current is { } currentNode)
        {
            sum += currentNode.Value;
            if (float.IsInfinity(sum))
                throw new NumberTooLargeException();
            current = currentNode.GetNext();
        }

        if (isNegative)
            sum = -sum;
        return sum;
    }

    /// <summary>
    /// Converts a number sequence to a <see cref="double" />.
    /// </summary>
    /// <param name="node">
    /// The number sequence to convert.
    /// </param>
    /// <param name="isNegative">
    /// A value that indicates whether the number is negative.
    /// </param>
    /// <returns>
    /// The converted <see cref="double" />.
    /// </returns>
    /// <exception cref="NumberTooLargeException">
    /// A <see cref="NumberTooLargeException" /> is thrown if the number is less than <see cref="double.NegativeInfinity" /> or more than <see cref="double.PositiveInfinity" />.
    /// </exception>
    internal static double ToDoubleFrom(NumberSequenceNode node, bool isNegative)
    {
        double sum = 0.0D;

        NumberSequenceNode? current = node;
        while (current is { } currentNode)
        {
            sum += currentNode.Value;
            if (double.IsInfinity(sum))
                throw new NumberTooLargeException();
            current = currentNode.GetNext();
        }

        if (isNegative)
            sum = -sum;
        return sum;
    }

    /// <summary>
    /// Converts a number sequence to a <see cref="float" />.
    /// </summary>
    /// <param name="node">
    /// The number sequence to convert.
    /// </param>
    /// <param name="isNegative">
    /// A value that indicates whether the number is negative.
    /// </param>
    /// <returns>
    /// The converted <see cref="decimal" />.
    /// </returns>
    /// <exception cref="NumberTooLargeException">
    /// A <see cref="NumberTooLargeException" /> is thrown if the number is less than <see cref="decimal.MinValue" /> or more than <see cref="decimal.MaxValue" />.
    /// </exception>
    internal static decimal ToDecimalFrom(NumberSequenceNode node, bool isNegative)
    {
        decimal sum = 0.0M;

        NumberSequenceNode? current = node;
        while (current is { } currentNode)
        {
            sum += currentNode.Value;
            if (sum >= decimal.MaxValue)
                throw new NumberTooLargeException();
            current = currentNode.GetNext();
        }

        if (isNegative)
            sum = -sum;
        return sum;
    }
}