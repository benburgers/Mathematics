/*
 * Ben Burgers Mathematics
 * © 2022 Ben Burgers and contributors
 * Licensed under AGPL 3.0
 */

using BenBurgers.Mathematics.Numbers.Real.Rational.Integer.Natural.Resources;

namespace BenBurgers.Mathematics.Numbers.Real.Rational.Integer.Natural;

/// <summary>
/// An exception that is thrown if a number is not a natural number even though it is expected to be a natural number.
/// </summary>
public class NumberNotNaturalException
    : NumbersException
{
    /// <summary>
    /// Initializes a new instance of <see cref="NumberNotNaturalException" />.
    /// </summary>
    public NumberNotNaturalException()
        : base(ExceptionMessages.NaturalNumberCastNotNaturalNumber)
    {
    }
}
