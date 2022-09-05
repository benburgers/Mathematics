/*
 * Ben Burgers Mathematics
 * © 2022 Ben Burgers and contributors
 * Licensed under AGPL 3.0
 */

using BenBurgers.Mathematics.Numbers.Arithmetic;
using BenBurgers.Mathematics.Numbers.Arithmetic.Additions;
using BenBurgers.Mathematics.Numbers.Arithmetic.Subtractions;

namespace BenBurgers.Mathematics.Numbers.Real.Rational.Integer;

public partial struct IntegerNumber
{
    /// <summary>
    /// Subtracts one from <paramref name="integerNumber" />.
    /// </summary>
    /// <param name="integerNumber">
    /// The integer number.
    /// </param>
    /// <returns>
    /// The <paramref name="integerNumber" />, minus one.
    /// </returns>
    public static IntegerNumber operator --(IntegerNumber integerNumber)
        => new Subtraction<IntegerNumber, IntegerNumber>(integerNumber, (IntegerNumber)1)
            .Evaluate<IntegerNumber>(ArithmeticOptions.Default);

    /// <summary>
    /// Adds one to <paramref name="integerNumber" />.
    /// </summary>
    /// <param name="integerNumber">
    /// The integer number.
    /// </param>
    /// <returns>
    /// The <paramref name="integerNumber" />, plus one.
    /// </returns>
    public static IntegerNumber operator ++(IntegerNumber integerNumber)
        => new Addition<IntegerNumber, IntegerNumber>(integerNumber, (IntegerNumber)1)
            .Evaluate<IntegerNumber>(ArithmeticOptions.Default);
}