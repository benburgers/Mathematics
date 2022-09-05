/*
 * Ben Burgers Mathematics
 * © 2022 Ben Burgers and contributors
 * Licensed under AGPL 3.0
 */

namespace BenBurgers.Mathematics.Numbers.Sequence;

internal partial class NumberSequence : IDisposable
{
    /// <inheritdoc />
    public unsafe void Dispose()
    {
        if (this.isDisposed)
            return;
        var node = *(NumberSequenceNode*)this.Start.ToPointer();
        node.Dispose();
        this.isDisposed = true;
        GC.SuppressFinalize(this);
    }
}