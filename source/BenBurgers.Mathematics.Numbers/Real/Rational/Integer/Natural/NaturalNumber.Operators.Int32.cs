/*
 * Ben Burgers Mathematics
 * © 2022 Ben Burgers and contributors
 * Licensed under AGPL 3.0
 */

using BenBurgers.Mathematics.Numbers.Arithmetic.Additions;
using BenBurgers.Mathematics.Numbers.Arithmetic.Divisions;
using BenBurgers.Mathematics.Numbers.Arithmetic.Moduli;
using BenBurgers.Mathematics.Numbers.Arithmetic.Multiplications;
using BenBurgers.Mathematics.Numbers.Arithmetic.Subtractions;

namespace BenBurgers.Mathematics.Numbers.Real.Rational.Integer.Natural;

public partial struct NaturalNumber
{
    /// <summary>
    /// Determines whether <paramref name="left" /> is equal to <paramref name="right" />.
    /// </summary>
    /// <param name="left">
    /// The left argument to compare.
    /// </param>
    /// <param name="right">
    /// The right argument to compare.
    /// </param>
    /// <returns>
    /// A <see cref="bool" /> value that indicates whether <paramref name="left" /> is equal to <paramref name="right" />.
    /// </returns>
    public static bool operator ==(NaturalNumber left, int right)
    {
        if (right < 0) // not a natural number
            return false;
        return left.CompareTo(right) == 0;
    }

    /// <summary>
    /// Determines whether <paramref name="left" /> is equal to <paramref name="right" />.
    /// </summary>
    /// <param name="left">
    /// The left argument to compare.
    /// </param>
    /// <param name="right">
    /// The right argument to compare.
    /// </param>
    /// <returns>
    /// A <see cref="bool" /> value that indicates whether <paramref name="left" /> is equal to <paramref name="right" />. 
    /// </returns>
    public static bool operator ==(int left, NaturalNumber right)
    {
        if (left < 0) // not a natural number
            return false;
        return right.CompareTo(left) == 0;
    }

    /// <summary>
    /// Determines whether <paramref name="left" /> is not equal to <paramref name="right" />.
    /// </summary>
    /// <param name="left">
    /// The left argument to compare.
    /// </param>
    /// <param name="right">
    /// The right argument to compare.
    /// </param>
    /// <returns>
    /// A <see cref="bool" /> value that indicates whether <paramref name="left" /> is not equal to <paramref name="right" />.
    /// </returns>
    public static bool operator !=(NaturalNumber left, int right)
    {
        if (right < 0) // not a natural number
            return true;
        return left.CompareTo(right) != 0;
    }

    /// <summary>
    /// Determines whether <paramref name="left" /> is not equal to <paramref name="right" />.
    /// </summary>
    /// <param name="left">
    /// The left argument to compare.
    /// </param>
    /// <param name="right">
    /// The right argument to compare.
    /// </param>
    /// <returns>
    /// A <see cref="bool" /> value that indicates whether <paramref name="left" /> is not equal to <paramref name="right" />.
    /// </returns>
    public static bool operator !=(int left, NaturalNumber right)
    {
        if (left < 0) // not a natural number
            return true;
        return right.CompareTo(left) != 0;
    }

    /// <summary>
    /// Determines whether <paramref name="left" /> is smaller than or equal to <paramref name="right" />.
    /// </summary>
    /// <param name="left">
    /// The left argument to compare.
    /// </param>
    /// <param name="right">
    /// The right argument to compare.
    /// </param>
    /// <returns>
    /// A <see cref="bool" /> that indicates whether <paramref name="left" /> is smaller than or equal to <paramref name="right" />.
    /// </returns>
    public static bool operator <=(NaturalNumber left, int right)
    {
        if (right < 0) // natural number is always positive
            return false;
        return left.CompareTo(right) <= 0;
    }

    /// <summary>
    /// Determines whether <paramref name="left" /> is smaller than or equal to <paramref name="right" />.
    /// </summary>
    /// <param name="left">
    /// The left argument to compare.
    /// </param>
    /// <param name="right">
    /// The right argument to compare.
    /// </param>
    /// <returns>
    /// A <see cref="bool" /> that indicates whether <paramref name="left" /> is smaller than or equal to <paramref name="right" />.
    /// </returns>
    public static bool operator <=(int left, NaturalNumber right)
    {
        if (left < 0) // natural number is always positive
            return true;
        return right.CompareTo(left) >= 0;
    }

    /// <summary>
    /// Determines whether <paramref name="left" /> is smaller than <paramref name="right" />.
    /// </summary>
    /// <param name="left">
    /// The left argument to compare.
    /// </param>
    /// <param name="right">
    /// The right argument to compare.
    /// </param>
    /// <returns>
    /// A <see cref="bool" /> that indicates whether <paramref name="left" /> is smaller than <paramref name="right" />.
    /// </returns>
    public static bool operator <(NaturalNumber left, int right)
    {
        if (right < 0) // natural number is always positive
            return false;
        return left.CompareTo(right) < 0;
    }

    /// <summary>
    /// Determines whether <paramref name="left" /> is smaller than <paramref name="right" />.
    /// </summary>
    /// <param name="left">
    /// The left argument to compare.
    /// </param>
    /// <param name="right">
    /// The right argument to compare.
    /// </param>
    /// <returns>
    /// A <see cref="bool" /> that indicates whether <paramref name="left" /> is smaller than <paramref name="right" />.
    /// </returns>
    public static bool operator <(int left, NaturalNumber right)
    {
        if (left < 0) // natural number is always positive
            return true;
        return right.CompareTo(left) > 0;
    }

