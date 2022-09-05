/*
 * Ben Burgers Mathematics
 * © 2022 Ben Burgers and contributors
 * Licensed under AGPL 3.0
 */

namespace BenBurgers.Mathematics.Numbers.Arithmetic.Moduli;

public partial struct Modulus<TDividend, TDivisor>
{
    /// <summary>
    /// Determines whether the value of the calculation of <paramref name="modulus" /> is equivalent to <paramref name="value" />.
    /// </summary>
    /// <param name="modulus">
    /// The modulus.
    /// </param>
    /// <param name="value">
    /// The value to compare with.
    /// </param>
    /// <returns>
    /// A <see cref="bool" /> that indicates whether the evaluation of <paramref name="modulus" /> is equivalent to <paramref name="value" />.
    /// </returns>
    public static bool operator ==(Modulus<TDividend, TDivisor> modulus, int value) => modulus.Equals(value);

    /// <summary>
    /// Determines whether the value of the calculation of <paramref name="modulus" /> is equivalent to <paramref name="value" />.
    /// </summary>
    /// <param name="value">
    /// The value to compare with.
    /// </param>
    /// <param name="modulus">
    /// The modulus.
    /// </param>
    /// <returns>
    /// A <see cref="bool" /> that indicates whether the evaluation of <paramref name="modulus" /> is equivalent to <paramref name="value" />.
    /// </returns>
    public static bool operator ==(int value, Modulus<TDividend, TDivisor> modulus) => modulus.Equals(value);

    /// <summary>
    /// Determines whether the value of the evaluation of <paramref name="modulus" /> is not equivalent to <paramref name="value" />.
    /// </summary>
    /// <param name="modulus">
    /// The modulus.
    /// </param>
    /// <param name="value">
    /// The value to compare with.
    /// </param>
    /// <returns>
    /// A <see cref="bool" /> that indicates whether the evaluation of <paramref name="modulus" /> is equivalent to <paramref name="value" />.
    /// </returns>
    public static bool operator !=(Modulus<TDividend, TDivisor> modulus, int value) => !modulus.Equals(value);

    /// <summary>
    /// Determines whether the value of the evaluation of <paramref name="modulus" /> is not equivalent to <paramref name="value" />.
    /// </summary>
    /// <param name="value">
    /// The value to compare with.
    /// </param>
    /// <param name="modulus">
    /// The modulus.
    /// </param>
    /// <returns>
    /// A <see cref="bool" /> that indicates whether the evaluation of <paramref name="modulus" /> is equivalent to <paramref name="value" />.
    /// </returns>
    public static bool operator !=(int value, Modulus<TDividend, TDivisor> modulus) => !modulus.Equals(value);
}
