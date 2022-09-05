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
    /// Performs the modulus on a pair of integer number sequences.
    /// </summary>
    /// <param name="dividend">The end of the number sequence for the dividend in the modulus.</param>
    /// <param name="divisor">The end of the number sequence for the divisor in the modulus.</param>
    /// <param name="options">The arithmetic options.</param>
    /// <returns>The resulting number sequence from the modulus operation, start and end.</returns>
    internal unsafe static NumberSequence ModulusInteger(
        NumberSequence dividend,
        NumberSequence divisor,
        ArithmeticOptions options)
    {
        // A single node can be computed instantaneously.
        if (dividend.IsSingle && divisor.IsSingle)
        {
            var singleNodePointer = NumberSequenceNode.AllocateAndInitialize(dividend.EndNode.Value % divisor.EndNode.Value);
            return new(singleNodePointer, singleNodePointer);
        }

        // Pointers to the operands.
        IntPtr? dividendPointerCurrent = dividend.End;
        IntPtr? divisorPointerCurrent = divisor.End;

        // Prepare the result.
        IntPtr modulusPointerEnd = Marshal.AllocHGlobal(sizeof(NumberSequenceNode));
        IntPtr modulusPointerCurrent = modulusPointerEnd;

        // Start the process.
        var timeout = options.Timeout;
        var stopwatch = new Stopwatch();
        stopwatch.Start();

        // Divide the sequences and keep the remainder.
        var bitLength = sizeof(nuint) * 8;
        nuint modCurrent = 0;
        while (dividendPointerCurrent is { } dividendPointer)
        {
            // Check for timeout.
            if (stopwatch.Elapsed > timeout)
                throw new ArithmeticTimeoutException(typeof(NumberSequenceNode), timeout);

            // Copy dividend node to modulus node.
            var dividendNodeCurrent = *(NumberSequenceNode*)dividendPointer.ToPointer();
            var dividendNodePrevious = dividendNodeCurrent.GetPrevious();
            var modulusNodeCurrent = *(NumberSequenceNode*)modulusPointerCurrent;
            *(NumberSequenceNode*)modulusPointerCurrent.ToPointer() = new NumberSequenceNode(dividendNodeCurrent.Value, modulusNodeCurrent.Next);
            modulusNodeCurrent = *(NumberSequenceNode*)modulusPointerCurrent.ToPointer();

            while (divisorPointerCurrent is { } divisorPointer)
            {
                // Check for timeout.
                if (stopwatch.Elapsed > timeout)
                    throw new ArithmeticTimeoutException(typeof(NumberSequenceNode), timeout);

                var divisorNodeCurrent = *(NumberSequenceNode*)divisorPointer.ToPointer();
                var divisorNodePrevious = divisorNodeCurrent.GetPrevious();
                for (int bitShift = bitLength; bitShift >= 0; bitShift--)
                {
                    var numShiftedPrevious =
                        dividendNodePrevious is not { } numNodePrevious
                            ? 0
                            : numNodePrevious.Value >> bitShift;
                    var numShiftedCurrent = dividendNodeCurrent.Value << bitShift;
                    var numShiftedMerged = numShiftedPrevious + numShiftedCurrent;

                    var divShiftedPrevious =
                        divisorNodePrevious is not { } divNodePrevious
                            ? 0
                            : divNodePrevious.Value >> bitShift;
                    var divShiftedCurrent = divisorNodeCurrent.Value << bitShift;
                    var divShiftedMerged = divShiftedPrevious + divShiftedCurrent;

                    // TODO use result pointer to span multiple nodes
                    var modStep = numShiftedMerged - (numShiftedMerged & divShiftedCurrent);
                    modCurrent += modStep;
                    if (modCurrent < modStep)
                    {
                        // TODO overflow, create new node
                    }

                    if (bitShift == 0)
                    {
                        // TODO next node
                        break;
                    }
                }

                *(NumberSequenceNode*)modulusPointerCurrent.ToPointer() = new NumberSequenceNode(modCurrent);
                divisorPointerCurrent = divisorNodeCurrent.Previous;
            }
            divisorPointerCurrent = divisor.End; // Back to the end.
            dividendPointerCurrent = dividendNodeCurrent.Previous; // Move to previous.
        }

        // Finalize the process and return the result.
        stopwatch.Stop();

        return new(modulusPointerCurrent, modulusPointerEnd);
    }

    /// <summary>
    /// Performs the modulus on a pair of integer number sequences.
    /// </summary>
    /// <param name="dividend">The dividend in the modulus.</param>
    /// <param name="divisor">The divisor in the modulus.</param>
    /// <param name="options">The arithmetic options.</param>
    /// <param name="cancellationToken">The cancellation token.</param>
    /// <returns>The resulting number sequence from the modulus operation.</returns>
    internal static async Task<NumberSequence> ModulusIntegerAsync(
        NumberSequence dividend,
        NumberSequence divisor,
        ArithmeticOptions options,
        CancellationToken cancellationToken = default)
    {
        return await Task.Run(() => ModulusInteger(dividend, divisor, options), cancellationToken);
    }
}
