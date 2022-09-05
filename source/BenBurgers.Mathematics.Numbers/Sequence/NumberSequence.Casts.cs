/*
 * Ben Burgers Mathematics
 * © 2022 Ben Burgers and contributors
 * Licensed under AGPL 3.0
 */

using System.Runtime.InteropServices;

namespace BenBurgers.Mathematics.Numbers.Sequence;

internal partial class NumberSequence
{
    /// <summary>
    /// Converts an array of values to a number sequence.
    /// </summary>
    /// <param name="values">
    /// The values to cast.
    /// </param>
    public unsafe static explicit operator NumberSequence(nuint[] values)
    {
        // Initialize starting node with default values.
        var startPointer = Marshal.AllocHGlobal(sizeof(NumberSequenceNode));
        *(NumberSequenceNode*)startPointer = new NumberSequenceNode();

        IntPtr? currentPointer = startPointer;
        for (var i = 0; i < values.Length; ++i)
        {
            if (i == 0)
            {
                *(NumberSequenceNode*)currentPointer = new NumberSequenceNode(values[0]);
                continue;
            }

            // Assign next pointer of current node to the new node.
            var current = *(NumberSequenceNode*)currentPointer;
            var nextPointer = Marshal.AllocHGlobal(sizeof(NumberSequenceNode));
            *(NumberSequenceNode*)currentPointer = new NumberSequenceNode(current.Value, nextPointer, current.Previous);
            current = *(NumberSequenceNode*)currentPointer;

            // Initialize the new node.
            *(NumberSequenceNode*)nextPointer = new NumberSequenceNode(values[i], null, currentPointer);

            // Set current pointer to the next node.
            currentPointer = nextPointer;
        }

        return new(startPointer, currentPointer.Value);
    }

    /// <summary>
    /// Converts a <see cref="NumberSequence" /> <paramref name="value" /> to an array of <see langword="nuint" />.
    /// </summary>
    /// <param name="value">The value to convert.</param>
    public unsafe static explicit operator nuint[](NumberSequence value)
    {
        var result = new List<nuint>();
        NumberSequenceNode? current = value.StartNode;
        while (current is { } currentNode)
        {
            result.Add(currentNode.Value);
            current = currentNode.GetNext();
        }
        return result.ToArray();
    }
}