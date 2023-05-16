/*
 * Ben Burgers Mathematics
 * © 2022-2023 Ben Burgers and contributors
 * Licensed under AGPL 3.0
 */

using BenBurgers.Mathematics.Numbers.Real.Rational.Integer.Natural;

namespace BenBurgers.Mathematics.Numbers.Arithmetic.Moduli;

public partial struct Modulus<TDividend, TDivisor>
{
    /// <summary>
    /// Evaluates the result of the modulus operation and returns it as <see cref="uint" />.
    /// </summary>
    /// <param name="modulus">
    /// The modulus operation to evaluate.
    /// </param>
    /// <returns>
    /// The representation of the result of the modulus operation as an <see cref="uint" />.
    /// </returns>
    public static explicit operator uint(Modulus<TDividend, TDivisor> modulus)
        => modulus.Evaluate<uint>(ArithmeticOptions.Default);

    /// <summary>
    /// Evaluates the result of the modulus operation and returns it as <see cref="int" />.
    /// </summary>
    /// <param name="modulus">
    /// The modulus operation to evaluate.
    /// </param>
    /// <returns>
    /// The representation of the result of the modulus operation as an <see cref="int" />.
    /// </returns>
    public static explicit operator int(Modulus<TDividend, TDivisor> modulus)
        => modulus.Evaluate<int>(ArithmeticOptions.Default);

    /// <summary>
    /// Evaluates the result of the modulus operation and returns it as a <see cref="NaturalNumber" />.
    /// </summary>
    /// <param name="modulus">
    /// The modulus operation to evaluate.
    /// </param>
    /// <returns>
    /// The representation of the result of the modulus operation as a <see cref="NaturalNumber" />.
    /// </returns>
    public static implicit operator NaturalNumber(Modulus<TDividend, TDivisor> modulus)
        => modulus.Evaluate<NaturalNumber>(ArithmeticOptions.Default);
}