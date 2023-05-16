/*
 * Ben Burgers Mathematics
 * © 2022-2023 Ben Burgers and contributors
 * Licensed under AGPL 3.0
 */

using System.Diagnostics.CodeAnalysis;

namespace BenBurgers.Mathematics.Numbers.Sequence;

internal readonly partial struct NumberSequenceNode
    : IEquatable<NumberSequenceNode>
{
    /// <inheritdoc />
    public override bool Equals([NotNullWhen(true)] object? obj)
    {
        return obj switch
        {
            null => false,
            NumberSequenceNode node => this.Equals(node, false),
            _ => false
        };
    }

    /// <inheritdoc />
    public bool Equals(NumberSequenceNode other)
    {
        return this.Equals(other, false);
    }

    /// <summary>
    /// Indicates whether this instance and the specified <paramref name="other" /> are equal.
    /// If <paramref name="valueOnly" /> is <see langword="true" />, only the values are compared.
    /// </summary>
    /// <param name="other">
    /// The other node to compare.
    /// </param>
    /// <param name="valueOnly">
    /// Indicates whether only the value is compared.
    /// </param>
    /// <returns>
    /// <see langword="true" /> if the nodes are equal.
    /// </returns>
    public bool Equals([NotNullWhen(true)] NumberSequenceNode? other, bool valueOnly = false)
    {
        if (other is not { } otherNode)
            return false;
        if (valueOnly)
            return this.Value.Equals(otherNode.Value);

        NumberSequenceNode? currentLeft = this;
        NumberSequenceNode? currentRight = other;
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
    public override int GetHashCode()
    {
        var hash = new HashCode();
        NumberSequenceNode? current = this;
        while (current is { } currentNode)
        {
            hash.Add(currentNode.Value);
            current = currentNode.GetNext();
        }
        return hash.ToHashCode();
    }
}