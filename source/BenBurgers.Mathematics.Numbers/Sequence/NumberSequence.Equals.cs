/*
 * Ben Burgers Mathematics
 * © 2022 Ben Burgers and contributors
 * Licensed under AGPL 3.0
 */

using System.Diagnostics.CodeAnalysis;

namespace BenBurgers.Mathematics.Numbers.Sequence;

internal partial class NumberSequence : IEquatable<NumberSequence>
{
    /// <inheritdoc />
    public bool Equals([NotNullWhen(true)] NumberSequence? other)
    {
        if (other is not { } otherSequence)
            return false;
        if (ReferenceEquals(this, other))
            return true;

        NumberSequenceNode? currentLeft = this.StartNode;
        NumberSequenceNode? currentRight = other.StartNode;
        while (currentLeft is { } currentLeftNode && currentRight is { } currentRightNode)
        {
            if (!currentLeftNode.Value.Equals(currentRightNode.Value))
                return false;
            currentLeft = currentLeftNode.GetNext();
            currentRight = currentRightNode.GetNext();
        }
        if (currentLeft is null ^ currentRight is null)
            return false;

        return true;
    }

    /// <inheritdoc />
    public override bool Equals(object? obj)
    {
        return obj switch
        {
            null => false,
            NumberSequence sequence => this.Equals(sequence),
            _ => false
        };
    }

    /// <inheritdoc />
    public override int GetHashCode()
    {
        var hash = new HashCode();
        NumberSequenceNode? current = this.StartNode;
        while (current is { } currentNode)
        {
            hash.Add(currentNode.Value);
            current = currentNode.GetNext();
        }
        return hash.ToHashCode();
    }
}