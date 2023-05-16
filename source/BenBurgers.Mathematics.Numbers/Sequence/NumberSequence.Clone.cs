/*
 * Ben Burgers Mathematics
 * © 2022-2023 Ben Burgers and contributors
 * Licensed under AGPL 3.0
 */

using System.Runtime.InteropServices;

namespace BenBurgers.Mathematics.Numbers.Sequence;

internal partial class NumberSequence : ICloneable
{
    /// <summary>
    /// Creates and returns an exact copy of the sequence.
    /// </summary>
    /// <returns>
    /// An exact copy of the sequence.
    /// </returns>
    public unsafe NumberSequence Clone()
    {
        var sequenceClonePointer = Marshal.AllocHGlobal(sizeof(NumberSequenceNode));
        var currentClonePointer = sequenceClonePointer;
        *(NumberSequenceNode*)currentClonePointer.ToPointer() = new NumberSequenceNode(this.StartNode.Value);
        NumberSequenceNode? nextOriginal = this.StartNode.GetNext();

        while (nextOriginal is { } nextOriginalNode)
        {
            var nextClonePointer = Marshal.AllocHGlobal(sizeof(NumberSequenceNode));

            // Update the 'next' pointer of the current cloned node to the node that is about to be created.
            var currentClone = *(NumberSequenceNode*)currentClonePointer.ToPointer();
            *(NumberSequenceNode*)currentClonePointer.ToPointer() = new NumberSequenceNode(currentClone.Value, nextClonePointer, currentClone.Previous);

            // Create the next cloned node.
            *(NumberSequenceNode*)nextClonePointer.ToPointer() = new NumberSequenceNode(nextOriginalNode.Value, null, currentClonePointer);

            // Move to next node.
            nextOriginal = nextOriginalNode.GetNext();
            currentClonePointer = nextClonePointer;
        }

        return new(sequenceClonePointer, currentClonePointer);
    }

    object ICloneable.Clone()
    {
        return this.Clone();
    }
}