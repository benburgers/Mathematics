/*
 * Ben Burgers Mathematics
 * © 2022-2023 Ben Burgers and contributors
 * Licensed under AGPL 3.0
 */

using BenBurgers.Mathematics.Numbers.Sequence;
using System.Diagnostics;

namespace BenBurgers.Mathematics.Numbers.Arithmetic.Sequence;

internal static partial class SequenceArithmetic
{
    /// <summary>
    /// Determines whether <paramref name="sequence" /> is equal to <paramref name="other" />.
    /// </summary>
    /// <param name="sequence">
    /// The number sequence to compare.
    /// </param>
    /// <param name="other">
    /// The primitive number to compare.
    /// </param>
    /// <exception cref="NumberBinaryConversionException">
    /// A <see cref="NumberBinaryConversionException" /> is thrown if the number could not be compared.
    /// </exception>
    internal unsafe static bool IntegerEquals(NumberSequenceNode sequence, ulong other)
    {
        return sizeof(nuint) switch
        {
            sizeof(ulong) => IntegerEquals64Bits(sequence, other),
            sizeof(uint) => IntegerEquals32Bits(sequence, other),
            _ => throw new NumberBinaryConversionException()
        };
    }

    private static bool IntegerEquals32Bits(NumberSequenceNode sequence, ulong other)
    {
        if (sequence.Next is null)
            return sequence.Value.Equals((nuint)other);
        var nodeNext = sequence.GetNext()!.Value;
        if (nodeNext.Next is not null)
            return false;
        var upperBound = nodeNext.Value;
        var lowerBound = sequence.Value;
        return ((ulong)upperBound * uint.MaxValue + lowerBound).Equals(other);
    }

    private static bool IntegerEquals64Bits(NumberSequenceNode sequence, ulong other)
    {
        if (sequence.Next is not null)
            return false;
        return sequence.Value.Equals((nuint)other);
    }

    /// <summary>
    /// Determines whether <paramref name="sequence" /> is equal to <paramref name="other" />.
    /// </summary>
    /// <param name="sequence">
    /// The number sequence to compare.
    /// </param>
    /// <param name="isNegative">
    /// A value that indicates whether the number is negative.
    /// </param>
    /// <param name="other">
    /// The primitive number to compare.
    /// </param>
    /// <returns></returns>
    /// <exception cref="NumberBinaryConversionException">
    /// A <see cref="NumberBinaryConversionException" /> is thrown if the number could not be compared.
    /// </exception>
    internal unsafe static bool IntegerEquals(NumberSequenceNode sequence, bool isNegative, long other)
    {
        var otherIsNegative = other < 0L;
        if (isNegative != otherIsNegative)
            return false;
        return sizeof(nuint) switch
        {
            sizeof(ulong) when otherIsNegative => IntegerEquals64Bits(sequence, (ulong)-other),
            sizeof(ulong) when !otherIsNegative => IntegerEquals64Bits(sequence, (ulong)other),
            sizeof(uint) when otherIsNegative => IntegerEquals32Bits(sequence, (uint)-other),
            sizeof(uint) when !otherIsNegative => IntegerEquals32Bits(sequence, (uint)other),
            _ => throw new NumberBinaryConversionException()
        };
    }

    /// <summary>
    /// Determines whether <paramref name="sequence" /> is equal to <paramref name="other" />.
    /// </summary>
    /// <param name="sequence">
    /// The number sequence to compare.
    /// </param>
    /// <param name="isNegative">
    /// A value that indicates whether the number is negative.
    /// </param>
    /// <param name="other">
    /// The primitive number to compare.
    /// </param>
    /// <returns></returns>
    /// <exception cref="NumberBinaryConversionException">
    /// A <see cref="NumberBinaryConversionException" /> is thrown if the number could not be compared.
    /// </exception>
    internal static bool IntegerEquals(NumberSequenceNode sequence, bool isNegative, float other)
    {
        if (!isNegative && Math.Sign(other) < 0 || isNegative && Math.Sign(other) >= 0)
            // Signs do not match.
            return false;
        if (other - Math.Truncate(other) != 0.0F)
            // Not an integer.
            return false;
        if (sequence.Next is not null && nuint.MaxValue > other)
            // Single-precision floating-point number fits within one node.
            return sequence.Value.Equals((nuint)other);

        var sum = 0.0F;
        NumberSequenceNode? node = sequence;
        while (node is not null && sum <= other && !float.IsInfinity(sum))
        {
            sum += node.Value.Value;
            node = node.Value.GetNext();
        }
        if (float.IsInfinity(sum))
            return false;
        return sum.Equals(other);
    }

    /// <summary>
    /// Determines whether <paramref name="sequence" /> is equal to <paramref name="other" />.
    /// </summary>
    /// <param name="sequence">
    /// The number sequence to compare.
    /// </param>
    /// <param name="isNegative">
    /// A value that indicates whether the number is negative.
    /// </param>
    /// <param name="other">
    /// The primitive number to compare.
    /// </param>
    /// <returns></returns>
    /// <exception cref="NumberBinaryConversionException">
    /// A <see cref="NumberBinaryConversionException" /> is thrown if the number could not be compared.
    /// </exception>
    internal static bool IntegerEquals(NumberSequenceNode sequence, bool isNegative, double other)
    {
        if (!isNegative && Math.Sign(other) < 0 || isNegative && Math.Sign(other) >= 0)
            // Signs do not match.
            return false;
        if (other - Math.Truncate(other) != 0.0D)
            // Not an integer.
            return false;
        if (sequence.Next is not null && nuint.MaxValue > other)
            // Double-precision floating-point number fits within one node.
            return sequence.Value.Equals((nuint)other);

        var sum = 0.0D;
        NumberSequenceNode? node = sequence;
        while (node is not null && sum <= other && !double.IsInfinity(sum))
        {
            sum += node.Value.Value;
            node = node.Value.GetNext();
        }
        if (double.IsInfinity(other))
            return false;
        return sum.Equals(other);
    }

