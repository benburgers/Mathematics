/*
 * Ben Burgers Mathematics
 * © 2022-2023 Ben Burgers and contributors
 * Licensed under AGPL 3.0
 */

using BenBurgers.Mathematics.Numbers.Real.Rational.Integer.Resources;

namespace BenBurgers.Mathematics.Numbers.Real.Rational.Integer;

/// <summary>
/// An exception that is thrown if a number is not an integer.
/// </summary>
public class NumberNotIntegerException
    : NumbersException
{
    /// <summary>
    /// Initializes a new instance of <see cref="NumberNotIntegerException" />.
    /// </summary>
    public NumberNotIntegerException()
        : base(ExceptionMessages.NumberNotInteger)
    {
    }
}