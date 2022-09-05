/*
 * Ben Burgers Mathematics
 * © 2022 Ben Burgers and contributors
 * Licensed under AGPL 3.0
 */

using BenBurgers.Mathematics.Numbers.Real.Rational.Integer;
using BenBurgers.Mathematics.Numbers.Sequence;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace BenBurgers.Mathematics.Numbers.Arithmetic.Sequence;

internal static partial class SequenceArithmetic
{
    internal unsafe static IntegerNumber AddInteger(
        NumberSequence left,
        bool leftIsNegative,
        NumberSequence right,
        bool rightIsNegative,
        ArithmeticOptions options,
        CancellationToken cancellationToken = default)
    {
        // Allocate return values.
        var resultPointerStart = Marshal.AllocHGlobal(sizeof(NumberSequenceNode));
        *(NumberSequenceNode*)resultPointerStart.ToPointer() = new NumberSequenceNode();
        var resultIsNegative = leftIsNegative;

        // Initialize temporary values.
        var subtract = leftIsNegative ^ rightIsNegative;
        IntPtr? currentLeftPointer = left.Start;
        IntPtr? currentRightPointer = right.Start;
        IntPtr resultPointerCurrent = resultPointerStart;
        nuint carry = 0;

        // Start the addition.
        var stopwatch = new Stopwatch();
        stopwatch.Start();
        while (currentLeftPointer is not null && currentRightPointer is not null)
        {
            // Check for safeguards.
            cancellationToken.ThrowIfCancellationRequested();
            if (stopwatch.Elapsed >= options.Timeout)
                throw new ArithmeticTimeoutException(typeof(IntegerNumber), options.Timeout);

            // Read current values.
            var currentLeft = *(NumberSequenceNode*)currentLeftPointer.Value.ToPointer();
            var currentRight = *(NumberSequenceNode*)currentRightPointer.Value.ToPointer();
            var intermediateResult = *(NumberSequenceNode*)resultPointerCurrent.ToPointer();

            // Add or subtract carry.
            var intermediateResultValue = subtract
                ? unchecked(intermediateResult.Value - carry)
                : unchecked(intermediateResult.Value + carry);
            if (!subtract && intermediateResultValue < carry) // TODO subtract
                carry = 1;

            // Perform the addition.
            var addition = subtract
                    ? unchecked(currentLeft.Value - currentRight.Value)
                    : unchecked(currentLeft.Value + currentRight.Value);
            if (!subtract && addition < currentRight.Value) // TODO subtract
                carry += 1;
            intermediateResultValue = unchecked(addition + intermediateResultValue);
            carry += intermediateResultValue < carry ? (nuint)1 : 0;

            // Move to next.
            currentLeftPointer = currentLeft.Next;
            currentRightPointer = currentRight.Next;

            // Store intermediate result, include carry if non-zero.
            if (carry == 0)
                *(NumberSequenceNode*)resultPointerCurrent.ToPointer() = new NumberSequenceNode(intermediateResultValue, intermediateResult.Next, intermediateResult.Previous);
            else
            {
                var carryPointer = Marshal.AllocHGlobal(sizeof(NumberSequenceNode));
                *(NumberSequenceNode*)carryPointer.ToPointer() = new NumberSequenceNode(carry, null, resultPointerCurrent);
                *(NumberSequenceNode*)resultPointerCurrent.ToPointer() = new NumberSequenceNode(intermediateResultValue, carryPointer, intermediateResult.Previous);
                resultPointerCurrent = carryPointer;
            }
        }
        stopwatch.Stop();
        return new IntegerNumber(new NumberSequence(resultPointerStart, resultPointerCurrent), resultIsNegative);
    }

    internal static async Task<IntegerNumber> AddIntegerAsync(
        NumberSequence left,
        bool leftIsNegative,
        NumberSequence right,
        bool rightIsNegative,
        ArithmeticOptions options,
        CancellationToken cancellationToken = default)
    {
        return await Task.Run(() => AddInteger(left, leftIsNegative, right, rightIsNegative, options, cancellationToken), cancellationToken);
    }
}