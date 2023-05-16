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
    /// Converts a number sequence to a <see cref="string" />.
    /// </summary>
    /// <param name="numberType">
    /// The type of the number.
    /// </param>
    /// <param name="sequence">
    /// The number sequence to convert.
    /// </param>
    /// <param name="options">
    /// The arithmetic options.
    /// </param>
    /// <returns>
    /// The converted <see cref="string" />.
    /// </returns>
    internal static string ToString(
        Type numberType,
        NumberSequence sequence,
        ArithmeticOptions options)
    {
        var timeout = options.Timeout;
        var result = string.Empty;
        NumberSequenceNode? current = sequence.StartNode;

        var stopwatch = new Stopwatch();
        stopwatch.Start();
        while (current is { } currentNode)
        {
            // Check for timeout.
            if (stopwatch.Elapsed > timeout)
                throw new ArithmeticTimeoutException(numberType, timeout);

            // Concatenate string.
            var currentString = currentNode.Value.ToString();
            result = currentString + result;
            current = currentNode.GetNext();
        }
        stopwatch.Stop();

        return result;
    }

    /// <summary>
    /// Converts a number sequence to a <see cref="string" />.
    /// </summary>
    /// <param name="numberType">
    /// The type of the number.
    /// </param>
    /// <param name="sequence">
    /// The number sequence to convert.
    /// </param>
    /// <param name="options">
    /// The arithmetic options.
    /// </param>
    /// <param name="cancellationToken">
    /// The cancellation token.
    /// </param>
    /// <returns>
    /// The converted <see cref="string" />.
    /// </returns>
    /// <exception cref="TaskCanceledException">
    /// A <see cref="TaskCanceledException" /> is thrown if the operation is canceled.
    /// </exception>
    internal static async Task<string> ToStringAsync(
        Type numberType,
        NumberSequence sequence,
        ArithmeticOptions options,
        CancellationToken cancellationToken = default)
        => await Task.Run(() => ToString(numberType, sequence, options), cancellationToken);
}