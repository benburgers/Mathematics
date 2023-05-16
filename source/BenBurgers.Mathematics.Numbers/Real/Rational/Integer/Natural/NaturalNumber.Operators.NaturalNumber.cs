/*
 * Ben Burgers Mathematics
 * © 2022-2023 Ben Burgers and contributors
 * Licensed under AGPL 3.0
 */

using BenBurgers.Mathematics.Numbers.Arithmetic.Additions;
using BenBurgers.Mathematics.Numbers.Arithmetic.Moduli;
using BenBurgers.Mathematics.Numbers.Arithmetic.Multiplications;
using BenBurgers.Mathematics.Numbers.Arithmetic.Subtractions;

namespace BenBurgers.Mathematics.Numbers.Real.Rational.Integer.Natural;

public partial struct NaturalNumber
{
    /// <summary>
    /// Determines whether two natural numbers are equal.
    /// </summary>
    /// <param name="left">
    /// The left instance to compare.
    /// </param>
    /// <param name="right">
    /// The right instance to compare.
    /// </param>
    /// <returns>
    /// A <see cref="bool" /> that indicates whether the two natural numbers are equal.
    /// </returns>
    public static bool operator ==(NaturalNumber? left, NaturalNumber? right)
        => left is null ? right is null : left.Equals(right);

    /// <summary>
    /// Determines whether two natural numbers are not equal.
    /// </summary>
    /// <param name="left">
    /// The left instance to compare.
    /// </param>
    /// <param name="right">
    /// The right instance to compare.
    /// </param>
    /// <returns>
    /// A <see cref="bool" /> that indicates whether the two natural numbers are equal.
    /// </returns>
    public static bool operator !=(NaturalNumber? left, NaturalNumber? right)
        => left is null ? right is not null : !left.Equals(right);

    /// <summary>
    /// Determines whether the natural number is smaller than the other natural number.
    /// </summary>
    /// <param name="left">
    /// The left instance to compare.
    /// </param>
    /// <param name="right">
    /// The right instance to compare.
    /// </param>
    /// <returns>
    /// A <see cref="bool" /> that indicates whether the natural number is smaller than the other natural number.
    /// </returns>
    public static bool operator <(NaturalNumber? left, NaturalNumber? right)
        => left is not null && left.Value.CompareTo(right) < 0;

    /// <summary>
    /// Determines whether the natural number is smaller than or equal to the other natural number.
    /// </summary>
    /// <param name="left">
    /// The left instance to compare.
    /// </param>
    /// <param name="right">
    /// The right instance to compare.
    /// </param>
    /// <returns>
    /// A <see cref="bool" /> that indicates whether the natural number is smaller than or equal to the other natural number.
    /// </returns>
    public static bool operator <=(NaturalNumber? left, NaturalNumber? right)
        => left is not null && left.Value.CompareTo(right) <= 0;

    /// <summary>
    /// Determines whether the natural number is greater than the other natural number.
    /// </summary>
    /// <param name="left">
    /// The left instance to compare.
    /// </param>
    /// <param name="right">
    /// The right instance to compare.
    /// </param>
    /// <returns>
    /// A <see cref="bool" /> that indicates whether the natural number is greater than the other natural number.
    /// </returns>
    public static bool operator >(NaturalNumber? left, NaturalNumber? right)
        => left is not null && left.Value.CompareTo(right) > 0;

    /// <summary>
    /// Determines whether the natural number is greater than or equal to the other natural number.
    /// </summary>
    /// <param name="left">
    /// The left instance to compare.
    /// </param>
    /// <param name="right">
    /// The right instance to compare.
    /// </param>
    /// <returns>
    /// A <see cref="bool" /> that indicates whether the natural number is greater than or equal to the other natural number.
    /// </returns>
    public static bool operator >=(NaturalNumber? left, NaturalNumber? right)
        => left is not null && left.Value.CompareTo(right) >= 0;

    /// <summary>
    /// Adds two natural numbers.
    /// </summary>
    /// <param name="left">
    /// The operand to add to.
    /// </param>
    /// <param name="right">
    /// The operand to add.
    /// </param>
    /// <returns>
    /// The addition arithmetic operation.
    /// </returns>
    public static Addition<NaturalNumber, NaturalNumber> operator +(NaturalNumber left, NaturalNumber right)
        => new(left, right);

    /// <summary>
    /// Subtracts two natural numbers.
    /// </summary>
    /// <param name="left">
    /// The operand to subtract from.
    /// </param>
    /// <param name="right">
    /// The operand to subtract.
    /// </param>
    /// <returns>
    /// The subtraction arithmetic operation.
    /// </returns>
    public static Subtraction<NaturalNumber, NaturalNumber> operator -(NaturalNumber left, NaturalNumber right)
        => new(left, right);

    /// <summary>
    /// Multiplies two natural numbers.
    /// </summary>
    /// <param name="left">
    /// The instance to multiply.
    /// </param>
    /// <param name="right">
    /// The instance to multiply with.
    /// </param>
    /// <returns>
    /// The multiplication of the two natural numbers.
    /// </returns>
    public static Multiplication<NaturalNumber, NaturalNumber> operator *(NaturalNumber left, NaturalNumber right)
        => new(left, right);

    /// <summary>
    /// Divides a <see cref="NaturalNumber" /> <paramref name="left" /> by a <see cref="NaturalNumber" /> <paramref name="right" />.
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
    public static Fraction<NaturalNumber, NaturalNumber> operator /(NaturalNumber left, NaturalNumber right)
    {
        if (right.IsZero)
            throw new DivideByZeroException();
        return new Fraction<NaturalNumber, NaturalNumber>(left, right);
    }

    /// <summary>
    /// Performs a modulus operation on two natural numbers.
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
    /// <exception cref="NumbersException">
    /// A <see cref="NumbersException" /> is thrown if the modulo operation encountered an unexpected error.
    /// </exception>
    public static Modulus<NaturalNumber, NaturalNumber> operator %(NaturalNumber left, NaturalNumber right)
        => new(left, right);
}
