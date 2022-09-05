/*
 * Ben Burgers Mathematics
 * © 2022 Ben Burgers and contributors
 * Licensed under AGPL 3.0
 */

using BenBurgers.Mathematics.Numbers.Real.Rational;
using BenBurgers.Mathematics.Numbers.Real.Rational.Integer;
using BenBurgers.Mathematics.Numbers.Real.Rational.Integer.Natural;
using BenBurgers.Mathematics.Numbers.Real.Rational.Integer.Natural.Prime;

namespace BenBurgers.Mathematics.Numbers.Arithmetic.Divisions;

public partial struct Division<TNumerator, TDenominator>
{
    /// <summary>
    /// Evaluates the division to a <see cref="byte" />.
    /// </summary>
    /// <param name="division">
    /// The division to evaluate.
    /// </param>
    /// <exception cref="NumberTooLargeException">
    /// A <see cref="NumberTooLargeException" /> is thrown if the result of the evaluation is too large.
    /// </exception>
    /// <exception cref="NumberTypeNotSupportedException">
    /// An <see cref="NumberTypeNotSupportedException" /> is thrown if the arithmetic operation is evaluated to an unsupported number type.
    /// </exception>
    /// <exception cref="ArithmeticTimeoutException">
    /// An <see cref="ArithmeticTimeoutException" /> is thrown if the evaluation has exceeded its time-out limit.
    /// </exception>
    public static explicit operator byte(Division<TNumerator, TDenominator> division)
        => division.Evaluate<byte>(ArithmeticOptions.Default);

    /// <summary>
    /// Evaluates the division to a <see cref="sbyte" />.
    /// </summary>
    /// <param name="division">
    /// The division to evaluate.
    /// </param>
    /// <exception cref="NumberTooLargeException">
    /// A <see cref="NumberTooLargeException" /> is thrown if the result of the evaluation is too large.
    /// </exception>
    /// <exception cref="NumberTypeNotSupportedException">
    /// An <see cref="NumberTypeNotSupportedException" /> is thrown if the arithmetic operation is evaluated to an unsupported number type.
    /// </exception>
    /// <exception cref="ArithmeticTimeoutException">
    /// An <see cref="ArithmeticTimeoutException" /> is thrown if the evaluation has exceeded its time-out limit.
    /// </exception>
    public static explicit operator sbyte(Division<TNumerator, TDenominator> division)
        => division.Evaluate<sbyte>(ArithmeticOptions.Default);

    /// <summary>
    /// Evaluates the division to a <see cref="ushort" />.
    /// </summary>
    /// <param name="division">
    /// The division to evaluate.
    /// </param>
    /// <exception cref="NumberTooLargeException">
    /// A <see cref="NumberTooLargeException" /> is thrown if the result of the evaluation is too large.
    /// </exception>
    /// <exception cref="NumberTypeNotSupportedException">
    /// An <see cref="NumberTypeNotSupportedException" /> is thrown if the arithmetic operation is evaluated to an unsupported number type.
    /// </exception>
    /// <exception cref="ArithmeticTimeoutException">
    /// An <see cref="ArithmeticTimeoutException" /> is thrown if the evaluation has exceeded its time-out limit.
    /// </exception>
    public static explicit operator ushort(Division<TNumerator, TDenominator> division)
        => division.Evaluate<ushort>(ArithmeticOptions.Default);

    /// <summary>
    /// Evaluates the division to a <see cref="short" />.
    /// </summary>
    /// <param name="division">
    /// The division to evaluate.
    /// </param>
    /// <exception cref="NumberTooLargeException">
    /// A <see cref="NumberTooLargeException" /> is thrown if the result of the evaluation is too large.
    /// </exception>
    /// <exception cref="NumberTypeNotSupportedException">
    /// An <see cref="NumberTypeNotSupportedException" /> is thrown if the arithmetic operation is evaluated to an unsupported number type.
    /// </exception>
    /// <exception cref="ArithmeticTimeoutException">
    /// An <see cref="ArithmeticTimeoutException" /> is thrown if the evaluation has exceeded its time-out limit.
    /// </exception>
    public static explicit operator short(Division<TNumerator, TDenominator> division)
        => division.Evaluate<short>(ArithmeticOptions.Default);

