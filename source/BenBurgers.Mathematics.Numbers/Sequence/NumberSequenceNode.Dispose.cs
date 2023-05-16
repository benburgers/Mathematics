/*
 * Ben Burgers Mathematics
 * © 2022-2023 Ben Burgers and contributors
 * Licensed under AGPL 3.0
 */

using System.Runtime.InteropServices;

namespace BenBurgers.Mathematics.Numbers.Sequence;

internal readonly partial struct NumberSequenceNode
    : IDisposable
{
    /// <inheritdoc />
    public unsafe void Dispose()
    {
        NumberSequenceNode? current = this;
        while (current is { } currentNode)
        {
            var next = currentNode.GetNext();
            if (next is { Previous: { } previous })
            {
                Marshal.FreeHGlobal(previous);
            }
            current = next;
        }
        if (current is { } lastNode)
        {
            Marshal.FreeHGlobal(new IntPtr(&lastNode));
        }
    }
}