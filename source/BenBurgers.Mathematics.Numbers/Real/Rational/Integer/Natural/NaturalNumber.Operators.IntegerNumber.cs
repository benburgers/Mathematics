/*
 * Ben Burgers Mathematics
 * © 2022-2023 Ben Burgers and contributors
 * Licensed under AGPL 3.0
 */

using BenBurgers.Mathematics.Numbers.Arithmetic.Moduli;

namespace BenBurgers.Mathematics.Numbers.Real.Rational.Integer.Natural;

public partial struct NaturalNumber
{
    /// <summary>
    /// Determines whether the natural number is less than or equal to the integer number.
    /// </summary>
    /// <param name="left">
    /// The left instance to compare.
    /// </param>
    /// <param name="right">
    /// The right instance to compare.
    /// </param>
    /// <returns>
    /// A value that indicates whether the natural number is less than or equal to the integer number.
    /// </returns>
    public static bool operator <=(NaturalNumber? left, IntegerNumber? right)
        => left is not null && left.Value.CompareTo(right) <= 0;

    /// <summary>
    /// Determines whether the natural number is greater than or equal to the integer number.
    /// </summary>
    /// <param name="left">
    /// The left instance to compare.
    /// </param>
    /// <param name="right">
    /// The right instance to compare.
    /// </param>
    /// <returns>
    /// A value that indicates whether the natural number is greater than or equal to the integer number.
    /// </returns>
    public static bool operator >=(NaturalNumber? left, IntegerNumber? right)
        => left is not null && left.Value.CompareTo(right) >= 0;

    /// <summary>
    /// Divides a <see cref="NaturalNumber" /> <paramref name="left" /> by an <see cref="IntegerNumber" /> <paramref name="right" />.
    /// </summary>
    /// <param name="left">
    /// The numerator.
    /// </param>
    /// <param name="right">
    /// The denominator.
    /// </param>
    /// <returns>
    /// A <see cref="Fraction{TNumerator, TDenominator}" />.
    /// </returns>
    /// <exception cref="DivideByZeroException">
    /// A <see cref="DivideByZeroException" /> is thrown if <paramref name="right" /> is zero.
    /// </exception>
    public static Fraction<NaturalNumber, IntegerNumber> operator /(NaturalNumber left, IntegerNumber right)
    {
        if (right.IsZero)
            throw new DivideByZeroException();
        return new Fraction<NaturalNumber, IntegerNumber>(left, right);
    }

    /// <summary>
    /// Divides an <see cref="IntegerNumber" /> <paramref name="left" /> by a <see cref="NaturalNumber" /> <paramref name="right" />.
    /// </summary>
    /// <param name="left">
    /// The numerator.
    /// </param>
    /// <param name="right">
    /// The denominator.
    /// </param>
    /// <returns>
    /// A <see cref="Fraction{TNumerator, TDenominator}" />.
    /// </returns>
    /// <exception cref="DivideByZeroException">
    /// A <see cref="DivideByZeroException" /> is thrown if <paramref name="right" /> is zero.
    /// </exception>
    public static Fraction<IntegerNumber, NaturalNumber> operator /(IntegerNumber left, NaturalNumber right)
    {
        if (right.IsZero)
            throw new DivideByZeroException();
        return new Fraction<IntegerNumber, NaturalNumber>(left, right);
    }

    /// <summary>
    /// Performs a modulus operation on a natural number and an integer number.
    /// </summary>
    /// <param name="left">
    /// The instance to divide.
    /// </param>
    /// <param name="right">
    /// The instance by which to divide.
    /// </param>
    /// <returns>
    /// The modulus operation.
    /// </returns>
    public static Modulus<NaturalNumber, IntegerNumber> operator %(NaturalNumber left, IntegerNumber right)
        => new(left, right);

    /// <summary>
    /// Performs a modulus operation on an integer number and a natural number.
    /// </summary>
    /// <param name="left">
    /// The instance to divide.
    /// </param>
    /// <param name="right">
    /// The instance by which to divide.
    /// </param>
    /// <returns>
    /// The modulus operation.
    /// </returns>
    public static Modulus<IntegerNumber, NaturalNumber> operator %(IntegerNumber left, NaturalNumber right)
        => new(left, right);
}