    /// <summary>
    /// Evaluates the division to a <see cref="uint" />.
    /// </summary>
    /// <param name="division">
    /// The division to evaluate.
    /// </param>
    /// <exception cref="NumberTooLargeException">
    /// A <see cref="NumberTooLargeException" /> is thrown if the result of the evaluation is too large.
    /// </exception>
    /// <exception cref="NumberTypeNotSupportedException">
    /// An <see cref="NumberTypeNotSupportedException" /> is thrown if the arithmetic operation is evaluated to an unsupported number type.
    /// </exception>
    /// <exception cref="ArithmeticTimeoutException">
    /// An <see cref="ArithmeticTimeoutException" /> is thrown if the evaluation has exceeded its time-out limit.
    /// </exception>
    public static explicit operator uint(Division<TNumerator, TDenominator> division)
        => division.Evaluate<uint>(ArithmeticOptions.Default);

    /// <summary>
    /// Evaluates the division to an <see cref="int" />.
    /// </summary>
    /// <param name="division">
    /// The division to evaluate.
    /// </param>
    /// <exception cref="NumberTooLargeException">
    /// A <see cref="NumberTooLargeException" /> is thrown if the result of the evaluation is too large.
    /// </exception>
    /// <exception cref="NumberTypeNotSupportedException">
    /// An <see cref="NumberTypeNotSupportedException" /> is thrown if the arithmetic operation is evaluated to an unsupported number type.
    /// </exception>
    /// <exception cref="ArithmeticTimeoutException">
    /// An <see cref="ArithmeticTimeoutException" /> is thrown if the evaluation has exceeded its time-out limit.
    /// </exception>
    public static explicit operator int(Division<TNumerator, TDenominator> division)
        => division.Evaluate<int>(ArithmeticOptions.Default);

    /// <summary>
    /// Evaluates the division to a <see cref="ulong" />.
    /// </summary>
    /// <param name="division">
    /// The division to evaluate.
    /// </param>
    /// <exception cref="NumberTooLargeException">
    /// A <see cref="NumberTooLargeException" /> is thrown if the result of the evaluation is too large.
    /// </exception>
    /// <exception cref="NumberTypeNotSupportedException">
    /// An <see cref="NumberTypeNotSupportedException" /> is thrown if the arithmetic operation is evaluated to an unsupported number type.
    /// </exception>
    /// <exception cref="ArithmeticTimeoutException">
    /// An <see cref="ArithmeticTimeoutException" /> is thrown if the evaluation has exceeded its time-out limit.
    /// </exception>
    public static explicit operator ulong(Division<TNumerator, TDenominator> division)
        => division.Evaluate<ulong>(ArithmeticOptions.Default);

    /// <summary>
    /// Evaluates the division to a <see cref="long" />.
    /// </summary>
    /// <param name="division">
    /// The division to evaluate.
    /// </param>
    /// <exception cref="NumberTooLargeException">
    /// A <see cref="NumberTooLargeException" /> is thrown if the result of the evaluation is too large.
    /// </exception>
    /// <exception cref="NumberTypeNotSupportedException">
    /// An <see cref="NumberTypeNotSupportedException" /> is thrown if the arithmetic operation is evaluated to an unsupported number type.
    /// </exception>
    /// <exception cref="ArithmeticTimeoutException">
    /// An <see cref="ArithmeticTimeoutException" /> is thrown if the evaluation has exceeded its time-out limit.
    /// </exception>
    public static explicit operator long(Division<TNumerator, TDenominator> division)
        => division.Evaluate<long>(ArithmeticOptions.Default);

    /// <summary>
    /// Evaluates the division to a <see cref="float" />.
    /// </summary>
    /// <param name="division">
    /// The division to evaluate.
    /// </param>
    /// <exception cref="NumberTooLargeException">
    /// A <see cref="NumberTooLargeException" /> is thrown if the result of the evaluation is too large.
    /// </exception>
    /// <exception cref="NumberTypeNotSupportedException">
    /// An <see cref="NumberTypeNotSupportedException" /> is thrown if the arithmetic operation is evaluated to an unsupported number type.
    /// </exception>
    /// <exception cref="ArithmeticTimeoutException">
    /// An <see cref="ArithmeticTimeoutException" /> is thrown if the evaluation has exceeded its time-out limit.
    /// </exception>
    public static explicit operator float(Division<TNumerator, TDenominator> division)
        => division.Evaluate<float>(ArithmeticOptions.Default);

