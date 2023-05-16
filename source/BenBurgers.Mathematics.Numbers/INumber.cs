/*
 * Ben Burgers Mathematics
 * © 2022-2023 Ben Burgers and contributors
 * Licensed under AGPL 3.0
 */

namespace BenBurgers.Mathematics.Numbers;

/// <summary>
/// Represents a number.
/// </summary>
public interface INumber
    : IComparable,
    IComparable<byte>,
    IComparable<sbyte>,
    IComparable<ushort>,
    IComparable<short>,
    IComparable<uint>,
    IComparable<int>,
    IComparable<ulong>,
    IComparable<long>,
    IComparable<float>,
    IComparable<double>,
    IComparable<decimal>,
    IEquatable<byte>,
    IEquatable<sbyte>,
    IEquatable<ushort>,
    IEquatable<short>,
    IEquatable<uint>,
    IEquatable<int>,
    IEquatable<ulong>,
    IEquatable<long>,
    IEquatable<float>,
    IEquatable<double>,
    IEquatable<decimal>
{
    /// <summary>
    /// Gets a value that indicates whether the number is negative.
    /// </summary>
    bool IsNegative { get; }

    /// <summary>
    /// Gets a value that indicates whether the number is a zero value.
    /// </summary>
    bool IsZero { get; }

    /// <summary>
    /// Gets the class of numbers the number belongs to.
    /// </summary>
    NumberClass NumberClass { get; }
}

/// <summary>
/// Represents a number.
/// </summary>
/// <typeparam name="TNumber">
/// The type of the number.
/// </typeparam>
public interface INumber<TNumber>
    : INumber
    where TNumber : INumber<TNumber>
{
}