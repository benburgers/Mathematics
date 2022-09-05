/*
 * Ben Burgers Mathematics
 * © 2022 Ben Burgers and contributors
 * Licensed under AGPL 3.0
 */

using BenBurgers.Mathematics.Numbers.Arithmetic;
using BenBurgers.Mathematics.Numbers.Arithmetic.Additions;
using BenBurgers.Mathematics.Numbers.Arithmetic.Subtractions;

namespace BenBurgers.Mathematics.Numbers.Real.Rational.Integer.Natural;

public partial struct NaturalNumber
{
    /// <summary>
    /// Subtracts one from <paramref name="naturalNumber" />.
    /// </summary>
    /// <param name="naturalNumber">
    /// The natural number 
    /// </param>
    /// <returns>
    /// The <paramref name="naturalNumber" />, minus one.
    /// </returns>
    public static NaturalNumber operator --(NaturalNumber naturalNumber)
        => new Subtraction<NaturalNumber, NaturalNumber>(naturalNumber, (NaturalNumber)1)
                .Evaluate<NaturalNumber>(ArithmeticOptions.Default);

    /// <summary>
    /// Adds one to <paramref name="naturalNumber" />.
    /// </summary>
    /// <param name="naturalNumber">
    /// The natural number.
    /// </param>
    /// <returns>
    /// The <paramref name="naturalNumber" />, plus one.
    /// </returns>
    public static NaturalNumber operator ++(NaturalNumber naturalNumber)
        => new Addition<NaturalNumber, NaturalNumber>(naturalNumber, (NaturalNumber)1)
                .Evaluate<NaturalNumber>(ArithmeticOptions.Default);
}