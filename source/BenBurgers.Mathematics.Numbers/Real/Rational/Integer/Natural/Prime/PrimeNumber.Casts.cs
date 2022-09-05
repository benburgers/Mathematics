/*
 * Ben Burgers Mathematics
 * © 2022 Ben Burgers and contributors
 * Licensed under AGPL 3.0
 */

using BenBurgers.Mathematics.Numbers.Sequence;

namespace BenBurgers.Mathematics.Numbers.Real.Rational.Integer.Natural.Prime;

public partial struct PrimeNumber
{
    /// <summary>
    /// Casts a <see cref="PrimeNumber" /> <paramref name="prime" /> to an <see cref="uint" />.
    /// </summary>
    /// <param name="prime">
    /// The <see cref="PrimeNumber" /> to cast.
    /// </param>
    /// <exception cref="NumberTooLargeException">
    /// A <see cref="NumberTooLargeException" /> is thrown if the <paramref name="prime" /> does not fit in a <see langword="uint" />.
    /// </exception>
    public static explicit operator uint(PrimeNumber prime)
    {
        if (!prime.sequence.IsSingle || prime.sequence.StartNode.Value > uint.MaxValue)
            throw new NumberTooLargeException();
        return (uint)prime.sequence.StartNode.Value;
    }

    /// <summary>
    /// Casts a <see cref="PrimeNumber" /> <paramref name="prime" /> to a <see cref="NaturalNumber" />.
    /// </summary>
    /// <param name="prime">
    /// The <see cref="PrimeNumber" /> to cast.
    /// </param>
    public static explicit operator NaturalNumber(PrimeNumber prime)
        => new(prime.sequence);

    /// <summary>
    /// Casts a <see cref="PrimeNumber" /> <paramref name="prime" /> to an <see cref="IntegerNumber" />.
    /// </summary>
    /// <param name="prime">
    /// The <see cref="PrimeNumber" /> to cast.
    /// </param>
    public static explicit operator IntegerNumber(PrimeNumber prime)
        => new(prime.sequence, isNegative: false);

    /// <summary>
    /// Casts a <see langword="uint" /> <paramref name="number" /> to a <see cref="PrimeNumber" />.
    /// </summary>
    /// <param name="number">
    /// The <see langword="uint" /> to cast.
    /// </param>
    public static explicit operator PrimeNumber(uint number)
    {
        var nodePointer = NumberSequenceNode.AllocateAndInitialize(number);
        var sequence = new NumberSequence(nodePointer, nodePointer);
        return new(sequence);
    }

    /// <summary>
    /// Casts a <see cref="NaturalNumber" /> <paramref name="natural" /> to a <see cref="PrimeNumber" />.
    /// </summary>
    /// <param name="natural">
    /// The <see cref="NaturalNumber" /> to cast.
    /// </param>
    public static explicit operator PrimeNumber(NaturalNumber natural)
        => new(natural.sequence);

    /// <summary>
    /// Casts a <see cref="IntegerNumber" /> <paramref name="integer" /> to a <see cref="PrimeNumber" />.
    /// </summary>
    /// <param name="integer">
    /// The <see cref="IntegerNumber" /> to cast.
    /// </param>
    public static explicit operator PrimeNumber(IntegerNumber integer)
    {
        if (integer.IsNegative)
            throw new NumberNegativeException();
        return new PrimeNumber(integer.sequence);
    }
}