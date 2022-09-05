/*
 * Ben Burgers Mathematics
 * © 2022 Ben Burgers and contributors
 * Licensed under AGPL 3.0
 */

using BenBurgers.Mathematics.Numbers.Sequence;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace BenBurgers.Mathematics.Numbers.Arithmetic.Sequence;

internal static partial class SequenceArithmetic
{
    /// <summary>
    /// Parses a number sequence from a <see cref="string" /> representation.
    /// </summary>
    /// <param name="numberString">
    /// The <see cref="string" /> representation of a number.
    /// </param>
    /// <param name="options">
    /// The options for arithmetic operations.
    /// </param>
    /// <returns>
    /// The parsed number sequence.
    /// </returns>
    /// <exception cref="ArithmeticTimeoutException">
    /// An <see cref="ArithmeticTimeoutException" /> is thrown if the operation exceeded the timeout.
    /// </exception>
    internal unsafe static NumberSequence Parse(
        string numberString,
        ArithmeticOptions options)
    {
        var head = Marshal.AllocHGlobal(sizeof(NumberSequenceNode));
        *(NumberSequenceNode*)head.ToPointer() = new NumberSequenceNode();
        var current = head;
        var currentNode = *(NumberSequenceNode*)current.ToPointer();
        var currentNodeValue = currentNode.Value;

        var powerOfTenMax = Math.Floor(Math.Log10(nuint.MaxValue));
        var digitMax = Math.Floor(nuint.MaxValue / Math.Pow(10.0D, powerOfTenMax));
        var powerOfTen = 0;

        var timeout = options.Timeout;
        var stopwatch = new Stopwatch();
        stopwatch.Start();
        for (var i = numberString.Length - 1; i >= 0; --i)
        {
            // Check for timeout.
            if (stopwatch.Elapsed > timeout)
                throw new ArithmeticTimeoutException(typeof(NumberSequenceNode), timeout);

            // Convert the digit.
            var digit = numberString[i] - (nuint)'0';
            if (powerOfTen == powerOfTenMax && digit > digitMax || powerOfTen > powerOfTenMax)
            {
                var next = Marshal.AllocHGlobal(sizeof(NumberSequenceNode));
                *(NumberSequenceNode*)next.ToPointer() = new NumberSequenceNode(digit, null, current);
                *(NumberSequenceNode*)current.ToPointer() = new NumberSequenceNode(currentNodeValue, next, currentNode.Previous);
                currentNodeValue = digit;
                current = next;
                powerOfTen = 1; // reset power of 10
            }
            else
            {
                currentNodeValue += unchecked(digit * (nuint)Math.Pow(10, powerOfTen));
                powerOfTen++;
                currentNode = *(NumberSequenceNode*)current.ToPointer();
                *(NumberSequenceNode*)current.ToPointer() = new NumberSequenceNode(currentNodeValue, currentNode.Next, currentNode.Previous);
            }
        }

        stopwatch.Stop();
        return new(head, current);
    }

    /// <summary>
    /// Parses a number sequence from a <see cref="string" /> representation.
    /// </summary>
    /// <param name="numberString">
    /// The <see cref="string" /> representation of a number.
    /// </param>
    /// <param name="options">
    /// The options for arithmetic operations.
    /// </param>
    /// <param name="cancellationToken">
    /// The cancellation token.
    /// </param>
    /// <returns>
    /// The parsed number sequence.
    /// </returns>
    /// <exception cref="ArithmeticTimeoutException">
    /// An <see cref="ArithmeticTimeoutException" /> is thrown if the operation exceeded the timeout.
    /// </exception>
    /// <exception cref="TaskCanceledException">
    /// A <see cref="TaskCanceledException" /> is thrown if the operation was canceled.
    /// </exception>
    internal static async Task<NumberSequence> ParseAsync(
        string numberString,
        ArithmeticOptions options,
        CancellationToken cancellationToken)
        => await Task.Run(() => Parse(numberString, options), cancellationToken);
}