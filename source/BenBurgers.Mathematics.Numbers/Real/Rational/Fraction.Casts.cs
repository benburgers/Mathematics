/*
 * Ben Burgers Mathematics
 * © 2022 Ben Burgers and contributors
 * Licensed under AGPL 3.0
 */

using BenBurgers.Mathematics.Numbers.Arithmetic;
using BenBurgers.Mathematics.Numbers.Arithmetic.Divisions;
using System.Numerics;

namespace BenBurgers.Mathematics.Numbers.Real.Rational;

public readonly partial struct Fraction<TNumerator, TDenominator>
{
    /// <summary>
    /// Calculates the value of the fraction and returns it as a <see cref="byte" />.
    /// </summary>
    /// <param name="fraction">
    /// The fraction to calculate.
    /// </param>
    public static explicit operator byte(Fraction<TNumerator, TDenominator> fraction)
        => new Division<TNumerator, TDenominator>(fraction.Numerator, fraction.Denominator).Evaluate<byte>(ArithmeticOptions.Default);

    /// <summary>
    /// Calculates the value of the fraction and returns it as a <see cref="sbyte" />.
    /// </summary>
    /// <param name="fraction">
    /// The fraction to calculate.
    /// </param>
    public static implicit operator sbyte(Fraction<TNumerator, TDenominator> fraction)
        => new Division<TNumerator, TDenominator>(fraction.Numerator, fraction.Denominator).Evaluate<sbyte>(ArithmeticOptions.Default);

    /// <summary>
    /// Calculates the value of the fraction and returns it as a <see cref="short" />.
    /// </summary>
    /// <param name="fraction">
    /// The fraction to calculate.
    /// </param>
    public static implicit operator short(Fraction<TNumerator, TDenominator> fraction)
        => new Division<TNumerator, TDenominator>(fraction.Numerator, fraction.Denominator).Evaluate<short>(ArithmeticOptions.Default);

    /// <summary>
    /// Calculates the value of the fraction and returns it as a <see cref="ushort" />.
    /// </summary>
    /// <param name="fraction">
    /// The fraction to calculate.
    /// </param>
    public static implicit operator ushort(Fraction<TNumerator, TDenominator> fraction)
        => new Division<TNumerator, TDenominator>(fraction.Numerator, fraction.Denominator).Evaluate<ushort>(ArithmeticOptions.Default);

    /// <summary>
    /// Calculates the value of the fraction and returns it as an <see cref="int" />.
    /// </summary>
    /// <param name="fraction">
    /// The fraction to calculate.
    /// </param>
    public static implicit operator int(Fraction<TNumerator, TDenominator> fraction)
        => new Division<TNumerator, TDenominator>(fraction.Numerator, fraction.Denominator).Evaluate<int>(ArithmeticOptions.Default);

    /// <summary>
    /// Calculates the value of the fraction and returns it as a <see cref="uint" />.
    /// </summary>
    /// <param name="fraction">
    /// The fraction to calculate.
    /// </param>
    public static implicit operator uint(Fraction<TNumerator, TDenominator> fraction)
        => new Division<TNumerator, TDenominator>(fraction.Numerator, fraction.Denominator).Evaluate<uint>(ArithmeticOptions.Default);

    /// <summary>
    /// Calculates the value of the fraction and returns it as a <see cref="long" />.
    /// </summary>
    /// <param name="fraction">
    /// The fraction to calculate.
    /// </param>
    public static implicit operator long(Fraction<TNumerator, TDenominator> fraction)
        => new Division<TNumerator, TDenominator>(fraction.Numerator, fraction.Denominator).Evaluate<long>(ArithmeticOptions.Default);

    /// <summary>
    /// Calculates the value of the fraction and returns it as a <see cref="ulong" />.
    /// </summary>
    /// <param name="fraction">
    /// The fraction to calculate.
    /// </param>
    public static implicit operator ulong(Fraction<TNumerator, TDenominator> fraction)
        => new Division<TNumerator, TDenominator>(fraction.Numerator, fraction.Denominator).Evaluate<ulong>(ArithmeticOptions.Default);

    /// <summary>
    /// Calculates the value of the fraction and returns it as a <see cref="BigInteger" />.
    /// </summary>
    /// <param name="fraction">
    /// The fraction to calculate.
    /// </param>
    public static implicit operator BigInteger(Fraction<TNumerator, TDenominator> fraction)
        => new Division<TNumerator, TDenominator>(fraction.Numerator, fraction.Denominator).Evaluate<BigInteger>(ArithmeticOptions.Default);

    /// <summary>
    /// Calculates the value of the fraction and returns it as a <see cref="float" />.
    /// </summary>
    /// <param name="fraction">
    /// The fraction to calculate.
    /// </param>
    public static implicit operator float(Fraction<TNumerator, TDenominator> fraction)
        => new Division<TNumerator, TDenominator>(fraction.Numerator, fraction.Denominator).Evaluate<float>(ArithmeticOptions.Default);

    /// <summary>
    /// Calculates the value of the fraction and returns it as a <see cref="double" />.
    /// </summary>
    /// <param name="fraction">
    /// The fraction to calculate.
    /// </param>
    public static implicit operator double(Fraction<TNumerator, TDenominator> fraction)
        => new Division<TNumerator, TDenominator>(fraction.Numerator, fraction.Denominator).Evaluate<double>(ArithmeticOptions.Default);

    /// <summary>
    /// Calculates the value of the fraction and returns it as a <see cref="decimal" />.
    /// </summary>
    /// <param name="fraction">
    /// The fraction to calculate.
    /// </param>
    public static implicit operator decimal(Fraction<TNumerator, TDenominator> fraction)
        => new Division<TNumerator, TDenominator>(fraction.Numerator, fraction.Denominator).Evaluate<decimal>(ArithmeticOptions.Default);
}