    /// <summary>
    /// Evaluates the division to a <see cref="double" />.
    /// </summary>
    /// <param name="division">
    /// The division to evaluate.
    /// </param>
    /// <exception cref="NumberTooLargeException">
    /// A <see cref="NumberTooLargeException" /> is thrown if the result of the evaluation is too large.
    /// </exception>
    /// <exception cref="NumberTypeNotSupportedException">
    /// An <see cref="NumberTypeNotSupportedException" /> is thrown if the arithmetic operation is evaluated to an unsupported number type.
    /// </exception>
    /// <exception cref="ArithmeticTimeoutException">
    /// An <see cref="ArithmeticTimeoutException" /> is thrown if the evaluation has exceeded its time-out limit.
    /// </exception>
    public static explicit operator double(Division<TNumerator, TDenominator> division)
        => division.Evaluate<double>(ArithmeticOptions.Default);

    /// <summary>
    /// Evaluates the division to a <see cref="decimal" />.
    /// </summary>
    /// <param name="division">
    /// The division to evaluate.
    /// </param>
    /// <exception cref="NumberTooLargeException">
    /// A <see cref="NumberTooLargeException" /> is thrown if the result of the evaluation is too large.
    /// </exception>
    /// <exception cref="NumberTypeNotSupportedException">
    /// An <see cref="NumberTypeNotSupportedException" /> is thrown if the arithmetic operation is evaluated to an unsupported number type.
    /// </exception>
    /// <exception cref="ArithmeticTimeoutException">
    /// An <see cref="ArithmeticTimeoutException" /> is thrown if the evaluation has exceeded its time-out limit.
    /// </exception>
    public static explicit operator decimal(Division<TNumerator, TDenominator> division)
        => division.Evaluate<decimal>(ArithmeticOptions.Default);

    /// <summary>
    /// Evaluates the division to a <see cref="PrimeNumber" />.
    /// </summary>
    /// <param name="division">
    /// The division to evaluate.
    /// </param>
    /// <exception cref="ArithmeticTimeoutException">
    /// An <see cref="ArithmeticTimeoutException" /> is thrown if the evaluation has exceeded its time-out limit.
    /// </exception>
    /// <exception cref="NumberNotPrimeException">
    /// A <see cref="NumberNotPrimeException" /> is thrown if the evaluation is not a prime number.
    /// </exception>
    public static explicit operator PrimeNumber(Division<TNumerator, TDenominator> division)
        => division.Evaluate<PrimeNumber>(ArithmeticOptions.Default);

    /// <summary>
    /// Evaluates the division to a <see cref="NaturalNumber" />.
    /// </summary>
    /// <param name="division">
    /// The division to evaluate.
    /// </param>
    /// <exception cref="NumberNegativeException">
    /// A <see cref="NumberNegativeException" /> is thrown if the evaluated number is negative (natural numbers cannot be negative).
    /// </exception>
    public static explicit operator NaturalNumber(Division<TNumerator, TDenominator> division)
        => division.Evaluate<NaturalNumber>(ArithmeticOptions.Default);

    /// <summary>
    /// Evaluates the division to an <see cref="IntegerNumber" />.
    /// </summary>
    /// <param name="division">
    /// The division to evaluate.
    /// </param>
    public static explicit operator IntegerNumber(Division<TNumerator, TDenominator> division)
        => division.Evaluate<IntegerNumber>(ArithmeticOptions.Default);

    /// <summary>
    /// Converts the division to a fraction.
    /// </summary>
    /// <param name="division">
    /// The division to convert.
    /// </param>
    public static explicit operator Fraction<TNumerator, TDenominator>(Division<TNumerator, TDenominator> division)
        => new(division.Numerator, division.Denominator);
}