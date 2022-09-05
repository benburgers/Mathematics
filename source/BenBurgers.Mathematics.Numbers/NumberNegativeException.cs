/*
 * Ben Burgers Mathematics
 * © 2022 Ben Burgers and contributors
 * Licensed under AGPL 3.0
 */

using BenBurgers.Mathematics.Numbers.Resources;

namespace BenBurgers.Mathematics.Numbers;

/// <summary>
/// An exception that is thrown if a number is negative in a context where negative numbers are not allowed.
/// </summary>
public class NumberNegativeException
    : NumbersException
{
    /// <summary>
    /// Initializes a new instance of <see cref="NumberNegativeException" />.
    /// </summary>
    public NumberNegativeException()
        : base(ExceptionMessages.NumberNegative)
    {
    }
}