    /// <summary>
    /// Determines whether <paramref name="left" /> is greater than or equal to <paramref name="right" />.
    /// </summary>
    /// <param name="left">
    /// The left argument to compare.
    /// </param>
    /// <param name="right">
    /// The right argument to compare.
    /// </param>
    /// <returns>
    /// A <see cref="bool" /> that indicates whether <paramref name="left" /> is greater than or equal to <paramref name="right" />.
    /// </returns>
    public static bool operator >=(NaturalNumber left, int right)
    {
        if (right < 0) // natural number is always positive
            return true;
        return left.CompareTo(right) >= 0;
    }

    /// <summary>
    /// Determines whether <paramref name="left" /> is greater than or equal to <paramref name="right" />.
    /// </summary>
    /// <param name="left">
    /// The left argument to compare.
    /// </param>
    /// <param name="right">
    /// The right argument to compare.
    /// </param>
    /// <returns>
    /// A <see cref="bool" /> that indicates whether <paramref name="left" /> is greater than or equal to <paramref name="right" />.
    /// </returns>
    public static bool operator >=(int left, NaturalNumber right)
    {
        if (left < 0) // natural number is always positive
            return false;
        return right.CompareTo(left) <= 0;
    }

    /// <summary>
    /// Determines whether <paramref name="left" /> is greater than <paramref name="right" />.
    /// </summary>
    /// <param name="left">
    /// The left argument to compare.
    /// </param>
    /// <param name="right">
    /// The right argument to compare.
    /// </param>
    /// <returns>
    /// A <see cref="bool" /> that indicates whether <paramref name="left" /> is greater than <paramref name="right" />.
    /// </returns>
    public static bool operator >(NaturalNumber left, int right)
    {
        if (right < 0) // natural number is always positive
            return true;
        return left.CompareTo(right) > 0;
    }

    /// <summary>
    /// Determines whether <paramref name="left" /> is greater than <paramref name="right" />.
    /// </summary>
    /// <param name="left">
    /// The left argument to compare.
    /// </param>
    /// <param name="right">
    /// The right argument to compare.
    /// </param>
    /// <returns>
    /// A <see cref="bool" /> that indicates whether <paramref name="left" /> is greater than <paramref name="right" />.
    /// </returns>
    public static bool operator >(int left, NaturalNumber right)
    {
        if (left < 0) // natural number is always positive
            return false;
        return right.CompareTo(left) < 0;
    }

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
    /// The arithmetic operation for addition.
    /// </returns>
    public static Addition<NaturalNumber, IntegerNumber> operator +(NaturalNumber left, int right)
        => new(left, (IntegerNumber)right);

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
    /// The arithmetic operation for addition.
    /// </returns>
    public static Addition<IntegerNumber, NaturalNumber> operator +(int left, NaturalNumber right)
        => new((IntegerNumber)left, right);

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
    /// The arithmetic operation for subtraction.
    /// </returns>
    public static Subtraction<NaturalNumber, IntegerNumber> operator -(NaturalNumber left, int right)
        => new(left, (IntegerNumber)right);

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
    /// The arithmetic operation for subtraction.
    /// </returns>
    public static Subtraction<IntegerNumber, NaturalNumber> operator -(int left, NaturalNumber right)
        => new((IntegerNumber)left, right);

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
    /// The arithmetic operation for multiplication.
    /// </returns>
    public static Multiplication<NaturalNumber, IntegerNumber> operator *(NaturalNumber left, int right)
        => new(left, (IntegerNumber)right);

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
    /// The arithmetic operation for multiplication.
    /// </returns>
    public static Multiplication<IntegerNumber, NaturalNumber> operator *(int left, NaturalNumber right)
        => new((IntegerNumber)left, right);

    /// <summary>
    /// Divides <paramref name="left" /> by <paramref name="right" />.
    /// </summary>
    /// <param name="left">
    /// The number to divide.
    /// </param>
    /// <param name="right">
    /// The number to divide <paramref name="left" /> by.
    /// </param>
    /// <returns>
    /// The arithmetic operation for division.
    /// </returns>
    public static Division<NaturalNumber, IntegerNumber> operator /(NaturalNumber left, int right)
        => new(left, (IntegerNumber)right);

    /// <summary>
    /// Divides <paramref name="left" /> by <paramref name="right" />.
    /// </summary>
    /// <param name="left">
    /// The number to divide.
    /// </param>
    /// <param name="right">
    /// The number to divide <paramref name="left" /> by.
    /// </param>
    /// <returns>
    /// The arithmetic operation for division.
    /// </returns>
    public static Division<IntegerNumber, NaturalNumber> operator /(int left, NaturalNumber right)
        => new((IntegerNumber)left, right);

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
    /// The arithmetic operation for modulus.
    /// </returns>
    public static Modulus<NaturalNumber, IntegerNumber> operator %(NaturalNumber left, int right)
        => new(left, (IntegerNumber)right);

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
    /// The arithmetic operation for modulus.
    /// </returns>
    public static Modulus<IntegerNumber, NaturalNumber> operator %(int left, NaturalNumber right)
        => new((IntegerNumber)left, right);
}