/*
 * Ben Burgers Mathematics
 * © 2022 Ben Burgers and contributors
 * Licensed under AGPL 3.0
 */

namespace BenBurgers.Mathematics.Numbers.Sequence;

/// <summary>
/// A binary representation of a number, using the largest native unsigned integer number of the processor architecture as its components.
/// </summary>
internal readonly partial struct NumberSequenceNode
{
    /// <summary>
    /// Initializes a new instance of <see cref="NumberSequenceNode" />.
    /// </summary>
    /// <param name="value">The value of the current component of the binary representation.</param>
    /// <param name="next">The next component in the binary representation.</param>
    /// <param name="previous">The previous component in the binary representation.</param>
    internal NumberSequenceNode(nuint value, IntPtr? next, IntPtr? previous)
    {
        this.Value = value;
        this.Next = next;
        this.Previous = previous;
    }

    /// <summary>
    /// Initializes a new instance of <see cref="NumberSequenceNode" />.
    /// </summary>
    /// <param name="value">The value of the current component of the binary representation.</param>
    /// <param name="next">The next component in the binary representation.</param>
    internal NumberSequenceNode(nuint value, IntPtr? next)
        : this(value, next, null)
    {
    }

    /// <summary>
    /// Initializes a new instance of <see cref="NumberSequenceNode" />.
    /// </summary>
    /// <param name="value">The value of the current component of the binary representation.</param>
    internal NumberSequenceNode(nuint value)
        : this(value, null)
    {
    }

    /// <summary>
    /// Gets the value of this component of the binary representation.
    /// </summary>
    internal nuint Value { get; }

    /// <summary>
    /// Gets a pointer to the previous component of the binary representation.
    /// </summary>
    internal IntPtr? Previous { get; }

    /// <summary>
    /// Gets a pointer to the next component of the binary representation.
    /// </summary>
    internal IntPtr? Next { get; }

    /// <summary>
    /// Gets the previous component of the binary representation.
    /// </summary>
    /// <returns>The previous component of the binary representation.</returns>
    internal unsafe NumberSequenceNode? GetPrevious()
    {
        if (this.Previous is not null)
            return *(NumberSequenceNode*)this.Previous.Value.ToPointer();
        return null;
    }

    /// <summary>
    /// Gets the next component of the binary representation.
    /// </summary>
    /// <returns>The next component of the binary representation.</returns>
    internal unsafe NumberSequenceNode? GetNext()
    {
        if (this.Next is { } nextNode)
        {
            return *(NumberSequenceNode*)nextNode.ToPointer();
        }
        return null;
    }
}