/*
 * Ben Burgers Mathematics
 * © 2022 Ben Burgers and contributors
 * Licensed under AGPL 3.0
 */

using System.Buffers.Binary;
using System.Runtime.InteropServices;

namespace BenBurgers.Mathematics.Numbers.Sequence;

internal readonly partial struct NumberSequenceNode
{
    /// <summary>
    /// Allocates memory and initializes a new node with the specified value.
    /// </summary>
    /// <param name="value">
    /// The value of the node.
    /// </param>
    /// <returns>
    /// The pointer to the newly allocated node.
    /// </returns>
    internal static unsafe IntPtr AllocateAndInitialize(byte value)
    {
        var nodePointer = Marshal.AllocHGlobal(sizeof(NumberSequenceNode));
        *(NumberSequenceNode*)nodePointer.ToPointer() = new NumberSequenceNode(value);
        return nodePointer;
    }

    /// <summary>
    /// Allocates memory and initializes a new node with the specified value.
    /// </summary>
    /// <param name="value">
    /// The value of the node.
    /// </param>
    /// <returns>
    /// The pointer to the newly allocated node.
    /// </returns>
    internal static unsafe IntPtr AllocateAndInitialize(ushort value)
    {
        var nodePointer = Marshal.AllocHGlobal(sizeof(NumberSequenceNode));
        *(NumberSequenceNode*)nodePointer.ToPointer() = new NumberSequenceNode(value);
        return nodePointer;
    }

    /// <summary>
    /// Allocates memory and initializes a new node with the specified value.
    /// </summary>
    /// <param name="value">
    /// The value of the node.
    /// </param>
    /// <returns>
    /// The pointer to the newly allocated node.
    /// </returns>
    internal static unsafe IntPtr AllocateAndInitialize(uint value)
    {
        var nodePointer = Marshal.AllocHGlobal(sizeof(NumberSequenceNode));
        *(NumberSequenceNode*)nodePointer.ToPointer() = new NumberSequenceNode(value);
        return nodePointer;
    }

    /// <summary>
    /// Allocates memory and initializes a new node with the specified value.
    /// </summary>
    /// <param name="value">
    /// The value of the node.
    /// </param>
    /// <returns>
    /// The pointer to the newly allocated node.
    /// </returns>
    /// <exception cref="NumberTooLargeException">
    /// A <see cref="NumberTooLargeException" /> is thrown if the length of <see langword="ulong" /> is not supported.
    /// </exception>
    internal static unsafe IntPtr AllocateAndInitialize(ulong value)
    {
        switch (sizeof(nuint))
        {
            case sizeof(ulong):
                var node64Pointer = Marshal.AllocHGlobal(sizeof(NumberSequenceNode));
                *(NumberSequenceNode*)node64Pointer.ToPointer() = new NumberSequenceNode((nuint)value);
                return node64Pointer;
            case sizeof(uint):
                var numberLittleEndian = BitConverter.IsLittleEndian ? value : BinaryPrimitives.ReverseEndianness(value);
                var node32PointerLowerBound = Marshal.AllocHGlobal(sizeof(NumberSequenceNode));
                var node32PointerUpperBound = Marshal.AllocHGlobal(sizeof(NumberSequenceNode));
                var lowerBound = (uint)value;
                var upperBound = (uint)(value >> sizeof(uint) * 8);
                *(NumberSequenceNode*)node32PointerLowerBound.ToPointer() = new NumberSequenceNode(lowerBound, node32PointerUpperBound);
                *(NumberSequenceNode*)node32PointerUpperBound.ToPointer() = new NumberSequenceNode(upperBound, null, node32PointerLowerBound);
                return node32PointerLowerBound;
            default:
                throw new NumberBinaryConversionException();
        }
    }
}