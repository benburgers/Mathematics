/*
 * Ben Burgers Mathematics
 * © 2022-2023 Ben Burgers and contributors
 * Licensed under AGPL 3.0
 */

namespace BenBurgers.Mathematics.Numbers.Sequence;

/// <summary>
/// A number sequence.
/// </summary>
internal partial class NumberSequence
{
    private bool isDisposed;

    /// <summary>
    /// Initializes a new instance of <see cref="NumberSequence" />.
    /// </summary>
    /// <param name="start">
    /// The start of the sequence.
    /// </param>
    /// <param name="end">
    /// The end of the sequence.
    /// </param>
    internal NumberSequence(IntPtr start, IntPtr end)
    {
        this.Start = start;
        this.End = end;
    }

    /// <summary>
    /// Destructs the current instance of <see cref="NumberSequence" />.
    /// </summary>
    ~NumberSequence()
    {
        this.Dispose();
    }

    internal IntPtr Start { get; }

    /// <summary>
    /// Gets the node at the start of the sequence.
    /// </summary>
    internal unsafe NumberSequenceNode StartNode => *(NumberSequenceNode*)this.Start.ToPointer();

    internal IntPtr End { get; }

    /// <summary>
    /// Gets the node at the end of the sequence.
    /// </summary>
    internal unsafe NumberSequenceNode EndNode => *(NumberSequenceNode*)this.End.ToPointer();

    /// <summary>
    /// Gets a value that indicates whether the sequence contains a single node.
    /// </summary>
    internal unsafe bool IsSingle =>
        this.Start == this.End
        || ((*(NumberSequenceNode*)this.Start.ToPointer()).Next
            == (*(NumberSequenceNode*)this.End.ToPointer()).Previous);
}