    /// <summary>
    /// Determines whether <paramref name="sequence" /> is equal to <paramref name="other" />.
    /// </summary>
    /// <param name="sequence">
    /// The number sequence to compare.
    /// </param>
    /// <param name="isNegative">
    /// A value that indicates whether the number is negative.
    /// </param>
    /// <param name="other">
    /// The primitive number to compare.
    /// </param>
    /// <returns></returns>
    /// <exception cref="NumberBinaryConversionException">
    /// A <see cref="NumberBinaryConversionException" /> is thrown if the number could not be compared.
    /// </exception>
    internal static bool IntegerEquals(NumberSequenceNode sequence, bool isNegative, decimal other)
    {
        if (!isNegative && Math.Sign(other) < 0 || isNegative && Math.Sign(other) >= 0)
            // Signs do not match.
            return false;
        if (other - Math.Truncate(other) != 0.0M)
            // Not an integer.
            return false;
        if (sequence.Next is not null && nuint.MaxValue > other)
            // Decimal number fits within one node.
            return sequence.Value.Equals((nuint)other);

        var sum = 0.0M;
        NumberSequenceNode? node = sequence;
        while (node is { } current && sum <= other && sum < decimal.MaxValue)
        {
            sum += current.Value;
            node = current.GetNext();
        }
        if (sum == decimal.MaxValue)
            return false;
        return sum.Equals(other);
    }

    /// <summary>
    /// Determines whether two integer number sequences are equal.
    /// </summary>
    /// <param name="numberType">
    /// The original type of the number that is performing the comparison.
    /// </param>
    /// <param name="options">
    /// The options for performing the comparison.
    /// </param>
    /// <param name="sequenceLeft">
    /// The left sequence to compare.
    /// </param>
    /// <param name="sequenceRight">
    /// The right sequence to compare.
    /// </param>
    /// <param name="sequenceLeftIsNegative">
    /// A value that indicates whether the left sequence is a negative number.
    /// </param>
    /// <param name="sequenceRightIsNegative">
    /// A value that indicates whether the right sequence is a negative number.
    /// </param>
    /// <param name="cancellationToken">
    /// The cancellation token.
    /// </param>
    /// <returns>
    /// A <see cref="bool" /> that indicates whether the integer number sequences are equal.
    /// </returns>
    /// <exception cref="ArithmeticTimeoutException">
    /// An <see cref="ArithmeticTimeoutException" /> is thrown if the operation exceeded the timeout.
    /// </exception>
    /// <exception cref="TaskCanceledException">
    /// A <see cref="TaskCanceledException" /> is thrown if the operation was canceled.
    /// </exception>
    internal static async Task<bool> IntegerEqualsAsync(
        Type numberType,
        ArithmeticOptions options,
        NumberSequenceNode sequenceLeft,
        NumberSequenceNode sequenceRight,
        bool sequenceLeftIsNegative = false,
        bool sequenceRightIsNegative = false,
        CancellationToken cancellationToken = default)
    {
        if (sequenceLeftIsNegative != sequenceRightIsNegative)
            return false;

        return await Task.Run(() =>
        {
            var stopwatch = new Stopwatch();
            var timeout = options.Timeout;
            NumberSequenceNode? nodeLeft = sequenceLeft;
            NumberSequenceNode? nodeRight = sequenceRight;
            while (nodeLeft is { } left && nodeRight is { } right)
            {
                // Check for cancellation or timeout.
                cancellationToken.ThrowIfCancellationRequested();
                if (stopwatch.Elapsed > timeout)
                    throw new ArithmeticTimeoutException(numberType, timeout);

                if (!nodeLeft.Value.Equals(nodeRight.Value))
                    return false;

                nodeLeft = left.GetNext();
                nodeRight = right.GetNext();
            }
            stopwatch.Stop();
            return true;
        }, cancellationToken);
    }

    /// <summary>
    /// Determines whether two integer number sequences are equal.
    /// </summary>
    /// <param name="numberType">
    /// The original type of the number that is performing the comparison.
    /// </param>
    /// <param name="options">
    /// The options for performing the comparison.
    /// </param>
    /// <param name="sequenceLeft">
    /// The left sequence to compare.
    /// </param>
    /// <param name="sequenceRight">
    /// The right sequence to compare.
    /// </param>
    /// <param name="sequenceLeftIsNegative">
    /// A value that indicates whether the left sequence is a negative number.
    /// </param>
    /// <param name="sequenceRightIsNegative">
    /// A value that indicates whether the right sequence is a negative number.
    /// </param>
    /// <returns>
    /// A <see cref="bool" /> that indicates whether the integer number sequences are equal.
    /// </returns>
    /// <exception cref="ArithmeticTimeoutException">
    /// An <see cref="ArithmeticTimeoutException" /> is thrown if the operation exceeded the timeout.
    /// </exception>
    internal static bool IntegerEquals(
        Type numberType,
        ArithmeticOptions options,
        NumberSequenceNode sequenceLeft,
        NumberSequenceNode sequenceRight,
        bool sequenceLeftIsNegative = false,
        bool sequenceRightIsNegative = false)
        => IntegerEqualsAsync(
            numberType,
            options,
            sequenceLeft,
            sequenceRight,
            sequenceLeftIsNegative,
            sequenceRightIsNegative)
        .ConfigureAwait(false)
        .GetAwaiter()
        .GetResult();
}