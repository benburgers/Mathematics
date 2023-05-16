/*
 * Ben Burgers Mathematics
 * © 2022-2023 Ben Burgers and contributors
 * Licensed under AGPL 3.0
 */

namespace BenBurgers.Mathematics.Numbers.Real.Irrational;

public partial struct Pi
{
    /// <summary>
    /// Always returns <c>false</c> because <see cref="Pi" /> is an irrational number.
    /// </summary>
    /// <param name="pi">Pi</param>
    /// <param name="right">The right number to compare.</param>
    /// <returns>
    /// Always <c>false</c>.
    /// </returns>
    public static bool operator ==(Pi pi, int right) => false;

    /// <summary>
    /// Always returns <c>false</c> because <see cref="Pi" /> is an irrational number.
    /// </summary>
    /// <param name="left">The left number to compare.</param>
    /// <param name="pi">Pi</param>
    /// <returns>
    /// Always <c>false</c>.
    /// </returns>
    public static bool operator ==(int left, Pi pi) => false;

    /// <summary>
    /// Always returns <c>true</c> because <see cref="Pi" /> is an irrational number.
    /// </summary>
    /// <param name="pi">Pi</param>
    /// <param name="right">The right number to compare.</param>
    /// <returns>
    /// Always <c>true</c>.
    /// </returns>
    public static bool operator !=(Pi pi, int right) => true;

    /// <summary>
    /// Always returns <c>true</c> because <see cref="Pi" /> is an irrational number.
    /// </summary>
    /// <param name="left">The left number to compare.</param>
    /// <param name="pi">Pi</param>
    /// <returns>
    /// Always <c>true</c>.
    /// </returns>
    public static bool operator !=(int left, Pi pi) => true;

    /// <summary>
    /// Determines whether <paramref name="pi" /> is smaller than or equal to <paramref name="right" />.
    /// </summary>
    /// <param name="pi">Pi</param>
    /// <param name="right">The right number to compare.</param>
    /// <returns>
    /// A <see cref="bool" /> value that indicates whether <paramref name="pi" /> is smaller than or equal to <paramref name="right" />.
    /// </returns>
    public static bool operator <=(Pi pi, int right)
        => pi.CompareTo(right) <= 0;

    /// <summary>
    /// Determines whether <paramref name="left" /> is smaller than or equal to <paramref name="pi" />.
    /// </summary>
    /// <param name="left">The left number to compare.</param>
    /// <param name="pi">Pi</param>
    /// <returns>
    /// A <see cref="bool" /> value that indicates whether <paramref name="left" /> is smaller than or equal to <paramref name="pi" />.
    /// </returns>
    public static bool operator <=(int left, Pi pi)
        => pi.CompareTo(left) >= 0;

    /// <summary>
    /// Determines whether <paramref name="pi" /> is greater than or equal to <paramref name="right" />.
    /// </summary>
    /// <param name="pi">Pi</param>
    /// <param name="right">The right number to compare.</param>
    /// <returns>
    /// A <see cref="bool" /> value that indicates whether <paramref name="right" /> is greater than or equal to <paramref name="right" />.
    /// </returns>
    public static bool operator >=(Pi pi, int right)
        => pi.CompareTo(right) >= 0;

    /// <summary>
    /// Determines whether <paramref name="left" /> is greater than or equal to <paramref name="pi" />.
    /// </summary>
    /// <param name="left">The left number to compare.</param>
    /// <param name="pi">Pi</param>
    /// <returns>
    /// A <see cref="bool" /> value that indicates whether <paramref name="left" /> is greater than or equal to <paramref name="pi" />.
    /// </returns>
    public static bool operator >=(int left, Pi pi)
        => pi.CompareTo(left) <= 0;

    /// <summary>
    /// Determines whether <paramref name="pi" /> is smaller than <paramref name="right" />.
    /// </summary>
    /// <param name="pi">Pi</param>
    /// <param name="right">The right number to compare.</param>
    /// <returns>
    /// A <see cref="bool" /> value that indicates whether <paramref name="pi" /> is smaller than <paramref name="right" />.
    /// </returns>
    public static bool operator <(Pi pi, int right)
        => pi.CompareTo(right) < 0;

    /// <summary>
    /// Determines whether <paramref name="left" /> is smaller than <paramref name="pi" />.
    /// </summary>
    /// <param name="left">The left number to compare.</param>
    /// <param name="pi">Pi</param>
    /// <returns>
    /// A <see cref="bool" /> value that indicates whether <paramref name="left" /> is smaller than <paramref name="pi" />.
    /// </returns>
    public static bool operator <(int left, Pi pi)
        => pi.CompareTo(left) > 0;

    /// <summary>
    /// Determines whether <paramref name="pi" /> is greater than <paramref name="right" />.
    /// </summary>
    /// <param name="pi">Pi</param>
    /// <param name="right">The right number to compare.</param>
    /// <returns>
    /// A <see cref="bool" /> value that indicates whether <paramref name="pi" /> is greater than <paramref name="right" />.
    /// </returns>
    public static bool operator >(Pi pi, int right)
        => pi.CompareTo(right) > 0;

    /// <summary>
    /// Determines whether <paramref name="left" /> is greater than <paramref name="pi" />.
    /// </summary>
    /// <param name="left">The left number to compare.</param>
    /// <param name="pi">Pi</param>
    /// <returns>
    /// A <see cref="bool" /> value that indicates whether <paramref name="left" /> is greater than <paramref name="pi" />.
    /// </returns>
    public static bool operator >(int left, Pi pi)
        => pi.CompareTo(left) < 0;
}