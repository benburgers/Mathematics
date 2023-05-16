/*
 * Ben Burgers Mathematics
 * © 2022-2023 Ben Burgers and contributors
 * Licensed under AGPL 3.0
 */

using BenBurgers.Mathematics.Numbers.Arithmetic.Additions;
using BenBurgers.Mathematics.Numbers.Arithmetic.Divisions;
using BenBurgers.Mathematics.Numbers.Arithmetic.Moduli;
using BenBurgers.Mathematics.Numbers.Arithmetic.Multiplications;
using BenBurgers.Mathematics.Numbers.Arithmetic.Subtractions;

namespace BenBurgers.Mathematics.Numbers.Real.Rational.Integer;

public partial struct IntegerNumber
{
    /// <summary>
    /// Determines whether <paramref name="left" /> and <paramref name="right" /> are equal.
    /// </summary>
    /// <param name="left">
    /// The left number to compare.
    /// </param>
    /// <param name="right">
    /// The right number to compare.
    /// </param>
    /// <returns>
    /// A <see cref="bool" /> that indicates whether the numbers are equal.
    /// </returns>
    public static bool operator ==(IntegerNumber left, IntegerNumber right)
        => left.Equals(right);

    /// <summary>
    /// Determines whether <paramref name="left" /> and <paramref name="right" /> are not equal.
    /// </summary>
    /// <param name="left">
    /// The left number to compare.
    /// </param>
    /// <param name="right">
    /// The right number to compare.
    /// </param>
    /// <returns>
    /// A <see cref="bool" /> that indicates whether the numbers are not equal.
    /// </returns>
    public static bool operator !=(IntegerNumber left, IntegerNumber right)
        => !left.Equals(right);

    /// <summary>
    /// Adds <paramref name="right" /> to <paramref name="left" />.
    /// </summary>
    /// <param name="left">
    /// The number to add to.
    /// </param>
    /// <param name="right">
    /// The number to add.
    /// </param>
    /// <returns>
    /// The addition arithmetic operation of <paramref name="left" /> and <paramref name="right" />.
    /// </returns>
    public static Addition<IntegerNumber, IntegerNumber> operator +(IntegerNumber left, IntegerNumber right)
        => new(left, right);

    /// <summary>
    /// Subtracts <paramref name="right" /> from <paramref name="left" />.
    /// </summary>
    /// <param name="left">
    /// The number to subtract from.
    /// </param>
    /// <param name="right">
    /// The number to subtract.
    /// </param>
    /// <returns>
    /// The subtraction arithmetic operation of <paramref name="left" /> and <paramref name="right" />.
    /// </returns>
    public static Subtraction<IntegerNumber, IntegerNumber> operator -(IntegerNumber left, IntegerNumber right)
        => new(left, right);

    /// <summary>
    /// Multiplies <paramref name="left" /> by <paramref name="right" />.
    /// </summary>
    /// <param name="left">
    /// The number to multiply.
    /// </param>
    /// <param name="right">
    /// The number to multiply by.
    /// </param>
    /// <returns>
    /// The multiplication arithmetic operation of <paramref name="left" /> and <paramref name="right" />.
    /// </returns>
    public static Multiplication<IntegerNumber, IntegerNumber> operator *(IntegerNumber left, IntegerNumber right)
        => new(left, right);

    /// <summary>
    /// Divides <paramref name="left" /> by <paramref name="right" />.
    /// </summary>
    /// <param name="left">
    /// The number to divide.
    /// </param>
    /// <param name="right">
    /// The number to divide by.
    /// </param>
    /// <returns>
    /// The division arithmetic operation of <paramref name="left" /> and <paramref name="right" />.
    /// </returns>
    public static Division<IntegerNumber, IntegerNumber> operator /(IntegerNumber left, IntegerNumber right)
        => new(left, right);

    /// <summary>
    /// Determines the modulus of <paramref name="left" /> and <paramref name="right" />.
    /// </summary>
    /// <param name="left">
    /// The dividend of the modulus.
    /// </param>
    /// <param name="right">
    /// The divisor of the modulus.
    /// </param>
    /// <returns>
    /// The modulus arithmetic operation of <paramref name="left" /> and <paramref name="right" />.
    /// </returns>
    public static Modulus<IntegerNumber, IntegerNumber> operator %(IntegerNumber left, IntegerNumber right)
        => new(left, right);
}
