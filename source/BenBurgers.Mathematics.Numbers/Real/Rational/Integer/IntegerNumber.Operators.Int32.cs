/*
 * Ben Burgers Mathematics
 * © 2022-2023 Ben Burgers and contributors
 * Licensed under AGPL 3.0
 */

namespace BenBurgers.Mathematics.Numbers.Real.Rational.Integer;

/*
 * Although primitive number types can be cast to managed number types,
 * it will be more efficient to treat them directly.
 * For instance, a primitive number type has a fixed length, so whenever a managed type is longer,
 * conclusions can already be drawn.
 */
public partial struct IntegerNumber
{
    /// <summary>
    /// Determines whether <paramref name="left" /> and <paramref name="right" /> are equal.
    /// </summary>
    /// <param name="left">The left number to compare.</param>
    /// <param name="right">The right number to compare.</param>
    /// <returns>
    /// A <see cref="bool" /> value that indicates whether the numbers are equal.
    /// </returns>
    public static bool operator ==(IntegerNumber left, int right)
        => left.Equals(right);

    /// <summary>
    /// Determines whether <paramref name="left" /> and <paramref name="right" /> are equal.
    /// </summary>
    /// <param name="left">The left number to compare.</param>
    /// <param name="right">The right number to compare.</param>
    /// <returns>
    /// A <see cref="bool" /> value that indicates whether the numbers are equal.
    /// </returns>
    public static bool operator ==(int left, IntegerNumber right)
        => right.Equals(left);

    /// <summary>
    /// Determines whether <paramref name="left" /> and <paramref name="right" /> are not equal.
    /// </summary>
    /// <param name="left">The left number to compare.</param>
    /// <param name="right">The right number to compare.</param>
    /// <returns>
    /// A <see cref="bool" /> value that indicates whether the numbers are not equal.
    /// </returns>
    public static bool operator !=(IntegerNumber left, int right)
        => !left.Equals(right);

    /// <summary>
    /// Determines whether <paramref name="left" /> and <paramref name="right" /> are not equal.
    /// </summary>
    /// <param name="left">The left number to compare.</param>
    /// <param name="right">The right number to compare.</param>
    /// <returns>
    /// A <see cref="bool" /> value that indicates whether the numbers are not equal.
    /// </returns>
    public static bool operator !=(int left, IntegerNumber right)
        => !right.Equals(left);

    /// <summary>
    /// Determines whether <paramref name="left" /> is smaller than or equal to <paramref name="right" />.
    /// </summary>
    /// <param name="left">The left number to compare.</param>
    /// <param name="right">The right number to compare.</param>
    /// <returns>
    /// A <see cref="bool" /> value that indicates whether <paramref name="left" /> is smaller than or equal to <paramref name="right" />.
    /// </returns>
    public static bool operator <=(IntegerNumber left, int right)
        => left.CompareTo(right) <= 0;

    /// <summary>
    /// Determines whether <paramref name="left" /> is smaller than or equal to <paramref name="right" />.
    /// </summary>
    /// <param name="left">The left number to compare.</param>
    /// <param name="right">The right number to compare.</param>
    /// <returns>
    /// A <see cref="bool" /> value that indicates whether <paramref name="left" /> is smaller than or equal to <paramref name="right" />.
    /// </returns>
    public static bool operator <=(int left, IntegerNumber right)
        => right.CompareTo(left) >= 0;

    /// <summary>
    /// Determines whether <paramref name="left" /> is greater than or equal to <paramref name="right" />.
    /// </summary>
    /// <param name="left">The left number to compare.</param>
    /// <param name="right">The right number to compare.</param>
    /// <returns>
    /// A <see cref="bool" /> value that indicates whether <paramref name="left" /> is greater than or equal to <paramref name="right" />.
    /// </returns>
    public static bool operator >=(IntegerNumber left, int right)
        => left.CompareTo(right) >= 0;

    /// <summary>
    /// Determines whether <paramref name="left" /> is greather than or equal to <paramref name="right" />.
    /// </summary>
    /// <param name="left">The left number to compare.</param>
    /// <param name="right">The right number to compare.</param>
    /// <returns>
    /// A <see cref="bool" /> value that indicates whether <paramref name="left" /> is greater than or equal to <paramref name="right" />.
    /// </returns>
    public static bool operator >=(int left, IntegerNumber right)
        => right.CompareTo(left) <= 0;

    /// <summary>
    /// Determines whether <paramref name="left" /> is smaller than <paramref name="right" />.
    /// </summary>
    /// <param name="left">The left number to compare.</param>
    /// <param name="right">The right number to compare.</param>
    /// <returns>
    /// A <see cref="bool" /> value that indicates whether <paramref name="left" /> is smaller than <paramref name="right" />.
    /// </returns>
    public static bool operator <(IntegerNumber left, int right)
        => left.CompareTo(right) < 0;

    /// <summary>
    /// Determines whether <paramref name="left" /> is smaller than <paramref name="right" />.
    /// </summary>
    /// <param name="left">The left number to compare.</param>
    /// <param name="right">The right number to compare.</param>
    /// <returns>
    /// A <see cref="bool" /> value that indicates whether <paramref name="left" /> is smaller than <paramref name="right" />.
    /// </returns>
    public static bool operator <(int left, IntegerNumber right)
        => right.CompareTo(left) > 0;

    /// <summary>
    /// Determines whether <paramref name="left" /> is greater than <paramref name="right" />.
    /// </summary>
    /// <param name="left">The left number to compare.</param>
    /// <param name="right">The right number to compare.</param>
    /// <returns>
    /// A <see cref="bool" /> value that indicates whether <paramref name="left" /> is greater than <paramref name="right" />.
    /// </returns>
    public static bool operator >(IntegerNumber left, int right)
        => left.CompareTo(right) > 0;

    /// <summary>
    /// Determines whether <paramref name="left" /> is greater than <paramref name="right" />.
    /// </summary>
    /// <param name="left">The left number to compare.</param>
    /// <param name="right">The right number to compare.</param>
    /// <returns>
    /// A <see cref="bool" /> value that indicates whether <paramref name="left" /> is greater than <paramref name="right" />.
    /// </returns>
    public static bool operator >(int left, IntegerNumber right)
        => right.CompareTo(left) < 0;
}