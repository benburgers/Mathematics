/*
 * Ben Burgers Mathematics
 * © 2022 Ben Burgers and contributors
 * Licensed under AGPL 3.0
 */

using BenBurgers.Mathematics.Numbers.Resources;

namespace BenBurgers.Mathematics.Numbers;

/// <summary>
/// An exception that is thrown if a number is too large.
/// </summary>
public class NumberTooLargeException
    : NumbersException
{
    /// <summary>
    /// Initializes a new instance of <see cref="NumberTooLargeException" />.
    /// </summary>
    public NumberTooLargeException()
        : base(ExceptionMessages.NumberTooLarge)
    {
    }
}
