/*
 * Ben Burgers Mathematics
 * © 2022-2023 Ben Burgers and contributors
 * Licensed under AGPL 3.0
 */

using BenBurgers.Mathematics.Numbers.Sequence;

namespace BenBurgers.Mathematics.Numbers.Arithmetic.Sequence;

internal static partial class SequenceArithmetic
{
    internal static async Task<int> CompareAsync(
        NumberSequenceNode left,
        bool leftIsNegative,
        NumberSequenceNode right,
        bool rightIsNegative,
        CancellationToken cancellationToken = default)
    {
        // Negative sign is always smaller.
        if (leftIsNegative && !rightIsNegative)
            return -1;
        if (!leftIsNegative && rightIsNegative)
            return 1;

        NumberSequenceNode? currentLeft = left;
        NumberSequenceNode? currentRight = right;

        // Go to the last node.
        await Task.Run(() =>
        {
            while (currentLeft!.Value.Next is not null && currentRight!.Value.Next is not null)
            {
                currentLeft = left.GetNext();
                currentRight = right.GetNext();
            }
        }, cancellationToken);

        // If there is an unequal amount of nodes, the number with more nodes is larger.
        if (currentLeft is not null && currentRight is null)
            return 1;
        if (currentLeft is null && currentRight is not null)
            return -1;

        // If the tail component is unequal, we already know which number is larger.
        var lastComparison = currentLeft!.Value.Value.CompareTo(currentRight!.Value.Value);
        if (lastComparison != 0)
            return lastComparison;

        // Go back to the first node until there is an inequality.
        NumberSequenceNode? previousLeft = currentLeft!.Value.GetPrevious();
        NumberSequenceNode? previousRight = currentRight!.Value.GetPrevious();
        var aggregateComparison = await Task.Run(() =>
        {
            while (previousLeft.HasValue && previousRight.HasValue)
            {
                previousLeft = previousLeft!.Value.GetPrevious();
                previousRight = previousRight!.Value.GetPrevious();
                var comparison = previousLeft!.Value.Value.CompareTo(previousRight!.Value.Value);
                if (comparison != 0)
                    return comparison;
            }
            // The numbers are equal.
            return 0;
        }, cancellationToken);

        return aggregateComparison;
    }

    internal static int IntegerCompare(
        NumberSequenceNode left,
        bool leftIsNegative,
        NumberSequenceNode right,
        bool rightIsNegative)
        => CompareAsync(left, leftIsNegative, right, rightIsNegative)
            .ConfigureAwait(false)
            .GetAwaiter()
            .GetResult();

}
