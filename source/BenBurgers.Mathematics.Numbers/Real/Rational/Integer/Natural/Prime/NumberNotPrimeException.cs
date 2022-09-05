/*
 * Ben Burgers Mathematics
 * © 2022 Ben Burgers and contributors
 * Licensed under AGPL 3.0
 */

using BenBurgers.Mathematics.Numbers.Real.Rational.Integer.Natural.Prime.Resources;

namespace BenBurgers.Mathematics.Numbers.Real.Rational.Integer.Natural.Prime;

/// <summary>
/// A <see cref="NumberNotPrimeException" /> is thrown if a number is expected to be a prime number, but really isn't a prime number.
/// </summary>
public class NumberNotPrimeException
    : NumbersException
{
    /// <summary>
    /// Initializes a new instance of <see cref="NumberNotPrimeException" />.
    /// </summary>
    public NumberNotPrimeException()
        : base(ExceptionMessages.NumberNotPrime)
    {
    }
}
