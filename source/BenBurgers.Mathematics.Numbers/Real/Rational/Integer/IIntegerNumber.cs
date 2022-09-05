/*
 * Ben Burgers Mathematics
 * © 2022 Ben Burgers and contributors
 * Licensed under AGPL 3.0
 */

using BenBurgers.Mathematics.Numbers.Sequence;

namespace BenBurgers.Mathematics.Numbers.Real.Rational.Integer;

/// <summary>
/// Represents an integer number.
/// </summary>
public interface IIntegerNumber
    : IRationalNumber,
    IComparable<IIntegerNumber>,
    IEquatable<IIntegerNumber>
{
    /// <summary>
    /// Gets the binary number sequence.
    /// </summary>
    internal NumberSequence Sequence { get; }

    /// <summary>
    /// Gets a value that indicates whether the integer number is even.
    /// </summary>
    bool IsEven { get; }
}

/// <summary>
/// Represents an integer number.
/// </summary>
/// <typeparam name="TIntegerNumber">The type of integer number.</typeparam>
public interface IIntegerNumber<TIntegerNumber>
    : IIntegerNumber,
    IRationalNumber<TIntegerNumber>
    where TIntegerNumber : IIntegerNumber<TIntegerNumber>
{
}